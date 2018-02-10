using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueur : MonoBehaviour {


    public int life = 10;
    CharacterController char_cont;
    Vector3 init_pos;
    Rigidbody rigibody;
    private Vector3 moveDirection = Vector3.zero;

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
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
