using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public KeyCode input;
    public float maxTimeHold;
    public float maxForce;
    private bool isHold;

    void Start()
    {
        isHold = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.name == "Ball")
        {
            Collider ball = collision.collider;
            ReadInput(ball);
        }
    }

    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            //collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}
