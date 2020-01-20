using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    
    public Rigidbody rb;

    private bool ActivatePressurePlate = false;
    private bool OpenDoor = false;

    public GameObject door;

    public Animator anim;
    public Animator Anim;

    void Start()
    {
        anim.enabled = false;
        Anim.enabled = false;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(ActivatePressurePlate)
        {
            Debug.Log("Activated");
            OpenDoor = true;
        }
        else
        {
            Debug.Log("Deactivated");
            OpenDoor = false;
        }
    }
    
    void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == Constants.Tags.Cube || col.transform.tag == Constants.Tags.Player)
        {
            ActivatePressurePlate = true;
            anim.enabled = true;
            Anim.enabled = true;
            anim.Play("Button");
            Anim.Play("OpenDoor");
        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.transform.tag == Constants.Tags.Cube || col.transform.tag == Constants.Tags.Player)
        {
            ActivatePressurePlate = false;
            anim.Play("Button2");
            Anim.Play("CloseDoor");
        }
    }
}
