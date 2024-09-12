using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    public float springPower;

    private HingeJoint hinge;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring spring = hinge.spring;
        if (Input.GetKey(input))
        {
            spring.spring = springPower;
        }
        else
        {
            spring.spring = 0;
        }
        hinge.spring = spring;
        Debug.Log("Uhuyy");

    }

    private void MovePaddle()
    {

    }
}
