using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class LapisBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Lapis narcotized");
            Description.SetDefault("Extra minions, weaker minions.");
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.maxMinions +=6;
			player.minionDamage -=0.75f;
			player.lifeRegen -= 2;
        }
    }
}
