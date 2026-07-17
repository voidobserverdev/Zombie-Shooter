using UnityEngine;

public class ZombieAI : MonoBehaviour, IDamageable
{
    private Transform player;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth;
    [SerializeField] private Rigidbody2D zombieRb;

    void Start()
    {
        currentHealth = maxHealth;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (player != null)
        {
            Vector2 moveDirection = (player.transform.position - transform.position).normalized;
            zombieRb.linearVelocity = moveDirection * moveSpeed;
        }
        else
        {
            zombieRb.linearVelocity = Vector2.zero;
        }
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth > 0)
        {
            Debug.Log("Health: " + currentHealth);
        }
        else
        {
            Debug.Log("Zombie killed!");
            Destroy(gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.TryGetComponent(out IDamageable damageable))
            {
                damageable.TakeDamage(25);
            }
        }
    }
}
