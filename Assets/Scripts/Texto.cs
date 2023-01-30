using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Texto : MonoBehaviour
{
    private TextMeshProUGUI PizzaTexto;
    // Start is called before the first frame update
    void Start()
    {
        PizzaTexto = GetComponent<TextMeshProUGUI>();
    }

    public void AtualizaPizzaTexto(Inventario playerInventario)
    {
        PizzaTexto.text = playerInventario.numeroPizza.ToString();
    }
}
