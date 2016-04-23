using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(EnemyFollowPlayer))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AudioSource))]

public class EnemyControl : MonoBehaviour {
	public float maxLife;
	public float DeadTime;
	public bool Dead;
	public bool hitted;
    bool foundPlayer;

    float life;
    Animator anim;
    LevelControl lc;
    EnemyFollowPlayer efp;

    [SerializeField] BoxCollider findPlayer;
    [SerializeField]
    SphereCollider attack;
    [SerializeField]
    Image health;

    [SerializeField]AudioClip findSound;
    [SerializeField]AudioClip dieSound;
    AudioSource playAudio;

    // Use this for initialization
    void Start () {
		Dead = false; 
		hitted = false;
        lc = (LevelControl)FindObjectOfType(typeof(LevelControl));
        anim = GetComponent<Animator>();
        foundPlayer = false;
        attack.gameObject.SetActive(false);
        efp = GetComponent<EnemyFollowPlayer>();
        efp.enabled = true;
        life = maxLife;
        UpdateHealth(0);
        playAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

	}

	public void UpdateHealth(float damage)
	{
        if (life >= 0)
        {
            life -= damage;
            health.fillAmount = life / maxLife;
        }
        else
        {
			Dead = true;
            StartCoroutine("DeadCoroutine");
        }
    }
	
	void OnTriggerStay(Collider other)
	{
        
        if (other.gameObject.tag == "Player")
		{

            if (!foundPlayer)
            {
               
                findPlayer.gameObject.SetActive(false);
                attack.gameObject.SetActive(true);
                anim.SetBool("Follow", true);
                efp.enabled = true;
                foundPlayer = true;
                playAudio.clip = findSound;
                playAudio.Play();

            }
            else {
                anim.SetBool("Attack", true);
                attack.gameObject.SetActive(true);
				if (!Dead) {
					efp.enabled = false;
				}

            }
            
		}
	}

    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            if (foundPlayer)
            {
				if (!Dead) {
					efp.enabled = true;
				}
                
                anim.SetBool("Follow", true);
                anim.SetBool("Attack", false);
            }
        }
    }


    IEnumerator DeadCoroutine()
	{
		Dead = true;
        playAudio.Stop();
        playAudio.clip = dieSound;
        playAudio.Play();
        anim.SetTrigger("Die");

        yield return new WaitForSeconds(DeadTime);
		Destroy(this.gameObject);
	}
}
