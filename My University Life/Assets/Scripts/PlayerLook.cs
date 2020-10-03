using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField]
    private string mouseXInputName, mouseYInputName;
    [SerializeField]
    private float mouseSensitivity;
    [SerializeField]
    private Transform playerBody;
    bool escapeClicked = false;

    private float xAxisClamp;

    private void Awake()
    {
        xAxisClamp = 0.0f;
    }

    private void Update()
    {
        CameraRotation();
        if (Input.GetKeyDown(KeyCode.Escape) && !escapeClicked)
        {
            Cursor.lockState = CursorLockMode.None;
            mouseSensitivity = 0f;
            escapeClicked = true;
        }
        if(Input.GetKeyDown(KeyCode.LeftControl) && escapeClicked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            mouseSensitivity = 150f;
            escapeClicked = false;
        }
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(270.0f);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
