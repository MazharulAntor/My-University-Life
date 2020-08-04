using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThikanaBusTimeRoutine2 : MonoBehaviour
{
    public static bool firstStation = true, secondStation = false, thirdStation = false;
    public static bool touched = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (firstStation && !ThikanaBusMove2.returnWay)
        {
            if (TimeDate.hours == 0 && TimeDate.minutes == 20)
            {
                ThikanaBusMove2.busShouldMove = true;
                ThikanaBusMove2.sideChange = true;
                firstStation = false;
            }
        }

        if (firstStation && ThikanaBusMove2.returnWay)
        {
            if (TimeDate.hours == 0 && TimeDate.minutes == 40)
            {
                ThikanaBusMove2.busShouldMove = true;
                ThikanaBusMove2.sideChange = true;
                firstStation = false;
            }
        }

        if (secondStation)
        {
            if (secondStation && !ThikanaBusMove2.returnWay)
            {
                if (TimeDate.hours == 0 && TimeDate.minutes == 30)
                {
                    ThikanaBusMove2.busShouldMove = true;
                    ThikanaBusMove2.sideChange = true;
                    secondStation = false;
                }
            }
            if (secondStation && ThikanaBusMove2.returnWay)
            {
                if (TimeDate.hours == 0 && TimeDate.minutes == 50)
                {
                    ThikanaBusMove2.busShouldMove = true;
                    ThikanaBusMove2.sideChange = true;
                    secondStation = false;
                }
            }
        }

        if (thirdStation)
        {
            StartCoroutine(BusInterval());
        }
    }

    IEnumerator BusInterval()
    {
        thirdStation = false;
        yield return new WaitForSeconds(5.0f);
        ThikanaBusMove2.busShouldMove = true;
        ThikanaBusMove2.sideChange = true;
    }
}
