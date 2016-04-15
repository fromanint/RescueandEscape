using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class CharacterMove : MonoBehaviour {

	public int speed;
    

	Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}


    public void Move(float horizontal, float vertical, Transform tracker) {
        // Debug.Log(direction);
        //rb.velocity = speed * Vector3.forward * vertical;
        if(vertical != 0 && horizontal !=0)
        transform.rotation = tracker.rotation;
        rb.velocity = speed * new Vector3(horizontal, 0, vertical);
        /*rb.AddForce(Vector3.forward * speed * vertical);
        transform.Translate(Vector3.forward * speed * vertical);*/


    }
}
