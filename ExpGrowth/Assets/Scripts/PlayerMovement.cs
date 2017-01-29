using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private float speedCopy;

    public float increasedSpeed;

    private Vector3 targetPosition;

    Rigidbody playerObject;

    Animator anim;

    private bool isMoving;
    void Start()
    {
        playerObject = GetComponent<Rigidbody>();
        speedCopy = speed;
        isMoving = false;
        anim = GetComponent<Animator>();
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
    }

    void FixedUpdate()
    {
        if(isMoving)
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        playerObject.AddForce(transform.forward * speed);
    }


}
