using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThikanaBusMove2 : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    public static bool busShouldMove = true;
    public static bool sideChange = true;
    public static bool bus2Left = false;
    public static bool returnFinalEndPointTouched = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BusStartPoint.bus1Left || !returnFinalEndPointTouched)
        {
            if (busShouldMove)
            {
                if (sideChange)
                {
                    Debug.Log("Side changed 2");
                    transform.localPosition = new Vector3(transform.localPosition.x - 5f, transform.localPosition.y, transform.localPosition.z);
                    sideChange = false;
                }
                transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            }
        }
    }
}
