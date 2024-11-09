using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Brings game into start of game scene
    public void StartGameScene() {
        SceneManager.LoadScene("GameplayScene");
    }
}
