using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperAttack : IAttack
{
    public GameObject bullet;
    public Transform gun;
    public float force;
    public float multiplyShoot;
    public void fire()
    {
        GameObject bufBullet = Object.Instantiate(bullet, gun.position, Quaternion.identity);
        Rigidbody2D bulletRb = bufBullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(gun.up * force * multiplyShoot);
        Object.Destroy(bufBullet, 3f);
    }
}
