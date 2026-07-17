using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;
    [SerializeField] private Transform player;
    [SerializeField] private float spawnRate = 2f;
    private float timer = 0f;
    private Vector2 spawnPosition;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnZombie();
            timer = 0f;
        }
    }

    void SpawnZombie()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized * Random.Range(8f, 10f);
        spawnPosition = (Vector2)player.position + randomDirection;
        Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);
    }
}
