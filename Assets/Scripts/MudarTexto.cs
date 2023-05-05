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
    // Start is called before the first frame update
    void Start()
    {
        pont.text = "Pontuação: ";
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Shoot.isShooted)
        {
            spawnCount++;
            pontuacao++;
            Debug.Log(pontuacao);
            pont.text = "Pontuação: " + pontuacao.ToString();
        }
    }
}
