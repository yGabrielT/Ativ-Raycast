using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    [SerializeField]
    private Animator shoot;
    [SerializeField]
    private Transform ArmaPos;
    [SerializeField]
    private LayerMask inimigo;
    public GameObject objBullet;
    private float distanceMax = 100f;
    public float projVel;
    private Vector3 PontoFinal;
    public bool inimigoAtingido = false;
    public static bool isShooted = false;
    public Transform PontoOrigem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray.origin, ray.direction, out hit, distanceMax))
        {

            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.green);
            inimigoAtingido = true;
            PontoFinal = hit.point;
            
        }
        else
        {
            inimigoAtingido = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            InstaciarBala();
            shoot.SetTrigger("Shoot");
            shoot.ResetTrigger("Cooldown");

            if (inimigoAtingido == true)
            {
                
                if (hit.collider.gameObject.CompareTag("Inimigo"))
                {
                    Debug.Log("Você atingiu o inimigo");
                    isShooted = true;
                    Destroy(hit.transform.gameObject);
                }
                    
            }
            else
            {
                shoot.ResetTrigger("Shoot");
                shoot.SetTrigger("Cooldown");
                isShooted = false;
            }

        }
        else
        {
            shoot.ResetTrigger("Shoot");
            shoot.SetTrigger("Cooldown");
            isShooted = false;
        }

    }

    private void InstaciarBala()
    {
        var projectOBJ = Instantiate(objBullet, PontoOrigem.position, Quaternion.identity);
        projectOBJ.GetComponent<Rigidbody>().velocity = (PontoFinal - PontoOrigem.position).normalized * projVel;
    }
}
