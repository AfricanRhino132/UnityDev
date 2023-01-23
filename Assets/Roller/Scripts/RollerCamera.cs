using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float distance;
    //[SerializeField] private float distanceY;
    //[SerializeField] private float distanceZ;
    //private Vector3 offset = Vector3.zero;

    [SerializeField] private float pitch;
    [SerializeField] private float yaw = 0;

    [SerializeField] private float sensitivity;

    void Start()
    {
        //offset = new Vector3(0, distanceY, distanceZ);
    }

    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * sensitivity;

        Quaternion qyaw = Quaternion.AngleAxis(yaw, Vector3.up);
        Quaternion qpitch = Quaternion.AngleAxis(pitch, Vector3.right);
        Quaternion rotation = qyaw * qpitch;

        Vector3 offset = rotation * Vector3.back * distance;
        
        //transform.position = target.position + (Vector3.up + offset);
        transform.position = target.position + offset;
        transform.rotation = Quaternion.LookRotation(-offset);
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
