using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTicket : MonoBehaviour
{
    [SerializeField]
    private GameObject buyTicketPanel;
    [SerializeField]
    private float studentFare = 20f;
    [SerializeField]
    private float publicFare = 35f;
    public static bool hasTicket = false;
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
    }

    private void OnTriggerExit(Collider other)
    {
        buyTicketPanel.SetActive(false);
    }

    public void PublicFare()
    {
        if (!hasTicket)
        {
            Debug.Log("PublicFare");
            Transaction.SubtractAmount(publicFare);
            hasTicket = true;
        }       
    }

    public void StudentFare()
    {
        if (!hasTicket)
        {
            Debug.Log("StudentFare");
            Transaction.SubtractAmount(studentFare);
            hasTicket = true;
        }
    }
}
