using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;
using static Xerath.Program;
using static Xerath.Menus;
using static Xerath.Spells;
namespace Xerath
{
    internal class Combo
    {
        public static void ComboExecute()
        {
            var target = TargetSelector.GetTarget(Spells.Q.Range, DamageType.Magical);

            if (target.IsInvulnerable || (target == null)) return;

            if (ComboMenu["Q"].Cast<CheckBox>().CurrentValue)
            {
                if (target.IsValidTarget(Spells.Q.Range) && Spells.Q.IsReady())
                {
                    
                }

            }
        }

    }
} 
