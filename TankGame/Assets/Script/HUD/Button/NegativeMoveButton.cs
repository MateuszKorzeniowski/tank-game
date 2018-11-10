using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NegativeMoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent NegativeMove;

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        TankController player = FindObjectOfType<NowActive>().NowActiveController();

        if (player != null)
        {
            player.SetMoveDirection(-1);
        }

        Debug.Log("Left");
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        TankController player = FindObjectOfType<NowActive>().NowActiveController();

        if (player != null)
            player.SetMoveDirection(0);
        Debug.Log("Stop");
    }
}
