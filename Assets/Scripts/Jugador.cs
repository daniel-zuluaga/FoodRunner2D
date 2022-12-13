using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public static Jugador instance;

    [Header("Running")]
    public float speedRun;

    [Header("Jump Data")]
    public float forceJump;
    public Transform CheckGround;
    public bool inGround;
    public LayerMask MaskGround;

    public GameObject deadPlayer;

    [Header("Components")]
    public Rigidbody2D rb2D;
    public Animator anim;
    public AudioSource audioS;

    private void FixedUpdate()
    {
        Move();

        inGround = Physics2D.OverlapCircle(CheckGround.position, 0.8f, MaskGround);
        anim.SetBool("isGrounded", inGround);
    }

    void Move()
    {
        rb2D.velocity = new Vector2(speedRun, rb2D.velocity.y);

        anim.SetFloat("VelX", rb2D.velocity.x);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // We make it jump
            if (inGround)
            {
                audioS.Play();
                rb2D.velocity = new Vector2(rb2D.velocity.x, forceJump);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            Instantiate(deadPlayer, transform.position, transform.rotation);
            Destroy(deadPlayer);
            Destroy(gameObject);
            MenuManager.instance.GameOver();
        }
    }
}
