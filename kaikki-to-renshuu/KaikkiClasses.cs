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
    public Form[] forms { get; set; }
    public Related[] related { get; set; }
    public Category[] categories { get; set; }
    public Sens[] senses { get; set; }
}

public class Form
{
    public string form { get; set; }
}

public class Related
{
    public string word { get; set; }
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
}

public class Example
{
    public string text { get; set; }
}

