using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHRotation : MonoBehaviour
{
    [SerializeField] GameObject lH_Lamp;
    [SerializeField] float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        lH_Lamp.transform.Rotate(0.0f,speed,0.0f,Space.World);
        
    }
}
