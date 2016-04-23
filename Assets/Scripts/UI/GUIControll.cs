using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIControll : MonoBehaviour {
    [SerializeField]
    PanelUpdate[] panelUpdate;

    // Update is called once per frame
    public void Start()
    {
        LevelControl lc = (LevelControl)FindObjectOfType(typeof(LevelControl));
        RescuedGnome(lc);
    }

    // Update is called once per frame
    public void RescuedGnome(LevelControl lc)
    {
        foreach (PanelUpdate pu in panelUpdate)
        {
            pu.RescuedGnome(lc);
        }
    }

	public void HasKey(LevelControl lc)
	{
        foreach (PanelUpdate pu in panelUpdate)
        {
            pu.HasKey(lc);
        }


    }

    public void UpdateHealth(LevelControl lc)
    {
        foreach (PanelUpdate pu in panelUpdate)
        {
            pu.UpdateHealth(lc);
        }


    }
}
