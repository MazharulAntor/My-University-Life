using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    private bool onceClick = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F) && onceClick)
            {
                TimeDate.timer += 10800;
                onceClick = false;
                StartCoroutine(sleeapGap());
            }

        }

        IEnumerator sleeapGap()
        {
            yield return new WaitForSeconds(5f);
            onceClick = true;
        }
    }
}
