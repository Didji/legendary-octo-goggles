using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueur : MonoBehaviour {


    public int life = 10;
    CharacterController char_cont;
    Vector3 init_pos;

	// Use this for initialization
	void Start ()
    {
        char_cont = GetComponent<CharacterController>();
        life = 5;
        init_pos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            //transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * 2f * Time.deltaTime, transform.position.y, transform.position.z);
            char_cont.Move(transform.right*Time.deltaTime*2f);//(new Vector3(transform.position.x + Input.GetAxis("Horizontal") * 0.01f * Time.deltaTime, transform.position.y, transform.position.z));


        
        }

        transform.position = new Vector3(transform.position.x, init_pos[1], init_pos[2]);
	}
}
