using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusEndPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject player, playerCamera;
    [SerializeField]
    private Transform getDownFromBusPoint;
    private bool downFromBus = false;
    [SerializeField]
    private Transform thikanaBus1, thikanaBus2, thikanaBusStation3;
    public static bool touched1 = true, touched2 = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (downFromBus)
        {
            player.GetComponent<PlayerMove>().enabled = true;
            playerCamera.GetComponent<PlayerLook>().enabled = true;
            downFromBus = false;
            BuyTicket.hasTicket = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ThikanaBus1" && touched1)
        {
            ThikanaBusMove1.busShouldMove = false;
            thikanaBus1.position = thikanaBusStation3.position;
            ThikanaBusTimeRoutine1.thirdStation = true;
            touched1 = false;
            if (BuyTicket.thikanaTicket && SitOnBus.thikanaSit1)
            {
                PassengerGetDownFromBus();
                BuyTicket.thikanaTicket = false;
            }
            SitOnBus.thikanaPassengersPoint1 = false;
        }
        if(other.gameObject.tag == "ThikanaBus2" && touched2)
        {
            ThikanaBusMove2.busShouldMove = false;
            thikanaBus2.position = thikanaBusStation3.position;
            ThikanaBusTimeRoutine2.thirdStation = true;
            touched2 = false;
            if(BuyTicket.thikanaTicket && SitOnBus.thikanaSit2)
            {
                PassengerGetDownFromBus();
                BuyTicket.thikanaTicket = false;
            }
            SitOnBus.thikanaPassengersPoint2 = false;
        }
    }

    private void PassengerGetDownFromBus()
    {
        player.transform.position = getDownFromBusPoint.position;
        player.transform.forward = getDownFromBusPoint.forward;
        player.transform.parent = null;
        downFromBus = true;
    }
}
