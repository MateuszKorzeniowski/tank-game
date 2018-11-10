using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

    //zmiana kata nachylanie lufy
    public Transform cannon; //chodzi o podstawe wieżyczki
    public TankController tank;
    //zakres wartosci
    private float minAngle = -15f;
    private float maxAngle = 45f;
    //zmianna porzechowujaca obecny kat
    private float angle = 0f;
    //przechowuje kierunek czy wieżyczka ma sie obniżyć czy podniesc
    private float directionCannon;
    public float speed;

    private void Start()
    {
        cannon.transform.rotation = Quaternion.Euler(0,0,angle); //wyjsciowe ustawienie działka
        tank = GetComponent<TankController>();
    }

    private void Update()
    {
        if(tank.isFacingRight==false)
        {
            cannon.transform.rotation = Quaternion.Euler(0, -180f, angle);
        }

    }

    public void SetAngleCannon(float _angle)
    {
        angle += _angle;
        if (angle < minAngle) angle = minAngle;
        if (angle > maxAngle) angle = maxAngle;
        cannon.transform.rotation = Quaternion.Euler(0, 0, angle);
    }


}
