using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(AudioSource))]

public class gnomeCollected : MonoBehaviour {
    public GameObject jail;
    public Animator gnome;
    LevelControl lc;

    [SerializeField]
    AudioClip collectsound;
    AudioSource playAudio;
    // Use this for initialization
    void Start() {
        lc = (LevelControl) FindObjectOfType(typeof(LevelControl));
        playAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.tag);
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("DestroyAnim");
        }
    }

	public void Collect()
	{
		StartCoroutine("DestroyAnim");
	}

    IEnumerator DestroyAnim() {

        playAudio.Stop();
        playAudio.clip = collectsound;
        playAudio.loop = false;
        playAudio.Play();
        Destroy(jail);
        gnome.SetBool("Rescued", true);
        yield return new WaitForSeconds (10);
        lc.Rescued++;
        GUIControll gc= (GUIControll)FindObjectOfType(typeof(GUIControll));
        gc.RescuedGnome(lc);
        Destroy(gameObject);
    }
    
}
