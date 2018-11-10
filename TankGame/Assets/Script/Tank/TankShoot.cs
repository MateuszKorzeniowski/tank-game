using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour {

    public Transform shotPoint;
    public Transform cannon;
    public GameObject prefabBullet;
    public float multipleForce;
    public float force;
    private float minForce = 0;
    private float maxForce = 100f;
    private float speed = 20f;
    public bool isShoot =true;

    HUDController hud;

    private void Start()
    {
        hud = FindObjectOfType<HUDController>();
    }

    public void SetForce(float _force)
    {
        force += _force;
        if (force < minForce) force = minForce;
        if (force > maxForce) force = maxForce;
        hud._force = force;
    }

    public void Shoot()
    {
        if (isShoot)
        {
            TankController player = GetComponent<TankController>();
            GameObject bullet = Instantiate(prefabBullet, shotPoint.transform.position, Quaternion.identity);

            if (player != null && player.isFacingRight)
                bullet.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(force * multipleForce, 0), ForceMode2D.Impulse);

            else bullet.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-force * multipleForce, 0), ForceMode2D.Impulse);

            Destroy(bullet, 10f);
            isShoot = false;
        }
    }
}
