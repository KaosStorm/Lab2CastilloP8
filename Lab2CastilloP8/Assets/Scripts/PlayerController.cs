using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private float zbound;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();
    }
    void MovePlayer()
    {
        float verticalMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; 
        float horizontalMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(Vector3.right * verticalMovement);
        transform.Translate(Vector3.forward * horizontalMovement);
    }
    void ConstrainPlayerPosition()
    {
        if (transform.position.z < -zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zbound);
        }
        if (transform.position.z < zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zbound);
        }
    }
}





    