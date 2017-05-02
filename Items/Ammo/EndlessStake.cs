using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessStake : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Stake Munitions Crate";
            item.ammo = AmmoID.Stake;
            item.ranged = true;
			item.width = 20;
			item.height = 14;
            item.damage = 25;
            item.knockBack = 4.5f;
            item.shootSpeed = 3;
            item.shoot = ProjectileID.Stake;
            item.toolTip = "Provides infinite Stakes";
			item.value = 1000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stake, 3996);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}