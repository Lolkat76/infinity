using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions
{
	public class EndlessBuilderPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Construction Potion";
			item.width = 14;
			item.height = 24;
            item.useStyle = 2;
            item.useTime = 17;
            item.useAnimation = 17;
            item.UseSound = SoundID.Item3;
            item.buffType = BuffID.Builder;
            item.buffTime = 216000;
            item.toolTip = "Infinitely provides Builder";
			item.value = 25000;
			item.rare = 2;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BuilderPotion, 30);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}