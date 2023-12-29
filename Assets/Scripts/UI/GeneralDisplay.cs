using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralDisplay : MonoBehaviour
{
    public GameObject inventory;
    public GameObject TpUI;

    PlayerScript player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        TpUI.SetActive(player.isWaitingMapTp);
    }
}
