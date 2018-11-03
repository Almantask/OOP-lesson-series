using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_guide
{
    public enum Color { Brown, Blue, Red, Black, Orange, Green, White}
    public class Dog
    {
        // Properties
        public Color FurColor { set; get; }
        public Color EyeColor { set; get; }
        public float Height { set; get; }
        public float Lenght { set; get; }
        public float Weight { set; get; }
        public string Name { set; get; }

        public int Age => (DateTime.Now - _birthdate).Days / 365 + 1;

        // Fields
        // Others don't really know about the commands the dog knows
        private List<string> _commands;
        private readonly DateTime _birthdate;

        // Default constructor
        public Dog()
        {
            FurColor = Color.Brown;
            EyeColor = Color.Brown;
            Height = 30;
            Lenght = 60;
            Weight = 10;
            Name = "Ricky";
            _birthdate = DateTime.Now;
            _commands = new List<string>();
        }

        // Parameterised constructor
        public Dog(string name, DateTime birthdate, float weight, float length, float height, Color eyeColor, Color furColor)
        {
            FurColor = furColor;
            EyeColor = eyeColor;
            Height = height;
            Lenght = length;
            Weight = weight;
            Name = name;
            _birthdate = birthdate;
            _commands = new List<string>();
        }

        // Methods
        public void Sit()
        {
            // sit
        }

        public void LayDown()
        {
            // lay down
        }

        public void Shake()
        {
            // give hand
        }

        public void Come()
        {
            // come to master
        }
    }
}
