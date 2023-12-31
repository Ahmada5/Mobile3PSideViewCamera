using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCON : MonoBehaviour
{
    public GameObject target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }


}
