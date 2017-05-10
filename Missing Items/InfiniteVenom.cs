using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteVenom : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Venom Quiver";
			item.damage = 17;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Inflicts target with venom. And has infinite arrows.";
			item.consumable = false;
			item.knockBack = 4.2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 282;
			item.shootSpeed = 4.3f;
			item.ammo = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1341, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}