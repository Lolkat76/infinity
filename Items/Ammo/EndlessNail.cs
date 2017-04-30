using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessNail : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Nail Munitions Crate";
            item.ammo = AmmoID.NailFriendly;
            item.ranged = true;
			item.width = 8;
			item.height = 8;
            item.damage = 30;
            item.knockBack = 3f;
            item.shootSpeed = 6;
            item.shoot = ProjectileID.NailFriendly;
            item.toolTip = "Provides infinite Nails";
			item.value = 1000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Nail, 3996);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}