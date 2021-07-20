using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    public GameObject endGameScreen;
    public TMP_Text outcomeText;
    // Start is called before the first frame update
    void Start()
    {
        endGameScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
