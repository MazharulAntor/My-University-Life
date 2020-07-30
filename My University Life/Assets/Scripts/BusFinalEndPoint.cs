using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusFinalEndPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject thikanaReturnBusStation1, thikanaBus, thikanaBus2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bus")
        {
            thikanaBus.transform.position = thikanaReturnBusStation1.transform.position;
            ThikanaBusMove.busShouldMove = false;
            thikanaBus.transform.forward = thikanaReturnBusStation1.transform.forward;
            BusInitialPoint.busQueueReturn.Add(1);
        }
        if (other.gameObject.tag == "Bus2")
        {
            thikanaBus2.transform.position = thikanaReturnBusStation1.transform.position;
            ThikanaBusMove2.busShouldMove = false;
            thikanaBus2.transform.forward = thikanaReturnBusStation1.transform.forward;
            BusInitialPoint.busQueueReturn.Add(2);
        }
    }
}
