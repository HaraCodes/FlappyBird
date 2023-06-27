using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeMoveScript : MonoBehaviour
{
    public float deadZone = -38;   
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = GameObject.FindGameObjectWithTag("pipeSpawner").GetComponent<PipeSpawnScript>().moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone){
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
    }
}
