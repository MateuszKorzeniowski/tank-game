using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowActive : MonoBehaviour
{

    GameObject player0;
    GameObject player1;
    GameObject player2;
    GameObject player3;

    private void Start()
    {
        player0 = GameObject.FindGameObjectWithTag("Player0");
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
    }

    public TankController NowActiveController()
    {
        if (player0!=null && player0.GetComponent<TankController>().enabled)
            return player0.GetComponent<TankController>();
        else if (player1 != null && player1.GetComponent<TankController>().enabled)
            return player1.GetComponent<TankController>();
        else if (player2 != null && player2.GetComponent<TankController>().enabled)
            return player2.GetComponent<TankController>();
        else if (player3 != null &&player3.GetComponent<TankController>().enabled)
            return player3.GetComponent<TankController>();
        else return null;
    }

    public TankShoot NowActiveForce()
    {
        if (player0 != null && player0.GetComponent<TankShoot>().enabled)
            return player0.GetComponent<TankShoot>();
        else if (player1 != null && player1.GetComponent<TankShoot>().enabled)
            return player1.GetComponent<TankShoot>();
        else if (player2 != null && player2.GetComponent<TankShoot>().enabled)
            return player2.GetComponent<TankShoot>();
        else if (player3 != null && player3.GetComponent<TankShoot>().enabled)
            return player3.GetComponent<TankShoot>();
        else return null;
    }

    public CannonController NowActiveCannon()
    {
        if (player0 != null && player0.GetComponent<CannonController>().enabled)
            return player0.GetComponent<CannonController>();
        else if (player1 != null && player1.GetComponent<CannonController>().enabled)
            return player1.GetComponent<CannonController>();
        else if (player2 != null && player2.GetComponent<CannonController>().enabled)
            return player2.GetComponent<CannonController>();
        else if (player3 != null && player3.GetComponent<CannonController>().enabled)
            return player3.GetComponent<CannonController>();
        else return null;
    }
}
