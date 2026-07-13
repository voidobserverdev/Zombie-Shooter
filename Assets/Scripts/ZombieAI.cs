using UnityEngine;

public class ZombieAI : MonoBehaviour, IDamageable
{
    private Transform player;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float maxHealth = 10f;
    [SerializeField] private float currentHealth;
    [SerializeField] private Rigidbody2D zombieRb;

    void Start()
    {
        currentHealth = maxHealth;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        Vector2 moveDirection = (player.transform.position - transform.position).normalized;
        zombieRb.linearVelocity = moveDirection * moveSpeed;
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
}
