using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        TankController tank = FindObjectOfType<TankController>();
        if (tank.enabled)
            Debug.Log("Nie");
        else Debug.Log("Tak");
    }
}
