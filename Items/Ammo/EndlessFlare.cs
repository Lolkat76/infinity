using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessFlare : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Flare Munitions Crate";
			item.damage = 1;
			item.ranged = true;
            item.ammo = AmmoID.Flare;
            item.shoot = ProjectileID.Flare;
			item.width = 26;
			item.height = 26;
			item.toolTip = "Provides infinite Flares";
			item.knockBack = 1.5f;
            item.shootSpeed = 6f;
			item.value = 1000;
			item.rare = 2;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Flare, 3996);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}