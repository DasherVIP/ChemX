using ChemX.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class IcicleBottle : ModItem
	{
		public override void SetStaticDefaults() 
		{
			//DisplayName.SetDefault("Icicle Bottle");
			Tooltip.SetDefault("It's way too cold, should you even drink this?.");
        }
		
		public override void SetDefaults() {
			item.damage = 15;
			item.useStyle = 2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.noMelee = true;
			item.knockBack = 1.5f;
			item.width = 40;
			item.height = 40;
			item.rare = 2;
			item.autoReuse = false;
			item.UseSound = SoundID.Item4;
			item.shoot = ProjectileType<Icicle>();
			item.shootSpeed = 10f;
			item.maxStack = 999;
			item.consumable = true;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ItemID.IceBlock, 3);
			recipe.AddIngredient(ItemID.Shiverthorn, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}