using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelBarMenager : MonoBehaviour {

    private GasSystem gasSystem;


    private void Start()
    {
        gasSystem = new GasSystem(100);
    }

    private void Update()
    {
        transform.localScale = new Vector3(gasSystem.GetGasProcent(), 0.5f);
    }
    
    public GasSystem TakeGas()
    {
        return gasSystem;
    }
}
