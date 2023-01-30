using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    float tempoAtual = 0f;
    float tempoInicial = 120f;

    [SerializeField] private Text timer;
    private void Start()
    {
        tempoAtual = tempoInicial;
    }

    private void Update()
    {
        tempoAtual -= 1 * Time.deltaTime;
        timer.text = tempoAtual.ToString("0");

        if (tempoAtual <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
