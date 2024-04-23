using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}

       

    