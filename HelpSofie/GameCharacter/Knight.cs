﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelpSofie
{
    // This class represents knight and implements interfaces!
    class Knight : ICharacter, ISmashSlashes, IRaiseShield, IShieldGlare
    {
        // The body of interface methods is provided here!
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }

        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }

        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
}
