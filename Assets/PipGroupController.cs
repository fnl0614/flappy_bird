using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;

public class PipGroupController : MonoBehaviour
{
    [SerializeField] GameObject pipes;
    [SerializeField] float timeBetweenSpawns;
    float timer;
    [SerializeField] float spawnRange;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if (timer >= timeBetweenSpawns)
        {
            timer = 0 ;
            float yOffset = Random.Range(-2,2);
            //  Debug.Log("transform.position.y : " + (transform.position.y + yOffset));
            Vector3  spawnLOC = new Vector3(transform.position.x, 
            transform.position.y+yOffset, transform.position.z);
            Instantiate(pipes,spawnLOC,Quaternion.identity);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
