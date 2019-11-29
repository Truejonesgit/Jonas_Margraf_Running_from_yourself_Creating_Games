using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    
    public TextMeshProUGUI youWin;    
    public TextMeshProUGUI timerText;
    public float timeLeft = 180F;
    

    // Start is called before the first frame update
    void Start()
    {
        
        youWin.enabled = false;
        timerText = GetComponent<TextMeshProUGUI>();
        
    }



    // Update is called once per frame
    void Update()
    {

       

        float t = timeLeft -= Time.deltaTime;

        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;

        
        if (timeLeft <= 0)
        {
            timeLeft = 0;
            GameObject.Find("Main Camera").GetComponent <BasicAI> ().enabled = false;
            youWin.enabled = true;
            

        }
    }


   
}
