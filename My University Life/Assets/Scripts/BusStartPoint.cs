using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusStartPoint : MonoBehaviour
{
    [SerializeField]
    private Transform thikanaBusStation2;
    [SerializeField]
    private GameObject thikanaBus, thikanaBus2;
    private bool touched = true, touched2 = true;
    public static bool bus1Left = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bus" && touched)
        {
            touched = false;
            ThikanaBusMove.busShouldMove = false;
            ThikanaBusMove.sideChange = false;
            BusTimeRoutine.secondStation = true;
            thikanaBus.transform.position = thikanaBusStation2.position;
            bus1Left = true;
            ThikanaBusMove2.busShouldMove = true;
            ThikanaBusMove2.sideChange = true;
        }
        else if(other.gameObject.tag == "Bus2" && touched2)
        {
            touched2 = false;
            ThikanaBusMove2.busShouldMove = false;
            ThikanaBusMove2.sideChange = false;
            BusTimeRoutine2.secondStation = true;
            thikanaBus2.transform.position = thikanaBusStation2.position;
        }
    }
}
