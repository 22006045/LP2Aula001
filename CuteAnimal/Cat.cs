using System;

namespace CuteAnimal
{
    public class Cat
    {
        private Feed feed;
        private Mood mood;
        private readonly Random random; 

        public int Energy{get ; private set;}
        public string Name{get ;}


        private Cat()
        {
            random = new Random();
        
        }
        
        public Cat(int energy, Feed feed, Mood mood) : this()
        {
            Energy = energy;
            this.feed = feed;
            this.mood = mood;
        }

        public Cat(string name) : this()
        {
            Name = name;
            Energy = random.Next(1,6);
            feed = (Feed)random.Next((int)Feed.AboutToExplode + 1);
            mood = (Mood)random.Next((int)Mood.HyperActive + 1);

        }

        public void Eat()
        {
            if (feed < Feed.AboutToExplode)
                feed++;
        }   

        public void Sleep()
        {
            mood = (Mood)random.Next((int)Mood.HyperActive + 1);
            Energy++;

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