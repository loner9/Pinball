using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public float transitionSpeed = 100;
    public ScoreController scoreController;
    float displayScore;

    private void Update()
    {
        displayScore = Mathf.MoveTowards(displayScore, scoreController.score, transitionSpeed * Time.deltaTime);
        UpdateScoreDisplay();
        //scoreText.text = scoreController.score.ToString();
    }

    public void UpdateScoreDisplay()
    {
        scoreText.text = string.Format("{0:0}", displayScore);
    }
}
