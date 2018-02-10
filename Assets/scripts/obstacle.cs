using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacle : MonoBehaviour {

    // Use this for initialization

    joueur _joueur;
   
    void Start ()
    {
        _joueur = GameObject.Find("Sphere").GetComponent<joueur>();
    }

    // Update is called once per frame
    void Update ()
    {
	   
	}

    
}

