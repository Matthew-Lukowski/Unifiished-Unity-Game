using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDoor : MonoBehaviour
{
    public GameObject lvlend;

    private void Start() {
        lvlend = GameObject.Find("LevelFinish");
    }

    private void OnTriggerEnter2D(Collider2D x) {
        if (x.tag == "Player") {
            Time.timeScale = 0;
            PlayerPrefs.SetFloat("CurrentLevel", SceneManager.GetActiveScene().buildIndex + 1);
            if (PlayerPrefs.GetFloat("LevelsCompleted") < SceneManager.GetActiveScene().buildIndex + 1) {
                PlayerPrefs.SetFloat("LevelsCompleted", SceneManager.GetActiveScene().buildIndex + 1);
            }
            
            lvlend.GetComponent<Canvas>().enabled = true;
        }
    }
}
