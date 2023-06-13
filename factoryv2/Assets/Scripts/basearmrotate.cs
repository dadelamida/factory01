using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basearmrotate : MonoBehaviour
{
    // Start is called before the first frame update
    private bool rotatetype =true ;
    private int maxrotate;
    private int rotate=1;
    void Start()
    {
        maxrotate = Random.Range(5, 95);

    }

// Update is called once per frame
void Update()
    {




        if (rotatetype) {
            transform.Rotate(0, 0.5f, 0);
            rotate++;
        }
        else
        {
            transform.Rotate(0, -0.5f, 0);
            rotate--;
        }

        if (rotate > maxrotate) { 
            rotatetype = false;
        }
        if (rotate < (0-maxrotate))
        {
            rotatetype = true;
        }

    }
}
