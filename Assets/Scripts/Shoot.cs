using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    [SerializeField]
    private Transform ArmaPos;
    [SerializeField]
    private LayerMask inimigo;
    private float distanceMax = 100f;
    public bool inimigoAtingido = false;
    public static bool isShooted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray.origin, ray.direction, out hit, distanceMax, inimigo))
        {

            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.green);
            inimigoAtingido = true;
            
        }
        else
        {
            inimigoAtingido = false;
        }
        if (inimigoAtingido == true && Input.GetMouseButtonDown(0))
        {
            if(hit.collider.gameObject.CompareTag("Inimigo"))
            Debug.Log("Você atingiu o inimigo");
            isShooted = true;
            Destroy(hit.transform.gameObject);
        }
        else
        {
            isShooted=false;
        }
    }
}
