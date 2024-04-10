using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBattletech;

public abstract class Unit
{
    // e.g. Phoenix Hawx, Kanga Jump Tank
    public virtual string Name { get; }
    public virtual int BattleValue { get; }
    // e.g. PHX-1K
    public virtual string Designation { get; set; }
    // e.g. The White Hand
    public virtual string Callsign { get; set; }
}

