using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrackScore : MonoBehaviour
{
    // Start is called before the first frame update
    int currentScore;
    TMP_Text scoreText;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        currentScore = 0;
        scoreText.text = currentScore.ToString();
    }

    public void IncrementScore()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }
}
