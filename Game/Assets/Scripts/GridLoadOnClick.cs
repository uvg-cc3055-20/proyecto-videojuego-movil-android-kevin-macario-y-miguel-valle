﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GridLoadOnClick : MonoBehaviour {
    public void PlayGame()
    {
        SceneManager.LoadScene("Menu");
    }
}