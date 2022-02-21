using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject Enemy;

    public float spawnRangez = 5.0f;

    public float startDelay = 1.5f;

    public Vector3 spawnpos;

    public float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(0.5f, 1.5f);
        InvokeRepeating("RandomSpawnLoc", startDelay, spawnInterval);
    }

    

    public void RandomSpawnLoc() {

        spawnpos = new Vector3(-11, 1, Random.Range(-spawnRangez, spawnRangez));

        Instantiate(Enemy, spawnpos, Enemy.transform.rotation);
    }
     
 
}

    



        


 
   
 
