using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStart : MonoBehaviour
{

    public GameObject countDown;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("StartDelay");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }



     IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3.5f;
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        countDown.gameObject.SetActive (false);
        Time.timeScale = 1;

    }

}
