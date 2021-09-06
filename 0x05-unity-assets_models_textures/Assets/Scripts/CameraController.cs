using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    public GameObject target;
    private float targetDistance;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 0.0f;
    private float rotX;

    void Start ()
    {
        targetDistance = Vector3.Distance(transform.position, target.transform.position);
    }

    void Update ()
    {
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
        transform.position = target.transform.position - (transform.forward * targetDistance);
    }
}
