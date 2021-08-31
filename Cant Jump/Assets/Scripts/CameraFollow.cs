
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if(player!=null)transform.position = new Vector3(0, player.transform.position.y,-10);
    }
}
