using UnityEngine;
using System.Collections;

public class gnomeCollected : MonoBehaviour {
    public GameObject jail;
    // Use this for initialization

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
        { Destroy(jail); }
    }
}
