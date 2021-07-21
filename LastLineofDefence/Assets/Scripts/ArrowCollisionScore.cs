using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollisionScore : MonoBehaviour
{
    private GameManager _gameManager;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Shield")
        {
            _gameManager.AddScore(score);
        }

    }
}
