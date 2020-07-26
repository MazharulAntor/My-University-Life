using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyTicket : MonoBehaviour
{
    [SerializeField]
    private GameObject buyTicketPanel, ticketBoughtPanel;
    [SerializeField]
    private float fare;
    public static bool hasTicket = false, first = false;
    private bool panelOpen = false;
    [SerializeField]
    private Text ticketPriceText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        buyTicketPanel.SetActive(true);
        ticketPriceText.text = "Ticket Price: " + fare;
        Debug.Log("1");
        panelOpen = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (panelOpen)
            {
                Debug.Log("2");
                if (!hasTicket)
                {
                    Debug.Log("Ticket Bought!");
                    Transaction.SubtractAmount(fare);
                    hasTicket = true;
                    first = true;
                }
                else if(!first)
                {
                    ticketBoughtPanel.SetActive(true);
                    StartCoroutine(DisplayMessage());
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        buyTicketPanel.SetActive(false);
        panelOpen = false;
        ticketBoughtPanel.SetActive(false);
        if (first)
        {
            first = false;
        }
    }

    IEnumerator DisplayMessage()
    {
        yield return new WaitForSeconds(1f);
        ticketBoughtPanel.SetActive(false);
    }

}
