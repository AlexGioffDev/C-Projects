string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

void ShowEmail(string[,] employeers, string domain = "contoso.com") {
  for(int i = 0; i < employeers.GetLength(0); i++) {
    string email = employeers[i, 0].Substring(0, 2).ToLower() + employeers[i, 1].ToLower() + "@" + domain;
    System.Console.WriteLine(email);
  }
}

ShowEmail(corporate);
ShowEmail(external, externalDomain);


