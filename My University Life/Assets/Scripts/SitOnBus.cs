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
    private GameObject player;
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
            BusMove.busShouldMove = true;
            player.transform.parent = busSeatTracker.transform;
            player.transform.position = busSeatTracker.position;
            Debug.Log("Bus Seat taken!");
            player.GetComponent<PlayerMove>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enterBusPanel.SetActive(false);
    }

}
