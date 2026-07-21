using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private Button restartButton;
    [SerializeField] private Button mainmenuButton;

    void Start()
    {
        restartButton.onClick.AddListener(() => RestartGame());
        mainmenuButton.onClick.AddListener(() => ReturnToMenu());
    }

    void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
