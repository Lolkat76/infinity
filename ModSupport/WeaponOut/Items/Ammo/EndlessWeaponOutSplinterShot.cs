using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.WeaponOut.Items.Ammo
{
	public class EndlessWeaponOutSplinterShot : ModItem
	{
        Mod otherMod = ModLoader.GetMod("WeaponOut");

		public override void SetDefaults()
		{
			item.name = "Endless Splinter Shot";
            item.ammo = AmmoID.Bullet;
            item.ranged = true;
			item.width = 8;
			item.height = 8;
            item.damage = 4;
            item.knockBack = 1f;
            item.shootSpeed = 2;
            if (otherMod != null)
            {
                item.shoot = otherMod.ProjectileType("SplinterShot");
            }
            item.toolTip = "Provides infinite Splinter Shots";
			item.value = 1000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("SplinterShot"), 3996);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}