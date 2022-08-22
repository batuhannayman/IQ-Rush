using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Obstacle_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(-1.5f, 0, 0));
    }
}
