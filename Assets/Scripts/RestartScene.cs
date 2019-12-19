using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Prototype_2");
            Time.timeScale = 1;

            //? instead of scenemanager? (veraltet?)
            //Application.LoadLevel(Application.loadedLevel);  


        }

        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("StartMenu");
        }

    }
}
