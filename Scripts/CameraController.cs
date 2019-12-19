using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    float mousSensitivity;
    
    [SerializeField]
    Transform player, playerGun;

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        RotateCamera();
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * mousSensitivity;
        float rotAmountY = mouseY * mousSensitivity;

        Vector3 rotPlayerGun = playerGun.transform.rotation.eulerAngles;
        Vector3 rotPlayer = player.transform.rotation.eulerAngles;

        rotPlayerGun.x -= rotAmountY;
        rotPlayerGun.z = 0;
        rotPlayer.y += rotAmountX;

        playerGun.rotation = Quaternion.Euler(rotPlayerGun);
        player.rotation = Quaternion.Euler(rotPlayer);

    }
}
