using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMove : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    public static bool busShouldMove = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (busShouldMove)
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
