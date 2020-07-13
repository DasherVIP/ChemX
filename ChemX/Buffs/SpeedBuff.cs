using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class SpeedBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Light Speed!");
            Description.SetDefault("You are going too fast!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 999f;
			player.runAcceleration = 0.1f;
			player.maxRunSpeed = 7f;
			player.wingTimeMax = 0;
			player.wingTime = 0;
        }
    }
}


