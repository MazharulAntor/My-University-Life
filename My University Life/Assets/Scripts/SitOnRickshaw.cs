using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitOnRickshaw : MonoBehaviour
{
    [SerializeField]
    private Transform rickshawSeatTracker;
    [SerializeField]
    private GameObject callRickshawPanel;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject rickshaw;

    private void OnTriggerEnter(Collider other)
    {
        callRickshawPanel.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Transaction.amount >= 10)
            {
                callRickshawPanel.SetActive(false);
                rickshaw.SetActive(true);
                RickshawMove.rickshawShouldMove = true;
                player.transform.parent = rickshawSeatTracker.transform;
                player.transform.position = rickshawSeatTracker.position;
                Debug.Log("Seat taken!");
                player.GetComponent<PlayerMove>().enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        callRickshawPanel.SetActive(false);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

}
