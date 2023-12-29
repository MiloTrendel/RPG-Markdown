using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMTalking : IFSMachine
{
    private PlayerController controller;
    private PlayerScript player;

    public FSMTalking()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();

        player.isTalking = true;
    }

    void IFSMachine.Walk()
    {

    }
    void IFSMachine.ExitState()
    {
        player.isTalking = false;
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
