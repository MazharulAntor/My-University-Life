using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusStartPoint : MonoBehaviour
{
    [SerializeField]
    private Transform thikanaBusStation2;
    [SerializeField]
    private GameObject thikanaBus1, thikanaBus2;
    public static bool touched1 = true, touched2 = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ThikanaBus1" && touched1)
        {
            touched1 = false;
            ThikanaBusMove1.busShouldMove = false;
            ThikanaBusMove1.sideChange = false;
            ThikanaBusTimeRoutine1.secondStation = true;
            thikanaBus1.transform.position = thikanaBusStation2.position;
            SitOnBus.thikanaPassengersPoint1 = true;
            Debug.Log(ThikanaBusMove1.bustype);
        }
        if (other.gameObject.tag == "ThikanaBus2" && touched2)
        {
            touched2 = false;
            ThikanaBusMove2.busShouldMove = false;
            ThikanaBusMove2.sideChange = false;
            ThikanaBusTimeRoutine2.secondStation = true;
            Debug.Log("OK");
            thikanaBus2.transform.position = thikanaBusStation2.position;
            SitOnBus.thikanaPassengersPoint2 = true;
            Debug.Log(ThikanaBusMove2.bustype);
        }
    }
}
