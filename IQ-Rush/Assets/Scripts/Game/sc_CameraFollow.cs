using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 8, -9);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, target.position.z) + offset;
    }
}
