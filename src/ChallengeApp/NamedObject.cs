namespace ChallengeApp
{
    public class NamedObject
    {
        protected NamedObject(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}