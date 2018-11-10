using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PositiveMoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent PositiveMove;

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        TankController player = FindObjectOfType<NowActive>().NowActiveController();

        if(player!=null)
        {
            player.SetMoveDirection(1);
        }

        Debug.Log("Right");
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        TankController player = FindObjectOfType<NowActive>().NowActiveController();
        if (player!=null)
            player.SetMoveDirection(0);
        Debug.Log("Stop");
    }
}
