using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;

    void Start()
    {
        startButton.onClick.AddListener(() => StartGame());
        exitButton.onClick.AddListener(() => ExitGame());
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
