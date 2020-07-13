using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class Lapis : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lapis Pill");
			Tooltip.SetDefault("Increases your max number of minions by 6 \nDecreases minion damage by 75% \nMake sure to use it after summoning minions!");
        }
		
		public override void SetDefaults() 
		{
			item.noUseGraphic = true;
			item.consumable = true;
			item.useStyle = 2;
			item.width = 20;
			item.height = 20;
			item.noMelee = true;
			item.UseSound = SoundID.Item2;
			item.maxStack = 30;
			item.useAnimation = 20;
			item.useTime = 20;
			item.buffType = mod.BuffType ("LapisBuff");
			item.buffTime = 30000;
			item.rare = 1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Glass, 1);
			recipe.AddIngredient(ItemID.PlatinumOre, 3);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}