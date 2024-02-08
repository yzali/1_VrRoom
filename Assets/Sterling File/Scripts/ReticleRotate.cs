using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ReticleRotate : MonoBehaviour
{
    // Start is called before the first frame update
    float tmp = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 v3 = new Vector3(0,1,0);
        // transform.Rotate(v3);
        transform.Rotate(0, 1, 0,Space.Self);
    }
}
