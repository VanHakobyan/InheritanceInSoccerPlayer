
 inheritance in soccer player class library
 
 This is an example of inheritance.
 According to the data used by football players
 
 ```C#
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
```
 

 
