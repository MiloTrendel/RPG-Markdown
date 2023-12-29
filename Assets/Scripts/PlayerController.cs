using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public bool wantsToMove = false;
    public bool ShowDebug = true;

    public bool canWalk = false;

    private float horizontalInput;
    private float verticalInput;

    public Vector2 axisMove;

    public Rigidbody2D rdBod;

    private FSMachine stateMachine;

    private void Start()
    {
        rdBod = GetComponent<Rigidbody2D>();
        stateMachine = GetComponent<FSMachine>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput != 0f || verticalInput != 0f)
        {
            wantsToMove = true;
            stateMachine.ChangeState(new FSMWalking());
        }   
        else
        {
            wantsToMove = false;
            stateMachine.ChangeState(new FSMWalking());
        }
            

        PrintDebug();

        axisMove = new Vector2 (horizontalInput, verticalInput).normalized;
    }

    private void PrintDebug()
    {
        if (!ShowDebug)
            return;

        Debug.Log(wantsToMove);
        Debug.Log(horizontalInput);
        Debug.Log(verticalInput);
    }

    public void GoTo(Vector3 pointToGoTo)
    {
        transform.position = Vector3.MoveTowards(transform.position, pointToGoTo, speed * Time.deltaTime);
    }

    public void Move()
    {
        if (canWalk) rdBod.velocity = axisMove * speed;
        else rdBod.velocity = Vector3.zero;
    }
}
