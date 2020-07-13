using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class Jet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Jet Inhaler");
			Tooltip.SetDefault("Makes the world around you slower.");
        }
		
		public override void SetDefaults() 
		{
			item.consumable = true;
			item.useStyle = 2;
			item.width = 20;
			item.height = 20;
			item.noMelee = true;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Dust");
			item.maxStack = 30;
			item.useAnimation = 20;
			item.useTime = 20;
			item.buffType = mod.BuffType ("JetBuff");
			item.buffTime = 3000;
			item.rare = 1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.ClayBlock, 3);
			recipe.AddIngredient(ItemID.StrangePlant1, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.ClayBlock, 3);
			recipe.AddIngredient(ItemID.StrangePlant2, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}