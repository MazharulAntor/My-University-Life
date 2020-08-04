using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThikanaBusMove2 : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    public static bool busShouldMove = false;
    public static bool sideChange = false;
    public static bool returnWay = false;
    public static string bustype="up";
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (busShouldMove)
        {
            if (sideChange)
            {
                if (returnWay)
                {
                    Debug.Log("Side changed return");
                    transform.localPosition = new Vector3(transform.localPosition.x + 5f, transform.localPosition.y, transform.localPosition.z);
                }
                else
                {
                    Debug.Log("Side changed");
                    transform.localPosition = new Vector3(transform.localPosition.x - 5f, transform.localPosition.y, transform.localPosition.z);
                }
                sideChange = false;
            }
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
