using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MudarTexto : MonoBehaviour
{
    public TextMeshProUGUI pont;
    public static int pontuacao;
    public static int spawnCount = 0;

    void Start()
    {
        pont.text = "Pontuação: ";
    }

    void Update()
    {
       // Aumenta a pontuação quando a variavél isShooted do shoot é ativada
        if (Shoot.isShooted)
        {
            spawnCount++;
            pontuacao++;
            Debug.Log(pontuacao);
            pont.text = "Pontuação: " + pontuacao.ToString();
        }
    }
}
