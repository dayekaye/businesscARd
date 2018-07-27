using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorFloorness : MonoBehaviour
{

    // Update or FixedUpdate
    void Update()
    {
        Vector3 currentPosition = transform.position;
        float clampedY =
           Mathf.Clamp(currentPosition.y, 0, 10);

        if (!Mathf.Approximately(clampedY, currentPosition.y))
        {
            currentPosition.y = clampedY;
            transform.position = currentPosition;
        }
    }
}
 