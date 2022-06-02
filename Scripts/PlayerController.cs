using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform gunPos;
    private Rigidbody2D rb;
    public float speed = 1f;
    public float rotationSpeed = 3f;
    public float bulletSpeed = 100f;
    public GameObject bullet;
    public Sprite bulletSprite;
    public BulletBuilder bulletBuider;



    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
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

    private void Shoot()
    {
        bulletBuider = new BulletBuilder();
        GameObject bufBullet = bulletBuider.Visual.Name("IAmBullet").Sprite(bulletSprite).Physics.BoxCollider2D().Rigidbody2D(1f).Transform(gunPos);
        Rigidbody2D bulletRb = bufBullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(gunPos.up * bulletSpeed);
        Destroy(bufBullet, 3f);
    }

}
