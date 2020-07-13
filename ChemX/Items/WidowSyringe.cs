using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class WidowSyringe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("WiDoW Syringe");
			Tooltip.SetDefault("Hurts hard, but the euphoria makes you invincible.");
        }
		
		public override void SetDefaults() 
		{
			item.consumable = true;
			item.useStyle = 3;
			item.width = 10;
			item.height = 10;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.maxStack = 30;
			item.useAnimation = 20;
			item.useTime = 20;
			item.buffType = mod.BuffType ("WidowBuff");
			item.buffTime = 300;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Syringe");
			item.rare = 4;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DarkShard, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.AddIngredient(mod, "Catalyst");
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}