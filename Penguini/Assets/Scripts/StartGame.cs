using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Brings game into start of game scene
    public void StartGameScene() {
        Debug.Log("Starting Game.");
        SceneManager.LoadScene("GameplayScene");
    }
    public void ExitGame() {
        Debug.Log("Exiting Game.");
        Application.Quit();
    }
}
