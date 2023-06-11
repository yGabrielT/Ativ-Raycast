using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnInimigos : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    
   
    void Start()
    {
        // Seleciona aleatoriamente o XY dos inimigos e instancia no começo 
       for (int i = 0; i < 10; i++)
        {
            int x = UnityEngine.Random.Range(-10, 10);
            int y = UnityEngine.Random.Range(1, 10);
            Vector3 pos = new Vector3(x, y, 0);
            Instantiate(prefab, pos, Quaternion.identity);
        }


    }

    void Update()
    {
        //Instancia 10 inimigos quando 10 inimigos são eliminados 
        if (MudarTexto.spawnCount == 10)
        {
            MudarTexto.spawnCount = 0;
            for (int i = 0; i < 10; i++)
            {
                int x = UnityEngine.Random.Range(-10, 10);
                int y = UnityEngine.Random.Range(1, 10);
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(prefab, pos, Quaternion.identity);
            }
        }
        
    }
}
