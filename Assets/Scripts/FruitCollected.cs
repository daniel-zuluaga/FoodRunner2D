using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    public int puntosGanados;

    public AudioSource audioS;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioS.Play();
            Score.instance.IncrementarPuntos(puntosGanados);
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.8f);
        }
    }
}
