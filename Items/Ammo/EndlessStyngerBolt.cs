using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessStyngerBolt : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stynger Bolt Munitions Crate");
            Tooltip.SetDefault("Provides infinite Stynger Bolts");
        }

        public override void SetDefaults()
		{
            item.ammo = AmmoID.StyngerBolt;
            item.ranged = true;
			item.width = 10;
			item.height = 28;
            item.damage = 17;
            item.knockBack = 1f;
            item.shootSpeed = 2;
            item.shoot = ProjectileID.Stynger;
			item.value = 1000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StyngerBolt, 3996);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();         
		}
	}
}