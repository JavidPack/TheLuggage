using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheLuggage.Items
{
	public class OddKey : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Odd Key";
			item.damage = 0;
			item.useStyle = 1;
			item.shoot = mod.ProjectileType("TheLuggagePet");
			item.width = 16;
			item.height = 30;
			item.UseSound = SoundID.Item2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = 3;
			item.noMelee = true;
			item.toolTip = "Summons The Luggage";
			item.value = Item.buyPrice(0, 3, 0, 0);
			item.buffType = mod.BuffType("TheLuggageBuff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chest);
			recipe.AddIngredient(ItemID.LifeCrystal, 3);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}