using UnityEngine;
using System.Collections;


[RequireComponent(typeof(CharacterMove))]
public class PlayerControl : MonoBehaviour {

	CharacterMove cm;

	// Use this for initialization
	void Start () {
		cm = GetComponent<CharacterMove> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal")==0)
			cm.Stop();
		if(Input.GetAxis("Horizontal")>0)
			cm.MoveFront();
		if(Input.GetAxis("Horizontal")<0)
			cm.MoveBack();

			
	}
}
