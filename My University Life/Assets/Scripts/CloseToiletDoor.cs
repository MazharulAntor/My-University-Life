using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseToiletDoor : MonoBehaviour
{
    [SerializeField]
    Animator toiletDoor;
    [SerializeField]
    GameObject pressFClosePanel, pressGOpenPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && OpenToiletDoor.toiletDoorOpen)
        {
            Debug.Log("Toilet Close");
            pressFClosePanel.SetActive(true);
        }
        if(other.tag == "Player" && !OpenToiletDoor.toiletDoorOpen)
        {
            pressGOpenPanel.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                if (OpenToiletDoor.toiletDoorOpen)
                {
                    pressFClosePanel.SetActive(false);
                    toiletDoor.SetTrigger("ToiletDoorClose");
                    Debug.Log("Toilet Close 2");
                    OpenToiletDoor.toiletDoorOpen = false;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (other.tag == "Player")
            {
                if (!OpenToiletDoor.toiletDoorOpen)
                {
                    pressGOpenPanel.SetActive(false);
                    toiletDoor.SetTrigger("ToiletDoor");
                    Debug.Log("Toilet Open Inside");
                    OpenToiletDoor.toiletDoorOpen = true;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pressFClosePanel.SetActive(false);
            pressGOpenPanel.SetActive(false);
        }
    }
}
