using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusBlocks : MonoBehaviour
{
    bool bloqueColisionoJugador = false;
    public int score;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!bloqueColisionoJugador && other.gameObject.CompareTag("Player"))
        {
            bloqueColisionoJugador = true;
            Score.instance.IncrementarPuntos(score);
        }
    }


}
