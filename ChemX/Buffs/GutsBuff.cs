using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class GutsBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Gut Narcotized");
            Description.SetDefault("More health, less immunity frames.");
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.statLifeMax2 += 120;
			player.immuneTime -= 3;
        }
    }
}