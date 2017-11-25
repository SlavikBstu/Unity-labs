using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerCntrl : MonoBehaviour {

    public float speed = 20f;
    private Rigidbody2D rb;
    AudioSource audio;

    private bool faceRight = true;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    /*void Update () {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.up * 8000);

        if (moveX > 0 && !faceRight)
        {
            audio.Play();
            flip();
        }

        else if (moveX < 0 && faceRight)
        {
            audio.Play();
            flip():
        }

    }
    */
    void FixedUpdate()
    {
        float moveX = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

        bool isBoosting = CrossPlatformInputManager.GetButton("Jump");
        if (isBoosting)
        {
            rb.AddForce(Vector2.up * 2000);
        }
        
        if (moveX > 0 && !faceRight)
        {
            audio.Play();
            flip();
        }

        else if (moveX < 0 && faceRight)
        {
            audio.Play();
            flip();
        } 

    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
