using System;
using defender;
namespace inheritance_soccer
{
    class Program
    {
        static void CompaerNumber(int Value1, int Value2)
        {
            if (Value1 > Value2)
                Console.WriteLine("{0} is good", Value1);
            else
                Console.WriteLine("{0} is good", Value2);
        }

        static void CompaerString(string Value1, string Value2)
        {
            if (Value1 == Value2)
                Console.WriteLine("same team");
            else
                Console.WriteLine("not same team");
        }
        static void Main()
        {
            
            player Alba = new player();
            Alba.Position = "midfielder";
            Alba.Nationality = "Spain";
            
            goalkeeper TerStegen = new goalkeeper();
            TerStegen.Age = 24;
            TerStegen.Weight = 85;
            TerStegen.Team = "FC Barcelona";
            TerStegen.Goalkeeping = 88;

            forward Messi = new forward();
            Messi.Age = 29;
            Messi.Weight = 65;
            Messi.Team = "FC Barcelona";
            Messi.Dribbling = 94;
           
            midfielder Iniesta = new midfielder();
            Iniesta.Pass = 94;
            Iniesta.Nationality = "Spain";
            Iniesta.Dribbling = 85;

            Defender Pique = new Defender();
            Pique.Jump = 92;
            Pique.PhysicalContact = 87;
            Pique.Height = 192;
            Pique.DefensiveProwess = 88;

            CompaerString(TerStegen.Team, Messi.Team);

        }
    }
}
