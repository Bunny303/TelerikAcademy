using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLayout
{
    class Teacher: People
    {
        // Fields + props
        public string CommentTeacher { get; set; }
        public List<Discipline> Disciplines { get; set; }

        // Inheritance constructor
        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        { }
        
        //Constructor
        public Teacher(string firstName, string lastName, List<Discipline> disciplines, string comment)
            : this(firstName, lastName)
        {
            this.Disciplines = new List<Discipline>();
            foreach (var d in disciplines)
            {
                this.AddDiscipline(new Discipline(d.Name, d.NumberLectures, d.NumberExercises, d.CommentDiscipline));
            }
            this.CommentTeacher = comment;
        }

        // Method
        public void AddDiscipline(Discipline discipline)
        {
            Disciplines.Add(discipline);
        }
        public void RemoveDiscipline(Discipline discipline)
        {
            Disciplines.Remove(discipline);
        }
        public List<Discipline> ListDisciplines()
        {
            List<Discipline>  listDisciplines= (from discipline in Disciplines
                                        select discipline).ToList();
            return listDisciplines;
        }

    }
}
