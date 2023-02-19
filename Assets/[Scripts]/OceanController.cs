using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController : MonoBehaviour
{

    public float vericalSpeed;
    public Boundary boundary;

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        transform.position -= new Vector3(0.0f, vericalSpeed);
    }

    void CheckBounds() {
        if (transform.position.y <= boundary.bottom) {
            ResetObject();
        }
    }

    void ResetObject()
    {
        transform.position = new Vector2(0.0f, boundary.top);
    }
}
