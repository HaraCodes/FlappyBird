using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{   
    public GameObject pipe;
    public float Offset = 10;
    public float spawnRate=2;
    private float timer =0;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {   
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
        }
        else{
            spawnPipe();
        }
    }
    void spawnPipe(){
        float highest = transform.position.y + Offset;
        float lowest = transform.position.y - Offset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(highest, lowest),0),transform.rotation);
        timer=0;
    }    
}
