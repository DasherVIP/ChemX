using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class ZroBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Zro Narcotized");
            Description.SetDefault("Your blood is converting into mana.");
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.manaRegenBonus += 35;
			player.lifeRegen -= 15;
        }
    }
}


