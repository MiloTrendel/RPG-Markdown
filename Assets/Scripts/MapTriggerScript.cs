using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class MapTriggerScript : MonoBehaviour
{
    [SerializeField] private Transform pointToTPTo;
    [SerializeField] private Transform tpAnimPoint;
    [SerializeField] private Transform pointToWait;
    [SerializeField] private Transform pointToGoBack;
    [SerializeField] private PlayerScript player;
    [SerializeField] private PlayerController controller;
    [SerializeField] private CameraFollow cam;



    // Update is called once per frame
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PlayerScript>();
        controller = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PlayerController>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInParent<CameraFollow>();
    }

    private void Update()
    {
        if (player.isWaitingMapTp)
        {
            if (Input.GetKey(KeyCode.E))
            {
                cam.follow = false;
                controller.GoTo(tpAnimPoint.position);
                Debug.Log("Change");
            }
            else if (Input.GetKey(KeyCode.Escape))
            {
                controller.GoTo(pointToGoBack.position);
                player.isWaitingMapTp = false;
            }
            
        }
    }
}
