using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueur : MonoBehaviour {


    public int life = 10;
    CharacterController char_cont;
    Vector3 init_pos;
    Rigidbody rigibody;
    private Vector3 moveDirection = Vector3.zero;
    public AudioSource audioSource;

    // Constantes
    float vitesse = 0.05f;
    float force = 0.012f;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    // Use this for initialization
    void Start ()
    {
        char_cont = GetComponent<CharacterController>();
        rigibody = GetComponent<Rigidbody>();
        life = 5;
        init_pos = transform.position;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (char_cont.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                audioSource.Play();
                moveDirection.y = jumpSpeed;
            }
                

        }
        moveDirection.y -= gravity * Time.deltaTime;
        char_cont.Move(moveDirection * Time.deltaTime);
    }
}
