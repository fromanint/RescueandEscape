using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {

	Transform parent;
	[SerializeField] GameObject UI;

	void Start()
	{
		parent = transform.parent;
	}

	public void HideGameOver()
	{
		transform.parent = parent;
		UI.SetActive (false);
	}

	public void ShowGameOver()
	{
		UI.SetActive (true);
		transform.parent = null;
	}
	

}
