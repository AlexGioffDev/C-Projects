string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] idsArray = orderStream.Split(",");
Array.Sort(idsArray);
foreach (var id in idsArray)
{
  if(id.Length == 4){
    System.Console.WriteLine(id);
  } else {
    System.Console.WriteLine($"{id}\t\t- Error");
  }
}