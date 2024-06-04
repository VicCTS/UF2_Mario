using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    /*public Transform playerTransform;
    public Vector3 offset;

    public Vector2 minCameraPosition;
    public Vector2 maxCameraPosition;*/

    public Transform player;

    public Vector2 minPositions;
    public Vector2 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(playerTransform != null)
        {
            Vector3 desiredPosition = playerTransform.position + offset;

            float clampX = Mathf.Clamp(desiredPosition.x, minCameraPosition.x, maxCameraPosition.x);
            float clampY = Mathf.Clamp(desiredPosition.y, minCameraPosition.y, maxCameraPosition.y);

            Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);
            
            transform.position = clampedPosition;
        }*/

        Vector3 desiredPosition = player.position + new Vector3(0, 0, -10);

        float clampX = Mathf.Clamp(desiredPosition.x, minPositions.x, maxPosition.x);
        float clampY = Mathf.Clamp(desiredPosition.y, minPositions.y, maxPosition.y);

        Vector3 clampedPostion = new Vector3(clampX, clampY, desiredPosition.z);

        transform.position = clampedPostion;
    }
}
