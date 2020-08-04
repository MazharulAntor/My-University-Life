using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    [SerializeField]
    Animator entryGate;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (PickUpThings.items.Contains("ID"))
            {
                entryGate.SetTrigger("Open Gate");
            }
        }
    }
}
