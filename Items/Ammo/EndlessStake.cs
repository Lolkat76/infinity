using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessStake : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stake Munitions Crate");
            Tooltip.SetDefault("Provides infinite Stakes");
        }

        public override void SetDefaults()
		{
            item.ammo = AmmoID.Stake;
            item.ranged = true;
			item.width = 20;
			item.height = 14;
            item.damage = 25;
            item.knockBack = 4.5f;
            item.shootSpeed = 3;
            item.shoot = ProjectileID.Stake;
			item.value = 1000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stake, 999);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}