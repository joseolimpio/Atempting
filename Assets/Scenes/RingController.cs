using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class RingController : MonoBehaviour
{
    float rotationSpeed;
    int ringID;
    GameObject[] doorGOS;
    GameObject[] ringGOS;


    // Start is called before the first frame update
    void Start()
    {
        doorGOS = GameObject.FindGameObjectsWithTag("door");
        ringGOS = GameObject.FindGameObjectsWithTag("outterRing");
    }

    // Update is called once per frame
    void Update()
    {
        //DoorControl(); alterar para checar 
        RingControl();
    }

    void DoorControl()
    {
       //controle do comportamento das portas
    }
    void RingControl()
    {
        rotationSpeed = 60;
        ringID = 5;

        foreach (GameObject ring in ringGOS)
        {   
            ring.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            if (rotationSpeed <= 450)
            {
                rotationSpeed *= 2;
            }
            else if (rotationSpeed <= 600)
            {
                rotationSpeed += 30;
            }
            Debug.Log("The ring speed is [" + rotationSpeed + "] for ring [" + ringID + "]");
            ringID--;
        }

    }
}