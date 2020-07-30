using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusTimeRoutine : MonoBehaviour
{
    public static bool secondStation = false, thirdStation = false;
    public static bool touched = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (secondStation)
        {
            StartCoroutine(BusInterval());
        }
        if (thirdStation)
        {
            StartCoroutine(BusInterval());
        }
    }

    IEnumerator BusInterval()
    {
        secondStation = false;
        thirdStation = false;
        yield return new WaitForSeconds(3.0f);
        ThikanaBusMove.busShouldMove = true;
        ThikanaBusMove.sideChange = true;
    }
}
