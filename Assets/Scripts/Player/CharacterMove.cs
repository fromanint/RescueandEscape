using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class CharacterMove : MonoBehaviour {

	public int speed;


	Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	public void MoveFront(){
		
		rb.velocity = speed * transform.forward; 
	}
	public void MoveBack(){
		rb.velocity = -speed * transform.forward; 
	}
	public void Stop(){
		rb.velocity = new Vector3(0,0,0);
	}
}
