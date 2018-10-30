using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

    public Text gas;
    public float _gas;
    public Text health;
    public float _health;
    public Text force;
    public float _force;

    private void LateUpdate()
    {
        gas.text = "Gas: " + (int)_gas;
        health.text = "Health: " + (int)_health;

        force.text = "Force: " + (int)_force; 
    }

}
