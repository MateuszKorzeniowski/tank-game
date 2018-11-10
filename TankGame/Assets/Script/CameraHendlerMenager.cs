using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHendlerMenager : MonoBehaviour {

    public CameraFollow cameraFollow;
    public Transform player1Transform;
    private float zoom=20f;
    public float zoomMin=10f;
    public float zoomMax=60f;


    private void Start()
    {
        cameraFollow.Setup(() => zoom);
    }

    private void Update()
    {
        cameraFollow.SetCameraFollowPosition(player1Transform.position);
        float zoomDir = Input.GetAxisRaw("Mouse ScrollWheel");

        if (zoomDir > 0f)
        {
            ZoomIn();
        }
        else if(zoomDir < 0f)
        {
            ZoomOut();
        }
    }

    private void ZoomIn()
    {
        zoom -= 5f;
        if (zoom < zoomMin) zoom = zoomMin;
    }
    private void ZoomOut()
    {
        zoom += 5f;
        if (zoom > zoomMax) zoom = zoomMax;
    }
}
