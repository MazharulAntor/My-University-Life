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
        if (other.gameObject.tag == "ThikanaBus1")
        {
            thikanaBus.transform.position = thikanaReturnBusStation1.transform.position;
            ThikanaBusMove1.busShouldMove = false;
            thikanaBus.transform.forward = thikanaReturnBusStation1.transform.forward;
            ThikanaBusMove1.returnWay = true;
            ThikanaBusTimeRoutine1.firstStation = true;

            BusEndPoint.touched1 = true;
            BusStartPoint.touched1 = true;

            ThikanaBusMove1.bustype = "down";
        }
        if (other.gameObject.tag == "ThikanaBus2")
        {
            thikanaBus2.transform.position = thikanaReturnBusStation1.transform.position;
            ThikanaBusMove2.busShouldMove = false;
            thikanaBus2.transform.forward = thikanaReturnBusStation1.transform.forward;
            ThikanaBusMove2.returnWay = true;
            ThikanaBusTimeRoutine2.firstStation = true;

            BusEndPoint.touched2 = true;
            BusStartPoint.touched2 = true;
            ThikanaBusMove2.bustype = "down";

        }
    }
}
