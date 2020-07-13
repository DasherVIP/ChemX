using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
    public class IronFleshBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Iron Flesh");
            Description.SetDefault("Increases defence, works with ironskin");
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.statDefense +=10;
        }
    }
}