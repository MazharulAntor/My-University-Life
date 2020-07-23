using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RickshawMove : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    public static bool rickshawShouldMove = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (rickshawShouldMove)
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        
    }

}
