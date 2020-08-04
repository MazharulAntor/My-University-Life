using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusFinalEndPointReturn : MonoBehaviour
{
    [SerializeField]
    private GameObject thikanaBusStation1, thikanaBus1, thikanaBus2;
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
            thikanaBus1.transform.position = thikanaBusStation1.transform.position;
            ThikanaBusMove1.busShouldMove = false;
            thikanaBus1.transform.forward = thikanaBusStation1.transform.forward;
            ThikanaBusMove1.returnWay = false;
            ThikanaBusTimeRoutine1.firstStation = true;

            BusEndPoint.touched1 = true;
            BusStartPoint.touched1 = true;

            ThikanaBusMove1.bustype = "up";
        }
        if (other.gameObject.tag == "ThikanaBus2")
        {
            thikanaBus2.transform.position = thikanaBusStation1.transform.position;
            ThikanaBusMove2.busShouldMove = false;
            thikanaBus2.transform.forward = thikanaBusStation1.transform.forward;
            ThikanaBusMove2.returnWay = false;
            ThikanaBusTimeRoutine2.firstStation = true;

            BusEndPoint.touched2 = true;
            BusStartPoint.touched2 = true;

            ThikanaBusMove2.bustype = "up";
        }
    }
}
