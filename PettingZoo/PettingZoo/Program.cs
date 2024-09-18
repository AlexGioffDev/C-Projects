using System;
using System.ComponentModel;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);


void RandomizeAnimals() {
  Random random = new Random();

  for (int i = 0; i < pettingZoo.Length; i++)
  {
      int r = random.Next(pettingZoo.Length);

      string temp = pettingZoo[i];
      pettingZoo[i] = pettingZoo[r];
      pettingZoo[r] = temp;
  }
}


string[,] AssignGroup(int groups = 6) {

  string[,] result = new string[groups, pettingZoo.Length/groups];
  int start = 0;

  for(int i = 0; i < groups; i++) {
    for (int j = 0; j < result.GetLength(1); j++) {
      result[i, j] = pettingZoo[start++];
    }
  }

  return result;
}

void PlanSchoolVisit(string  schoolName, int groups = 6){
  RandomizeAnimals();
  string[,] group = AssignGroup(groups);
  System.Console.WriteLine(schoolName);
  PrintGroup(group);
}

void PrintGroup(string[,] groups) {
  for(int i = 0; i < groups.GetLength(0); i++){
    System.Console.Write($"Group {i + 1}: ");
    for(int j = 0; j < groups.GetLength(1); j++) {
      System.Console.Write($"{groups[i, j]} ");
    }
    System.Console.WriteLine();
  }
}