using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endMenu : MonoBehaviour
{
    public static bool WinGame = false;
    public GameObject endMenuUI;
    public GameObject endUI;
    public GameObject pauseUI;
    public GameObject timerUI;
    public GameObject Player;
    public Text currentTime;
    public Text winTime;
    public GameObject Slot;
    private bool finished;
    private bool notran = true;

    // Update is called once per frame
    void Update()
    {
        if (finished && notran)
        {
            Pause();
            notran = false;
        }
           
    }



    void Pause()
    {
        winTime.text = currentTime.text;
        endMenuUI.SetActive(true);
        pauseUI.SetActive(false);
        Slot.SetActive(false);
        Time.timeScale = 0f;
        WinGame = true;
        Player.GetComponent<PlayerMovement>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        Player.GetComponent<PlayerMovement>().enabled = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Finish()
    {
        finished = true;
    }
    public void Dead()
    {
        timerUI.SetActive(false);
        pauseUI.SetActive(false);
        endUI.SetActive(true);
        Slot.SetActive(false);
        Time.timeScale = 0f;
        Player.GetComponent<PlayerMovement>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}

