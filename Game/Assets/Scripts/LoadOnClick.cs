﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Kevin Macario 17369
//Miguel Valle 17102
//Clase que cambia escena

public class LoadOnClick: MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Grid");
    }
}