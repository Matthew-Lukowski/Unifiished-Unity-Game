using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour
{
    public GameObject[] button;
    public bool lvlselect;

    private void Start() {
        if(lvlselect == true) {
            for (int x = (int)PlayerPrefs.GetFloat("LevelsCompleted"); x >= 0; x--) {
                button[x].SetActive(true);
            }
        }    
    }

    public void ResetLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void NextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }
    public void Menu() {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
    public void LevelSelect() {
        SceneManager.LoadScene(EventSystem.current.currentSelectedGameObject.name);
    }
}
