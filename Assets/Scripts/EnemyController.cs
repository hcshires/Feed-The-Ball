using UnityEngine;

public class EnemyController : MonoBehaviour {

    /* GameObjects */
    private Rigidbody rb;
    // private Vector3 initialPos;

    /* Local Values */
    private bool hitWallZ = false;
    private bool hitWallX = false;
    public float speed;

    // Use this for initialization
    void Start() {
        // initialPos = new Vector3(6.8f, -1.2f, 22.39f);
        rb = GetComponent<Rigidbody>();
        // rb.position = initialPos;
    }

    // Physics
    void FixedUpdate() {
        if (gameObject.tag == "Enemy") {
            if (hitWallZ == false)
            {
                rb.position += Vector3.left * (Time.deltaTime * speed);
            }
            else
            {
                rb.position += Vector3.right * (Time.deltaTime * speed);
            }
        }
        else
        {
            if (hitWallX == false)
            {
                rb.position += Vector3.back * (Time.deltaTime * speed);
            }
            else
            {
                rb.position += Vector3.forward * (Time.deltaTime * speed);
            }
        }
    }
    
    void OnTriggerEnter(Collider other) // Called when collision is triggered
    {
        if (other.gameObject.CompareTag("ZWall"))
        {
            hitWallZ = true;
        }
        else if (other.gameObject.CompareTag("ZWallRight"))
        {
            hitWallZ = false;
        }
        else if (other.gameObject.CompareTag("XWall"))
        {
            hitWallX = true;
        }
        else if (other.gameObject.CompareTag("XWallRight"))
        {
            hitWallX = false;
        }
    }
}