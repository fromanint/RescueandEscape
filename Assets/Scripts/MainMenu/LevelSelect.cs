using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

    [SerializeField] GameObject PanelPlay;
    [SerializeField] GameObject PanelBlock;
    [SerializeField] GameObject PanelComing;


    [SerializeField] Image playImage;
    [SerializeField] float seconds= 2;
    [SerializeField]
    string levelName;
    [SerializeField]
    bool Blocked=true;
    [SerializeField]
    bool Coming = true;
    float fillImage;
    bool clicking;



    void Start()
    {
        clicking = false;
        fillImage = 0;

        if (!Coming)
        {
            if (!Blocked)
            {
                PanelPlay.SetActive(true);
                PanelComing.SetActive(false);
                PanelBlock.SetActive(false);
            }
            else
            {
                PanelPlay.SetActive(false);
                PanelComing.SetActive(false);
                PanelBlock.SetActive(true);
            }
        }
        else
        {
            PanelPlay.SetActive(false);
            PanelComing.SetActive(true);
            PanelBlock.SetActive(false);
        }

    }


    public void isWatching()
    {
        Debug.Log(Blocked + " /" + Coming);
        if(!Coming)
        {
            Debug.Log("clicking");
            if (!Blocked)
            { 
           
            StartCoroutine("Clicking"); }
        }


    }

    void Update()
    {
         
        if (clicking)
        {

            Debug.Log(fillImage);
            playImage.fillAmount = fillImage / seconds;
            fillImage += seconds / 100;

        }
        

    }

    public void noWatching()
    {
        clicking = false;
        fillImage = 0;
        StopCoroutine("Clicking");
    }

    IEnumerator Clicking()
    {
        clicking = true;
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(levelName);   
    }


}
