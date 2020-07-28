using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitOnBus : MonoBehaviour
{
    [SerializeField]
    private GameObject enterBusPanel;
    [SerializeField]
    private Transform busSeatTracker;
    [SerializeField]
    private GameObject player, playerCamera;
    [SerializeField]
    private int counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        enterBusPanel.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (BuyTicket.hasTicket && Input.GetKeyDown(KeyCode.F))
        {
            if(BuyTicket.thikanaTicket && counter == 1)
            {
                ThikanaBusMove.busShouldMove = true;
                player.transform.parent = busSeatTracker.transform;
                player.transform.position = busSeatTracker.position;
                Debug.Log("Bus Seat taken!");
                player.GetComponent<PlayerMove>().enabled = false;
                playerCamera.GetComponent<PlayerLook>().enabled = false;
                player.transform.forward = busSeatTracker.forward;
            }
            else if (BuyTicket.savarTicket && counter == 2)
            {
                SavarBusMove.busShouldMove = true;
                player.transform.parent = busSeatTracker.transform;
                player.transform.position = busSeatTracker.position;
                Debug.Log("Bus Seat taken!");
                player.GetComponent<PlayerMove>().enabled = false;
                playerCamera.GetComponent<PlayerLook>().enabled = false;
                player.transform.forward = busSeatTracker.forward;
            }
            else if (BuyTicket.shuvecchaTicket && counter == 3)
            {
                ShuvecchaBusMove.busShouldMove = true;
                player.transform.parent = busSeatTracker.transform;
                player.transform.position = busSeatTracker.position;
                Debug.Log("Bus Seat taken!");
                player.GetComponent<PlayerMove>().enabled = false;
                playerCamera.GetComponent<PlayerLook>().enabled = false;
                player.transform.forward = busSeatTracker.forward;
            }
            else if (BuyTicket.shuvojatraTicket && counter == 4)
            {
                ShuvojatraBusMove.busShouldMove = true;
                player.transform.parent = busSeatTracker.transform;
                player.transform.position = busSeatTracker.position;
                Debug.Log("Bus Seat taken!");
                player.GetComponent<PlayerMove>().enabled = false;
                playerCamera.GetComponent<PlayerLook>().enabled = false;
                player.transform.forward = busSeatTracker.forward;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enterBusPanel.SetActive(false);
    }

}
