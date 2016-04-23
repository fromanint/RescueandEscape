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
			if (lc.playerHealth > 0) {
				pu.UpdateHealth (lc);
			} else {
				foreach (PanelUpdate puc in panelUpdate)
				{
					puc.gameObject.SetActive(false);
				}
				GameOverControl go = (GameOverControl)FindObjectOfType(typeof(GameOverControl));
				go.ShowGameOver ();
			}
        }


    }
}
