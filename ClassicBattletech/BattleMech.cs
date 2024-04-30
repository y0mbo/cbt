using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssaultSimulator;

public class BattleMech : Unit
{
    public new string Name;
    public new int BattleValue;

    public BattleMech(string name, int battleValue)
    {
        Name = name;
        BattleValue = battleValue;
    }
}
