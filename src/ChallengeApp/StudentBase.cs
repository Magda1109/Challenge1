namespace ChallengeApp
{
    public abstract class StudentBase : NamedObject, IStudent
    {
        protected StudentBase(string name) : base(name)
        {
        }
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();
        protected void AddLetterGrade(string grade)
        {
            switch (grade)
            {
                case "A":
                    AddGrade("100");
                    break;
                case "B":
                    AddGrade("90");
                    break;
                case "B+" or "+B":
                    AddGrade("95");
                    break;
                case "C":
                    AddGrade("80");
                    break;
                case "C+" or "+C":
                    AddGrade("85");
                    break;
                case "D":
                    AddGrade("70");
                    break;
                case "D+" or "+D":
                    AddGrade("75");
                    break;
                case "E":
                    AddGrade("60");
                    break;
                case "E+" or "+E":
                    AddGrade("65");
                    break;
                case "F":
                    AddGrade("0");
                    break;
                default:
                    AddGrade("0");
                    break;
            }
        }
    }
}