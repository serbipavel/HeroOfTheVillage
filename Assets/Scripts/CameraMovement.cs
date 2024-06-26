using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    float xMouse;
    float yMouse;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        xMouse = Input.GetAxis("Mouse X");
        yMouse = Input.GetAxis("Mouse Y");

        transform.eulerAngles += new Vector3(-yMouse, 0f, 0f);
        player.transform.eulerAngles += new Vector3(0, xMouse, 0f);

        transform.position = (player.transform.position + new Vector3(0, .6f, 0)) - transform.forward * 3;

    }
}
