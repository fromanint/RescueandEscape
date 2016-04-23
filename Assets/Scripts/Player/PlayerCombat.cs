using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Animator))]
public class PlayerCombat : MonoBehaviour {



    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Block"))
        {
            anim.SetBool("Block", true);
        }
        else
        {
            anim.SetBool("Block", false);
        }

        if (Input.GetButtonDown("Attack"))
        {
            anim.SetTrigger("Attack");
        }
	
	}
}
