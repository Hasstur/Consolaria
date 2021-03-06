using Terraria.ModLoader;

namespace Consolaria.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class TurkorMask : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 24;
			item.rare = 3;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Turkor Mask");
			Tooltip.SetDefault("");
		}
	}
}
