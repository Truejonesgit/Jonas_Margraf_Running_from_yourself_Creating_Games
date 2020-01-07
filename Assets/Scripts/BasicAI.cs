using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class BasicAI : MonoBehaviour
{


    public GameObject Player;
    private NavMeshAgent killer;
    public float gameoverDistance = 7f;
    private float killerDelay = 1f;

  
    

    public TextMeshProUGUI gameOver;

     void Start()
    {
        
        killer = GetComponent<NavMeshAgent>();
        

        gameOver.enabled = false;

        InvokeRepeating("DelayMovement", killerDelay, killerDelay);

    }


    void Update()
    {
        

 

        

    }

    void DelayMovement()
    {

        killer.destination = Player.transform.position;

        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < gameoverDistance)

        {
            Time.timeScale = 0;
            gameOver.enabled = true;



        }

    }


}