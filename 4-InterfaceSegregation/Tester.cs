namespace InterfaceSegregation
{
    public class Tester : IWorkTeamActivities, ITestActivities
    {
        public Tester()
        {
        }

        public void Plan()
        {
            Console.WriteLine("I'm planning user stories");
        }

        public void Comunicate()
        {
            Console.WriteLine("I'm talking to the team user");
        }

        public void Test() 
        {
            throw new ArgumentException();
        }
    }
}