using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensSlider : MonoBehaviour
{
    private float sens;
    public Slider SSlider;
    void Start()
    {
        sens = PlayerPrefs.GetFloat("sens", 120f);
        SSlider.value = sens;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("sens", SSlider.value);
    }

    public void updateSens(float sensit)
    {
        sens = sensit;
    }
}
