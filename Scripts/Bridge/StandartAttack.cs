using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartAttack : IAttack
{
    public GameObject bullet;
    public Transform gun;
    public float force;
    public void fire()
    {
        GameObject bufBullet = Object.Instantiate(bullet, gun.position, Quaternion.identity);
        Rigidbody2D bulletRb = bufBullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(gun.up * force);
        Object.Destroy(bufBullet, 3f);
    }
}
