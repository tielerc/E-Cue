﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_NN : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("y"))
        {
            SceneManager.LoadScene("Scene_NNY", LoadSceneMode.Single);
        }    else if (Input.GetKeyDown("n"))
        {
            SceneManager.LoadScene("Scene_NNN", LoadSceneMode.Single);
        }
    }
}
