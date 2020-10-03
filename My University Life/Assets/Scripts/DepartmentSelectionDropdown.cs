using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepartmentSelectionDropdown : MonoBehaviour
{
    [SerializeField]
    Dropdown departmentSelection;

    void Start()
    {
        departmentSelection.onValueChanged.AddListener(delegate
        {
            SelectDepartment(departmentSelection);
        });
    }

    public void SelectDepartment(Dropdown varsitySelection)
    {
        Information.selectedDepartment = varsitySelection.captionText.text.ToString();
    }

}
