using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FSMWalking : IFSMachine
{
    private PlayerController controller;
    private PlayerScript player;

    public FSMWalking()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    void IFSMachine.Walk()
    {
        controller.Move();
    }

    void IFSMachine.ExitState()
    {
        
    }

    #region
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
    #endregion
}
