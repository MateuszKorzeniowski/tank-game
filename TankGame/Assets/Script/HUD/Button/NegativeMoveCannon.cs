using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NegativeMoveCannon : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPointerDown;

    public UnityEvent NegativeCannon;

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        isPointerDown = true;

        Debug.Log("Down");
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
                player.SetAngleCannon(-Time.deltaTime * 10f);
        }
    }
}
