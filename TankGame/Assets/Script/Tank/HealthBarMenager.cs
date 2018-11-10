using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarMenager : MonoBehaviour {

    private HealthSystem healthSystem;


    private void Start()
    {
        healthSystem = new HealthSystem(100);
    }

    private void Update()
    {
        transform.localScale = new Vector3(healthSystem.GetHealthProcent(), 0.5f);
    }

    public HealthSystem TakeHealth()
    {
        return healthSystem;
    }
}
