using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [Header("Running")]
    public float speedRun;

    [Header("Jump Data")]
    public float forceJump;
    public Transform CheckGround;
    public bool inGround;
    public LayerMask MaskGround;

    [Header("Components")]
    public Rigidbody2D rb2D;
    public Animator anim;

    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(speedRun, rb2D.velocity.y);

        anim.SetFloat("VelX", rb2D.velocity.x);

        inGround = Physics2D.OverlapCircle(CheckGround.position, 0.8f, MaskGround);
        anim.SetBool("isGrounded", inGround);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // We make it jump
            if (inGround)
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, forceJump);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
