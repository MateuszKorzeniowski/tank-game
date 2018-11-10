using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PositiveForceButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPointerDown;

    public UnityEvent PositiveForce;

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        isPointerDown = true;

        Debug.Log("Up");
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        isPointerDown = false;

        Debug.Log("Stop");
    }

    private void Update()
    {
        if(isPointerDown)
        {
            TankShoot player = FindObjectOfType<NowActive>().NowActiveForce();

            if (player != null)
                player.SetForce(Time.deltaTime*10f);
        }
    }
}
