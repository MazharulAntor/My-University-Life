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
    [SerializeField]
    private string busCode;
    public static bool thikanaSit1 = false, thikanaSit2 = false;
    public static bool thikanaPassengersPoint1, thikanaPassengersPoint2 = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enterBusPanel.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (BuyTicket.hasTicket && Input.GetKeyDown(KeyCode.F))
        {
            if (BuyTicket.thikanaTicket && counter == 1)
            {
                if (busCode == "Thikana1" && ThikanaBusMove1.bustype == BuyTicket.ticketType && thikanaPassengersPoint1)
                {
                    player.transform.parent = busSeatTracker.transform;
                    player.transform.position = busSeatTracker.position;
                    player.transform.forward = busSeatTracker.forward;
                    thikanaSit1 = true;
                    PlayerMoveLookScriptsDisable();
                }
                if(busCode == "Thikana2" && ThikanaBusMove2.bustype == BuyTicket.ticketType && thikanaPassengersPoint2)
                {
                    player.transform.parent = busSeatTracker.transform;
                    player.transform.position = busSeatTracker.position;
                    player.transform.forward = busSeatTracker.forward;
                    thikanaSit2 = true;
                    PlayerMoveLookScriptsDisable();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enterBusPanel.SetActive(false);
        }
    }

    private void PlayerMoveLookScriptsDisable()
    {
        Debug.Log("Bus Seat taken!");
        player.GetComponent<PlayerMove>().enabled = false;
        playerCamera.GetComponent<PlayerLook>().enabled = false;
    }

}
