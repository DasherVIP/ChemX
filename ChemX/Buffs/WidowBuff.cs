using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class WidowBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("WiDoW narcotized");
            Description.SetDefault("Heavily damaged, but temporarily invincible.");
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.statLifeMax2 =1;
			player.immune = true;
			player.immuneAlpha =0;
        }
    }
}
