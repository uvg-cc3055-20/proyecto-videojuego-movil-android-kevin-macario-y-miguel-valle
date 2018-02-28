using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kevin Macario 17369
//Miguel Valle 17102
//Clase que hace que se mueva a la derecha el personaje

public class Right : MonoBehaviour {

    public GameObject fs;
    public void TurnRight()
    {
        fs.GetComponent<Move>().Rmas();
    }
}
