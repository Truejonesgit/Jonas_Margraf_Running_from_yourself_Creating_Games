using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    //public Vector3 offset;
    //public bool useOffsetValues;

    // Start is called before the first frame update
    void Start()
    {
        //if (!useOffsetValues)
        {
            //offset = target.position - transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void LateUpdate()
    {
        transform.LookAt(target.transform);
        //transform.position = target.position - offset;
    }





}

