using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChemX.Items
{
	public class ConjurationPotion : ModItem
	{
		public override void SetStaticDefaults() 
		{
			//DisplayName.SetDefault("ConjurationPotion");
		Tooltip.SetDefault("20% increased minion damage \nMake sure to use before summoning the minions!");
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
			item.buffType = mod.BuffType ("ConjurationBuff");
			item.buffTime = 24000;
			item.rare = 3;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SummoningPotion, 1);
			recipe.AddIngredient(ItemID.MagicPowerPotion, 1);
			recipe.AddIngredient(mod, "Catalyst");
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}