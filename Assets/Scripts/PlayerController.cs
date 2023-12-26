using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public bool isMoving = false;
    public bool ShowDebug = true;

    private float horizontalInput;
    private float verticalInput;

    Rigidbody2D rdBod;

    private void Start()
    {
        rdBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput != 0f || verticalInput != 0f)
            isMoving = true;
        else
            isMoving = false;

        PrintDebug();

        rdBod.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }

    private void PrintDebug()
    {
        if (!ShowDebug)
            return;

        Debug.Log(isMoving);

        Debug.Log(horizontalInput);
        Debug.Log(verticalInput);
    }
}
