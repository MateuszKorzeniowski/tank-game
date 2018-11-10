using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootButton : MonoBehaviour
{
    public void Shoot()
    {
        TankShoot player = FindObjectOfType<NowActive>().NowActiveForce();
        
        if(player!=null)
        {
            player.Shoot();
        }
    }
}
