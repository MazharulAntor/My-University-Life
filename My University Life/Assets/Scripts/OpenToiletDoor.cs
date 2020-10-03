using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenToiletDoor : MonoBehaviour
{
    [SerializeField]
    Animator toiletDoor;
    [SerializeField]
    GameObject pressFOpenPanel, pressGClosePanel;
    public static bool toiletDoorOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !toiletDoorOpen)
        {
            pressFOpenPanel.SetActive(true);
        }
        if (other.tag == "Player" && toiletDoorOpen)
        {
            pressGClosePanel.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                if (!toiletDoorOpen)
                {
                    pressFOpenPanel.SetActive(false);
                    toiletDoor.SetTrigger("ToiletDoor");
                    toiletDoorOpen = true;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (other.tag == "Player")
            {
                if (toiletDoorOpen)
                {
                    pressGClosePanel.SetActive(false);
                    toiletDoor.SetTrigger("ToiletDoorClose");
                    Debug.Log("Toilet Close Outside");
                    toiletDoorOpen = false;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pressFOpenPanel.SetActive(false);
            pressGClosePanel.SetActive(false);
        }
    }
}
