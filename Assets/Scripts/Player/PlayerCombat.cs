using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Animator))]
public class PlayerCombat : MonoBehaviour {

	bool block;

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		block = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Block"))
        {
            anim.SetBool("Block", true);
			block = true;
        }
        else
        {
			if (block) {
				anim.SetBool ("Block", false);
			}
        }
		if (Input.GetButtonDown("Attack"))
		{
			anim.SetTrigger("Attack");
		}

	
	}
}
