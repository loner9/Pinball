using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;

    private HingeJoint hinge;

    private float targetPressed;
    private float targetRelease;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
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
            spring.targetPosition = targetPressed;
        }
        else
        {
            spring.targetPosition = targetRelease;
        }

        hinge.spring = spring;
    }


    private void MovePaddle()
    {

    }
}
