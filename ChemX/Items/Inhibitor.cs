using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class Inhibitor : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Inhibitor");
			Tooltip.SetDefault("Made with gel and ice \nUsed for downgrading potions.");
        }
		
		public override void SetDefaults() 
		{
			item.maxStack = 30;
			item.rare = 1;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 6);
			recipe.AddIngredient(ItemID.IceBlock, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}