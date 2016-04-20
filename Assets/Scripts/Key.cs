using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {


	LevelControl lc;
	public float speed = 10f;


	// Use this for initialization
	void Start () {
		lc = (LevelControl) FindObjectOfType(typeof(LevelControl));
	}




	void Update ()
	{
		transform.Rotate(Vector3.left, speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.transform.tag);
		if (other.gameObject.tag == "Player")
		{
			lc.Key = true;
			GUIControll gc= (GUIControll)FindObjectOfType(typeof(GUIControll));
			gc.HasKey (lc);
			Destroy (gameObject);
		}

	}

}
