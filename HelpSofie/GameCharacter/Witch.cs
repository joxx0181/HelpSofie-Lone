using System;
using System.Collections.Generic;
using System.Text;

namespace HelpSofie
{
    // This class represents witch and implements interfaces!
    class Witch : ICharacter, IRaiseShield, IShieldGlare, ITeleport
    {
        // The body of interface methods is provided here!
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

        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
    }
}
