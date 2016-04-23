using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {

	Transform parent;
	[SerializeField] GameObject UI;

	void Start()
	{
		UI.SetActive (false);
		parent = transform.parent;
	}

	public void HideGameOver()
	{
		transform.parent = parent;
		UI.SetActive (false);
	}

	public void ShowGameOver()
	{
		EnemyControl[] enemies = FindObjectsOfType<EnemyControl> () as EnemyControl[];
		foreach (EnemyControl enemy in enemies) {
			Destroy (enemy.gameObject);
		}
		UI.SetActive (true);
		transform.parent = null;

		CharacterController cc = FindObjectOfType<CharacterController> ();
		cc.enabled = false;
	}
	

}
