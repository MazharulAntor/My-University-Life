using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    public Courses courses;
    public StudyArea studyArea;

    [SerializeField]
    Text yourNameText, idNumberText;
    public static string yourNameString = null, varsityNameString = null, departmentNameString = null, idNumberString = null;
    [SerializeField]
    GameObject informationPanel;
    [SerializeField]
    GameObject player, playerCamera;

    [SerializeField]
    Text showNameText, showVarsityNameText, showDepartmentNameText, showIdNumberText;
    [SerializeField]
    GameObject informationProfilePanel, semestersPanel;

    bool editName=true, saveName=false;
    [SerializeField]
    Text editNameText, editVarsityText, editDepartmentText, editIdText;
    [SerializeField]
    InputField nameInputField, varsityNameInputField, departmentNameInputField, idInputField;
    [SerializeField]
    GameObject nameInputFieldGameObject, varsityNameInputFieldGameObject, departmentNameInputFieldGameObject, idInputFieldGameObject;

    [SerializeField]
    GameObject allInformationPanel;
    [SerializeField]
    Text profileNameText;
    public static string selectedVarsity, selectedDepartment;

    static string semester1 = "COMPLETED", semester2 = "PENDING", semester3, semester4, semester5, semester6, semester7, semester8, semester9, semester10, semester11, semester12;
    static string coins = "NOTEXPENDED", registrationDate = "NOTMISSED";

    [SerializeField]
    Text Text1Status, Text2Status, Text3Status, Text4Status, Text5Status, Text6Status, Text7Status, Text8Status, Text9Status, Text10Status, Text11Status, Text12Status;

    [SerializeField]
    GameObject TextAvailable, TextSkip;

    [SerializeField]
    Button Status1Button, Status2Button, Status3Button, Status4Button, Status5Button, Status6Button, Status7Button, Status8Button, Status9Button, Status10Button, Status11Button, Status12Button;

    [SerializeField]
    GameObject Button2Coins, Button3Coins, Button4Coins, Button5Coins, Button6Coins, Button7Coins, Button8Coins, Button9Coins, Button10Coins, Button11Coins, Button12Coins;

    public static int whichSemesterClicked;
    [SerializeField]
    GameObject semesterOverviewPanel, SemesterCoursesPanel, CourseViewPanel;

    private void Awake()
    {
        TimeDate.stopTime = true;
        player.GetComponent<PlayerMove>().enabled = false;
        playerCamera.GetComponent<PlayerLook>().enabled = false;
    }

    public void SubmitInformation()
    {
        yourNameString = yourNameText.text;
        Debug.Log(yourNameString);
        varsityNameString = selectedVarsity;
        Debug.Log(varsityNameString);
        departmentNameString = selectedDepartment;
        Debug.Log(departmentNameString);
        idNumberString = idNumberText.text; 
        Debug.Log(idNumberString);
        if (yourNameString != "" && varsityNameString != "" && departmentNameString != "" && idNumberString != "")
        {
            informationPanel.SetActive(false);
            player.GetComponent<PlayerMove>().enabled = true;
            playerCamera.GetComponent<PlayerLook>().enabled = true;
            LockCursor();
            TimeDate.stopTime = false;
        }
        profileNameText.text = yourNameString;
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ShowMyInformation()
    {
        informationProfilePanel.SetActive(true);
        semestersPanel.SetActive(false);
        semesterOverviewPanel.SetActive(false);
        showNameText.text = yourNameString;
        showVarsityNameText.text = varsityNameString;
        showDepartmentNameText.text = departmentNameString;
        showIdNumberText.text = idNumberString;
    }

    

    public void EditName()
    {
        if (editName)
        {
            editName = false;
            saveName = true;
            editNameText.text = "Save";
            nameInputFieldGameObject.SetActive(true);
            nameInputField.text = yourNameString;

        }
        else if (saveName)
        {
            saveName = false;
            editName = true;
            editNameText.text = "Edit";
            nameInputFieldGameObject.SetActive(false);
            yourNameString = nameInputField.text;
            profileNameText.text = yourNameString;
            ShowMyInformation();
        }
    }



    public void ShowAllInformationPanel()
    {
        allInformationPanel.SetActive(true);
    }

    public void ShowSemesters()
    {
        informationProfilePanel.SetActive(false);
        semesterOverviewPanel.SetActive(false);
        semestersPanel.SetActive(true);

        if (semester1 == "COMPLETED")
        {
            if (semester2 == "PENDING")
            {
                Status2Button.interactable = true;
                Text2Status.text = "Register";
                TextAvailable.SetActive(true);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, 0f, 0f);
                    Button2Coins.SetActive(true);
                    Status2Button.interactable = false;
                }
            }
            Text1Status.text = "Completed";
            Status1Button.interactable = false;
        }
        if (semester2 == "COMPLETED")
        {
            if (semester3 == "PENDING")
            {
                Status3Button.interactable = true;
                Text3Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f, 0f);
                    Button3Coins.SetActive(true);
                    Status3Button.interactable = false;
                }
            }
            Text2Status.text = "Completed";
            Status2Button.interactable = false;
        }
        if (semester3 == "COMPLETED")
        {
            if (semester4 == "PENDING")
            {
                Status4Button.interactable = true;
                Text4Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 2, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 2, 0f);
                    Button4Coins.SetActive(true);
                    Status4Button.interactable = false;
                }
            }
            Text3Status.text = "Completed";
            Status3Button.interactable = false;
        }
        if (semester4 == "COMPLETED")
        {
            if (semester5 == "PENDING")
            {
                Status5Button.interactable = true;
                Text5Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 3, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 3, 0f);
                    Button5Coins.SetActive(true);
                    Status5Button.interactable = false;
                }
            }
            Text4Status.text = "Completed";
            Status4Button.interactable = false;
        }
        if (semester5 == "COMPLETED")
        {
            if (semester6 == "PENDING")
            {
                Status6Button.interactable = true;
                Text6Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 4, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 4, 0f);
                    Button6Coins.SetActive(true);
                    Status6Button.interactable = false;
                }
            }
            Text5Status.text = "Completed";
            Status5Button.interactable = false;
        }
        if (semester6 == "COMPLETED")
        {
            if (semester7 == "PENDING")
            {
                Status7Button.interactable = true;
                Text7Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 5, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 5, 0f);
                    Button7Coins.SetActive(true);
                    Status7Button.interactable = false;
                }
            }
            Text6Status.text = "Completed";
            Status6Button.interactable = false;
        }
        if (semester7 == "COMPLETED")
        {
            if (semester8 == "PENDING")
            {
                Status8Button.interactable = true;
                Text8Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 6, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 6, 0f);
                    Button8Coins.SetActive(true);
                    Status8Button.interactable = false;
                }
            }
            Text7Status.text = "Completed";
            Status7Button.interactable = false;
        }
        if (semester8 == "COMPLETED")
        {
            if (semester9 == "PENDING")
            {
                Status9Button.interactable = true;
                Text9Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 7, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 7, 0f);
                    Button9Coins.SetActive(true);
                    Status9Button.interactable = false;
                }
            }
            Text8Status.text = "Completed";
            Status8Button.interactable = false;
        }
        if (semester9 == "COMPLETED")
        {
            if (semester10 == "PENDING")
            {
                Status10Button.interactable = true;
                Text10Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 8, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 8, 0f);
                    Button10Coins.SetActive(true);
                    Status10Button.interactable = false;
                }
            }
            Text9Status.text = "Completed";
            Status9Button.interactable = false;
        }
        if (semester10 == "COMPLETED")
        {
            if (semester11 == "PENDING")
            {
                Status11Button.interactable = true;
                Text11Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 9, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 9, 0f);
                    Button11Coins.SetActive(true);
                    Status11Button.interactable = false;
                }
            }
            Text10Status.text = "Completed";
            Status10Button.interactable = false;
        }
        if (semester11 == "COMPLETED")
        {
            if (semester12 == "PENDING")
            {
                Status12Button.interactable = true;
                Text12Status.text = "Register";
                TextAvailable.SetActive(true);
                TextAvailable.transform.localPosition = new Vector3(298f, -37f * 10, 0f);
                if (registrationDate == "MISSED")
                {
                    TextSkip.SetActive(true);
                    TextSkip.transform.localPosition = new Vector3(505.5f, -37f * 10, 0f);
                    Button12Coins.SetActive(true);
                    Status12Button.interactable = false;
                }
            }
            Text11Status.text = "Completed";
            Status11Button.interactable = false;
        }
        if (semester12 == "COMPLETED")
        {
            Text12Status.text = "Completed";
            Status12Button.interactable = false;
        }
    }

    public void SkipToNextDateRegistration(int semNo)
    {
        if (coins == "NOTEXPENDED" && Transaction.amount >= 500.0f)
        {
            if (semNo == 2)
            {
                Button2Coins.SetActive(false);
                Status2Button.interactable = true;
                Button2Coins.SetActive(false);
            }
            else if (semNo == 3)
            {
                Button3Coins.SetActive(false);
                Status3Button.interactable = true;
                Button3Coins.SetActive(false);
            }
            else if (semNo == 4)
            {
                Button4Coins.SetActive(false);
                Status4Button.interactable = true;
                Button4Coins.SetActive(false);
            }
            else if (semNo == 5)
            {
                Button5Coins.SetActive(false);
                Status5Button.interactable = true;
                Button5Coins.SetActive(false);
            }
            else if (semNo == 6)
            {
                Button6Coins.SetActive(false);
                Status6Button.interactable = true;
                Button6Coins.SetActive(false);
            }
            else if (semNo == 7)
            {
                Button7Coins.SetActive(false);
                Status7Button.interactable = true;
                Button7Coins.SetActive(false);
            }
            else if (semNo == 8)
            {
                Button8Coins.SetActive(false);
                Status8Button.interactable = true;
                Button8Coins.SetActive(false);
            }
            else if (semNo == 9)
            {
                Button9Coins.SetActive(false);
                Status9Button.interactable = true;
                Button9Coins.SetActive(false);
            }
            else if (semNo == 10)
            {
                Button10Coins.SetActive(false);
                Status10Button.interactable = true;
                Button10Coins.SetActive(false);
            }
            else if (semNo == 11)
            {
                Button11Coins.SetActive(false);
                Status11Button.interactable = true;
                Button11Coins.SetActive(false);
            }
            else if (semNo == 12)
            {
                Button12Coins.SetActive(false);
                Status12Button.interactable = true;
                Button12Coins.SetActive(false);
            }


            TextSkip.SetActive(false);
            Transaction.SubtractAmount(500.0f);
            coins = "EXPENDED";
            registrationDate = "NOTMISSED";
        }
    }

    public void RegisterSemester()
    {
        if (semester2 == "PENDING")
        {
            Text2Status.text = "Registered";
            Status2Button.interactable = false;
            semester2 = "REGISTERED";
        }
        else if (semester3 == "PENDING")
        {
            Text3Status.text = "Registered";
            Status3Button.interactable = false;
            semester3 = "REGISTERED";
        }
        else if (semester4 == "PENDING")
        {
            Text4Status.text = "Registered";
            Status4Button.interactable = false;
            semester4 = "REGISTERED";
        }
        else if (semester5 == "PENDING")
        {
            Text5Status.text = "Registered";
            Status5Button.interactable = false;
            semester5 = "REGISTERED";
        }
        else if (semester6 == "PENDING")
        {
            Text6Status.text = "Registered";
            Status6Button.interactable = false;
            semester6 = "REGISTERED";
        }
        else if (semester7 == "PENDING")
        {
            Text7Status.text = "Registered";
            Status7Button.interactable = false;
            semester7 = "REGISTERED";
        }
        else if (semester8 == "PENDING")
        {
            Text8Status.text = "Registered";
            Status8Button.interactable = false;
            semester8 = "REGISTERED";
        }
        else if (semester9 == "PENDING")
        {
            Text9Status.text = "Registered";
            Status9Button.interactable = false;
            semester9 = "REGISTERED";
        }
        else if (semester10 == "PENDING")
        {
            Text10Status.text = "Registered";
            Status10Button.interactable = false;
            semester10 = "REGISTERED";
        }
        else if (semester11 == "PENDING")
        {
            Text11Status.text = "Registered";
            Status11Button.interactable = false;
            semester11 = "REGISTERED";
        }
        else if (semester12 == "PENDING")
        {
            Text12Status.text = "Registered";
            Status12Button.interactable = false;
            semester12 = "REGISTERED";
        }
        TextAvailable.SetActive(false);
    }

    public void OpenSemester(int semesterNo)
    {
        semestersPanel.SetActive(false);
        whichSemesterClicked = semesterNo;
        semesterOverviewPanel.SetActive(true);
        SemesterCoursesPanel.SetActive(true);
        CourseViewPanel.SetActive(false);
        courses.DetermineSemesterCourses();
        studyArea.courseStudyIndividualPanel.SetActive(false);
    }
}
