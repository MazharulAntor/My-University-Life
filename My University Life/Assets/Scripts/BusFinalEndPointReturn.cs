using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusFinalEndPointReturn : MonoBehaviour
{
    [SerializeField]
    private GameObject thikanaBusStation1, thikanaBus, thikanaBus2;
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
            thikanaBus.transform.position = thikanaBusStation1.transform.position;
            ThikanaBusMove.busShouldMove = false;
            thikanaBus.transform.forward = thikanaBusStation1.transform.forward;
            BusInitialPoint.busQueueReturn.Add(1);
        }
        if (other.gameObject.tag == "Bus2")
        {
            ThikanaBusMove2.returnFinalEndPointTouched = true;
            thikanaBus2.transform.position = thikanaBusStation1.transform.position;
            ThikanaBusMove2.busShouldMove = false;
            thikanaBus2.transform.forward = thikanaBusStation1.transform.forward;
            BusInitialPoint.busQueueReturn.Add(2);
        }
    }
}
