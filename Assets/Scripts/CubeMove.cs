using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    bool up, down, left, right;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            up = true;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            down = true;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            left = true;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            right = true;

        if (Input.GetKeyUp(KeyCode.UpArrow))
            up = false;
        if (Input.GetKeyUp(KeyCode.DownArrow))
            down = false;
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            left = false;
        if (Input.GetKeyUp(KeyCode.RightArrow))
            right = false;
    }

    private void FixedUpdate()
    {
        if (up) rb.AddForce(Vector3.up);
        if (down) rb.AddForce(Vector3.down);
        if (left) rb.AddForce(Vector3.left);
        if (right) rb.AddForce(Vector3.right);
    }
}