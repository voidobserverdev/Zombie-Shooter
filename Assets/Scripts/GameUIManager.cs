using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] private Slider healthBar;

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        healthBar.value = currentHealth / maxHealth;
    }
}
