using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaikki_to_renshuu;


public class KaikkiRoot
{
    public string word { get; set; }
    public string lang_code { get; set; }
    public string lang { get; set; }
    public string pos { get; set; }
    public string pos_title { get; set; }
    public Synonym[] synonyms { get; set; }
    public Derived[] derived { get; set; }
    public Proverb[] proverbs { get; set; }
    public Phras[] phrases { get; set; }
    public Category[] categories { get; set; }
    public Sens[] senses { get; set; }
    public Form[] forms { get; set; }
    public Sound[] sounds { get; set; }
    public Translation[] translations { get; set; }
    public Related[] related { get; set; }
    public string[] etymology_texts { get; set; }
    public string[] tags { get; set; }
    public Antonym[] antonyms { get; set; }
    public Hyponym[] hyponyms { get; set; }
    public Hypernym[] hypernyms { get; set; }
    public Coordinate_Terms[] coordinate_terms { get; set; }
    public Descendant[] descendants { get; set; }
    public Collocation[] collocations { get; set; }
    public Abbreviation[] abbreviations { get; set; }
    public Cognate[] cognates { get; set; }
    public Meronym[] meronyms { get; set; }
    public Holonym[] holonyms { get; set; }
}

public class Synonym
{
    public string word { get; set; }
    public string[][] ruby { get; set; }
    public string sense { get; set; }
}

public class Derived
{
    public string word { get; set; }
    public string sense { get; set; }
    public string[][] ruby { get; set; }
}

public class Proverb
{
    public string word { get; set; }
    public string sense { get; set; }
    public string[][] ruby { get; set; }
}

public class Phras
{
    public string word { get; set; }
    public string sense { get; set; }
    public string[][] ruby { get; set; }
}

public class Category
{
    public string name { get; set; }
    public string kind { get; set; }
    public object[] parents { get; set; }
    public string source { get; set; }
}

public class Sens
{
    public string[] glosses { get; set; }
    public Example[] examples { get; set; }
    public string id { get; set; }
    public string[] tags { get; set; }
    public Category1[] categories { get; set; }
    public string[][] ruby { get; set; }
    public string[] raw_tags { get; set; }
    public string[] topics { get; set; }
    public Form_Of[] form_of { get; set; }
}

public class Example
{
    public string text { get; set; }
    public string translation { get; set; }
    public string _ref { get; set; }
    public string[][] ruby { get; set; }
}

public class Category1
{
    public string name { get; set; }
    public string kind { get; set; }
    public object[] parents { get; set; }
    public string source { get; set; }
}

public class Form_Of
{
    public string word { get; set; }
}

public class Form
{
    public string form { get; set; }
    public string[] raw_tags { get; set; }
    public string[] tags { get; set; }
}

public class Sound
{
    public string[] tags { get; set; }
    public string[] raw_tags { get; set; }
    public string form { get; set; }
    public string roman { get; set; }
    public string ipa { get; set; }
    public string audio { get; set; }
    public string ogg_url { get; set; }
    public string mp3_url { get; set; }
    public string oga_url { get; set; }
}

public class Translation
{
    public string lang_code { get; set; }
    public string lang { get; set; }
    public string word { get; set; }
    public string sense { get; set; }
    public string roman { get; set; }
    public string[] tags { get; set; }
}

public class Related
{
    public string word { get; set; }
    public string[][] ruby { get; set; }
    public string sense { get; set; }
}

public class Antonym
{
    public string word { get; set; }
    public string[][] ruby { get; set; }
    public string sense { get; set; }
}

public class Hyponym
{
    public string word { get; set; }
    public string[][] ruby { get; set; }
}

public class Hypernym
{
    public string word { get; set; }
}

public class Coordinate_Terms
{
    public string word { get; set; }
}

public class Descendant
{
    public string lang_code { get; set; }
    public string lang { get; set; }
    public string word { get; set; }
    public string roman { get; set; }
}

public class Collocation
{
    public string word { get; set; }
    public string sense { get; set; }
    public string[][] ruby { get; set; }
}

public class Abbreviation
{
    public string word { get; set; }
    public string[][] ruby { get; set; }
}

public class Cognate
{
    public string word { get; set; }
    public string lang_code { get; set; }
    public string lang { get; set; }
}

public class Meronym
{
    public string word { get; set; }
    public string[][] ruby { get; set; }
}

public class Holonym
{
    public string word { get; set; }
}

