using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

List<Dictionary<string, object>> getWorldCupData(){
    var sr = new StreamReader(@"worldcupdata.json");
    var jsonString = sr.ReadToEnd();
    var cupWinnerDict = System.Text.Json.JsonSerializer.Deserialize<List<Dictionary<string, object>>>(jsonString);
    return cupWinnerDict;
}

void printData(List<Dictionary<string, object>> worldCupList){
    foreach (Dictionary<string, object> worldCup in worldCupList){
        Console.WriteLine($"{worldCup["country"]} - {worldCup["year"]}" );
    }
}

var worldcupdata = getWorldCupData();
printData(worldcupdata);
// foreach (Dictionary<string, object> worldCup in worldcupdata){
//     Console.WriteLine(worldCup["country"]);
// }

var g = worldcupdata.Where(wc=>wc["country"].Equals("Germany"));

