using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI textScore;
    public static Score instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateScore()
    {
        textScore.text = "Score: " + score.ToString();
    }

    public void IncrementarPuntos(int scoreText)
    {
        int puntosAIncrementar = scoreText;
        score += puntosAIncrementar;
        UpdateScore();
    }
}
