using UnityEngine;
using System.Collections;


[RequireComponent(typeof(CharacterMove))]
public class PlayerControl : MonoBehaviour {

	CharacterMove cm;
    public Transform headTracker;
	// Use this for initialization
	void Start () {
		cm = GetComponent<CharacterMove> ();
	}
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        //cm.Move(new Vector3(vertical, 0, horizontal));
        cm.Move(horizontal, vertical,headTracker);
        
		/*if(Input.GetAxis("Vertical")==0)
			cm.Stop();
		if(Input.GetAxis("Vertical") >0)
			cm.MoveFront();
		if(Input.GetAxis("Vertical") <0)
			cm.MoveBack();*/

			
	}
}
