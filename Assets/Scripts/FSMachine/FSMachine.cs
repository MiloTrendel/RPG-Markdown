using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FSMachine : MonoBehaviour, IFSMachine
{
    public IFSMachine currentState;
    public IFSMachine previousState = null;

    public PlayerController controller;
    public PlayerScript player;

    public bool ShowDebug = true;

    void Start()
    {
        player = GetComponent<PlayerScript>();
        controller = GetComponent<PlayerController>();

        currentState = new FSMIdle();

        log(currentState.GetType().ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
            currentState.OpenInventory();

        else if (Input.GetKey(KeyCode.E))
            currentState.StartTalk();

        else if (Input.GetKey(KeyCode.Escape))
            currentState.CloseEvent();

        currentState.Walk();
    }

    public void ChangeState(IFSMachine nextState)
    {

        if (nextState.GetType() != currentState.GetType())
        {
            currentState = nextState;
            log("changed");
        }
        /*if (player.isWaitingMapTp)
        {
            ChangeState(new FSMWaitMapTP());
        }
        else
        {
            if (controller.wantsToMove && !player.isTalking && !player.isInInventory)
            {
                ChangeState(new FSMWalking());
            }

            if (!controller.wantsToMove && !player.isInInventory && !player.isTalking)
            {
                ChangeState(new FSMIdle());
            }

            if (Input.GetKey(KeyCode.I) && !player.isTalking)
            {
                ChangeState(new FSMInventory());
            }

            if (Input.GetKey(KeyCode.E) && player.isInTalkingRange && !player.isInInventory)
            {
                ChangeState(new FSMTalking());
            }
        }*/
    }

    void IFSMachine.Walk()
    {
        currentState.Walk();
    }
    void IFSMachine.OpenInventory() 
    { 
        currentState.OpenInventory(); 
    }

    void IFSMachine.CloseEvent()
    {
        currentState.CloseEvent();
    }

    void IFSMachine.StartTalk() 
    { 
        currentState.StartTalk(); 
    }
    void IFSMachine.ChangeMapTrigger() 
    { 
        currentState.ChangeMapTrigger(); 
    }

    private void log(string msg)
    {
        if (!ShowDebug)
            return;

        Debug.Log("Update State " + msg);
    }
}
