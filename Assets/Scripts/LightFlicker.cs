using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float timeOn = 0.3f;
    public float timeOff = 0.8f;
    public float changeTime = 0f;

    void Update()
    {
        if (Time.time > changeTime)
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            if (GetComponent<Light>().enabled)
            {
                changeTime = Time.time + timeOn * Random.Range(0, 6);
            }
            else
            {
                changeTime = Time.time + timeOff * Random.Range(0, 2);
            }
        }
    }
}
