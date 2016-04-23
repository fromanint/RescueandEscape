using UnityEngine;
using System.Collections;

public class EnemyFollowPlayer : MonoBehaviour {


	private GameObject Player;
	public float Speed;

    void OnEnable()
    {
        transform.GetComponent<Rigidbody>().isKinematic = false;
    }
	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
        this.enabled = false;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 targetPostition = new Vector3(Player.transform.position.x,
                                     this.transform.position.y,
                                     Player.transform.position.z);
        transform.LookAt(targetPostition);
		transform.GetComponent<Rigidbody>().velocity = transform.forward * Speed;

    }

    void OnDisable()
    {
        transform.GetComponent<Rigidbody>().isKinematic = true;
    }





}
