using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class Guts : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Increase defense by 10");
        }
		
		public override void SetDefaults() 
		{
			item.consumable = true;
			item.useStyle = 2;
			item.width = 20;
			item.height = 20;
			item.noMelee = true;
			item.UseSound = SoundID.Item2;
			item.maxStack = 30;
			item.useAnimation = 17;
			item.useTime = 17;
			item.buffType = mod.BuffType ("GutsBuff");
			item.buffTime = 12000;
			item.rare = 1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TissueSample, 2);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 3);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}