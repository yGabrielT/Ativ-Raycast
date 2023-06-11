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
        pont.text = "Pontua��o: ";
    }

    void Update()
    {
       // Aumenta a pontua��o quando a variav�l isShooted do shoot � ativada
        if (Shoot.isShooted)
        {
            spawnCount++;
            pontuacao++;
            Debug.Log(pontuacao);
            pont.text = "Pontua��o: " + pontuacao.ToString();
        }
    }
}
