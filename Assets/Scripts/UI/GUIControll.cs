using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIControll : MonoBehaviour {

    [SerializeField] Text gnomesRescueL;
    [SerializeField] Image LifeL;
    [SerializeField] Text gnomesRescueR;
    [SerializeField] Image LifeR;

	[SerializeField] Image Key;


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

	public void HasKey(LevelControl lc)
	{
		Color color = new Color(Key.color.r, Key.color.g, Key.color.b, 1F);
		Key.color = color;
	}
}
