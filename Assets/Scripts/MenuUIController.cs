using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIController : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CreditScene() { 
        SceneManager.LoadScene("Credit"); 
    }

    public void Exit()
    {
        Application.Quit();
    }
}
