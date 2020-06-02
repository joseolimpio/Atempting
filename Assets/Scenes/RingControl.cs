using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class RingControl : MonoBehaviour
{
    public float rotationSpeed;
    GameObject doorGO = new GameObject();
    GameObject outterRing = new GameObject();

    // Start is called before the first frame update
    void Awake()
    {
        doorGO = GameObject.Find("door");
        outterRing = GameObject.Find("outterRing");
    }

    // Update is called once per frame
    void Update()
    {
        outterRing.transform.Rotate(0, 0, (rotationSpeed * Time.deltaTime));
    }

    void DoorControl()
    {
        doorGO.transform.Rotate(0, 0, (rotationSpeed * Time.deltaTime));
    }
}