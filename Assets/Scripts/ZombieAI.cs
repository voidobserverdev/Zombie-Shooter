using UnityEngine;

public class ZombieAI : MonoBehaviour, IDamageable
{
    [SerializeField] private Transform player;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float maxHealth = 10f;
    [SerializeField] private float currentHealth;
    [SerializeField] private Rigidbody2D zombieRb;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
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
