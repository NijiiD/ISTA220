using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net.Mail;

namespace EX06
{
    class squadLeader
    {
        public static void command1()
            {
              Console.WriteLine("Alright 1st Squad get on line, team leaders let me know when you're up");
            }
        public static void command2(bool ready)
        {
            
            if (ready == true)
            {
                Console.WriteLine("Ok fire your weapons, prepare to move bravo team");
            }
            else
            {
                Console.WriteLine("Well hurry up and get your soliders on line!");
            }
        }
        public static void command3()
        {
           Console.WriteLine("Alpha Team, Shift Fire");
        }
        public static void command4()
        {
           Console.WriteLine("Ok Alpha Team, Lift Fire");

        }
        public static void command5()
        {
           Console.WriteLine("Alright, assault through");

        }
        public static void command6()
        {
           Console.WriteLine("Now I want a 360 security parameter around the area, team leaders I want a LACE report when they're all in position.");
        }
        public static void command7()
        {
            Console.WriteLine("Alright Good. Endex.");
        }
    }
    class aTeamLeader
    {
        public static void command1(bool ready)
        {
            if (ready == true)
            {
                Console.WriteLine("Alpha Team Ready");
            }
            else
            {
                Console.WriteLine("Not ready yet Staff Sergeant");
            }
        }
        public static void command2()
        {
            Console.WriteLine("Alpha Team Shifting Fire");

        }
        public static void command3()
        {
            Console.WriteLine("Alpha Team Lifting Fire");
        }
        public static void command4()
        {
            Console.WriteLine("Let's go Alpha push through");
        }  
        public static void command5()
        {
         
            Console.WriteLine("Ok Alpha, I want one at the 12, 2, 4 and 6 o'clock with intersecting fields of fire, move.");
        }
        public static void command6()
        {
            Console.WriteLine("Staff Sergeant Alpha Team is all green");
        }


    }
    class bTeamLeader
    {
        public static void command1(bool ready)
        {
            if (ready == true)
            {
                Console.WriteLine("Bravo Team Ready");
            }
            else
            {
                Console.WriteLine("Not ready yet Staff Sergeant");
            }
        }
        public static void command2()
        {
            Console.WriteLine("Bravo Team moving into position");

        }
        public static void command3()
        {
            Console.WriteLine("Set. Bravo Team pushing through");
        }
        public static void command4()
        {
            Console.WriteLine("Bravo Team reached limit of advance. Holding position");
        }
        public static void command5()
        {

            Console.WriteLine("Ok Bravo, I want one at the 12, 10, 8 and 6 o'clock with intersecting fields of fire, move.");
        }
        public static void command6()
        {
            Console.WriteLine("Staff Sergeant Bravo Team is green, amber, green, green");
        }


    }
    class Weapons
    {
        public virtual string gun()
        {
            return "*firing of a gun*";
        }
    }
    class M4 : Weapons
    {
        public override string gun()
        {
            base.gun();
            return "*pow, pow, pow, pow*";

        }
    }
    class M249B : Weapons
    {
        public override string gun()
        {
           base.gun();
           return "*bangbangbangbangbangbang*";
        }
    }

    class BattleDrill1A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start the battle drill.");
            squadLeader.command1();

            Console.WriteLine("Are the teams in position? True or False: ");
            bool H;
            bool.TryParse(Console.ReadLine(), out H);

            //Console.WriteLine("Are you in position Bravo Team? Yes or No: ");
            //bool H;
            // bool.TryParse(Console.ReadLine(), out H);

            aTeamLeader.command1(H);
            bTeamLeader.command1(H);
            squadLeader.command2(H);
            Console.Write("\n");

            M4 SquadRifles = new M4();
            Console.WriteLine(SquadRifles.gun());

            bTeamLeader.command2();
            Console.WriteLine("\n");

            Console.WriteLine(SquadRifles.gun());

            bTeamLeader.command3();
            Console.WriteLine("\n");

            M4 BravoTeamR = new M4();
            M249B BravoTeamM = new M249B();

            Console.WriteLine(BravoTeamR.gun());
            Console.WriteLine(BravoTeamM.gun());
            Console.WriteLine("\n");

            squadLeader.command3();
            aTeamLeader.command2();
            Console.WriteLine("\n");
            Console.WriteLine(BravoTeamR.gun());
            Console.WriteLine(BravoTeamM.gun());

            Console.WriteLine("\n");
            squadLeader.command4();
            aTeamLeader.command3();
            bTeamLeader.command4();

            Console.WriteLine("\n");
            squadLeader.command5();
            aTeamLeader.command4();
            Console.WriteLine("\n");

            M4 AlphaTeamR = new M4();
            M249B AlphaTeamM = new M249B();

            Console.WriteLine(AlphaTeamR.gun());
            Console.WriteLine(AlphaTeamM.gun());
            Console.WriteLine("\n");

            squadLeader.command6();
            Console.WriteLine("\n");

            aTeamLeader.command5();
            bTeamLeader.command5();
            Console.WriteLine("\n");

            aTeamLeader.command6();
            bTeamLeader.command6();
            squadLeader.command7();
        }
    }
}
