using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDate : MonoBehaviour
{
    public static float timer;
    private float seconds;
    public static float minutes;
    public static float hours;
    [SerializeField]
    private Text timeShower;
    [SerializeField]
    private Text dayCountShower;
    [SerializeField]
    private Text dayShower;
    [SerializeField]
    private float timeSpeed;
    private float day;
    private int dayTrack;
    private string dayName;
    // Start is called before the first frame update
    void Awake()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimeShower();
    }

    private void TimeShower()
    {
        timer += Time.deltaTime * timeSpeed;
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60) % 60;
        hours = (int)(timer / 3600) % 24;
        day = (int)(timer / 86400) % 30;

        timeShower.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");

        dayCountShower.text = "Day " + (day + 1);
        dayTrack = (int)(day + 1) % 7;
        switch (dayTrack)
        {
            case 1:
                dayName = "Saturday";
                break;
            case 2:
                dayName = "Sunday";
                break;
            case 3:
                dayName = "Monday";
                break;
            case 4:
                dayName = "Tuesday";
                break;
            case 5:
                dayName = "Wednesday";
                break;
            case 6:
                dayName = "Thursday";
                break;
            case 0:
                dayName = "Friday";
                break;
        }
        dayShower.text = dayName;
        

    }
}
