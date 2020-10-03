using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarsitySelectionDropDown : MonoBehaviour
{
    [SerializeField]
    Dropdown varsitySelection;

    void Start()
    {
        varsitySelection.onValueChanged.AddListener(delegate
        {
            SelectVarsity(varsitySelection);
        });
    }

    public void SelectVarsity(Dropdown varsitySelection)
    {
        Information.selectedVarsity = varsitySelection.captionText.text.ToString();
    }

}
