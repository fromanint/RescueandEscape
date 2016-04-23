using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class FriendFollow : MonoBehaviour {

    private GameObject Player;
    public float Speed;
    Animator anim;
    bool near;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        near = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPostition = new Vector3(Player.transform.position.x,
                                     this.transform.position.y,
                                     Player.transform.position.z);
        transform.LookAt(targetPostition);
       if(near)
        { transform.GetComponent<Rigidbody>().velocity = Vector3.zero; }
        else{ transform.GetComponent<Rigidbody>().velocity = transform.forward * Speed; }

    }

    void OnTriggerExit(Collider other)
    {
        near = false;
        anim.SetBool("Walk", true);

    }
    void OnTriggerEnter(Collider other)
    {
        near = true;
        anim.SetBool("Walk", false);

    }
}
