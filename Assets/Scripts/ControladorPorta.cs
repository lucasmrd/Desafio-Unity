using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class ControladorPorta : MonoBehaviour
{
    private Animator portaAnim;

    private bool PortaAbrindo = false;

    private void Awake()
    {
        portaAnim = gameObject.GetComponent<Animator>(); 
    }

    public void PlayAnimation()
    {
        if(!PortaAbrindo)
        {
            portaAnim.Play("PortaAbrindo", 0, 0.0f);
            PortaAbrindo = true;
        }

        else
        {
            portaAnim.Play("PortaFechando", 0, 0.0f);
            PortaAbrindo = false;
        }
    }
}
