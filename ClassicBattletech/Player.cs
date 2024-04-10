using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBattletech;

public class Player
{
    public string Name { get; set; }
    public string Role { get; set; }
    public List<Unit> Units { get; }

    public Player()
    {
        Units = new List<Unit>();
    }

    public Player (string name)
    {
        Name = name.Trim();
        Units = new List<Unit>();
    }
}
