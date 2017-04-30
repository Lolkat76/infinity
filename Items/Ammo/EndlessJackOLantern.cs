using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessJackOLantern : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Explosive Jack 'O Lantern";
            item.ammo = AmmoID.JackOLantern;
            item.ranged = true;
			item.width = 8;
			item.height = 8;
            item.damage = 30;
            item.knockBack = 3f;
            item.shootSpeed = 7;
            item.shoot = ProjectileID.JackOLantern;
            item.toolTip = "Provides infinite Explosive Jack 'O Lanterns";
			item.value = 1000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JackOLantern, 3996);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}