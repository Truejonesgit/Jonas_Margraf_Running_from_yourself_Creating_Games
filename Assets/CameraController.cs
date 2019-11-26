using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    //comment this out

    public Vector3 offset;
    public bool useOffsetValues;

    public float rotateSpeed;
    public Transform pivot;



    // Start is called before the first frame update
    void Start()
    {
        //comment this out

        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }


        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;


        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void LateUpdate()
    {
        

        //comment this out

        //transform.position = target.position - offset;

        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(vertical, 0, 0);


        if(pivot.rotation.eulerAngles.x > 45f && pivot.rotation.eulerAngles.x < 180f)
        {
            pivot.rotation = Quaternion.Euler(45f, 0, 0);

        }

        float desiredYAngle = target.eulerAngles.y;
        float desiredXAngle = target.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);

        if (transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y - 0.5f, transform.position.z);

        }



        transform.LookAt(target.transform);

    }





}

