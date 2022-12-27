using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public delegate void GradeAddedBelowCDelegate(object sender, EventArgs args);

    public class InMemoryStudent : StudentBase
    {
        private readonly List<double> _grades = new List<double>();

        public InMemoryStudent(string name) : base(name)
        {
        }

        public event GradeAddedBelowCDelegate GradeBelowC;

        public override void AddGrade(string grade)
        {
            var success = double.TryParse(grade, out var number);
            switch (success)
            {
                case true when number > 75 && number <= 100:
                    this._grades.Add(number);
                    Console.WriteLine($"Grade '{grade}' has been added as {number}.");
                    break;
                case true when number >= 0 && number <= 75:
                    GradeBelowC(this, new EventArgs());
                    this._grades.Add(number);
                    Console.WriteLine($"Grade '{grade}' has been added as {number}.");
                    break;
                case true:
                    Console.WriteLine($"Grade '{grade}' has not been added as the value must be in the range 0-100.");
                    break;
                case false when grade is "A" or "B" or "C" or "D" or "E" or "F" or "B+" or "+B" or "C+" or "+C" or "D+" or "+D" or "E+" or "+E" or "F":
                    AddLetterGrade(grade);
                    break;
                case false:
                    Console.WriteLine($"Grade '{grade}' is incorrect.");
                    break;
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            for (var index = 0; index < _grades.Count; index += 1)
            {
                result.Add(_grades[index]);
            }

            return result;
        }
    }
}