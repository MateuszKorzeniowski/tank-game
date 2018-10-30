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

    private void Update()
    {
        if(Input.GetAxisRaw("Jump") > 0f && isShoot)
        {
            GameObject bullet= Instantiate(prefabBullet, shotPoint.transform.position, cannon.transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(force * multipleForce, 0), ForceMode2D.Impulse);
            Destroy(bullet, 2f);
            isShoot = false;
        }

        if(Input.GetKey(KeyCode.E) && force < maxForce)
        {
            force += Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.Q) && force>minForce)
        {
            force -= Time.deltaTime * speed;
        }
        if (force < minForce) force = minForce;
        if (force > maxForce) force = maxForce;

        hud._force = force;
    }
}
