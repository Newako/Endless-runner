using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private bool alive = true;

    public float currentSpeed = 0.1f; //starting speed
    public float maxSpeed = 10f; // maximum limit

    public float leftRightSpeed = 4;
    public float jumpForce = 160f;

    [SerializeField] LayerMask groundMask;
    [SerializeField] Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        currentSpeed = 0.1f;
    }

    void Update()
    {
        // Move left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        }
        // Move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
        }
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (transform.position.y < -5)
        {
            Die();
        }

        if (currentSpeed < maxSpeed)
        {
            IncreaseSpeedOverTime();
        }
    }

    private void FixedUpdate()
    {
        if (!alive) return;

        KeepUpright();
    }

    private void MovePlayer()
    {
        transform.position += new Vector3(currentSpeed * Time.deltaTime, 0, 0);
    }

    private void IncreaseSpeedOverTime()
    {
        // Increase speed
        currentSpeed += 0.5f * Time.deltaTime;
    }

    public void KeepUpright()
    {
        Quaternion uprightRotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
        rb.MoveRotation(uprightRotation);
        rb.angularVelocity = Vector3.zero;
    }

    public void Die()
    {
        alive = false;
        //Restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);

        rb.AddForce(Vector3.up * jumpForce);
    }
}