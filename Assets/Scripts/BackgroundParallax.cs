using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    [SerializeField] private Vector2 velocityParallax;

    private Vector2 offset;

    private Material material;

    [SerializeField] private GameObject player; 

    // Start is called before the first frame update
    void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            offset = velocityParallax * Time.deltaTime;
            material.mainTextureOffset += offset;
        }
    }
}
