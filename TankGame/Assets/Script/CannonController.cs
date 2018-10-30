using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

    //zmiana kata nachylanie lufy
    public Transform cannon; //chodzi o podstawe wieżyczki
    public Transform shotPoint;
    public TankControler tank;
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
        tank = GetComponent<TankControler>();
    }

    private void Update()
    {

        //sterowanie cannonem
        directionCannon = Input.GetAxisRaw("Vertical");
        if (directionCannon > 0f && angle < maxAngle)
        {
            angle += (speed * Time.deltaTime);
        }
        else if(directionCannon < 0f && angle > minAngle)
        {
            angle -= (speed * Time.deltaTime);
        }

        if (angle < minAngle) angle = minAngle;
        if (angle > maxAngle) angle = maxAngle;

        cannon.transform.rotation = Quaternion.Euler(0, 0, angle);

        //jelsi patrzymy w lewo to od rotacji odejmujemy rotację 180 ze wzgledu na występowanie funkcji Flip w Tank Controller
        if(tank.isFacingRight==false)
        {
            cannon.transform.rotation = Quaternion.Euler(0, -180f, angle);
        }

    }


}
