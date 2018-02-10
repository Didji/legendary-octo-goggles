using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {


    joueur _joueur;

	// Use this for initialization
	void Start () {

        _joueur = GameObject.Find("Sphere").GetComponent<joueur>();


    }
	
	// Update is called once per frame
	void Update ()
    {

        print(_joueur.life);


    }
}
