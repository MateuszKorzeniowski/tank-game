using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasSystem {

    private float gas;
    private int gasMax;


	public GasSystem(int gasMax)
    {
        this.gasMax = gasMax;
        gas = (float)gasMax;
    }

    public float GetGas()
    {
        return gas;
    }

    public void SetGas(float gas)
    {
        this.gas = gas;
    }

    public void AddGas(int addGas)
    {
        gas += (float)addGas;
        if (gas > (float)gasMax) gas = (float)gasMax;
    }

    public void BurnGas(float oddGas)
    {
        gas -= oddGas;
        if (gas < 0) gas = 0;
    }

    public float GetGasProcent()
    {
        return (float)gas / gasMax;
    }
}
