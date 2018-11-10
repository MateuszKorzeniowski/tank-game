using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurn : MonoBehaviour
{
    GameObject player0;


    private void Start()
    {
        player0 = GameObject.FindGameObjectWithTag("Player0");
    }

    public void TurnPlayer0()
    {
        if(player0!=null)
        {
            player0.GetComponent<TankController>().enabled = true;
            player0.GetComponent<CannonController>().enabled = true;
            player0.GetComponent<TankShoot>().enabled = true;
        }
    }
    public void EndTurnPlayer0()
    {
        if(player0!=null)
        {
            player0.GetComponent<TankController>().enabled = false;
            player0.GetComponent<CannonController>().enabled = false;
            player0.GetComponent<TankShoot>().enabled = false;
        }
    }
}
