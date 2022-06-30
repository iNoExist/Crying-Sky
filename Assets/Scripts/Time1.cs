using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time1 : MonoBehaviour
{
    public Text PR1;
    public void reset_click()
    {
        PlayerPrefs.DeleteKey("Lv1");
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("Lv1"))
        {
            float t = PlayerPrefs.GetFloat("Lv1");
            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("f2");
            PR1.text = minutes + ":" + seconds;
        }
        else
        {
            PR1.text = "N/A";
        }
    }


}
