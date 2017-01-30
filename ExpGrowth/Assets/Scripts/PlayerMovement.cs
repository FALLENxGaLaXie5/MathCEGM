using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private float speedCopy;

    public float increasedSpeed;

    public Vector3 pubVelocity;

    private Vector3 targetPosition;

    public Text speedText;

    Rigidbody playerObject;

    Animator anim;

    private bool isMoving;
    void Start()
    {
        playerObject = GetComponent<Rigidbody>();
        speedCopy = speed;
        isMoving = false;
        anim = GetComponent<Animator>();
        pubVelocity = playerObject.velocity;
    }


    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            isMoving = true;
            anim.SetBool("walking", true);
        }
        else
        {
            isMoving = false;
            anim.SetBool("walking", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speedCopy = speed;
            speed = speed * speed;
        }
        else if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed = speed / speedCopy;
        }

        displayText();
    }

    void FixedUpdate()
    {
        if(isMoving)
        {
            MovePlayer();
        }
        pubVelocity = playerObject.velocity;
    }

    void MovePlayer()
    {
        playerObject.AddForce(transform.forward * speed);
    }

    void displayText()
    {
        speedText.text = "Speed: " + this.speed;
    }

}
