using ChemX.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class FlameBottle : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Flame in a Bottle");
			Tooltip.SetDefault("It's way too hot, should you even drink this?.");
        }
		
		public override void SetDefaults() {
			item.damage = 31;
			item.useStyle = 2;
			item.useAnimation = 16;
			item.useTime = 16;
			item.noMelee = true;
			item.knockBack = 2.5f;
			item.width = 40;
			item.height = 40;
			item.rare = 3;
			item.autoReuse = true;
			item.UseSound = SoundID.Item3;
			item.shoot = ProjectileType<FlamePulse>();
			item.shootSpeed = 100;
			item.maxStack = 999;
			item.consumable = true;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ItemID.Hellstone, 3);
			recipe.AddIngredient(ItemID.Fireblossom, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}