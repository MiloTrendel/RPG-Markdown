using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMInventory : IFSMachine
{
    public GameObject inventoryUI;

    public FSMInventory()
    {
        inventoryUI = GameObject.FindGameObjectWithTag("InventoryUI");
        inventoryUI.SetActive(false);
    }
    void IFSMachine.Walk()
    {

    }

    void IFSMachine.OpenInventory()
    {
        inventoryUI.SetActive(true);
    }

    void IFSMachine.CloseEvent()
    {
        inventoryUI.SetActive(false);
    }

    void IFSMachine.StartTalk()
    {

    }

    void IFSMachine.ChangeMapTrigger()
    {

    }
}
