using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThikanaBusTimeRoutine1 : MonoBehaviour
{
    public static bool firstStation = true, secondStation = false, thirdStation = false;
    public static bool touched = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (firstStation && !ThikanaBusMove1.returnWay)
        {
            if (TimeDate.hours == 0 && TimeDate.minutes == 10)
            {
                ThikanaBusMove1.busShouldMove = true;
                ThikanaBusMove1.sideChange = true;
                firstStation = false;
            }
        }

        if(firstStation && ThikanaBusMove1.returnWay)
        {
            if (TimeDate.hours == 0 && TimeDate.minutes == 30)
            {
                ThikanaBusMove1.busShouldMove = true;
                ThikanaBusMove1.sideChange = true;
                firstStation = false;
            }
        }

        if (secondStation)
        {
            if (secondStation && !ThikanaBusMove1.returnWay)
            {
                if (TimeDate.hours == 0 && TimeDate.minutes == 20)
                {
                    ThikanaBusMove1.busShouldMove = true;
                    ThikanaBusMove1.sideChange = true;
                    secondStation = false;
                }
            }
            if (secondStation && ThikanaBusMove1.returnWay)
            {
                if (TimeDate.hours == 0 && TimeDate.minutes == 40)
                {
                    ThikanaBusMove1.busShouldMove = true;
                    ThikanaBusMove1.sideChange = true;
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
        ThikanaBusMove1.busShouldMove = true;
        ThikanaBusMove1.sideChange = true;
    }


}
