using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transaction : MonoBehaviour
{
    public static float amount = 1000f;
    private static Text BDTText;

    private void Awake()
    {
        BDTText=GameObject.Find("Canvas/BDTText").GetComponent<Text>();
        BDTText.text = "" + amount;
    }
    public static void SubtractAmount(float subAmount)
    {
        if(subAmount <= amount)
        {
            Debug.Log("SubtractAmount");
            amount -= subAmount;
            Debug.Log(amount);
            BDTText.text = "" + amount;
        }
    }
}
