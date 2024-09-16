using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampDetect : MonoBehaviour
{
    public float score;

    public Collider bola;
    public ScoreController scoreController;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            //tambah skor kalau terkena bola
            scoreController.AddScore(score);
        }
    }
}
