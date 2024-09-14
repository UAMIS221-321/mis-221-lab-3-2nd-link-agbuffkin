//Main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);
//End Main

static string GetEnjoymentLevel(){
    System.Console.WriteLine("What is your preferred level of enjoyment?\nBoring\nAverage\nFun\nEpic");
    return (Console.ReadLine());
}

static string GetStadiumRecommendation(string enjoymentLevel){
    if(enjoymentLevel == "Boring" || enjoymentLevel == "boring"){
        return "Neyland Stadium";
    }
    else if(enjoymentLevel == "Average" || enjoymentLevel == "average"){
        return "Jordan-Hare Stadium";
    }
    else if(enjoymentLevel == "Fun" || enjoymentLevel == "fun"){
        return "Tiger Stadium";
    }
    else if(enjoymentLevel == "Epic" || enjoymentLevel == "epic"){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else{
        return "Invalid input";
    }
}

static string GetGameRecommendation(string stadium){
    if(stadium == "Neyland Stadium") {
        return "vs Kent State";
    }
    else if(stadium == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    }
    else if(stadium == "Tiger Stadium"){
        return "vs Alabama";
    }
    else if(stadium == "Saban Field at Bryant-Denny Stadium"){
        return "vs Auburn";
    }
    else{
        return "Invalid input";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    Console.Clear();
    System.Console.WriteLine($"Your recommended stadium is {stadium} and game is {game}");
}
