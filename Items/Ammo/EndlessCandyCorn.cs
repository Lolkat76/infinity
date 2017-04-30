using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessCandyCorn : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Candy Corn Munitions Crate";
            item.ammo = AmmoID.CandyCorn;
            item.ranged = true;
			item.width = 8;
			item.height = 8;
            item.damage = 9;
            item.knockBack = 1.5f;
            item.shootSpeed = 4;
            item.shoot = ProjectileID.CandyCorn;
            item.toolTip = "Provides infinite Candy Corn";
			item.value = 1000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CandyCorn, 3996);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}