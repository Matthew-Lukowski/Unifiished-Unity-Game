using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Volume : MonoBehaviour
{
    public static float mastervolume;
    public static float musicvolume;
    public static float effectsvolume;

    public Slider slider1master;
    public Slider slider2music;
    public Slider slider3effects;

    public void Start() {
        slider1master.value = mastervolume;
        slider2music.value = musicvolume;
        slider3effects.value = effectsvolume;
    }

    public void SetMasterVolume(float volume) {
        PlayerPrefs.SetFloat("MasterVolume", volume);
        mastervolume = volume;
    }
    public void SetMusicVolume(float volume) {
        PlayerPrefs.SetFloat("MusicVolume", volume);
        musicvolume = volume;
    }
    public void SetEffectsVolume(float volume) {
        PlayerPrefs.SetFloat("EffectsVolume", volume);
        effectsvolume = volume;
    }

}
