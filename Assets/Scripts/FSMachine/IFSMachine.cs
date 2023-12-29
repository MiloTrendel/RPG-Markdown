using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFSMachine
{
    public void Walk();
    public void OpenInventory();
    public void CloseEvent();
    public void StartTalk();
    public void ChangeMapTrigger();
}
