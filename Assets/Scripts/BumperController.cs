using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    [SerializeField]
    private float multiplier;
    private Animator animator;

    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Ball")
        {
            Debug.Log("HIT");
            Rigidbody ballRB = collision.collider.GetComponent<Rigidbody>();
            ballRB.velocity *= multiplier;

            animator.SetTrigger("hit");

        }
        
    }
}
