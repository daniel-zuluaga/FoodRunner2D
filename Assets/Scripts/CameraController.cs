using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float separation;

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            transform.position = new Vector3(target.position.x + separation, transform.position.y, transform.position.z);
        }
    }
}
