using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions.Combos
{
	public class OffenseComboPotion : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Offence Combo Potion");
            Tooltip.SetDefault("Infinitely provides many offensive buffs.");
        }

        public override void SetDefaults()
		{
			item.width = 14;
			item.height = 24;
            item.useStyle = 2;
            item.useTime = 17;
            item.useAnimation = 17;
            item.UseSound = SoundID.Item3;
			item.value = 25000;
			item.rare = 8;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "EndlessAmmoReservationPotion", 1);
            recipe.AddIngredient(null, "EndlessArcheryPotion", 1);
            recipe.AddIngredient(null, "EndlessMagicPowerPotion", 1);
            recipe.AddIngredient(null, "EndlessRagePotion", 1);
            recipe.AddIngredient(null, "EndlessTitanPotion", 1);
            recipe.AddIngredient(null, "EndlessWrathPotion", 1);
            recipe.AddIngredient(null, "EndlessSummoningPotion", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.AmmoReservation, 216000);
            player.AddBuff(BuffID.Archery, 216000);
            player.AddBuff(BuffID.MagicPower, 216000);
            player.AddBuff(BuffID.Rage, 216000);
            player.AddBuff(BuffID.Titan, 216000);
            player.AddBuff(BuffID.Wrath, 216000);
            player.AddBuff(BuffID.Summoning, 216000);
            return true;
        }
    }
}