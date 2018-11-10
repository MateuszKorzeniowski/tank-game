using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour {

    private Camera myCamera;
    private Func<float> GetCameraZoomFunc;
    private Vector3 offset = new Vector3(0f, 5f, -10f);
    private Vector3 cameraFallowPosition;

    private void Start()
    {
        myCamera = transform.GetComponent<Camera>();
    }

    //funkcja pobierajaca i przypisujaca namiary celu do sledzenia przez kamere
    public void Setup(Func<float> GetCameraZoomFunc)
    {
        this.GetCameraZoomFunc = GetCameraZoomFunc;
    }

    public void SetCameraFollowPosition(Vector3 cameraFallowPosition)
    {
        this.cameraFallowPosition =cameraFallowPosition + offset;
    }

    private void Update()
    {
        HandleMovment();
        HandleZoom();
    }

    private void HandleMovment()
    {
        float cameraFollowSpeed = 1f;
        myCamera.transform.position = Vector3.Lerp(myCamera.transform.position, cameraFallowPosition, cameraFollowSpeed);
    }

    private void HandleZoom()
    {
        float cameraZoom = GetCameraZoomFunc();

        float cameraZoomDifference = cameraZoom - myCamera.orthographicSize;
        float cameraZoomSpeed = 1f;

        myCamera.orthographicSize += cameraZoomDifference * cameraZoomSpeed * Time.deltaTime;

        if(cameraZoomDifference>0)
        {
            if(myCamera.orthographicSize> cameraZoom)
            {
                myCamera.orthographicSize = cameraZoom;
            }
        }
        else
        {
            if(myCamera.orthographicSize<cameraZoom)
            {
                myCamera.orthographicSize = cameraZoom;
            }
        }
    }
}
