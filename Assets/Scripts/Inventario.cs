using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Inventario : MonoBehaviour
{
   public int numeroPizza { get; private set; }
   public GameObject pizzaFinal;
   public int x;
   public int z;
   public int qnt;
   /*
    void Start()
   {
        //StartCoroutine(pizzaSpawn());
   }
   */
    public UnityEvent<Inventario> PizzaColetada;
   public void pizzasColetadas()
    {
        numeroPizza++;
        PizzaColetada.Invoke(this);

        if (numeroPizza == 4)
        {
            qnt = numeroPizza;
        }

        if (numeroPizza == 5)
        {
            SceneManager.LoadScene("MenuFinal");
        }
    }
    
    private void Update()
    {
        if (qnt == 4)
        {
            x = Random.Range(-37, 23);
            z = Random.Range(-34, -20);
            Instantiate(pizzaFinal, new Vector3(x, 0, z), Quaternion.identity);
            qnt++;
            //yield return new WaitForSeconds(0.1f);
        }
    }
}
