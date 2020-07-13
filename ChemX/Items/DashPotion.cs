using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class DashPotion : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dashing potion");
			Tooltip.SetDefault("Grants a shield of cthulhu style dash.");
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
			item.buffType = mod.BuffType ("DashBuff");
			item.buffTime = 12000;
			item.rare = 2;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 2);
			recipe.AddIngredient(ItemID.CorruptSeeds, 1);
			recipe.AddIngredient(ItemID.JungleGrassSeeds, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 2);
			recipe.AddIngredient(ItemID.CrimsonSeeds, 1);
			recipe.AddIngredient(ItemID.JungleGrassSeeds, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}