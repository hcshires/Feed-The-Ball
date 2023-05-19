using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    /// Public Fields
    public float speed = 0;
    public TextMeshProUGUI scoreText;
    public GameObject winTextObject;

    /// Private Fields
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int score;
    private int pickUpCount;

    /// Tags
    private string PICKUP_TAG = "PickUp";

    /// <summary> 
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get RigidBody component from Player GameObject
        score = 0;
        pickUpCount = GameObject.FindGameObjectsWithTag(PICKUP_TAG).Length;

        SetScoreText();
        winTextObject.SetActive(false);
    }

    /// <summary>Set the Score to the text in the game</summary>
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

        if (score >= pickUpCount)
        {
            winTextObject.SetActive(true);
        }
    }

    /// <summary>
    /// Called when the Player GameObject moves
    /// </summary>
    /// <param name="movementValue">Movement weight of the Player</param>
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    /// <summary>
    /// Every frame, just before physics calculations
    /// </summary>
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PICKUP_TAG))
        {
            other.gameObject.SetActive(false);
            score++;

            SetScoreText();
        }
    }
}
