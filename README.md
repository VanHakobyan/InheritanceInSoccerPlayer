
# Inheritance in soccer player class library

<p align="center">
<img src="http://ytimg.googleusercontent.com/vi/9vTiObCQajg/mqdefault.jpg">
</p>

 This is an example of inheritance.
 According to the data used by football players
 
 ```csharp
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
           
            midfielder Mkhitaryan = new midfielder();
            Mkhitaryan.Pass = 81;
            Mkhitaryan.Nationality = "Armenia";
            Mkhitaryan.Dribbling = 87;

            Defender Pique = new Defender();
            Pique.Jump = 92;
            Pique.PhysicalContact = 87;
            Pique.Height = 192;
            Pique.DefensiveProwess = 88;
            //Does the same team?
            CompaerString(TerStegen.Team, Messi.Team);//Yes of course
```

### *For more [Henrikh Mkhitaryan](https://en.wikipedia.org/wiki/Henrikh_Mkhitaryan) <br>


 

 
