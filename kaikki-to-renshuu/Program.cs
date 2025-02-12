// See https://aka.ms/new-console-template for more information
using kaikki_to_renshuu;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

CultureInfo.CurrentCulture = new CultureInfo("ja-JP", false);

Console.Write("Import json path: ");
string? path = Console.ReadLine();

Console.Write("Export json path: ");
string? exportPath = Console.ReadLine();

if(!File.Exists(path))
{
    Console.WriteLine("File not found.");
    return;
}

if(string.IsNullOrWhiteSpace(exportPath))
{
    Console.WriteLine("Export path is required.");
    return;
}

List<RenshuuRoot> conversion = [];

foreach(var line in File.ReadAllLines(path))
{
    var word = JsonConvert.DeserializeObject<KaikkiRoot>(line);
    if(word == null)
    {
        continue;
    }

    if(word.forms == null)
    {
        continue;
    }

    foreach (var form in word.forms)
    {
        conversion.Add(new RenshuuRoot
        {
            Kana = form.form,
            Kanji = word.word,
            Senses = word.senses.SelectMany(s => s.glosses).Where(e => e.Contains(form.form)).ToList()
        });
    }
}

File.WriteAllText(exportPath, JsonConvert.SerializeObject(conversion, Formatting.Indented));
