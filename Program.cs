using System.Text.Json;
using System.Text.Json.Nodes;

string jsonFilePath = @"C:\Users\User\Downloads\transcripts_18_Jul_10.33_am__Sepang_Low_Bitrate.mp3-20230907014411.json";
string jsonData = File.ReadAllText(jsonFilePath);
JsonObject jsonObject = JsonSerializer.Deserialize<JsonObject>(jsonData);
JsonArray resultsArray = (JsonArray)jsonObject["results"];

foreach (JsonObject resultObject in resultsArray)
{
    string transcript = (string)resultObject["alternatives"][0]["transcript"];
    Console.WriteLine(transcript);
}