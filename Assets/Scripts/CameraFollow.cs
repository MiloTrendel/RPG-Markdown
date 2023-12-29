using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;
    public bool follow = true;

    public Transform target;

    private Vector3 vel = Vector3.zero;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        targetPosition.z = transform.position.z;

        if (follow) transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping);
    }
}
