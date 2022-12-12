using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelected : MonoBehaviour
{
    public enum Player
    {
        Frog,
        VirtualGuy,
        PinkMan,
        MaskDude
    }

    public Jugador playerSelected;
    public Animator anim;
    public SpriteRenderer spriteR;
    public RuntimeAnimatorController[] playersController;
    public Sprite[] playersRenderer;

    // Start is called before the first frame update
    void Start()
    {
        ChangePlayerSkin();
    }

    public void ChangePlayerSkin()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Frog":
                spriteR.sprite = playersRenderer[0];
                anim.runtimeAnimatorController = playersController[0];
                break;
            case "VirtualGuy":
                spriteR.sprite = playersRenderer[1];
                anim.runtimeAnimatorController = playersController[1];
                break;
            case "PinkMan":
                spriteR.sprite = playersRenderer[2];
                anim.runtimeAnimatorController = playersController[2];
                break;
            case "MaskDude":
                spriteR.sprite = playersRenderer[3];
                anim.runtimeAnimatorController = playersController[3];
                break;
            default:
                spriteR.sprite = playersRenderer[3];
                anim.runtimeAnimatorController = playersController[3];
                break;
        }
    }
}
