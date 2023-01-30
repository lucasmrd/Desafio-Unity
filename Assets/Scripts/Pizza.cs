using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Inventario playerInventario = other.GetComponent<Inventario>();

        if (playerInventario != null)
        {
            playerInventario.pizzasColetadas();
            gameObject.SetActive(false);
        }
    }
}
