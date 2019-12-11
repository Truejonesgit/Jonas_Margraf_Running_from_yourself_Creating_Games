using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{

    public GameObject playerModel;
    private Vector3 moveDirection;
    public float rotateSpeed;
    public float gravityScale;
    public float moveSpeed;
    public CharacterController controller;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {

        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        moveDirection = new Vector3(Input.GetAxis("Vertical") * moveSpeed, 0f, Input.GetAxis("Horizontal") * moveSpeed);

        moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        moveDirection = moveDirection.normalized * moveSpeed;

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
        controller.Move(moveDirection * Time.deltaTime);

        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x, 0f, moveDirection.z));
            playerModel.transform.rotation = Quaternion.Slerp(playerModel.transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }


        anim.SetBool("isGrounded", controller.isGrounded);
        anim.SetFloat("Speed", (Mathf.Abs(Input.GetAxis("Vertical")) + (Mathf.Abs(Input.GetAxis("Horizontal")))));

    }
}