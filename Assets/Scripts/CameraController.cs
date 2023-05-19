using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset; // Value set in class
    
    // Start is called before the first frame update
    void Start()
    {
        // Init space between player and camera
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame (last task)
    // Don't run until Physics has moved GameObjects
    void LateUpdate()
    {
        // Adjust position vector ONLY (do not rotate camera), snaps to player position with init offset
        transform.position = player.transform.position + offset;
    }
}
