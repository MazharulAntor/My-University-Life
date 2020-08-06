using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpThings : MonoBehaviour
{
    public static List<string> items = new List<string>();
    [SerializeField]
    private GameObject itemsPanel, pickedIDText, pickedBagText, id, bag;
    public static bool pickedID, pickedBag = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pickedID)
        {
            pickedIDText.SetActive(false);
            id.SetActive(true);
        }

        if (!pickedBag)
        {
            pickedBagText.SetActive(false);
            bag.SetActive(true);
        }
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
                    pickedIDText.SetActive(true);
                    pickedID = true;
                    id.SetActive(false);
                }
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (!pickedBag)
                {
                    items.Add("Bag");
                    pickedBagText.SetActive(true);
                    pickedBag = true;
                    bag.SetActive(false);
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
