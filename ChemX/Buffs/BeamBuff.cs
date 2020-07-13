using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class BeamBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Beam narcotized");
            Description.SetDefault("Mana rushes throught your veins.");
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.magicDamage +=0.2f;
			player.manaRegenBonus -= 39;
        }
    }
}


