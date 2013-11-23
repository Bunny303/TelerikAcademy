using System;
using System.Linq;

namespace SchoolLayout
{
    class Discipline 
    {
        // Fields + properties
        public string Name { get; set; }
        public int NumberLectures { get; set; }
        public int NumberExercises { get; set; }
        public string CommentDiscipline { get; set; }

        // Constructors
        public Discipline(string name, int numLectures, int numExercises)
        {
            this.Name = name;
            this.NumberLectures = numLectures;
            this.NumberExercises = numExercises;
        }
        public Discipline(string name, int numLectures, int numExercises, string comment): this (name, numLectures, numExercises)
        {
            this.CommentDiscipline = comment;
        }

        
    }
}
