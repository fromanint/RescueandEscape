using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour {

    LevelControl lc;


    // Use this for initialization
    void Start()
    {
        lc = (LevelControl)FindObjectOfType(typeof(LevelControl));
    }


    public void Finish()
    {
        lc.Key = true;
        GUIControll gc = (GUIControll)FindObjectOfType(typeof(GUIControll));
        if (lc.Key)
        {
            SceneManager.LoadScene(0);
        }
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Finish();
        }

    }

}
