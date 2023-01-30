using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool jumpPressionado;   
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rigidbodyComponent;
    private bool colisao;

    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(colisao == false)
        {
            return;
        }

       if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressionado = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        if (jumpPressionado == true)
        {
            rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpPressionado = false;
        }

        rigidbodyComponent.velocity = new Vector3(horizontalInput*3, rigidbodyComponent.velocity.y, verticalInput*3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        colisao = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        colisao = false;
    }
}
 