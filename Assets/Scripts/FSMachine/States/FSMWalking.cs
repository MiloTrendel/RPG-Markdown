using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMWalking : IFSMachine
{
    [SerializeField] private PlayerController controller;


    public FSMWalking()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void IFSMachine.Walk()
    {
        controller.Move();
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
