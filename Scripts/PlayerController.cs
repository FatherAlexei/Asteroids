using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform gunPos;
    private Rigidbody2D rb;
    public float damage = 1f;
    public float speed = 1f;
    public float rotationSpeed = 3f;
    public float bulletSpeed = 100f;
    public GameObject bullet;
    public Sprite bulletSprite;
    private Weapon weapon;
    private WeaponProxy weaponProxy;
    private Text text;
    public Text textUI;
    private State state;

    public State State
    {
        set
        {
            state = value;
            state.Handle(this);
        }
    }

    void Awake()
    {
        State = new MovingForwardState();
        rb = GetComponent<Rigidbody2D>();
        weapon = new Weapon(bullet, gunPos, bulletSpeed);
        weaponProxy = new WeaponProxy(weapon, true, text);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            weaponProxy.fire();
        }
    } 

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddForce(gameObject.transform.up * speed);
            State = new MovingForwardState();
        }

        if (Input.GetKey(KeyCode.A))
        {
            //rb.AddTorque(1 * rotationSpeed);
            State = new RotationLeftState();
        }

        if (Input.GetKey(KeyCode.D))
        {
            //rb.AddTorque(-1 * rotationSpeed);
            State = new RotationRightState();
        }

        if (Input.GetKey(KeyCode.S))
        {
            //rb.AddForce(gameObject.transform.up * (speed * -1));
            State = new MovingBackState();
        }

    }


}
