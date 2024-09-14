using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Material offMaterial;
    public Material onMaterial;
    private bool isOn;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        isOn = false;
        renderer.material = offMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void set(bool on)
    {
        isOn = on;
        if (isOn == true)
        {
            renderer.material = onMaterial;
        }
        else
        {
            renderer.material = offMaterial;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Collider obj = other.GetComponent<Collider>();
        if (obj.name == "Ball")
        {
            set(!isOn);
        }
    }
}
