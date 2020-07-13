using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class ConjurationBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Conjuration");
            Description.SetDefault("20% increase in minion damage.");
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.minionDamage +=0.2f;
        }
    }
}


