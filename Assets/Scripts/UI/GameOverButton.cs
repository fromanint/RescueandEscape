﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverButton : MonoBehaviour {


	[SerializeField] Image playImage;
	[SerializeField] float seconds= 2;
	[SerializeField]
	int levelName = -1;
	float fillImage;
	bool clicking;
	// Use this for initialization
	void Start () {
		fillImage = 0;
		playImage.fillAmount = 0;
		clicking = false;
		if (levelName == -1) {
			levelName = SceneManager.GetActiveScene ().buildIndex;
		}
	}
	

	public void isWatching()
	{
		
		StartCoroutine("Clicking"); 



	}

	void Update()
	{

		if (clicking)
		{
			playImage.fillAmount = fillImage / seconds;
			fillImage += seconds / 100;

		}


	}

	public void noWatching()
	{
		clicking = false;
		fillImage = 0;
		playImage.fillAmount = 0;
		StopCoroutine("Clicking");
	}

	IEnumerator Clicking()
	{
		clicking = true;
		yield return new WaitForSeconds(seconds);

		SceneManager.LoadScene(levelName);   
	}
}
