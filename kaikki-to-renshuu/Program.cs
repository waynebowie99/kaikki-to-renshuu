using kaikki_to_renshuu;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;

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

foreach (var line in File.ReadAllLines(path))
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
        (string kana, string kanji) = (form.form, word.word);
        var kanjiChars = GetCharsInRange(form.form, 0x4E00, 0x9FBF);
        //var romajiInForm = GetCharsInRange(form.form, 0x0020, 0x007E);
        //var romajiInWord = GetCharsInRange(word.word, 0x0020, 0x007E);
        //var hiraganaChars = GetCharsInRange(form.form, 0x3040, 0x309F);
        //var katakanaChars = GetCharsInRange(form.form, 0x30A0, 0x30FF);
        if (kanjiChars.Count() > 0)
        {
            kanji = form.form;
            kana = word.word;
        }

        conversion.Add(new RenshuuRoot
        {
            Kana = kana,
            Kanji = kanji,
            Senses = word.senses.SelectMany(s => s.glosses).Where(e => e.Contains(kana)).ToList()
        });
    }
}

File.WriteAllText(exportPath, JsonConvert.SerializeObject(conversion, Formatting.Indented));

// https://stackoverflow.com/questions/15805859/detect-japanese-character-input-and-romajis-ascii
IEnumerable<char> GetCharsInRange(string text, int min, int max)
{
    return text.Where(e => e >= min && e <= max);
}
