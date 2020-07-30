using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThikanaBusMove : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    public static bool busShouldMove = true;
    public static bool sideChange = true;
    public static bool bus1Left = false;
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
                Debug.Log("Side changed");
                transform.localPosition = new Vector3(transform.localPosition.x - 5f, transform.localPosition.y, transform.localPosition.z);
                sideChange = false;
            }
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
