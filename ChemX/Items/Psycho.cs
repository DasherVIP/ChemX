using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class Psycho : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Psycho Syringe");
			Tooltip.SetDefault("Grants knockback immunity, and increases melee stats.");
        }
		
		public override void SetDefaults() 
		{
			item.consumable = true;
			item.useStyle = 3;
			item.width = 20;
			item.height = 20;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Syringe");
			item.noUseGraphic = true;
			item.noMelee = true;
			item.maxStack = 30;
			item.useAnimation = 10;
			item.useTime = 10;
			item.buffType = mod.BuffType ("PsychoBuff");
			item.buffTime = 2400;
			item.rare = 1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.Glass, 3);
			recipe.AddIngredient(ItemID.StrangePlant3, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.Glass, 3);
			recipe.AddIngredient(ItemID.StrangePlant4, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}