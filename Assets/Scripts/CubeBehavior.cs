using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    private ScoreManager _scoreManager;
    
    private void Start()
    {
        _scoreManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LoseArea"))
        {
            _scoreManager.currentScore = 0;
            _scoreManager.score.text = _scoreManager.currentScore.ToString();
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Floor"))
        {
            _scoreManager.currentScore++;
            _scoreManager.score.text = _scoreManager.currentScore.ToString();
            Destroy(gameObject);
        }
    }
}
