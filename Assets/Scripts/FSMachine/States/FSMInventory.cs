using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class FSMInventory : IFSMachine
{
    public GameObject inventoryUI;
    private PlayerController controller;
    private PlayerScript player;

    public FSMInventory()
    {
        inventoryUI = GameObject.FindGameObjectWithTag("InventoryUI").transform.GetChild(0).gameObject;
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        player.isInInventory = true;
        //inventoryUI = GameObject.FindGameObjectWithTag("InventoryUI").GetComponentInChildren<Image>();
    }
    void IFSMachine.Walk()
    {

    }

    void IFSMachine.ExitState()
    {
        player.isInInventory = false;
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
