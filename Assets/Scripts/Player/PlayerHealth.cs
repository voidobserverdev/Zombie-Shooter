using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float invincibilityDuration = 1f;
    private float invincibilityTimer = 0f;
    private bool isInvincible = false;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        invincibilityTimer += Time.deltaTime;
        if (invincibilityTimer >= invincibilityDuration)
        {
            isInvincible = false;
        }
    }

    public void TakeDamage(int damageAmount)
    {
        if (!isInvincible)
        {
            currentHealth -= damageAmount;
            Debug.Log("Player Health: " + currentHealth);
            isInvincible = true;
            invincibilityTimer = 0f;
        }

        if (currentHealth <= 0)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
