using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour {

    [SerializeField]   float Damage;

	
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            if (Input.GetButtonDown("Attack"))
            {
               
                EnemyControl en = other.gameObject.GetComponent<EnemyControl>();
                en.UpdateHealth(Damage);

            }
           
        }
    }
}
