using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void FirstStoryScene() {
        SceneManager.LoadScene("FirstStory");
    }

    public void SecondStoryScene() {
        SceneManager.LoadScene("SecondStory");
    }

    public void Tutorial() {
        SceneManager.LoadScene("Tutorial");
    }
}