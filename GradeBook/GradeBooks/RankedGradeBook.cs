using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name , bool IsWeighted) : base(name, IsWeighted)
        {
            Type = GradeBookType.Ranked;

        }
        public override char GetLetterGrade ( double averageGrade)
        {
            if (this.Students.Count < 5)
                throw new InvalidOperationException();
            if (averageGrade >= 80)
                return 'A';
            else if (averageGrade >= 60)
                return 'B';
            else if (averageGrade >= 40)
                return 'C';
            else if (averageGrade >= 20)
                return 'D';
            else
                return 'F';
        }
        public override void CalculateStatistics()
        {
            
            if (this.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics(); 
            }
        }

    }
}
