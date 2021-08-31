using UnityEngine;
using UnityEngine.UI;

public class Spikes : MonoBehaviour
{
    public GameObject deathScreen;

    public float spd;

    void Start() {
        deathScreen = GameObject.Find("GameOver");
    }
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * spd);
    }
    private void OnTriggerEnter2D(Collider2D x) {
        Destroy(x.gameObject);
        deathScreen.GetComponent<CanvasScaler>().enabled = false;
        deathScreen.GetComponent<Canvas>().enabled = true;
        deathScreen.GetComponent<CanvasScaler>().enabled = true;
    }

}
