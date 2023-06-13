using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class manuver : MonoBehaviour
{
   public GameObject jet;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
            if (Input.GetKey(KeyCode.A))
            {
               
                
                jet.transform.eulerAngles = new Vector3(
                jet.transform.eulerAngles.x,
                jet.transform.eulerAngles.y  ,
                 15
                );
       
        }
     
            if (Input.GetKey(KeyCode.D))
            {
       
             jet.transform.eulerAngles = new Vector3(
             jet.transform.eulerAngles.x,
             jet.transform.eulerAngles.y,
             -15);

    
        //        rotate++;
            }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            jet.transform.eulerAngles = new Vector3( 0,180,0);

        }

        //  }

    }
}
