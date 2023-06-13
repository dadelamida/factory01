using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    public float UGVSpeed = 1;
    public float RotateSpeed = 1;
    public float SidesMove = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, UGVSpeed);
            print("Go forward");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -UGVSpeed);
            print("Go backward");
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            print("Stop !");
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -RotateSpeed, 0);
            print("Go left");
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, RotateSpeed, 0);
            print("Go right");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-SidesMove, 0, 0);
            print("Go left");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(SidesMove, 0, 0);
       
            print("Go right");
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.localEulerAngles = new Vector3(60, 10, 90);


        }
     
    }
}
