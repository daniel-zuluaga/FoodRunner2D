using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBackgrounParallax : MonoBehaviour
{
    [SerializeField] private Vector2 velocityParallax;

    private Vector2 offset;

    private Material material;

    // Start is called before the first frame update
    void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = velocityParallax * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
