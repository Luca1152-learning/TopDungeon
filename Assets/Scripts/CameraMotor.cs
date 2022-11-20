using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;
    public float boundX = 0.3f;
    public float boundY = 0.15f;

    private void LateUpdate()
    {
        var delta = Vector3.zero;

        // Check if we are on the bounds of the X axis
        var deltaX = lookAt.position.x - transform.position.x;
        if (Mathf.Abs(deltaX) > boundX)
        {
            if (transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        // Check if we are on the bounds of the Y axis
        var deltaY = lookAt.position.y - transform.position.y;
        if (Mathf.Abs(deltaY) > boundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}