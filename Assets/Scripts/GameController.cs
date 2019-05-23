using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    /* Numbers for Manipulating the Scene */
    public float friction;
    public float speed;
    protected int score;
    protected int debug;

    /* GameObjects */
    private Rigidbody rb;
    public Text scoreText;
    public Text directionText;
    private Vector3 opposingForce;
    private Vector3 currentSpeed;

    /* Local Values */
    private Vector3 playerPosition;
    private bool isInstRunning = false; // Boolean for if instructions are on screen
    private string level;

    void Awake() // Prevents GameObjects from resetting upon Level update
    {
        DontDestroyOnLoad(gameObject);
        score = 0;
        debug = 2;
    }

    void Start() // Initialization
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update() // Update information displayed
    {
        MenuSelect();
        SetText();
    }

    void LevelChange(int lvl = 1) // Handles Level Transitions
    {
        level = "Level " + lvl.ToString(); // Scene name
        SceneManager.LoadScene(level);
        rb.position = Vector3.zero; // Reset position
        isInstRunning = false;
    }

    void FixedUpdate() // Physics
    {
        float moveX = Input.GetAxis("Horizontal"); // Checks for input and outputs to Axis
        float moveY = Input.GetAxis("Vertical");
        // float moveZ = Input.

        Vector3 movement = new Vector3(moveX, 0.0f, moveY);

        playerPosition = rb.position;
        // directionText.text = playerPosition.ToString();

        rb.AddForce(movement * speed); // Adds force via coordinates

        if (moveY == 0 && moveX == 0) // Accounts for Friction
        {
            currentSpeed = rb.velocity; // Checks for current speed rather than max speed set
            opposingForce = -currentSpeed * friction;

            rb.AddForce(opposingForce);
        }

        if (playerPosition.y <= -10) // If player falls off
        {
            rb.position = Vector3.zero;
        }
    }

    void OnTriggerEnter(Collider other) // Called when collision is triggered
    {
        if (other.gameObject.CompareTag("Coin")) // Collects coins
        {
            other.gameObject.SetActive(false);
            score++;
            SetText(true, false);
        }
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("EnemyZ")) // Hits enemies
        {
            rb.position = Vector3.zero;
        }
        if (other.gameObject.CompareTag("Checkpoint")) // Reaches checkpoint
        {

            SetText(true, true); // Handle level and text when a checkpoint is reached
        }
    }

    void SetText(bool update = false, bool checkpoint = false) // Sets text to the value of score
    {
        scoreText.text = "Score: " + score.ToString();

        if (score < 12) // Prevents initial text from remaining on screen when function is called by update()
        {
            directionText.text = "Welcome to Feed the Ball! To move the ball, press W, A, S, D or Arrow Keys.";
        }

        // When to update levels
        if (score == 12 && update == true) // 1
        {
            LevelChange(2);
            isInstRunning = true;
            directionText.text = "Avoid red enemies and collect all coins to advance to the next level. Good Luck!";
        }

        else if (score == 34 && checkpoint == true) // 2
        {
            LevelChange(3);
            isInstRunning = true;
            directionText.text = "Watch out for red platforms that act like enemies!";

        }
        else if (score == 59 && checkpoint == true) // 3
        {
            /* LevelChange(4); Currently not added */
            rb.position = Vector3.zero;
            directionText.text = "YOU WIN!";
        }

        else if (playerPosition.z >= 10 && isInstRunning == true)
        {
            directionText.text = "";
        }

    }

    void MenuSelect()
    {
        if (Input.GetKeyUp("l")) // Quick Skip to levels for debugging
        {
            LevelChange(debug);
            score += 12;
            debug++;
        }

        if (Input.GetKeyUp("q"))
        {
            score += 22;
        }

        if (Input.GetKeyUp("m")) // Level Menu
        {
            SceneManager.LoadScene("Level Menu");
        }
    }
}