using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {


    public GameObject[] enemies;

    void Start()
    { //this will spawn only one prefeb, if you want call it many time, create  a new function and call it or create for loop

        int enemyIndex = Random.Range(0, enemies.Length - 1);

        Instantiate(enemies[enemyIndex], transform.position,transform.rotation);
     }
   


}
