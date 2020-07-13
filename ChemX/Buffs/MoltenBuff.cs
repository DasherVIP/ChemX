using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChemX.Buffs
{
	public class MoltenBuff : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Molten");
            Description.SetDefault("'The ultimate hell-exploration potion.'");
        }
		
		public override void Update(Player player, ref int buffIndex)
		{
             player.AddBuff (BuffID.Inferno, 2);
			 player.AddBuff (BuffID.WaterWalking, 2);
			 player.AddBuff (BuffID.ObsidianSkin, 2);
		}
	}
}