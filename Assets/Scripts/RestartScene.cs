using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //uncomment if cursor should disappear in game mode

        //Cursor.lockState = CursorLockMode.Locked;
    }

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
            Application.Quit();
        }

    }
}
