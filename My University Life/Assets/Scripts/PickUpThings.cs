using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpThings : MonoBehaviour
{
    public static List<string> items = new List<string>();
    [SerializeField]
    private GameObject itemsPanel, pickedText;
    public static bool pickedID = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            itemsPanel.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (!pickedID)
                {
                    items.Add("ID");
                    pickedText.SetActive(true);
                    pickedID = true;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            itemsPanel.SetActive(false);
        }
    }
}
