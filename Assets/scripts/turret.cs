using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    private const int patrolLimit = 5;
    private CharacterController char_cont;
    private Vector3 startingPosition;
    private float speed;

	// Use this for initialization
	void Start () {
        startingPosition = transform.position;
        char_cont = GetComponent<CharacterController>();
        speed = -1.0f;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 currentPosition = transform.position;

        if (System.Math.Abs(currentPosition.x - startingPosition.x) >= patrolLimit)
        {
            speed *= -1.0f;
        }
        char_cont.Move(transform.right * Time.deltaTime * speed);
	}
}
