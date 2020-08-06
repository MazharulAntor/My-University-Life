using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    private bool onceClick = true;
    [SerializeField]
    GameObject sleepPanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        sleepPanel.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F) && onceClick)
            {
                TimeDate.timer += 10800;
                onceClick = false;
                PickUpThings.pickedID = false;
                PickUpThings.pickedBag = false;
                if (PickUpThings.items.Contains("ID"))
                {
                    PickUpThings.items.Remove("ID");
                }
                if (PickUpThings.items.Contains("Bag"))
                {
                    PickUpThings.items.Remove("Bag");
                }

                StartCoroutine(sleeapGap());
            }
        }
    }

    IEnumerator sleeapGap()
    {
        yield return new WaitForSeconds(5f);
        onceClick = true;
    }

    private void OnTriggerExit(Collider other)
    {
        sleepPanel.SetActive(false);
    }


}
