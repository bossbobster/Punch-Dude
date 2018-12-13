using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchDude : MonoBehaviour
{
    protected float horizontalSpeed = 5.0F;
    protected bool onGround = true;
    float x = 0;
    public AudioSource footsteps;
    protected bool walking = false;
    private void Start()
    {
        footsteps = GetComponent<AudioSource>();
    }
    private void Update()
    {
        x += 0.01F;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            walking = true;
            transform.position += transform.forward * 0.1F;
            transform.position += transform.up * Mathf.Abs(Mathf.Sin(x)) * 0.05F;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            walking = true;
            transform.position -= transform.forward * 0.1F;
            transform.position += transform.up * Mathf.Abs(Mathf.Sin(x)) * 0.05F;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            walking = true;
            transform.position += transform.right * 0.1F;
            transform.position += transform.up * Mathf.Abs(Mathf.Sin(x)) * 0.05F;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            walking = true;
            transform.position -= transform.right * 0.1F;
            transform.position += transform.up * Mathf.Abs(Mathf.Sin(x)) * 0.05F;
        }
        else
        {
            walking = false;
        }
        if(!walking)
        {
            footsteps.Play();
        }
        if (Input.GetKey(KeyCode.Space) && onGround == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * 5;
            onGround = false;
        }
        float mouseX = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX, 0);
    }

    private void OnCollisionStay(Collision other)
    {
        onGround = true;
    }
}
