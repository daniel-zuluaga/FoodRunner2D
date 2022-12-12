using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSkin : MonoBehaviour
{
    public GameObject player;

    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "Frog");
        ResetPlayerSkin();
        SceneManager.LoadScene("Game");
    }

    public void SetPlayerVirtualGuy()
    {
        PlayerPrefs.SetString("PlayerSelected", "VirtualGuy");
        ResetPlayerSkin();
        SceneManager.LoadScene("Game");
    }

    public void SetPlayerPinkMan()
    {
        PlayerPrefs.SetString("PlayerSelected", "PinkMan");
        ResetPlayerSkin();
        SceneManager.LoadScene("Game");
    }

    public void SetPlayerMaskDude()
    {
        PlayerPrefs.SetString("PlayerSelected", "MaskDude");
        ResetPlayerSkin();
        SceneManager.LoadScene("Game");
    }

    void ResetPlayerSkin()
    {
        player.GetComponent<PlayerSelected>().ChangePlayerSkin();
    }

}
