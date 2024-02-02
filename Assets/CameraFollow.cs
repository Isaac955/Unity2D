using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime = 0.25f;
    public float y = 0f;
    public float z = -10f;

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 nextPosition = new Vector3(target.position.x, transform.position.y, z);
            transform.position = Vector3.SmoothDamp(transform.position, nextPosition, ref velocity, smoothTime);
        }
    }
}
