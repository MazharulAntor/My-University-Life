using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitOnBus : MonoBehaviour
{
    [SerializeField]
    private GameObject enterBusButton;
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
        enterBusButton.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        enterBusButton.SetActive(false);
    }

    public void EnterBus()
    {
        if (BuyTicket.hasTicket)
        {
            BusMove.busShouldMove=true;
            player.transform.parent = busSeatTracker.transform;
            player.transform.position = busSeatTracker.position;
            Debug.Log("Bus Seat taken!");
            player.GetComponent<PlayerMove>().enabled = false;
        }
    }
}
