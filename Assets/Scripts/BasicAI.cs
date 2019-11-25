using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour
{


    private GameObject player;
    private NavMeshAgent enemy;

     void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        
        enemy.destination = player.transform.position;
    }
}