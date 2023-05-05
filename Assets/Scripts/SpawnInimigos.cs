using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnInimigos : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i < 10; i++)
        {
            int x = UnityEngine.Random.Range(-10, 10);
            int y = UnityEngine.Random.Range(1, 10);
            Vector3 pos = new Vector3(x, y, 0);
            Instantiate(prefab, pos, Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
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
