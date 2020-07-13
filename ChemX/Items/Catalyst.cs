using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class Catalyst : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Catalyst");
			Tooltip.SetDefault("Made with gel and hellstone \nUsed for upgrading potions.");
        }
		
		public override void SetDefaults() 
		{
			item.maxStack = 30;
			item.rare = 3;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 6);
			recipe.AddIngredient(ItemID.Hellstone, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}