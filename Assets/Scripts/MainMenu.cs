using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Story1()
    {
        SceneManager.LoadScene(3);
    }
    public void Sandbox()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    void Start() {
    }
    void Update() {
    }
}
