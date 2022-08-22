using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Obstacle_5 : MonoBehaviour
{
    bool isTop;

    // Start is called before the first frame update
    void Start()
    {
        isTop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (isTop == false)
        {
            if (transform.rotation != Quaternion.Euler(0, 0, -96))
            {
                transform.Rotate(new Vector3(0, 0, -1.5f));
            }
            else
            {
                isTop = true;
            }
        }
        else
        {
            if (transform.rotation != Quaternion.Euler(0, 0, 0))
            {
                transform.Rotate(new Vector3(0, 0, 4));
            }
            else
            {
                isTop = false;
            }
        }
    }
}
