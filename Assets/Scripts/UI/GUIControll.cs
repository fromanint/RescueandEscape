using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIControll : MonoBehaviour {

    [SerializeField] Text gnomesRescueL;
    [SerializeField] Image LifeL;
        [SerializeField] Text gnomesRescueR;
    [SerializeField] Image LifeR;



    // Update is called once per frame
    public void Start()
    {
        LevelControl lc = (LevelControl)FindObjectOfType(typeof(LevelControl));
        RescuedGnome(lc);
    }

    // Update is called once per frame
    public void RescuedGnome(LevelControl lc)
    {
        gnomesRescueL.text = lc.Rescued + " / " + lc.MaxRescued;
        gnomesRescueR.text = lc.Rescued + " / " + lc.MaxRescued;
    }

}
