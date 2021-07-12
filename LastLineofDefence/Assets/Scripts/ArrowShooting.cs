using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooting : MonoBehaviour
{
    
    public Transform player;
    public bool inRange;
    public Rigidbody projectile;
    public float range;
    public float bulletImpulse;

    public float bulletDelay = 2f;
    private float _bulletDelayTimer;
    public bool _bulletDelayComplete = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _canShoot();

    }
    public void shoot()
    {
         if (inRange && _bulletDelayComplete)
         {
             Rigidbody bullet = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);
             bullet.AddForce(transform.forward * bulletImpulse, ForceMode.Impulse);
             Destroy(bullet.gameObject, 2);
         }
    }
    public void checkInRange()
    {
        if (Vector3.Distance(transform.position, player.position) < range)
        {
            inRange = true;
            transform.LookAt(player);

        }
        else
        {
            inRange = false;
        }   
    }
    void _canShoot()
    {
         checkInRange();
         if (inRange && _bulletDelayComplete)
         {
             shoot();
             _bulletDelayComplete = false;
         }
         else if (!_bulletDelayComplete)
         {
             _bulletDelayTimer += Time.fixedDeltaTime;
             if (_bulletDelayTimer > bulletDelay)
             {
                 _bulletDelayComplete = true;
                 _bulletDelayTimer = 0;
                 _bulletDelayComplete = true;

             }
         }
    }
}

