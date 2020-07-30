using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMove : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    public static bool busShouldMove = true;
    private bool sideChange = true;
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
                transform.localPosition = new Vector3(transform.localPosition.x - 5f, transform.localPosition.y, transform.localPosition.z);
                sideChange = false;
            }
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
