using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaikki_to_renshuu;

public class RenshuuRoot
{
    public required string Kanji { get; set; }
    public required string Kana { get; set; }
    public List<string> Senses { get; set; } = [];
}
