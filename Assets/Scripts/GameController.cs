using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    /* Numbers for Manipulating the Scene */
    public float friction;
    public float speed;
    protected int score;
    protected int levelChange;

    /* GameObjects */
    private Rigidbody rb;
    public Text scoreText;
    public Text directionText;
    private Vector3 opposingForce;
    private Vector3 currentSpeed;

    /* Local Values */
    private Vector3 playerPosition;
    private bool isInstRunning = false;
    private string level;

    void Awake() // Prevents GameObjects from resetting upon Level Change
    {
        DontDestroyOnLoad(gameObject);
        score = 0;
        levelChange = 1;
    }

    void Start() // Initialization
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update() // Update information displayed
    {
        SetText(levelChange);
        MenuSelect();
    }

    void LevelChange() // Handles Level Transitions
    {
        levelChange++;
        level = "Level " + levelChange.ToString();
        SceneManager.LoadScene(level);
        rb.position = Vector3.zero;
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
        }
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("EnemyZ")) // Hits enemies
        {
            rb.position = Vector3.zero;
        }
    }

    void SetText(int level = 1) // Sets text to the value of score
    {
        scoreText.text = "Score: " + score.ToString();

        switch (score) // When to change levels
        {
            case 12:
                if (levelChange == 1)
                {
                    LevelChange();
                }
                break;
            case 34:
                if (levelChange == 2)
                {
                    LevelChange();
                }
                break;
            case 58:
                if (levelChange == 3)
                {
                    LevelChange();
                }
                break;
        }
        switch (level)
        {
            case 1:
                directionText.text = "Welcome to Feed the Ball! To move the ball, press W, A, S, D or Arrow Keys.";
                break;
            case 2:
                if (isInstRunning == false)
                {
                    isInstRunning = true;
                    directionText.text = "Avoid red enemies and collect all coins to advance to the next level. Good Luck!";
                }

                if (playerPosition.z >= 10 && isInstRunning == true)
                {
                    directionText.text = "";
                }
                break;
            case 3:
                if (isInstRunning == false)
                {
                    isInstRunning = true;
                    directionText.text = "Watch out for red platforms that act like enemies!";
                }

                if (playerPosition.z >= 10 && isInstRunning == true)
                {
                    directionText.text = "";
                }
                break;
        }
    }

    void MenuSelect()
    {
        if (Input.GetKeyUp("l")) // Quick Skip to levels for debugging
        {
            LevelChange();
        }

        if (Input.GetKeyUp("m")) // Level Menu
        {
            SceneManager.LoadScene("Level Menu");
        }
    }
}
