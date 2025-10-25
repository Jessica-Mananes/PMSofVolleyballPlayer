using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCommon
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public string Email { get; set; }

        public Player() { }


        public Player(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }
    }
}
