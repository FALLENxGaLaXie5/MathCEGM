using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour
{

    // How fast your object moves
    private float moveSpeed;
    // How fast your object will rotate in the direction of movement
    public float rotationSpeed;
    private Vector3 previousLocation;
    private Vector3 currentLocation;
    private Vector3 rotPosition;

    // Use this for initialization
    void Start()
    {

        moveSpeed = 100;
        //rotationSpeed = 5;

    }

    // Update is called once per frame
    void Update()
    {

        previousLocation = currentLocation;
        //currentLocation = transform.position;
        currentLocation = rotPosition;
        if (Input.GetKey("w") && Input.GetKey("a"))
        {
            currentLocation.z += moveSpeed * Time.fixedDeltaTime;
            currentLocation.x -= moveSpeed * Time.fixedDeltaTime;
            //transform.position = currentLocation;
            rotPosition = currentLocation;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rotPosition - previousLocation), Time.fixedDeltaTime * rotationSpeed);
        }
        else if (Input.GetKey("w") && Input.GetKey("d"))
        {
            currentLocation.z += moveSpeed * Time.fixedDeltaTime;
            currentLocation.x += moveSpeed * Time.fixedDeltaTime;
            rotPosition = currentLocation;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rotPosition - previousLocation), Time.fixedDeltaTime * rotationSpeed);
        }
        else if (Input.GetKey("a") && Input.GetKey("s"))
        {
            currentLocation.x -= moveSpeed * Time.fixedDeltaTime;
            currentLocation.z -= moveSpeed * Time.fixedDeltaTime;
            rotPosition = currentLocation;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rotPosition - previousLocation), Time.fixedDeltaTime * rotationSpeed);
        }
        else if (Input.GetKey("s") && Input.GetKey("d"))
        {
            currentLocation.z -= moveSpeed * Time.fixedDeltaTime;
            currentLocation.x += moveSpeed * Time.fixedDeltaTime;
            rotPosition = currentLocation;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rotPosition - previousLocation), Time.fixedDeltaTime * rotationSpeed);
        }
        else if (Input.GetKey("w"))
        {
            currentLocation.z += moveSpeed * Time.fixedDeltaTime;
            rotPosition = currentLocation;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rotPosition - previousLocation), Time.fixedDeltaTime * rotationSpeed);
        }
        else if (Input.GetKey("a"))
        {
            currentLocation.x -= moveSpeed * Time.fixedDeltaTime;
            rotPosition = currentLocation;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rotPosition - previousLocation), Time.fixedDeltaTime * rotationSpeed);
        }
        else if (Input.GetKey("s"))
        {
            currentLocation.z -= moveSpeed * Time.fixedDeltaTime;
            rotPosition = currentLocation;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rotPosition - previousLocation), Time.fixedDeltaTime * rotationSpeed);
        }
        else if (Input.GetKey("d"))
        {
            currentLocation.x += moveSpeed * Time.fixedDeltaTime;
            rotPosition = currentLocation;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rotPosition - previousLocation), Time.fixedDeltaTime * rotationSpeed);
        }

    }
}
