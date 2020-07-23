using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RickshawEndPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float rickshawFare = 10f;
    [SerializeField]
    private Transform getDownFromRickshawPoint;
    private bool downFromRickshaw = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (downFromRickshaw)
        {
            player.GetComponent<PlayerMove>().enabled = true;
            downFromRickshaw = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rickshaw")
        {
            RickshawMove.rickshawShouldMove = false;
            player.transform.position = getDownFromRickshawPoint.position;
            player.transform.forward = getDownFromRickshawPoint.forward;
            player.transform.parent = null;
            downFromRickshaw = true;
            Transaction.SubtractAmount(rickshawFare);
        }
    }
}
