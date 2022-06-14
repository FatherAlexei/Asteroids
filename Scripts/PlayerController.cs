using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform gunPos;
    private Rigidbody2D rb;
    public float speed = 1f;
    public float rotationSpeed = 3f;
    public float bulletSpeed = 100f;
    public GameObject bullet;
    public Sprite bulletSprite;
    private Weapon weapon;
    private WeaponProxy weaponProxy;
    private Text text;



    // Start is called before the first frame update
    void Awake()
    {
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

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(gameObject.transform.up * speed); 
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(1 * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-1 * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(gameObject.transform.up * (speed * -1));
        }

    }


}
