using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = ""Land"";
            age = 1;

        }

        public bool IsColdBlooded { get; set; }
            public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool growNewTail { get; set; } 


        
    }
}

