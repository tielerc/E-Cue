using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTest : MonoBehaviour
{
    // void OnEnable()
    // {
    //     // if(Input.GetKeyDown("y"))
    //     // {
    //     //     SceneManager.LoadScene("SceneTest_Y", LoadSceneMode.Single);
    //     //     print("y key was pressed");
    //     // } else if(Input.GetKeyDown("y"))
    //     // {
    //     //     SceneManager.LoadScene("SceneTest_N", LoadSceneMode.Single);
    //     //     print("N key was pressed");
    //     // }
    // }

    void Update()
    {
        if(Input.GetKeyDown("y"))
        {
            SceneManager.LoadScene("SceneTest_Y", LoadSceneMode.Single);
            print("y key was pressed");
        } else if(Input.GetKeyDown("n"))
        {
            SceneManager.LoadScene("SceneTest_N", LoadSceneMode.Single);
            print("N key was pressed");
        }
    }
}
