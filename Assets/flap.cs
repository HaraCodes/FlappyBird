using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wing;
    public Animator animator;
    void Start()
    {
        animator = wing.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            animator.Play("flapping_wings");
        }
    }
}
