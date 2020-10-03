using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;

public class DBConnection : MonoBehaviour
{
    [SerializeField]
    Text PerSpendText, MaxSpendDayText, SpentTodayText, TotalSpendText, RecommendedTimeRegularStudyText, SpentTimeRegularStudyText, SpentTodayRegularStudyText,
        SpentTodayAssignmentText, RecommendedTimeAssignment1Text, SpentTimeAssignment1Text, RecommendedTimeAssignment2Text, SpentTimeAssignment2Text, RecommendedTimeAssignment3Text, SpentTimeAssignment3Text,
        SpentTodayPresentationText, RecommendedTimePresentation1Text, SpentTimePresentation1Text, RecommendedTimePresentation2Text, SpentTimePresentation2Text, SpentTodayQuizText, RecommendedTimeQuiz1Text,
        SpentTimeQuiz1Text, RecommendedTimeQuiz2Text, SpentTimeQuiz2Text, RecommendedTimeQuiz3Text, SpentTimeQuiz3Text, SpentTodayMidText, RecommendedTimeMidText, SpentTimeMidText,
        SpentTodayFinalText, RecommendedTimeFinalText, SpentTimeFinalText;

    static public float perSpend, maxSpendDay, spentToday, totalSpend, spentTimeRegularStudy, spentTimeAssignment1, spentTimeAssignment2, spentTimeAssignment3,
        spentTimePresentation1, spentTimePresentation2, spentTimeQuiz1, spentTimeQuiz2, spentTimeQuiz3, spentTimeMid, spentTimeFinal, spentTodayRegularStudy,
        spentTodayAssignment, spentTodayPresentation, spentTodayQuiz, spentTodayMid, spentTodayFinal;

    string connection, sqlQuery;
    IDbConnection dbConnection;
    IDbCommand dbCommand;
    IDataReader reader;

    void Start()
    {
        connection = "URI=file:" + Application.dataPath + "/Plugins/Graduation.s3db";
    }

    public void ReadDatabase(string sqlQuery, string tableName)
    {
        using (dbConnection = new SqliteConnection(connection))
        {
            dbConnection.Open();
            dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = sqlQuery;
            reader = dbCommand.ExecuteReader();
            if (tableName == "CourseStudy")
            {
                if (reader.Read())
                {
                    perSpend = reader.GetFloat(3);
                    PerSpendText.text = perSpend.ToString() + " Mins";
                    maxSpendDay = reader.GetFloat(4);
                    MaxSpendDayText.text = maxSpendDay.ToString() + " Hrs";
                    RecommendedTimeRegularStudyText.text = reader.GetFloat(5).ToString() + " Hrs";
                    RecommendedTimeAssignment1Text.text = reader.GetFloat(6).ToString() + " Hrs";
                    RecommendedTimeAssignment2Text.text = reader.GetFloat(7).ToString() + " Hrs";
                    RecommendedTimeAssignment3Text.text = reader.GetFloat(8).ToString() + " Hrs";
                    RecommendedTimePresentation1Text.text = reader.GetFloat(9).ToString() + " Hrs";
                    RecommendedTimePresentation2Text.text = reader.GetFloat(10).ToString() + " Hrs";
                    RecommendedTimeQuiz1Text.text = reader.GetFloat(11).ToString() + " Hrs";
                    RecommendedTimeQuiz2Text.text = reader.GetFloat(12).ToString() + " Hrs";
                    RecommendedTimeQuiz3Text.text = reader.GetFloat(13).ToString() + " Hrs";
                    RecommendedTimeMidText.text = reader.GetFloat(14).ToString() + " Hrs";
                    RecommendedTimeFinalText.text = reader.GetFloat(15).ToString() + " Hrs";
                    spentToday= reader.GetFloat(16);
                    SpentTodayText.text = spentToday.ToString() + " Hrs";
                    totalSpend= reader.GetFloat(17);
                    TotalSpendText.text = totalSpend.ToString() + " Hrs";
                    spentTimeRegularStudy= reader.GetFloat(18);
                    SpentTimeRegularStudyText.text = spentTimeRegularStudy.ToString() + " Hrs";
                    spentTimeAssignment1= reader.GetFloat(19);
                    SpentTimeAssignment1Text.text = spentTimeAssignment1.ToString() + " Hrs";
                    spentTimeAssignment2= reader.GetFloat(20);
                    SpentTimeAssignment2Text.text = spentTimeAssignment2.ToString() + " Hrs";
                    spentTimeAssignment3= reader.GetFloat(21);
                    SpentTimeAssignment3Text.text = spentTimeAssignment3.ToString() + " Hrs";
                    spentTimePresentation1= reader.GetFloat(22);
                    SpentTimePresentation1Text.text = spentTimePresentation1.ToString() + " Hrs";
                    spentTimePresentation2= reader.GetFloat(23);
                    SpentTimePresentation2Text.text = spentTimePresentation2.ToString() + " Hrs";
                    spentTimeQuiz1= reader.GetFloat(24);
                    SpentTimeQuiz1Text.text = spentTimeQuiz1.ToString() + " Hrs";
                    spentTimeQuiz2= reader.GetFloat(25);
                    SpentTimeQuiz2Text.text = spentTimeQuiz2.ToString() + " Hrs";
                    spentTimeQuiz3= reader.GetFloat(26);
                    SpentTimeQuiz3Text.text = spentTimeQuiz3.ToString() + " Hrs";
                    spentTimeMid= reader.GetFloat(27);
                    SpentTimeMidText.text = spentTimeMid.ToString() + " Hrs";
                    spentTimeFinal= reader.GetFloat(28);
                    SpentTimeFinalText.text = spentTimeFinal.ToString() + " Hrs";
                    spentTodayRegularStudy= reader.GetFloat(29);
                    SpentTodayRegularStudyText.text = spentTodayRegularStudy.ToString() + " Hrs";
                    spentTodayAssignment= reader.GetFloat(30);
                    SpentTodayAssignmentText.text = spentTodayAssignment.ToString() + " Hrs";
                    spentTodayPresentation= reader.GetFloat(31);
                    SpentTodayPresentationText.text = spentTodayPresentation.ToString() + " Hrs";
                    spentTodayQuiz= reader.GetFloat(32);
                    SpentTodayQuizText.text = spentTodayQuiz.ToString() + " Hrs";
                    spentTodayMid= reader.GetFloat(33);
                    SpentTodayMidText.text = spentTodayMid.ToString() + " Hrs";
                    spentTodayFinal= reader.GetFloat(34);
                    SpentTodayFinalText.text = spentTodayFinal.ToString() + " Hrs";


                    Debug.Log("Per spend: " + reader.GetFloat(3));
                    reader.Close();
                    reader = null;
                    dbCommand.Dispose();
                    dbCommand = null;
                    dbConnection.Close();
                    dbConnection = null;
                }
            }
        }
    }

    public void UpdateDatabase(string sqlQuery)
    {
        using(dbConnection=new SqliteConnection(connection))
        {
                dbConnection.Open();
                dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandText = sqlQuery;
                dbCommand.ExecuteScalar();
                dbConnection.Close();         
        }
    }
}
