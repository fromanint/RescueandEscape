using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour {


    public int maxRescued = 10;

    public int Rescued;
    public bool Key;

    public float playerHealth;
    public float playerMaxHealth = 500;

	void Start()
	{
		Rescued = 0;
		Key = false;
        playerHealth = playerMaxHealth;
	}



}
