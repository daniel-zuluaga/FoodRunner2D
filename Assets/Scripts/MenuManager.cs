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

    public AudioSource audioS;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {

    }

    public void GameOver()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
        audioS.Play();
        objGameOver.SetActive(true);
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayGame()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
        SceneManager.LoadScene("Skin");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
        Application.Quit();
    }
}
