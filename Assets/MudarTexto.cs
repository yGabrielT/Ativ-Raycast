using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudarTexto : MonoBehaviour
{
    public Text pont;
    private int pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        //pont.text = "Pontuação: ";
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Shoot.isShooted)
        {
            
            pontuacao++;
            Debug.Log(pontuacao);
            pont.text = pontuacao.ToString("F2");
        }
        
    }
}
