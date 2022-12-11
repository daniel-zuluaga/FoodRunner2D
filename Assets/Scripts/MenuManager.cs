using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    [Header("Game Over")]
    public GameObject objGameOver;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI textScore;
    public Score score;
    public int bestScore;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        bestScoreText.text = PlayerPrefs.GetInt("bestScore", 0).ToString();
    }

    public void GameOver()
    {
        ChangeBestScore();
        objGameOver.SetActive(true);
        textScore.text = "Score\n" + score.score.ToString();
        bestScoreText.text = "Best Score\n" + bestScore.ToString();
    }

    public void ChangeBestScore()
    {
        if(score.score > PlayerPrefs.GetInt("bestScore", 0))
        {
            PlayerPrefs.SetInt("bestScore", score.score);
            bestScoreText.text = score.score.ToString();
        }
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
