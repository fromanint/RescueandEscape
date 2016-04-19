using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]

public class gnomeCollected : MonoBehaviour {
    public GameObject jail;
    public Animator gnome;
    LevelControl lc;
    // Use this for initialization
    void Start() {
        lc = (LevelControl) FindObjectOfType(typeof(LevelControl));
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.tag);
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("DestroyAnim");
        }
    }



    IEnumerator DestroyAnim() {
        Destroy(jail);
        gnome.SetBool("Rescued", true);
        yield return new WaitForSeconds (10);
        lc.Rescued++;
        GUIControll gc= (GUIControll)FindObjectOfType(typeof(GUIControll));
        gc.RescuedGnome(lc);
        Destroy(gameObject);
    }
    
}
