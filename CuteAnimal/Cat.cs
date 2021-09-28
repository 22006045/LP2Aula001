namespace CuteAnimal
{
    public class Cat
    {
        private readonly string name ;
        private int energy;
        private Feed feed;
        private Mood mood;

        public Cat(string name)
        {
            this.name = name;
        }

        public void Eat()
        {
            if (feed < Feed.AboutToExplode)
                feed++;
        }   

        public void Sleep()
        {
            energy++;

            if (feed > Feed.Starving)
                feed--;
        }

        public void Meow()
        {
            Console.WriteLine("Meow!!!!!!");
        }

        public void Play()
        {
            if (mood < Mood.HyperActive)
                mood++;
        }

    
    }


}