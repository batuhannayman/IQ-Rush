using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Obstacle_3 : MonoBehaviour
{
    bool turning_Left;

    // Start is called before the first frame update
    void Start()
    {
        turning_Left = false;
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (turning_Left == false)
        {
            if (transform.rotation != Quaternion.Euler(0, 0, 80))
            {
                transform.Rotate(new Vector3(0, 0, 2));
            }
            else
            {
                turning_Left = true;
            }
        }
        else
        {
            if (transform.rotation != Quaternion.Euler(0, 0, -80))
            {
                transform.Rotate(new Vector3(0, 0, -2));
            }
            else
            {
                turning_Left = false;
            }
        }
    }
}
