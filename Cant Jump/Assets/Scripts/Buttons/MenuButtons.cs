using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene("Level1");
    }

    public void Continue() {
        SceneManager.LoadScene((int)PlayerPrefs.GetFloat("CurrentLevel"));
    }

    public void LevelSelect() {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Exit() {        
#if UNITY_EDITOR
        
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }

    public void Options() {
        SceneManager.LoadScene("Options");
    }

    public void ExitOptions() {
        SceneManager.LoadScene("Menu");
    }
}
