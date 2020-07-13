using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class PsychoBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Psycho narcotized");
            Description.SetDefault("You don't feel pain, but you do feel stronger.");
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.4f;
			player.meleeCrit += 10;
			player.lifeRegen -= 8;
			player.noKnockback = true;
        }
    }
}


