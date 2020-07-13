using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class DashBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Dash!");
            Description.SetDefault("You can dash without special accessories!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.dash = 2;
        }
    }
}


