using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text timerText;
    public Text endText;
    private float startTime;
    private bool finished = false;
    public GameObject StartScreen;
    bool Firstloop = true;

    void Start()
    {

    }

    void Update()
    {

        if (finished)
        {
            return;
        }
        if (!(StartScreen.active))
        {
            if(Firstloop)
            {
                startTime = Time.time;
                Firstloop = false;
            }
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
        }
    }
    public void Finish()
    {
        float t = Time.time - startTime;
        finished = true;
        timerText.color = Color.red;
        endText.text = timerText.text;
        if (t < (PlayerPrefs.GetFloat("Lv1",9999))&& (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelOne")))
        {
            PlayerPrefs.SetFloat("Lv1", t);
        }
    }
}
