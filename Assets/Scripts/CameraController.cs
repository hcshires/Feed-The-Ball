using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    void Start() // Initialization
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate() // Runs every frame after all items have been processed
    {
        transform.position = player.transform.position + offset;
    }
}