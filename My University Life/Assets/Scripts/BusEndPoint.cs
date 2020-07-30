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
    private Transform thikanaBus, thikanaBusStation3;
    private bool timeFinished = false, coRoutine = true;
    public static bool touched = true;

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
        if (other.gameObject.tag == "Bus" && touched)
        {
            //if (BuyTicket.thikanaTicket)
            //{
                ThikanaBusMove.busShouldMove = false;
                thikanaBus.position = thikanaBusStation3.position;
                BusTimeRoutine.thirdStation = true;
            touched=false;


            //}
            if (BuyTicket.savarTicket)
            {
                SavarBusMove.busShouldMove = false;
            }
            else if (BuyTicket.shuvecchaTicket)
            {
                ShuvecchaBusMove.busShouldMove = false;
            }
            else if (BuyTicket.shuvojatraTicket)
            {
                ShuvojatraBusMove.busShouldMove = false;
            }
            player.transform.position = getDownFromBusPoint.position;
            player.transform.forward = getDownFromBusPoint.forward;
            player.transform.parent = null;
            downFromBus = true;
        }
    }
}
