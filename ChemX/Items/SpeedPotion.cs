using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class SpeedPotion : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Light Speed Potion");
			Tooltip.SetDefault("How to go way too fast 101");
        }
		
		public override void SetDefaults() 
		{
			item.consumable = true;
			item.useStyle = 2;
			item.width = 20;
			item.height = 20;
			item.noMelee = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.useAnimation = 17;
			item.useTime = 17;
			item.buffType = mod.BuffType ("SpeedBuff");
			item.buffTime = 6000;
		}
	}
}