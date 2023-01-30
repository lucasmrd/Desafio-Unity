using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passos : MonoBehaviour
{
    public AudioSource passos;
    //private bool w, a, s, d;
    /*private void Start()
    {
        w = Input.GetKey(KeyCode.W);
        a = Input.GetKey(KeyCode.A);
        s = Input.GetKey(KeyCode.S);
        d = Input.GetKey(KeyCode.D);
    }
    */
    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            passos.enabled = true;
        }

        else
        {
            passos.enabled = false;
        }
    }
}
