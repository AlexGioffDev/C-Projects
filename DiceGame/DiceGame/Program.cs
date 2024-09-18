Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        int target = GetTarget();
        int roll = GetRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}


bool ShouldPlay()
{
  
  string value = Console.ReadLine();
  return value.ToLower().Equals("y");
}


int GetTarget(){
  return random.Next(1, 6);
}

int GetRoll() {
  return random.Next(1, 7);
}

string WinOrLose(int target, int roll) {
  if(roll > target) {
    return "You Win!!";
  } else if(roll == target) {
    return "You Draw!";
  } 

  return "You Lose!";
}