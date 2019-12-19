using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickerLong : MonoBehaviour
{
    public float timeOn = 10f;
    public float timeOff = 1f;
    public float changeTime = 0f;

    void Update()
    {
        if (Time.time > changeTime)
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            if (GetComponent<Light>().enabled)
            {
                changeTime = Time.time + timeOn * Random.Range(0, 20);
            }
            else
            {
                changeTime = Time.time + timeOff * Random.Range(0, 2);
            }
        }
    }
}
