using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class BeamSyringe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Small controlled dose of Beam");
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
			item.buffType = mod.BuffType ("BeamBuff");
			item.buffTime = 6000;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Syringe");
			item.rare = 4;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Inhibitor");
			recipe.AddIngredient(mod, "BeamJug");
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}