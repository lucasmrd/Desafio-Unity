using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoTerceiraPessoa : MonoBehaviour
{
    [SerializeField] private CharacterController controle;
    [SerializeField] private float speed = 6f;
    [SerializeField] private float turnSmoothTime = 0.1f;
    [SerializeField] private Transform cam;

    private Animator animator;

    float turnSmoothVel;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direcao = new Vector3(horizontal, 0f, vertical).normalized;

        if (direcao.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direcao.x, direcao.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVel, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward; 
            controle.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        if (direcao != Vector3.zero)
        {
            animator.SetBool("Movendo", true);
        }

        else
        {
            animator.SetBool("Movendo", false);
        }
    }
    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
