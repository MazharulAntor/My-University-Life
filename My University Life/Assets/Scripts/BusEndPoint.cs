using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusEndPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Transform getDownFromBusPoint;
    private bool downFromBus = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (downFromBus)
        {
            player.GetComponent<PlayerMove>().enabled = true;
            downFromBus = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bus")
        {
            BusMove.busShouldMove = false;
            player.transform.position = getDownFromBusPoint.position;
            player.transform.forward = getDownFromBusPoint.forward;
            player.transform.parent = null;
            downFromBus = true;
        }
    }
}
