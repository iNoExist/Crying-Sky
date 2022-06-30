using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateVolume : MonoBehaviour
{
    public AudioSource Audio;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Audio.volume = PlayerPrefs.GetFloat("volume", 0.5f);
    }
}
