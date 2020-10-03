using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Courses : MonoBehaviour
{
    public StudyArea studyArea;

    public Dictionary<string, float> semester1 = new Dictionary<string, float>();
    public Dictionary<string, float> semester2 = new Dictionary<string, float>();
    public Dictionary<string, float> semester3 = new Dictionary<string, float>();
    public Dictionary<string, float> semester4 = new Dictionary<string, float>();
    public Dictionary<string, float> semester5 = new Dictionary<string, float>();
    public Dictionary<string, float> semester6 = new Dictionary<string, float>();
    public Dictionary<string, float> semester7 = new Dictionary<string, float>();
    public Dictionary<string, float> semester8 = new Dictionary<string, float>();
    public Dictionary<string, float> semester9 = new Dictionary<string, float>();
    public Dictionary<string, float> semester10 = new Dictionary<string, float>();
    public Dictionary<string, float> semester11 = new Dictionary<string, float>();
    public Dictionary<string, float> semester12 = new Dictionary<string, float>();

    [SerializeField]
    GameObject panel1, panel2, panel3, panel4, panel5, panel6, panel7;

    [SerializeField]
    Text Course1Text, Code1Text, Credit1Text;
    [SerializeField]
    Text Course2Text, Code2Text, Credit2Text;
    [SerializeField]
    Text Course3Text, Code3Text, Credit3Text;
    [SerializeField]
    Text Course4Text, Code4Text, Credit4Text;
    [SerializeField]
    Text Course5Text, Code5Text, Credit5Text;
    [SerializeField]
    Text Course6Text, Code6Text, Credit6Text;
    [SerializeField]
    Text Course7Text, Code7Text, Credit7Text;

    [SerializeField]
    public float attendence, presentation, assignment, quiz1, quiz2, quiz3, mid, final;
    [SerializeField]
    Text attendenceText, presentationText, assignmentText, quizAvgText, quiz1Text, quiz2Text, quiz3Text, midText, finalText;
    [SerializeField]
    public GameObject courseViewPanel, SemesterCoursesPanel;

    [SerializeField]
    int sem1TotalCourses;
    [SerializeField]
    List<string> coursesSem1 = new List<string>();
    [SerializeField]
    int sem2TotalCourses;
    [SerializeField]
    List<string> coursesSem2 = new List<string>();
    [SerializeField]
    int sem3TotalCourses;
    [SerializeField]
    List<string> coursesSem3 = new List<string>();
    [SerializeField]
    int sem4TotalCourses;
    [SerializeField]
    List<string> coursesSem4 = new List<string>();
    [SerializeField]
    int sem5TotalCourses;
    [SerializeField]
    List<string> coursesSem5 = new List<string>();
    [SerializeField]
    int sem6TotalCourses;
    [SerializeField]
    List<string> coursesSem6 = new List<string>();
    [SerializeField]
    int sem7TotalCourses;
    [SerializeField]
    List<string> coursesSem7 = new List<string>();
    [SerializeField]
    int sem8TotalCourses;
    [SerializeField]
    List<string> coursesSem8 = new List<string>();
    [SerializeField]
    int sem9TotalCourses;
    [SerializeField]
    List<string> coursesSem9 = new List<string>();
    [SerializeField]
    int sem10TotalCourses;
    [SerializeField]
    List<string> coursesSem10 = new List<string>();
    [SerializeField]
    int sem11TotalCourses;
    [SerializeField]
    List<string> coursesSem11 = new List<string>();
    [SerializeField]
    int sem12TotalCourses;
    [SerializeField]
    List<string> coursesSem12 = new List<string>();

    public int semesterTotalCourses;
    public List<string> semTakenCourses;
    public void DetermineSemesterCourses()
    {
        HideCoursePanel();
        studyArea.studyAreaPanel.SetActive(false);
        if (Information.whichSemesterClicked == 1)
        {
            semesterTotalCourses = sem1TotalCourses;
            semTakenCourses = coursesSem1;
        }
        else if (Information.whichSemesterClicked == 2)
        {
            semesterTotalCourses = sem2TotalCourses;
            semTakenCourses = coursesSem2;
        }
        else if (Information.whichSemesterClicked == 3)
        {
            semesterTotalCourses = sem3TotalCourses;
            semTakenCourses = coursesSem3;
        }
        else if (Information.whichSemesterClicked == 4)
        {
            semesterTotalCourses = sem4TotalCourses;
            semTakenCourses = coursesSem4;
        }
        else if (Information.whichSemesterClicked == 5)
        {
            semesterTotalCourses = sem5TotalCourses;
            semTakenCourses = coursesSem5;
        }
        else if (Information.whichSemesterClicked == 6)
        {
            semesterTotalCourses = sem6TotalCourses;
            semTakenCourses = coursesSem6;
        }
        else if (Information.whichSemesterClicked == 7)
        {
            semesterTotalCourses = sem7TotalCourses;
            semTakenCourses = coursesSem7;
        }
        else if (Information.whichSemesterClicked == 8)
        {
            semesterTotalCourses = sem8TotalCourses;
            semTakenCourses = coursesSem8;
        }
        else if (Information.whichSemesterClicked == 9)
        {
            semesterTotalCourses = sem9TotalCourses;
            semTakenCourses = coursesSem9;
        }
        else if (Information.whichSemesterClicked == 10)
        {
            semesterTotalCourses = sem10TotalCourses;
            semTakenCourses = coursesSem10;
        }
        else if (Information.whichSemesterClicked == 11)
        {
            semesterTotalCourses = sem11TotalCourses;
            semTakenCourses = coursesSem11;
        }
        else if (Information.whichSemesterClicked == 12)
        {
            semesterTotalCourses = sem12TotalCourses;
            semTakenCourses = coursesSem12;
        }
        AppearCoursesPanel(semesterTotalCourses);
        TakenCourses(semTakenCourses);
    }

    private void AppearCoursesPanel(int semTotalCourses)
    {
        int totalCourses;

        for (totalCourses = 1; totalCourses <= semTotalCourses; totalCourses++)
        {
            if (totalCourses == 1)
            {
                panel1.SetActive(true);
            }
            else if (totalCourses == 2)
            {
                panel2.SetActive(true);
            }
            else if (totalCourses == 3)
            {
                panel3.SetActive(true);
            }
            else if (totalCourses == 4)
            {
                panel4.SetActive(true);
            }
            else if (totalCourses == 5)
            {
                panel5.SetActive(true);
            }
            else if (totalCourses == 6)
            {
                panel6.SetActive(true);
            }
            else if (totalCourses == 7)
            {
                panel7.SetActive(true);
            }
        }
    }

    void HideCoursePanel()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
        panel7.SetActive(false);
    }

    void ClearPreviousCourseMarks()
    {
        attendenceText.text = "";
        presentationText.text = "";
        assignmentText.text = "";
        quiz1Text.text = "";
        quiz2Text.text = "";
        quiz3Text.text = "";
        midText.text = "";
        finalText.text = "";
        quizAvgText.text = "";
    }

    public void PanelCourseViewButton(Button button)
    {
        SemesterCoursesPanel.SetActive(false);
        int semesterNo = Information.whichSemesterClicked;
        Dictionary<string, float> viwedSem = ViewedSemester(semesterNo);
        //ClearPreviousCourseMarks();
        if (button.name == "Panel1Button")
        {
            ViewSemesterCourse(viwedSem, "attendenceCo1", "presentationCo1", "assignmentCo1", "quiz1Co1", "quiz2Co1", "quiz3Co1", "midCo1", "finalCo1");
        }
        if (button.name == "Panel2Button")
        {
            ViewSemesterCourse(viwedSem, "attendenceCo2", "presentationCo2", "assignmentCo2", "quiz1Co2", "quiz2Co2", "quiz3Co2", "midCo2", "finalCo2");
        }
        if (button.name == "Panel3Button")
        {
            ViewSemesterCourse(viwedSem, "attendenceCo3", "presentationCo3", "assignmentCo3", "quiz1Co3", "quiz2Co3", "quiz3Co3", "midCo3", "finalCo3");
        }
        if (button.name == "Panel4Button")
        {
            ViewSemesterCourse(viwedSem, "attendenceCo4", "presentationCo4", "assignmentCo4", "quiz1Co4", "quiz2Co4", "quiz3Co4", "midCo4", "finalCo4");
        }
        if (button.name == "Panel5Button")
        {
            ViewSemesterCourse(viwedSem, "attendenceCo5", "presentationCo5", "assignmentCo5", "quiz1Co5", "quiz2Co5", "quiz3Co5", "midCo5", "finalCo5");
        }
        if (button.name == "Panel6Button")
        {
            ViewSemesterCourse(viwedSem, "attendenceCo6", "presentationCo6", "assignmentCo6", "quiz1Co6", "quiz2Co6", "quiz3Co6", "midCo6", "finalCo6");
        }
        if (button.name == "Panel7Button")
        {
            ViewSemesterCourse(viwedSem, "attendenceCo7", "presentationCo7", "assignmentCo7", "quiz1Co7", "quiz2Co7", "quiz3Co7", "midCo7", "finalCo7");
        }


    }

    Dictionary<string, float> ViewedSemester(int semesterNo)
    {
        if (semesterNo == 1)
        {
            return semester1;
        }
        else if (semesterNo == 2)
        {
            return semester2;
        }
        else if(semesterNo == 3)
        {
            return semester3;
        }
        else if(semesterNo == 4)
        {
            return semester4;
        }
        else if(semesterNo == 5)
        {
            return semester5;
        }
        else if(semesterNo == 6)
        {
            return semester6;
        }
        else if(semesterNo == 7)
        {
            return semester7;
        }
        else if(semesterNo == 8)
        {
            return semester8;
        }
        else if(semesterNo == 9)
        {
            return semester9;
        }
        else if(semesterNo == 10)
        {
            return semester10;
        }
        else if(semesterNo == 11)
        {
            return semester11;
        }
        else if(semesterNo == 12)
        {
            return semester12;
        }
        return null;
    }

    void ViewSemesterCourse(Dictionary<string, float> viewCourse, string attendence, string presentation, string assignment, string quiz1, string quiz2, string quiz3, string mid, string final)
    {
        courseViewPanel.SetActive(true);
        try
        {
            AssignMarks(viewCourse[attendence], viewCourse[presentation], viewCourse[assignment], viewCourse[quiz1], viewCourse[quiz2], viewCourse[quiz3], viewCourse[mid], viewCourse[final]);
        }
        catch
        {

        }

    }

    void AssignMarks(float attendence, float presentation, float assignment, float quiz1, float quiz2, float quiz3, float mid, float final)
    {
        attendenceText.text = attendence.ToString();
        presentationText.text = presentation.ToString();
        assignmentText.text = assignment.ToString();
        quiz1Text.text = quiz1.ToString();
        quiz2Text.text = quiz2.ToString();
        quiz3Text.text = quiz3.ToString();
        midText.text = mid.ToString();
        finalText.text = final.ToString();

        float quizAvg = (quiz1 + quiz2 + quiz3) / 3;
        quizAvgText.text = quizAvg.ToString();

        courseViewPanel.SetActive(true);
    }

    public void CoursesButton()
    {
        SemesterCoursesPanel.SetActive(true);
        courseViewPanel.SetActive(false);
        DetermineSemesterCourses();
        studyArea.studyAreaPanel.SetActive(false);
        studyArea.courseStudyIndividualPanel.SetActive(false);
    }


    void TakenCourses(List<string> courseDetails)
    {
        for (int i = 0; i < courseDetails.Count; i++)
        {
            if (i == 0)
            {
                Course1Text.text = courseDetails[0];
            }
            else if (i == 1)
            {
                Code1Text.text = courseDetails[1];
            }
            else if (i == 2)
            {
                Credit1Text.text = courseDetails[2];
            }
            else if (i == 3)
            {
                Course2Text.text = courseDetails[3];
            }
            else if (i == 4)
            {
                Code2Text.text = courseDetails[4];
            }
            else if (i == 5)
            {
                Credit2Text.text = courseDetails[5];
            }
            else if (i == 6)
            {
                Course3Text.text = courseDetails[6];
            }
            else if (i == 7)
            {
                Code3Text.text = courseDetails[7];
            }
            else if (i == 8)
            {
                Credit3Text.text = courseDetails[8];
            }
            else if (i == 9)
            {
                Course4Text.text = courseDetails[9];
            }
            else if (i == 10)
            {
                Code4Text.text = courseDetails[10];
            }
            else if (i == 11)
            {
                Credit4Text.text = courseDetails[11];
            }
            else if (i == 12)
            {
                Course5Text.text = courseDetails[12];
            }
            else if (i == 13)
            {
                Code5Text.text = courseDetails[13];
            }
            else if (i == 14)
            {
                Credit5Text.text = courseDetails[14];
            }
            else if (i == 15)
            {
                Course6Text.text = courseDetails[15];
            }
            else if (i == 16)
            {
                Code6Text.text = courseDetails[16];
            }
            else if (i == 17)
            {
                Credit6Text.text = courseDetails[17];
            }
            else if (i == 18)
            {
                Course7Text.text = courseDetails[18];
            }
            else if (i == 19)
            {
                Code7Text.text = courseDetails[19];
            }
            else if (i == 20)
            {
                Credit7Text.text = courseDetails[20];
            }
        }

    }
}
