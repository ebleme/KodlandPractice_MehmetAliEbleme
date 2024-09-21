using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    [SerializeField]
    private float lifetime = 5f;


    Vector3 direction;
    private float time;


    private bool isPlayerBullet;

    public void setDirection(Vector3 dir, bool playerBullet)
    {
        direction = dir;
        isPlayerBullet = playerBullet;
    }

    void FixedUpdate()
    {
        transform.position += direction * (speed * Time.deltaTime);

        time += Time.fixedDeltaTime;

        if (time >= lifetime)
        {
            Destroy(gameObject);
        }

        Collider[] targets = Physics.OverlapSphere(transform.position, 1);
        foreach (var item in targets)
        {
            // Enemy vurulursa 
            if (isPlayerBullet)
            {
                if (item.CompareTag("Enemy"))
                {
                    EnemyManager.Instance.DestroyEnemy(item.GetComponent<EnemyController>());
                }

                // Dağa taşa ve diğer objelere vurunca da yok olsun
                if (!item.CompareTag("Player"))
                    Destroy(gameObject);
            }
            else
            {
                // Enemy bullet ise
                if (item.CompareTag("Player"))
                    item.GetComponent<PlayerController>().ChangeHealth(-10);

                // Dağa taşa ve diğer objelere vurunca da yok olsun
                if (!item.CompareTag("Enemy"))
                    Destroy(gameObject);
            }

            //  Bullet ı yok et
        }
    }
}