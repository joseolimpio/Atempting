using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class RingController : MonoBehaviour
{
    float rotationSpeed;
    int ringID;
    public Transform transform;
    public GameObject[] doorGOS;
    public GameObject[] ringGOS;
    public GameObject prefabRing;

    // Start is called before the first frame update

    private void Awake()
    {
        transform = GetComponent<Transform>();
    }
    void Start()
    {
        int x = 6;
        for (int i = 0; i < 5; i++)
        {
            prefabRing.transform.localScale = new Vector3(x, x, x);
            ringGOS[i] = Instantiate(prefabRing, new Vector3(0, 0, 0), Quaternion.identity, transform);
            x--;
        }     
    }

    // Update is called once per frame
    void Update()
    {
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
        for (int i = 0; i < 5; i++)
        {
            ringGOS[i].transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
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