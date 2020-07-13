using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class OverBeamBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Over Beamed");
            Description.SetDefault("You took far too much.");
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.magicDamage +=0.4f;
			player.manaRegenBonus -= 299;
        }
    }
}


