using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{

    float speed = 4;
    float rotation = 0;
    float rotationSpeed = 80;
    float gravity = 8;

    Vector3 Movedirection = Vector3.zero;

    CharacterController controller;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {

        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

        if (controller.isGrounded)

        {
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetInteger("Condition", 1);
                Movedirection = new Vector3(0, 0, 1);
                Movedirection = Movedirection * speed;
                Movedirection = transform.TransformDirection(Movedirection);

            }

            if (Input.GetKeyUp(KeyCode.W))

            {
                animator.SetInteger("Condition", 0);
                Movedirection = new Vector3(0, 0, 0);
            }
        }
                rotation = rotation + Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
                transform.eulerAngles = new Vector3(0, rotation, 0);

                Movedirection.y -= gravity * Time.deltaTime;
                controller.Move(Movedirection * Time.deltaTime);
            }
        }