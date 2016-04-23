using UnityEngine;
using System.Collections;

public class DamagePlayer : MonoBehaviour {

	public float Damage;


	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player" )
		{
            float damage=0;
            if (Input.GetButton("Block"))
            {
                damage = Damage / 5;
            }
            else
            {
                damage = Damage;
            }
            LevelControl lc = (LevelControl)FindObjectOfType(typeof(LevelControl));
            lc.playerHealth -= damage;
            GUIControll gc = (GUIControll)FindObjectOfType(typeof(GUIControll));
            gc.UpdateHealth(lc);
        }

	}

}
