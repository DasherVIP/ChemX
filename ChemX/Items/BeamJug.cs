using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class BeamJug : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Beam Jug");
			Tooltip.SetDefault("This is for making beam syringes, \ndo not drink it.");
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
			item.useAnimation = 40;
			item.useTime = 40;
			item.buffType = mod.BuffType ("OverBeamBuff");
			item.buffTime = 12000;
			item.rare = 3;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 6);
			recipe.AddIngredient(ItemID.SoulofLight, 2);
			recipe.AddIngredient(ItemID.HallowedSeeds, 1);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}