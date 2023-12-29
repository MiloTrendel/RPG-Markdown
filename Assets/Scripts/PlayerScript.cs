using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public bool isInInventory = false;
    public bool isTalking = false;
    public bool isInTalkingRange = false;
    public bool isWaitingMapTp = false;

    private PlayerController controller;

    float talkingRange = 10f;

    private List<AI> aiList = new List<AI>();
    public Transform currentAi;

    private void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position - currentAi.position).sqrMagnitude < talkingRange * talkingRange)
        {
            isInTalkingRange = true;
        }
        else
            isInTalkingRange = false;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Trigger");
        if (coll.CompareTag("MapTrigger"))
        {
            isWaitingMapTp = true;
        }
    }
}
