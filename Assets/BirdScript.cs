using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float flapStrength;
    
    public Rigidbody2D rBodyComponent;
    public GameObject GameOverScreen;
    public LogicScript logic;
    public bool isBirdAlive;
  
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        isBirdAlive = logic.isBirdAlive;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
         rBodyComponent.velocity = Vector2.up * flapStrength;
            
        }
        if(transform.position.y < -18)
        {
            OnCollisionEnter2D(new Collision2D());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.isBirdAlive = false;
        isBirdAlive = false;
        GameOverScreen.SetActive(true);
    }
}
