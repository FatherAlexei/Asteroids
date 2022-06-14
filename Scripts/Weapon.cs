using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private readonly GameObject bullet;
    private readonly Transform gun;
    private float force;
    private float timeToDestroy;

    public Weapon(GameObject bullet, Transform gun, float force)
    {
        this.bullet = bullet;
        this.gun = gun;
        this.force = force;
    }

    public void fire()
    {
        GameObject bufBullet = Object.Instantiate(bullet, gun.position, Quaternion.identity);
        Rigidbody2D bulletRb = bufBullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(gun.up * force);
        Object.Destroy(bufBullet, 3f);
    }
}
