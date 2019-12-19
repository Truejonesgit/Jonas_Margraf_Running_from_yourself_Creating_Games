using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Start()
    {

        Time.timeScale = 1;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
    public void PlayGame ()
    {

        SceneManager.LoadScene("Prototype_2");

    }


    public void QuitGame ()
    {

        Application.Quit();

    }
}
