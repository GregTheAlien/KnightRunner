using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject[] pipes;
    float rand;
    Vector3 pipeOffset;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1.5f, 3);
        Invoke("SpawnPipe", rand); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipe()
    {
        float randomOffset = Random.Range(-2.0f, 2.0f);
        pipeOffset = new Vector3(0, randomOffset, 0);
        rand = Random.Range(1.5f, 2.5f);

        int randomPipe = Random.Range(0, pipes.Length);        
        Instantiate(pipes[randomPipe], transform.position + pipeOffset, transform.rotation);
        
        Invoke("SpawnPipe", rand);
    }
}
