using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessFallenStar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Fallen Star";
            item.ammo = AmmoID.FallenStar;
			item.width = 18;
			item.height = 20;
            item.toolTip = "'I hold the galaxy in my hands'";
			item.value = 25000;
			item.rare = 2;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 99);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}