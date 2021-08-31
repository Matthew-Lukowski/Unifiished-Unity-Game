using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume")) {
            Volume.mastervolume = PlayerPrefs.GetFloat("MasterVolume"); 
        } else { 
            Volume.mastervolume = 1; 
        }
        if (PlayerPrefs.HasKey("MusicVolume")) {
            Volume.musicvolume = PlayerPrefs.GetFloat("MusicVolume");
        } else {
            Volume.musicvolume = 1;
        }
        if (PlayerPrefs.HasKey("EffectsVolume")) {
            Volume.effectsvolume = PlayerPrefs.GetFloat("EffectsVolume");
        } else {
            Volume.effectsvolume = 1;
        }
    }
}
