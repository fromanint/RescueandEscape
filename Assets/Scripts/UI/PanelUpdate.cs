using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelUpdate : MonoBehaviour {


    
    [SerializeField]
    Text gnomesRescue;
    [SerializeField]
    Image Life;
    [SerializeField]
    Image Key;


    public void Start()
    {
        LevelControl lc = (LevelControl)FindObjectOfType(typeof(LevelControl));
        RescuedGnome(lc);
    }

    // Update is called once per frame
    public void RescuedGnome(LevelControl lc)
    {

            gnomesRescue.text = lc.Rescued + " / " + lc.maxRescued;
       
    }

    public void HasKey(LevelControl lc)
    {

            Color color = new Color(Key.color.r, Key.color.g, Key.color.b, 1F);
            Key.color = color;

    }

    public void UpdateHealth(LevelControl lc)
    {
        Life.fillAmount = lc.playerHealth / lc.playerMaxHealth;
    }
}
