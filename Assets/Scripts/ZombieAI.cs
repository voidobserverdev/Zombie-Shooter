using UnityEngine;

public class ZombieAI : MonoBehaviour, IDamageable
{
    [SerializeField] private Transform player;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float health = 10f;
    [SerializeField] private Rigidbody2D zombieRb;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(int damageAmount)
    {

    }
}
