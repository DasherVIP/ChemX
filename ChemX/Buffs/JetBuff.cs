using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class JetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Jet narcotized");
            Description.SetDefault("The world around you is slower... \nor you're just really fast");
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 6.5f;
			player.runAcceleration = 0.3f;
			player.meleeSpeed += 0.3f;
			player.lifeRegen -= 8;
        }
    }
}


