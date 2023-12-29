using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private FSMachine stateMachine;
    private PlayerScript player;
    private PlayerController controller;

    private void Start()
    {
        stateMachine = GetComponent<FSMachine>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I) && !player.isTalking)
        {
            stateMachine.ChangeState(new FSMInventory());
        }

        else if (Input.GetKey(KeyCode.E) && player.isInTalkingRange && !player.isInInventory)
        {
            stateMachine.ChangeState(new FSMTalking());
        }

        else if (Input.GetKey(KeyCode.Escape) && (player.isTalking || player.isInInventory))
        {
            stateMachine.currentState.CloseEvent();
            stateMachine.ChangeState(new FSMIdle());
        }

        else if (player.isWaitingMapTp)
        {
            stateMachine.ChangeState(new FSMWaitMapTP());
        }
        else if (controller.wantsToMove && !player.isInInventory && !player.isTalking)
        {
            stateMachine.ChangeState(new FSMWalking());
        }

        else if (!controller.wantsToMove && !player.isInInventory && !player.isTalking)
        {
            stateMachine.ChangeState(new FSMIdle());
        }
    }
}
