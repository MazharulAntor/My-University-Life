using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudyArea : MonoBehaviour
{
    [SerializeField]
    DBConnection dBConnection;
    [SerializeField]
    Courses courses;

    [SerializeField]
    Text PerSpendText, MaxSpendDayText, SpentTodayText, TotalSpendText, RecommendedTimeRegularStudyText, SpentTimeRegularStudyText, SpentTodayRegularStudyText,
        SpentTodayAssignmentText, RecommendedTimeAssignment1Text, SpentTimeAssignment1Text, RecommendedTimeAssignment2Text, SpentTimeAssignment2Text, RecommendedTimeAssignment3Text, SpentTimeAssignment3Text,
        SpentTodayPresentationText, RecommendedTimePresentation1Text, SpentTimePresentation1Text, RecommendedTimePresentation2Text, SpentTimePresentation2Text, SpentTodayQuizText, RecommendedTimeQuiz1Text,
        SpentTimeQuiz1Text, RecommendedTimeQuiz2Text, SpentTimeQuiz2Text, RecommendedTimeQuiz3Text, SpentTimeQuiz3Text, SpentTodayMidText, RecommendedTimeMidText, SpentTimeMidText,
        SpentTodayFinalText, RecommendedTimeFinalText, SpentTimeFinalText;

    [SerializeField]
    GameObject panel1, panel2, panel3, panel4, panel5, panel6, panel7;
    [SerializeField]
    Text Course1Text, Course2Text, Course3Text, Course4Text, Course5Text, Course6Text, Course7Text;
    [SerializeField]
    public GameObject studyAreaPanel, courseStudyIndividualPanel, MaxSpendAlertPanel;
    int whichCourseClicked;

    string sqlQuery1, sqlQuery2;
    int semNo;

    public void AppearCoursesPanelStudyArea()
    {
        studyAreaPanel.SetActive(true);
        courses.SemesterCoursesPanel.SetActive(false);
        courses.courseViewPanel.SetActive(false);
        courseStudyIndividualPanel.SetActive(false);
        int totalCourses;

        for (totalCourses = 1; totalCourses <= courses.semesterTotalCourses; totalCourses++)
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

            TakenCoursesStudyArea();
        }
    }

    void TakenCoursesStudyArea()
    {
        for (int i = 0; i < courses.semTakenCourses.Count; i++)
        {
            if (i == 0)
            {
                Course1Text.text = courses.semTakenCourses[0];
            }
            else if (i == 3)
            {
                Course2Text.text = courses.semTakenCourses[3];
            }
            else if (i == 6)
            {
                Course3Text.text = courses.semTakenCourses[6];
            }
            else if (i == 9)
            {
                Course4Text.text = courses.semTakenCourses[9];
            }
            else if (i == 12)
            {
                Course5Text.text = courses.semTakenCourses[12];
            }
            else if (i == 15)
            {
                Course6Text.text = courses.semTakenCourses[15];
            }
            else if (i == 18)
            {
                Course7Text.text = courses.semTakenCourses[18];
            }
        }
    }

    public void StudyCourse(int courseNo)
    {
        MaxSpendAlertPanel.SetActive(false);
        whichCourseClicked = courseNo;
        semNo = Information.whichSemesterClicked;
        courseStudyIndividualPanel.SetActive(true);
        studyAreaPanel.SetActive(false);
        sqlQuery1 = "SELECT * FROM CourseStudy WHERE sem_no=" + semNo + " AND course_no=" + courseNo +"";

        dBConnection.ReadDatabase(sqlQuery1, "CourseStudy");
    }

    public void SpendTime(string purpose)
    {
        float perSpend= DBConnection.perSpend / 60, spentTime, spentToday, totalSpentTime, totalSpentToday;

        totalSpentTime = DBConnection.totalSpend + perSpend;
        totalSpentToday = DBConnection.spentToday + perSpend;
        if (totalSpentToday <= DBConnection.maxSpendDay)
        {
            if (purpose == "regularStudy")
            {
                spentTime = DBConnection.spentTimeRegularStudy + perSpend;
                spentToday = DBConnection.spentTodayRegularStudy + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_regular=\"{2}\", spent_today_regular_study=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "assignment1")
            {
                spentTime = DBConnection.spentTimeAssignment1 + perSpend;
                spentToday = DBConnection.spentTodayAssignment + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_assignment1=\"{2}\", spent_today_assignment=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "assignment2")
            {
                spentTime = DBConnection.spentTimeAssignment2 + perSpend;
                spentToday = DBConnection.spentTodayAssignment + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_assignment2=\"{2}\", spent_today_assignment=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "assignment3")
            {
                spentTime = DBConnection.spentTimeAssignment3 + perSpend;
                spentToday = DBConnection.spentTodayAssignment + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_assignment3=\"{2}\", spent_today_assignment=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "presentation1")
            {
                spentTime = DBConnection.spentTimePresentation1 + perSpend;
                spentToday = DBConnection.spentTodayPresentation + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_presentation1=\"{2}\", spent_today_presentation=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "presentation2")
            {
                spentTime = DBConnection.spentTimePresentation2 + perSpend;
                spentToday = DBConnection.spentTodayPresentation + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_presentation2=\"{2}\", spent_today_presentation=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "quiz1")
            {
                spentTime = DBConnection.spentTimeQuiz1 + perSpend;
                spentToday = DBConnection.spentTodayQuiz + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_quiz1=\"{2}\", spent_today_quiz=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "quiz2")
            {
                spentTime = DBConnection.spentTimeQuiz2 + perSpend;
                spentToday = DBConnection.spentTodayQuiz + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_quiz2=\"{2}\", spent_today_quiz=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "quiz3")
            {
                spentTime = DBConnection.spentTimeQuiz3 + perSpend;
                spentToday = DBConnection.spentTodayQuiz + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_quiz3=\"{2}\", spent_today_quiz=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "mid")
            {
                spentTime = DBConnection.spentTimeMid + perSpend;
                spentToday = DBConnection.spentTodayMid + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_mid=\"{2}\", spent_today_mid=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }
            if (purpose == "final")
            {
                spentTime = DBConnection.spentTimeFinal + perSpend;
                spentToday = DBConnection.spentTodayFinal + perSpend;
                sqlQuery2 = string.Format("UPDATE CourseStudy SET spent_today=\"{0}\", total_spent=\"{1}\", total_spent_final=\"{2}\", spent_today_final=\"{3}\" WHERE sem_no=\"{4}\" AND course_no=\"{5}\"", totalSpentToday, totalSpentTime, spentTime, spentToday, semNo, whichCourseClicked);
            }

            dBConnection.UpdateDatabase(sqlQuery2);
            dBConnection.ReadDatabase(sqlQuery1, "CourseStudy");
        }
        else
        {
            MaxSpendAlertPanel.SetActive(true);
        }
        

    }
}
