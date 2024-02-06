using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 360 * Time.deltaTime);
        string objName = transform.gameObject.name;
        // Vector3 eAngles = transform.localEulerAngles;
        // eAngles.y += 360 * Time.deltaTime;
        Debug.Log("rotate info z:  " +transform.localEulerAngles.z + " obj name is : " + objName);

        // transform.localEulerAngles = eAngles;
        // transform.Rotate(10*Time.deltaTime,0,0);
    }
}
