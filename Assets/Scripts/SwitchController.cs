using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Material offMaterial;
    public Material onMaterial;
    private bool isOn;
    private Renderer rend;
    // Start is called before the first frame update
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }
    private SwitchState state;
    public Collider bola;
    public ScoreController scoreController;
    [SerializeField]
    private float score;
    public AudioManager audioManager;
    public VFXManager VFXManager;
    void Start()
    {
        rend = GetComponent<Renderer>();
        
        set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            rend.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            rend.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
            VFXManager.PlayVFXSwitch(other.transform.position);
        }
    }

    private void Toggle()
    {
        if (state == SwitchState.On)
        {
            set(false);
            audioManager.playSFXSwitchOff(bola.transform.position);
        }
        else
        {
            set(true);
            audioManager.playSFXSwitchOn(bola.transform.position);
        }

        scoreController.AddScore(score);
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            rend.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            rend.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }

}
