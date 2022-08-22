using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Obstacle_1 : MonoBehaviour
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
        transform.Rotate(new Vector3(-2.0f, 0, 0));
    }
}
