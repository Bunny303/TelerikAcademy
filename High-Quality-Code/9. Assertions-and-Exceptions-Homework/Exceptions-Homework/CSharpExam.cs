using System;

public class CSharpExam : Exam
{
    private int score;

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (value >= 0 && value <= 100)
            {
                this.score = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Score must be between 0 and 100!");
            }
        }
    }

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
