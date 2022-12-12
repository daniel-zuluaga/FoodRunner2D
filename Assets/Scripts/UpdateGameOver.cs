using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateGameOver : MonoBehaviour
{
    public TextMeshProUGUI bestScoreTextValue;
    public TextMeshProUGUI textScore;
    public Score score;
    public int bestScore;


    // Start is called before the first frame update
    void Start()
    {
        bestScore = score.score;
        bestScoreTextValue.text = PlayerPrefs.GetInt("bestScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        textScore.text = "Score\n" + score.score.ToString();

        if (score.score > PlayerPrefs.GetInt("bestScore", 0))
        {
            PlayerPrefs.SetInt("bestScore", score.score);
            bestScoreTextValue.text = score.score.ToString();
            bestScore = score.score;
        }
    }
}
