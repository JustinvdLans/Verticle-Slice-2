using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float speed = 5f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}
