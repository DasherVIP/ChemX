using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class IronFleshPotion : ModItem
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
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.useAnimation = 17;
			item.useTime = 17;
			item.buffType = mod.BuffType ("IronFleshBuff");
			item.buffTime = 30000;
			item.rare = 4;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronskinPotion, 1);
			recipe.AddIngredient(ItemID.MythrilOre, 3);
			recipe.AddIngredient(mod, "Catalyst");
			recipe.AddIngredient(ItemID.Blinkroot, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronskinPotion, 1);
			recipe.AddIngredient(ItemID.OrichalcumOre, 3);
			recipe.AddIngredient(mod, "Catalyst");
			recipe.AddIngredient(ItemID.Blinkroot, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}