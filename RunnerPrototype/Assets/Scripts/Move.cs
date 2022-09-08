using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speedmove = 8f;
    [SerializeField] float forceJamp = 8f;
    [SerializeField] bool onGround = false;
    [SerializeField] Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        PlayerControl();
    }

    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }

    void PlayerControl()
    {
        transform.Translate(Vector3.forward * speedmove * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector3.up * forceJamp, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speedmove * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speedmove * Time.deltaTime);
        }
    }
}