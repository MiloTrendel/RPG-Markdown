using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMIdle : IFSMachine
{
    private PlayerController controller;
    private PlayerScript player;

    public FSMIdle()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    void IFSMachine.Walk()
    {

    }

    void IFSMachine.ExitState()
    {

    }

    void IFSMachine.OpenInventory()
    {

    }

    void IFSMachine.CloseEvent()
    {

    }

    void IFSMachine.StartTalk()
    {

    }

    void IFSMachine.ChangeMapTrigger()
    {

    }
}
