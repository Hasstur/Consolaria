using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Consolaria.Items
{
	public class OcramMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Ocram)");
		}
		public override void SetDefaults() 
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = TileType<Tiles.OcramMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = 3;
			item.value = 100000;
			item.accessory = true;
		}
	}
}
