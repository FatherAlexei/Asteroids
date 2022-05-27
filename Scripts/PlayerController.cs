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
    private ObjectPool objectPool;


    // Start is called before the first frame update
    void Awake()
    {
        objectPool = new ObjectPool(bullet);
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
        GameObject bufBullet = objectPool.Pop(gunPos);
        Rigidbody2D bulletRb = bufBullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(gameObject.transform.up * bulletSpeed);
        StartCoroutine(Pause(bufBullet));
    }

    IEnumerator Pause(GameObject bufBullet)
    {
        yield return new WaitForSeconds(3);
        objectPool.Push(bufBullet);
    }

}
