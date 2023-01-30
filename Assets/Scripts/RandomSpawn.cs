using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject pizza;
    public int x;
    public int z;
    public int qnt=0;

    void Start()
    {
        StartCoroutine(pizzaSpawn());
    }

    IEnumerator pizzaSpawn()
    {
        while (qnt < 4 )
        {
            x = Random.Range(-27, 23);
            z = Random.Range(-34, -20);
            Instantiate(pizza, new Vector3(x, 0, z), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            qnt++;
        }

    }
    

}
