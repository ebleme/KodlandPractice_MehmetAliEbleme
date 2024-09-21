using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform rifleStart;

    [SerializeField]
    private float fireInterval = 1f;
    
    public float health = 0;

    void Start()
    {
        ChangeHealth(100);

        InvokeRepeating(nameof(Fire), fireInterval, fireInterval);
    }

    private void Fire()
    {
        GameObject buf = Instantiate(bullet);
        buf.transform.position = rifleStart.position;
        buf.GetComponent<Bullet>().setDirection(transform.forward, false);
        buf.transform.rotation = transform.rotation;
    }

    public void ChangeHealth(int hp)
    {
        health += hp;
        if (health > 100)
        {
            health = 100;
        }
        else if (health <= 0)
        {
           Destroy(gameObject);
        }
    }
}
