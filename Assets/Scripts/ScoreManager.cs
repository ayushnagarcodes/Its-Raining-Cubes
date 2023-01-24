using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public Text score;
    public int currentScore = 0;

    private void Start()
    {
        score.text = currentScore.ToString();
    }
}
