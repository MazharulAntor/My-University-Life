using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleep : MonoBehaviour
{
    private bool onceClick = true;
    [SerializeField]
    GameObject sleepPanel;
    [SerializeField]
    GameObject blackSleepImage;

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
                TimeDate.timer += 21600;
                TimeDate.stopTime = true;
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

                StartCoroutine(sleepGap());
            }
        }
    }

    IEnumerator sleepGap()
    {
        blackSleepImage.SetActive(true);
        yield return new WaitForSeconds(5f);
        blackSleepImage.SetActive(false);
        TimeDate.stopTime = false;
        onceClick = true;
    }

    private void OnTriggerExit(Collider other)
    {
        sleepPanel.SetActive(false);
    }


}
