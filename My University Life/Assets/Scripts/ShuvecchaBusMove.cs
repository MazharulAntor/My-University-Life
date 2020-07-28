using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuvecchaBusMove : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    public static bool busShouldMove = false;
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
                sideChange = false;
                transform.localPosition = new Vector3(transform.localPosition.x - 5f, transform.localPosition.y, transform.localPosition.z);
            }
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
