using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Progress;

public class automovement : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.AI.NavMeshAgent navmeshagent;
    public Transform[] Target;
    public Transform Targetdesc;
    private bool fromdestination = false;
    private bool todestination = false;
    public float dist1;
    public float dist2;
    public Transform machine;
    public Transform[] item;
    public Rigidbody[] rigid;
    public Rigidbody hook;
    private int Counter = 0; 
    //public GameObject item;
    void Start()
    {
        fromdestination = true;
        todestination = false;
        print(item.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (fromdestination)
        {
             navmeshagent.destination = Target[Counter].position;
           // navmeshagent.destination = item[0].position;
        }
        if (todestination)
        {
            navmeshagent.destination = Targetdesc.position;
        }
        dist1 = Vector3.Distance(transform.position, Target[Counter].position);
        dist2 = Vector3.Distance(transform.position, Targetdesc.position);

       
        
        if (dist1 < 5.5f)
        {
            print("Go forward");
            fromdestination = false;
            todestination = true;
            item[Counter].parent = machine;
            item[Counter].position = hook.position;
            rigid[Counter].isKinematic = true;
          
        }
        if (dist2 < 5.5f && todestination)
        {
          
            fromdestination = true;
            todestination = false;
            item[Counter].parent = null;
            rigid[Counter].isKinematic = false;
            if (Counter < (item.Length-1))
                Counter++;
            else
                navmeshagent.speed = 0;
        }
      
        //if (dist1 < 5.5f)
        //{
        //    print("Go forward");
        //    fromdestination = false;
        //    todestination = true;
        //    item[1].parent = machine;
        //    item[1].position = hook.position;
        //    rigid.isKinematic = true;
        //}
        //if (dist2 < 5.5f && todestination)
        //{

        //    fromdestination = true;
        //    todestination = false;
        //    item[1].parent = null;
        //    rigid.isKinematic = false;
        //}
    }
}
