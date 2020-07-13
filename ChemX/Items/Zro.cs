using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class Zro : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Zro Dust");
			Tooltip.SetDefault("Covert your blood into mana \nTo avoid becoming manasick");
        }
		
		public override void SetDefaults() 
		{
			item.consumable = true;
			item.useStyle = 2;
			item.width = 20;
			item.height = 20;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Dust");
			item.maxStack = 30;
			item.useAnimation = 20;
			item.useTime = 20;
			item.buffType = mod.BuffType ("ZroBuff");
			item.buffTime = 300;
		}
	}
}