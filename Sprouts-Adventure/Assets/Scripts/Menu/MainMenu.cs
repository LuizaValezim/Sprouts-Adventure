using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Gameplay");
    }

    public void TryAgain() {
        SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame() {
        Application.Quit();
    }
}