using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;

    public IList<Exam> Exams { get; set; }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (value != null || value != "")
            {
                this.firstName = value;
            }
            else
            {
                throw new ArgumentNullException("First name can't be null or empty");
            }
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (value != null || value != "")
            {
                this.lastName = value;
            }
            else
            {
                throw new ArgumentNullException("Last name can't be null or empty");
            }
        }
    }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("The exam list is not define!");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException("The exam list is empty!");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("The exam list is not define!");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException("The exam list is empty!");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
