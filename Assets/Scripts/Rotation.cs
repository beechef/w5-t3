using System;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotateSpeed;
    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.maxAngularVelocity = 180f;
        // rig.AddTorque(Vector3.up);
    }


    void FixedUpdate()
    {
        //Vector3 rotation = Vector3.up;
        //rotation.y *= rotateSpeed;
        //rotation.y += rig.rotation.eulerAngles.y;
        //rig.MoveRotation(Quaternion.Euler(rotation));
        // rig.angularVelocity = Vector3.up * rotateSpeed;
        rig.AddTorque(new Vector3(0f, rotateSpeed, 0f), ForceMode.Acceleration);
    }
}