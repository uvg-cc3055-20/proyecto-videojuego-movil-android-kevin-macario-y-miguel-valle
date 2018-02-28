using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kevin Macario 17369
//Miguel Valle 17102
//Clase Mueve el personaje a la izquierda

public class Left : MonoBehaviour {

	// Use this for initialization
    public GameObject fs;
	public void TurnLeft()
    {
        fs.GetComponent<Move>().Rmenos();
    }
}
