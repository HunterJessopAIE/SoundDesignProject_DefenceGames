using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    public GameObject endGameScreen;

    // Start is called before the first frame update
    void Start()
    {
        endGameScreen.SetActive(false);
    }

    public void AddScore(int objectScore)
    {
        score += objectScore;
        scoreText.text = score.ToString();
        CheckScore();
    }


    private void CheckScore()
    {

    }

}
