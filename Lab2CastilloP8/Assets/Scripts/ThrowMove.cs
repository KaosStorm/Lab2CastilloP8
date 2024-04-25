using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowMove : MonoBehaviour
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
        float verticalMovement = Input.GetAxis("Vertical");
        float horizontalMovement = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * verticalMovement);
        transform.Translate(Vector3.forward * speed * horizontalMovement);
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
