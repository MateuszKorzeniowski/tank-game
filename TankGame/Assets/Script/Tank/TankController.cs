using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class TankController : MonoBehaviour {

    [Header("Move")]
    [Range(200, 600)]
    public float speed;
    private float moveDirection=0;
    [Tooltip("Must be checed when sprite is Right")]
    public bool isFacingRight = true;
    private bool isGas = true;

    private Rigidbody2D rb;
    private HUDController hud;
    private HealthBarMenager health;
    private FuelBarMenager gas;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hud = FindObjectOfType<HUDController>();
        gas = FindObjectOfType<FuelBarMenager>();
        health = FindObjectOfType<HealthBarMenager>();
    }

    void Update ()
    {
        hud._health = health.TakeHealth().GetHealth();

        if(gas.TakeGas().GetGas() <= 0f)
        {
            isGas = false;
        }

        if (isGas)
        {
            rb.velocity = Vector2.right * speed * moveDirection * Time.deltaTime;
            Flip();
            if (moveDirection != 0)
            {
                gas.TakeGas().BurnGas(Time.deltaTime*10f);
                hud._gas = gas.TakeGas().GetGas();
            }
        }
        else
        {
            Flip();
        }
    }

    private void VelocityMethod()
    {
        rb.velocity = Vector2.right * speed * moveDirection * Time.deltaTime;
    }

    void Flip()
    {
        if(moveDirection > 0f && !isFacingRight)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);
            isFacingRight = !isFacingRight;
        }
        else if(moveDirection < 0 && isFacingRight)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);
            isFacingRight = !isFacingRight;
        }
    }

    public void SetSuplise(int nbPlayer)
    {
        PlayerPrefs.SetInt("Player" + nbPlayer + " health", health.TakeHealth().GetHealth());
        PlayerPrefs.SetFloat("Player" + nbPlayer + " gas", gas.TakeGas().GetGas());
    }

    public void GetSuplise(int nbPlayer)
    {
        health.TakeHealth().SetHealth(PlayerPrefs.GetInt("Player" + nbPlayer + " health"));
        gas.TakeGas().SetGas(PlayerPrefs.GetFloat("Player" + nbPlayer + " gas"));
    }

    public void SetMoveDirection(int _direction)
    {
        moveDirection = _direction;
    }
}
