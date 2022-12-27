namespace ChallengeApp
{
    public interface IStudent
    {
        void AddGrade(string grade);
        Statistics GetStatistics();
        string Name { get; }
    }
}