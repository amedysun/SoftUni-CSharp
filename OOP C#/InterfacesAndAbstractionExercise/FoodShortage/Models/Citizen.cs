﻿namespace PersonInfo
{
    public class Citizen : IPerson , IIdentifiable, IBirthable
    {
        private int food;
        public Citizen(string name, int age,string iD,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = iD;
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }

        public int Food => this.food;

        public void BuyFood()
        {
            food += 10;
        }
    }
}
