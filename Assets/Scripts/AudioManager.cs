using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    public GameObject sfxSwitchOn;
    public GameObject sfxSwitchOff;
    // Start is called before the first frame update
    private void Start()
    {
        PlayBGM();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBGM() 
    {
        bgmAudioSource.Play();
    }
    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void playSFXSwitchOn(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchOn, spawnPosition, Quaternion.identity);
    }

    public void playSFXSwitchOff(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchOff, spawnPosition, Quaternion.identity);
    }
}
