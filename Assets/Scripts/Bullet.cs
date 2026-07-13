using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float lifeTime = 2f;

    void Start()
    {
        if(gameObject.TryGetComponent(out Rigidbody2D rigidbody2D))
        {
            rigidbody2D.linearVelocity = transform.right * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamageable damageable))
        {
            damageable.TakeDamage(1);
            Destroy(gameObject, lifeTime);
        }
    }
}
