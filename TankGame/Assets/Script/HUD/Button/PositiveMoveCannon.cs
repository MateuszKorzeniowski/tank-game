using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PositiveMoveCannon : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPointerDown;

    public UnityEvent PositiveCannon;

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
        if (isPointerDown)
        {
            CannonController player = FindObjectOfType<NowActive>().NowActiveCannon();

            if (player != null)
                player.SetAngleCannon(Time.deltaTime * 10f);
        }
    }
}
