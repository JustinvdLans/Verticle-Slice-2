using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    public Transform Destination;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = Destination.position;
            this.transform.parent = GameObject.Find("Destination").transform;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
