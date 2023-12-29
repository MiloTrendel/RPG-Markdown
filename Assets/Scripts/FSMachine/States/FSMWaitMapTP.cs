using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMWaitMapTP : IFSMachine
{
    private PlayerController controller;
    private PlayerScript player;

    public FSMWaitMapTP()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    void IFSMachine.ExitState()
    {

    }

    void IFSMachine.Walk()
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
