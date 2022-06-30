using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicPlayer : MonoBehaviour
{

    private float musicVolume;
    public Slider volumeSlider;


    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("volume", 0.5f);
        volumeSlider.value = musicVolume;
    }

    void Update()
    {
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void updateVolume (float volume)
    {
        musicVolume = volume;
    }
}
