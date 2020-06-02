using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class RingController : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject doorGO;
    public GameObject ringGO;

    // Start is called before the first frame update
    void Awake()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //DoorControl(); alterar para checar 
        RingControl();
    }

    void DoorControl()
    {
        doorGO.transform.Rotate(0, 0, (rotationSpeed * Time.deltaTime));
    }
    void RingControl()
    {
        ringGO.transform.Rotate(0, 0, (rotationSpeed * Time.deltaTime));
    }
}