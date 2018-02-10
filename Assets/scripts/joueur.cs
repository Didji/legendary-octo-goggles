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
    float vitesse = 4f;
    public float speed = 6.0F;
    public float jumpSpeed = 20.0F;
    public float gravity = 8.0F;
    private int tempsApresLancer;

    // Use this for initialization
    void Start ()
    {
        char_cont = GetComponent<CharacterController>();
        rigibody = GetComponent<Rigidbody>();
        life = 5;
        init_pos = transform.position;
        tempsApresLancer = -1;

    }
	
	// Update is called once per frame
	void Update ()
    {
        float deplacement = Input.GetAxis("Horizontal");
        if (deplacement != 0)
        {

            //transform.position = new Vector3(transform.position.x + deplacement * vitesse * Time.deltaTime, transform.position.y, transform.position.z);
            char_cont.Move(transform.right*Time.deltaTime * deplacement * vitesse);//(new Vector3(transform.position.x + Input.GetAxis("Horizontal") * 0.01f * Time.deltaTime, transform.position.y, transform.position.z));

        }

        if (Input.GetButton("Jump")) {
            moveDirection.y = jumpSpeed;
            char_cont.Move(transform.up * Time.deltaTime * jumpSpeed);
        }

    }
}
