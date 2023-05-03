using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoDano : MonoBehaviour
{
    [SerializeField]
    private Rigidbody obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Shoot.isShooted)
        {
            
           // obj.AddForce(Vector3.forward, ForceMode.Impulse);
            //Invoke("Atirado", 0.01f);


        }
        
    }
    //private void Atirado()
    //{
      //  Shoot.isShooted = false;
    //}
}
