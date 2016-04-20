using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour {


    public int MaxRescued = 10;

    public int Rescued;
    public bool Key;

	void Start()
	{
		Rescued = 0;
		Key = false;
	}

}
