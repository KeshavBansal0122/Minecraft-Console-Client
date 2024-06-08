using System.Collections.Generic;

namespace MinecraftClient.Inventory.ItemPalettes
{
    /// <summary>
    /// For MC 1.8
    /// Done manually by Milutinke :(
    /// </summary>
    public class ItemPalette110 : ItemPalette
    {
        private static readonly Dictionary<int, ItemType> mappings = new();

        static ItemPalette110()
        {
            // Mapping IDs are a derived from: (Item ID << 16) | Data
            mappings[0] = ItemType.Air;
            mappings[65536] = ItemType.Stone;
            mappings[65537] = ItemType.Granite;
            mappings[65538] = ItemType.PolishedGranite;
            mappings[65539] = ItemType.Diorite;
            mappings[65540] = ItemType.PolishedDiorite;
            mappings[65541] = ItemType.Andesite;
            mappings[65542] = ItemType.PolishedAndesite;
            mappings[131072] = ItemType.GrassBlock;
            mappings[196608] = ItemType.Dirt;
            mappings[196609] = ItemType.CoarseDirt;
            mappings[196610] = ItemType.Podzol;
            mappings[262144] = ItemType.Cobblestone;
            mappings[327680] = ItemType.OakPlanks;
            mappings[327681] = ItemType.SprucePlanks;
            mappings[327682] = ItemType.BirchPlanks;
            mappings[327683] = ItemType.JunglePlanks;
            mappings[327684] = ItemType.AcaciaPlanks;
            mappings[327685] = ItemType.DarkOakPlanks;
            mappings[393216] = ItemType.OakSapling;
            mappings[393217] = ItemType.SpruceSapling;
            mappings[393218] = ItemType.BirchSapling;
            mappings[393219] = ItemType.JungleSapling;
            mappings[393220] = ItemType.AcaciaSapling;
            mappings[393221] = ItemType.DarkOakSapling;
            mappings[458752] = ItemType.Bedrock;
            mappings[524288] = ItemType.WaterBucket; // Still Water Block Item
            mappings[589824] = ItemType.WaterBucket; // Flowing Water Block Item
            mappings[655360] = ItemType.LavaBucket; // Still Lava Block Item
            mappings[720896] = ItemType.LavaBucket; // Flowing Lava Block Item
            mappings[786432] = ItemType.Sand;
            mappings[786433] = ItemType.RedSand;
            mappings[851968] = ItemType.Gravel;
            mappings[917504] = ItemType.GoldOre;
            mappings[983040] = ItemType.IronOre;
            mappings[1048576] = ItemType.CoalOre;
            mappings[1114112] = ItemType.OakLog;
            mappings[1114113] = ItemType.SpruceLog;
            mappings[1114114] = ItemType.BirchLog;
            mappings[1114115] = ItemType.JungleLog;
            mappings[1179648] = ItemType.OakLeaves;
            mappings[1179649] = ItemType.SpruceLeaves;
            mappings[1179650] = ItemType.BirchLeaves;
            mappings[1179651] = ItemType.JungleLeaves;
            mappings[1245184] = ItemType.Sponge;
            mappings[1245185] = ItemType.WetSponge;
            mappings[1310720] = ItemType.Glass;
            mappings[1376256] = ItemType.LapisOre;
            mappings[1441792] = ItemType.LapisBlock;
            mappings[1507328] = ItemType.Dispenser;
            mappings[1572864] = ItemType.Sandstone;
            mappings[1572865] = ItemType.ChiseledSandstone;
            mappings[1572866] = ItemType.SmoothSandstone;
            mappings[1638400] = ItemType.NoteBlock;
            mappings[1769472] = ItemType.PoweredRail;
            mappings[1835008] = ItemType.DetectorRail;
            mappings[1900544] = ItemType.StickyPiston;
            mappings[1966080] = ItemType.Cobweb;
            mappings[2031617] = ItemType.Grass;
            mappings[2031618] = ItemType.Fern;
            mappings[2097152] = ItemType.DeadBush;
            mappings[2162688] = ItemType.Piston;
            mappings[2293760] = ItemType.WhiteWool;
            mappings[2293761] = ItemType.OrangeWool;
            mappings[2293762] = ItemType.MagentaWool;
            mappings[2293763] = ItemType.LightBlueWool;
            mappings[2293764] = ItemType.YellowWool;
            mappings[2293765] = ItemType.LimeWool;
            mappings[2293766] = ItemType.PinkWool;
            mappings[2293767] = ItemType.GrayWool;
            mappings[2293768] = ItemType.LightGrayWool;
            mappings[2293769] = ItemType.CyanWool;
            mappings[2293770] = ItemType.PurpleWool;
            mappings[2293771] = ItemType.BlueWool;
            mappings[2293772] = ItemType.BrownWool;
            mappings[2293773] = ItemType.GreenWool;
            mappings[2293774] = ItemType.RedWool;
            mappings[2293775] = ItemType.BlackWool;
            mappings[2424832] = ItemType.Dandelion;
            mappings[2490368] = ItemType.Poppy;
            mappings[2490369] = ItemType.BlueOrchid;
            mappings[2490370] = ItemType.Allium;
            mappings[2490371] = ItemType.AzureBluet;
            mappings[2490372] = ItemType.RedTulip;
            mappings[2490373] = ItemType.OrangeTulip;
            mappings[2490374] = ItemType.WhiteTulip;
            mappings[2490375] = ItemType.PinkTulip;
            mappings[2490376] = ItemType.OxeyeDaisy;
            mappings[2555904] = ItemType.BrownMushroom;
            mappings[2621440] = ItemType.RedMushroom;
            mappings[2686976] = ItemType.GoldBlock;
            mappings[2752512] = ItemType.IronBlock;
            mappings[2883584] = ItemType.StoneSlab;
            mappings[2883585] = ItemType.SandstoneSlab;
            mappings[2883587] = ItemType.CobblestoneSlab;
            mappings[2883588] = ItemType.BrickSlab;
            mappings[2883589] = ItemType.StoneBrickSlab;
            mappings[2883590] = ItemType.NetherBrickSlab;
            mappings[2883591] = ItemType.QuartzSlab;
            mappings[2949120] = ItemType.Bricks;
            mappings[3014656] = ItemType.Tnt;
            mappings[3080192] = ItemType.Bookshelf;
            mappings[3145728] = ItemType.MossyCobblestone;
            mappings[3211264] = ItemType.Obsidian;
            mappings[3276800] = ItemType.Torch;
            mappings[3407872] = ItemType.Spawner;
            mappings[3473408] = ItemType.OakStairs;
            mappings[3538944] = ItemType.Chest;
            mappings[3670016] = ItemType.DiamondOre;
            mappings[3735552] = ItemType.DiamondBlock;
            mappings[3801088] = ItemType.CraftingTable;
            mappings[3932160] = ItemType.Farmland;
            mappings[3997696] = ItemType.Furnace;
            mappings[4259840] = ItemType.Ladder;
            mappings[4390912] = ItemType.CobblestoneStairs;
            mappings[4587520] = ItemType.StonePressurePlate;
            mappings[4718592] = ItemType.OakPressurePlate;
            mappings[5046272] = ItemType.StoneButton;
            mappings[5177344] = ItemType.Ice;
            mappings[5308416] = ItemType.Cactus;
            mappings[5373952] = ItemType.Clay;
            mappings[5505024] = ItemType.Jukebox;
            mappings[5570560] = ItemType.OakFence;
            mappings[5832704] = ItemType.Glowstone;
            mappings[6225920] = ItemType.WhiteStainedGlass;
            mappings[6225921] = ItemType.OrangeStainedGlass;
            mappings[6225922] = ItemType.MagentaStainedGlass;
            mappings[6225923] = ItemType.LightBlueStainedGlass;
            mappings[6225924] = ItemType.YellowStainedGlass;
            mappings[6225925] = ItemType.LimeStainedGlass;
            mappings[6225926] = ItemType.PinkStainedGlass;
            mappings[6225927] = ItemType.GrayStainedGlass;
            mappings[6225928] = ItemType.LightGrayStainedGlass;
            mappings[6225929] = ItemType.CyanStainedGlass;
            mappings[6225930] = ItemType.PurpleStainedGlass;
            mappings[6225931] = ItemType.BlueStainedGlass;
            mappings[6225932] = ItemType.BrownStainedGlass;
            mappings[6225933] = ItemType.GreenStainedGlass;
            mappings[6225934] = ItemType.RedStainedGlass;
            mappings[6225935] = ItemType.BlackStainedGlass;
            mappings[6291456] = ItemType.OakTrapdoor;
            mappings[6422528] = ItemType.StoneBricks;
            mappings[6422529] = ItemType.MossyStoneBricks;
            mappings[6422530] = ItemType.CrackedStoneBricks;
            mappings[6422531] = ItemType.ChiseledStoneBricks;
            mappings[6488064] = ItemType.BrownMushroomBlock;
            mappings[6619136] = ItemType.IronBars;
            mappings[6684672] = ItemType.GlassPane;
            mappings[6946816] = ItemType.Vine;
            mappings[7012352] = ItemType.OakFenceGate;
            mappings[7077888] = ItemType.BrickStairs;
            mappings[7143424] = ItemType.StoneBrickStairs;
            mappings[7274496] = ItemType.LilyPad;
            mappings[7602176] = ItemType.EnchantingTable;
            mappings[7864320] = ItemType.EndPortalFrame;
            mappings[7929856] = ItemType.EndStone;
            mappings[7995392] = ItemType.DragonEgg;
            mappings[8257536] = ItemType.OakSlab;
            mappings[8257537] = ItemType.SpruceSlab;
            mappings[8257538] = ItemType.BirchSlab;
            mappings[8257539] = ItemType.JungleSlab;
            mappings[8257540] = ItemType.AcaciaSlab;
            mappings[8257541] = ItemType.DarkOakSlab;
            mappings[8454144] = ItemType.EmeraldOre;
            mappings[8519680] = ItemType.EnderChest;
            mappings[8585216] = ItemType.TripwireHook;
            mappings[8716288] = ItemType.EmeraldBlock;
            mappings[8781824] = ItemType.SpruceStairs;
            mappings[8847360] = ItemType.BirchStairs;
            mappings[8912896] = ItemType.JungleStairs;
            mappings[8978432] = ItemType.CommandBlock;
            mappings[9043968] = ItemType.Beacon;
            mappings[9109504] = ItemType.CobblestoneWall;
            mappings[4325376] = ItemType.Rail;
            mappings[4521984] = ItemType.Lever;
            mappings[4784128] = ItemType.RedstoneOre;
            mappings[4980736] = ItemType.RedstoneTorch;
            mappings[5111808] = ItemType.Snow;
            mappings[5242880] = ItemType.SnowBlock;
            mappings[5636096] = ItemType.Pumpkin;
            mappings[5701632] = ItemType.Netherrack;
            mappings[5767168] = ItemType.SoulSand;
            mappings[5963776] = ItemType.JackOLantern;
            mappings[6356992] = ItemType.InfestedStone;
            mappings[6356993] = ItemType.InfestedCobblestone;
            mappings[6356994] = ItemType.InfestedStoneBricks;
            mappings[6356995] = ItemType.InfestedMossyStoneBricks;
            mappings[6356996] = ItemType.InfestedCrackedStoneBricks;
            mappings[6356997] = ItemType.InfestedChiseledStoneBricks;
            mappings[6553600] = ItemType.RedMushroomBlock;
            mappings[6750208] = ItemType.Melon;
            mappings[7208960] = ItemType.Mycelium;
            mappings[7340032] = ItemType.NetherBricks;
            mappings[7405568] = ItemType.NetherBrickFence;
            mappings[7471104] = ItemType.NetherBrickStairs;
            mappings[8060928] = ItemType.RedstoneLamp;
            mappings[8388608] = ItemType.SandstoneStairs;
            mappings[9109505] = ItemType.MossyCobblestoneWall;
            mappings[9502720] = ItemType.Anvil;
            mappings[9502721] = ItemType.ChippedAnvil;
            mappings[9502722] = ItemType.DamagedAnvil;
            mappings[9568256] = ItemType.TrappedChest;
            mappings[9633792] = ItemType.LightWeightedPressurePlate;
            mappings[9699328] = ItemType.HeavyWeightedPressurePlate;
            mappings[9895936] = ItemType.DaylightDetector;
            mappings[9961472] = ItemType.RedstoneBlock;
            mappings[10027008] = ItemType.NetherQuartzOre;
            mappings[10092544] = ItemType.Hopper;
            mappings[10158080] = ItemType.QuartzBlock;
            mappings[10158081] = ItemType.ChiseledQuartzBlock;
            mappings[10158082] = ItemType.QuartzPillar;
            mappings[10223616] = ItemType.QuartzStairs;
            mappings[10289152] = ItemType.ActivatorRail;
            mappings[10354688] = ItemType.Dropper;
            mappings[10420224] = ItemType.WhiteTerracotta;
            mappings[10420225] = ItemType.OrangeTerracotta;
            mappings[10420226] = ItemType.MagentaTerracotta;
            mappings[10420227] = ItemType.LightBlueTerracotta;
            mappings[10420228] = ItemType.YellowTerracotta;
            mappings[10420229] = ItemType.LimeTerracotta;
            mappings[10420230] = ItemType.PinkTerracotta;
            mappings[10420231] = ItemType.GrayTerracotta;
            mappings[10420232] = ItemType.LightGrayTerracotta;
            mappings[10420233] = ItemType.CyanTerracotta;
            mappings[10420234] = ItemType.PurpleTerracotta;
            mappings[10420235] = ItemType.BlueTerracotta;
            mappings[10420236] = ItemType.BrownTerracotta;
            mappings[10420237] = ItemType.GreenTerracotta;
            mappings[10420238] = ItemType.RedTerracotta;
            mappings[10420239] = ItemType.BlackTerracotta;
            mappings[10485760] = ItemType.WhiteStainedGlassPane;
            mappings[10485761] = ItemType.OrangeStainedGlassPane;
            mappings[10485762] = ItemType.MagentaStainedGlassPane;
            mappings[10485763] = ItemType.LightBlueStainedGlassPane;
            mappings[10485764] = ItemType.YellowStainedGlassPane;
            mappings[10485765] = ItemType.LimeStainedGlassPane;
            mappings[10485766] = ItemType.PinkStainedGlassPane;
            mappings[10485767] = ItemType.GrayStainedGlassPane;
            mappings[10485768] = ItemType.LightGrayStainedGlassPane;
            mappings[10485769] = ItemType.CyanStainedGlassPane;
            mappings[10485770] = ItemType.PurpleStainedGlassPane;
            mappings[10485771] = ItemType.BlueStainedGlassPane;
            mappings[10485772] = ItemType.BrownStainedGlassPane;
            mappings[10485773] = ItemType.GreenStainedGlassPane;
            mappings[10485774] = ItemType.RedStainedGlassPane;
            mappings[10485775] = ItemType.BlackStainedGlassPane;
            mappings[10551296] = ItemType.AcaciaLeaves;
            mappings[10551297] = ItemType.DarkOakLeaves;
            mappings[10616832] = ItemType.AcaciaLog;
            mappings[10616833] = ItemType.DarkOakLog;
            mappings[10682368] = ItemType.AcaciaStairs;
            mappings[10747904] = ItemType.DarkOakStairs;
            mappings[10813440] = ItemType.SlimeBlock;
            mappings[10878976] = ItemType.Barrier;
            mappings[10944512] = ItemType.IronTrapdoor;
            mappings[11010048] = ItemType.Prismarine;
            mappings[11010049] = ItemType.PrismarineBricks;
            mappings[11010050] = ItemType.DarkPrismarine;
            mappings[11075584] = ItemType.SeaLantern;
            mappings[11141120] = ItemType.HayBlock;
            mappings[11206656] = ItemType.WhiteCarpet;
            mappings[11206657] = ItemType.OrangeCarpet;
            mappings[11206658] = ItemType.MagentaCarpet;
            mappings[11206659] = ItemType.LightBlueCarpet;
            mappings[11206660] = ItemType.YellowCarpet;
            mappings[11206661] = ItemType.LimeCarpet;
            mappings[11206662] = ItemType.PinkCarpet;
            mappings[11206663] = ItemType.GrayCarpet;
            mappings[11206664] = ItemType.LightGrayCarpet;
            mappings[11206665] = ItemType.CyanCarpet;
            mappings[11206666] = ItemType.PurpleCarpet;
            mappings[11206667] = ItemType.BlueCarpet;
            mappings[11206668] = ItemType.BrownCarpet;
            mappings[11206669] = ItemType.GreenCarpet;
            mappings[11206670] = ItemType.RedCarpet;
            mappings[11206671] = ItemType.BlackCarpet;
            mappings[11272192] = ItemType.Terracotta;
            mappings[11337728] = ItemType.CoalBlock;
            mappings[11403264] = ItemType.PackedIce;
            mappings[11468800] = ItemType.Sunflower;
            mappings[11468801] = ItemType.Lilac;
            mappings[11468802] = ItemType.TallGrass;
            mappings[11468803] = ItemType.LargeFern;
            mappings[11468804] = ItemType.RoseBush;
            mappings[11468805] = ItemType.Peony;
            mappings[11730944] = ItemType.RedSandstone;
            mappings[11730945] = ItemType.ChiseledRedSandstone;
            mappings[11730946] = ItemType.SmoothRedSandstone;
            mappings[11796480] = ItemType.RedSandstoneStairs;
            mappings[11927552] = ItemType.RedSandstoneSlab;
            mappings[11993088] = ItemType.SpruceFenceGate;
            mappings[12058624] = ItemType.BirchFenceGate;
            mappings[12124160] = ItemType.JungleFenceGate;
            mappings[12189696] = ItemType.DarkOakFenceGate;
            mappings[12255232] = ItemType.AcaciaFenceGate;
            mappings[12320768] = ItemType.SpruceFence;
            mappings[12386304] = ItemType.BirchFence;
            mappings[12451840] = ItemType.JungleFence;
            mappings[12517376] = ItemType.DarkOakFence;
            mappings[12582912] = ItemType.AcaciaFence;
            mappings[12976128] = ItemType.EndRod;
            mappings[13041664] = ItemType.ChorusPlant;
            mappings[13107200] = ItemType.ChorusFlower;
            mappings[13172736] = ItemType.PurpurBlock;
            mappings[13238272] = ItemType.PurpurPillar;
            mappings[13303808] = ItemType.PurpurStairs;
            mappings[13434880] = ItemType.PurpurSlab;
            mappings[13500416] = ItemType.EndStoneBricks;
            mappings[13631488] = ItemType.DirtPath;
            mappings[13762560] = ItemType.RepeatingCommandBlock;
            mappings[13828096] = ItemType.ChainCommandBlock;
            mappings[13959168] = ItemType.MagmaBlock;
            mappings[14024704] = ItemType.NetherWartBlock;
            mappings[14090240] = ItemType.RedNetherBricks;
            mappings[14155776] = ItemType.BoneBlock;
            mappings[14221312] = ItemType.StructureVoid;
            mappings[16711680] = ItemType.StructureBlock;
            mappings[16777216] = ItemType.IronShovel;
            mappings[16842752] = ItemType.IronPickaxe;
            mappings[16908288] = ItemType.IronAxe;
            mappings[16973824] = ItemType.FlintAndSteel;
            mappings[17039360] = ItemType.Apple;
            mappings[17104896] = ItemType.Bow;
            mappings[17170432] = ItemType.Arrow;
            mappings[17235968] = ItemType.Coal;
            mappings[17235969] = ItemType.Charcoal;
            mappings[17301504] = ItemType.Diamond;
            mappings[17367040] = ItemType.IronIngot;
            mappings[17432576] = ItemType.GoldIngot;
            mappings[17498112] = ItemType.IronSword;
            mappings[17825792] = ItemType.StoneSword;
            mappings[17891328] = ItemType.StoneShovel;
            mappings[17956864] = ItemType.StonePickaxe;
            mappings[18022400] = ItemType.StoneAxe;
            mappings[18087936] = ItemType.DiamondSword;
            mappings[18153472] = ItemType.DiamondShovel;
            mappings[18219008] = ItemType.DiamondPickaxe;
            mappings[18284544] = ItemType.DiamondAxe;
            mappings[18350080] = ItemType.Stick;
            mappings[18415616] = ItemType.Bowl;
            mappings[18481152] = ItemType.MushroomStew;
            mappings[18546688] = ItemType.GoldenSword;
            mappings[18612224] = ItemType.GoldenShovel;
            mappings[18677760] = ItemType.GoldenPickaxe;
            mappings[18743296] = ItemType.GoldenAxe;
            mappings[18808832] = ItemType.String;
            mappings[18874368] = ItemType.Feather;
            mappings[18939904] = ItemType.Gunpowder;
            mappings[19070976] = ItemType.StoneHoe;
            mappings[19136512] = ItemType.IronHoe;
            mappings[19202048] = ItemType.DiamondHoe;
            mappings[19267584] = ItemType.GoldenHoe;
            mappings[19464192] = ItemType.Bread;
            mappings[19529728] = ItemType.LeatherHelmet;
            mappings[19595264] = ItemType.LeatherChestplate;
            mappings[19660800] = ItemType.LeatherLeggings;
            mappings[19726336] = ItemType.LeatherBoots;
            mappings[19791872] = ItemType.ChainmailHelmet;
            mappings[19857408] = ItemType.ChainmailChestplate;
            mappings[19922944] = ItemType.ChainmailLeggings;
            mappings[19988480] = ItemType.ChainmailBoots;
            mappings[20054016] = ItemType.IronHelmet;
            mappings[20119552] = ItemType.IronChestplate;
            mappings[20185088] = ItemType.IronLeggings;
            mappings[20250624] = ItemType.IronBoots;
            mappings[20316160] = ItemType.DiamondHelmet;
            mappings[20381696] = ItemType.DiamondChestplate;
            mappings[20447232] = ItemType.DiamondLeggings;
            mappings[20512768] = ItemType.DiamondBoots;
            mappings[20578304] = ItemType.GoldenHelmet;
            mappings[20643840] = ItemType.GoldenChestplate;
            mappings[20709376] = ItemType.GoldenLeggings;
            mappings[20774912] = ItemType.GoldenBoots;
            mappings[20840448] = ItemType.Flint;
            mappings[20905984] = ItemType.Porkchop;
            mappings[20971520] = ItemType.CookedPorkchop;
            mappings[21037056] = ItemType.Painting;
            mappings[21102592] = ItemType.GoldenApple;
            mappings[21102593] = ItemType.EnchantedGoldenApple;
            mappings[21168128] = ItemType.OakSign;
            mappings[21299200] = ItemType.Bucket;
            mappings[21430272] = ItemType.LavaBucket;
            mappings[21495808] = ItemType.Minecart;
            mappings[21561344] = ItemType.Saddle;
            mappings[21626880] = ItemType.IronDoor;
            mappings[21692416] = ItemType.Redstone;
            mappings[21757952] = ItemType.Snowball;
            mappings[21823488] = ItemType.OakBoat;
            mappings[21889024] = ItemType.Leather;
            mappings[21954560] = ItemType.MilkBucket;
            mappings[22020096] = ItemType.Brick;
            mappings[22085632] = ItemType.ClayBall;
            mappings[22151168] = ItemType.SugarCane;
            mappings[22216704] = ItemType.Paper;
            mappings[22282240] = ItemType.Book;
            mappings[22347776] = ItemType.SlimeBall;
            mappings[22413312] = ItemType.ChestMinecart;
            mappings[22478848] = ItemType.FurnaceMinecart;
            mappings[22544384] = ItemType.Egg;
            mappings[22609920] = ItemType.Compass;
            mappings[22675456] = ItemType.FishingRod;
            mappings[22740992] = ItemType.Clock;
            mappings[22806528] = ItemType.GlowstoneDust;
            mappings[22872064] = ItemType.Salmon;
            mappings[22872065] = ItemType.Salmon;
            mappings[22872066] = ItemType.TropicalFish;
            mappings[22872067] = ItemType.Pufferfish;
            mappings[22937600] = ItemType.CookedSalmon;
            mappings[22937601] = ItemType.CookedSalmon;
            mappings[23003136] = ItemType.InkSac;
            mappings[23003137] = ItemType.RedDye;
            mappings[23003138] = ItemType.GreenDye;
            mappings[23003139] = ItemType.CocoaBeans;
            mappings[23003140] = ItemType.LapisLazuli;
            mappings[23003141] = ItemType.PurpleDye;
            mappings[23003142] = ItemType.CyanDye;
            mappings[23003143] = ItemType.LightGrayDye;
            mappings[23003144] = ItemType.GrayDye;
            mappings[23003145] = ItemType.PinkDye;
            mappings[23003146] = ItemType.LimeDye;
            mappings[23003147] = ItemType.YellowDye;
            mappings[23003148] = ItemType.LightBlueDye;
            mappings[23003149] = ItemType.MagentaDye;
            mappings[23003150] = ItemType.OrangeDye;
            mappings[23003151] = ItemType.BoneMeal;
            mappings[23068672] = ItemType.Bone;
            mappings[23134208] = ItemType.Sugar;
            mappings[23199744] = ItemType.Cake;
            mappings[23265280] = ItemType.RedBed;
            mappings[23330816] = ItemType.Repeater;
            mappings[23396352] = ItemType.Cookie;
            mappings[23527424] = ItemType.Shears;
            mappings[23592960] = ItemType.MelonSlice;
            mappings[23658496] = ItemType.PumpkinSeeds;
            mappings[23724032] = ItemType.MelonSeeds;
            mappings[23789568] = ItemType.Beef;
            mappings[23855104] = ItemType.CookedBeef;
            mappings[23920640] = ItemType.Chicken;
            mappings[23986176] = ItemType.CookedChicken;
            mappings[24051712] = ItemType.RottenFlesh;
            mappings[24117248] = ItemType.EnderPearl;
            mappings[24182784] = ItemType.BlazeRod;
            mappings[24248320] = ItemType.GhastTear;
            mappings[24313856] = ItemType.GoldNugget;
            mappings[24379392] = ItemType.NetherWart;
            mappings[24444928] = ItemType.Potion;
            mappings[24510464] = ItemType.GlassBottle;
            mappings[24576000] = ItemType.SpiderEye;
            mappings[24641536] = ItemType.FermentedSpiderEye;
            mappings[24707072] = ItemType.BlazePowder;
            mappings[24772608] = ItemType.MagmaCream;
            mappings[24838144] = ItemType.BrewingStand;
            mappings[24903680] = ItemType.Cauldron;
            mappings[24969216] = ItemType.EnderEye;
            mappings[25034752] = ItemType.GlisteringMelonSlice;
            mappings[25100288] = ItemType.BatSpawnEgg;
            mappings[25100288] = ItemType.BlazeSpawnEgg;
            mappings[25100288] = ItemType.CaveSpiderSpawnEgg;
            mappings[25100288] = ItemType.ChickenSpawnEgg;
            mappings[25100288] = ItemType.CowSpawnEgg;
            mappings[25100288] = ItemType.CreeperSpawnEgg;
            mappings[25100288] = ItemType.EndermanSpawnEgg;
            mappings[25100288] = ItemType.EndermiteSpawnEgg;
            mappings[25100288] = ItemType.GhastSpawnEgg;
            mappings[25100288] = ItemType.GuardianSpawnEgg;
            mappings[25100288] = ItemType.HorseSpawnEgg;
            mappings[25100288] = ItemType.MagmaCubeSpawnEgg;
            mappings[25100288] = ItemType.MooshroomSpawnEgg;
            mappings[25100288] = ItemType.OcelotSpawnEgg;
            mappings[25100288] = ItemType.PigSpawnEgg;
            mappings[25100288] = ItemType.PolarBearSpawnEgg;
            mappings[25100288] = ItemType.RabbitSpawnEgg;
            mappings[25100288] = ItemType.SheepSpawnEgg;
            mappings[25100288] = ItemType.ShulkerSpawnEgg;
            mappings[25100288] = ItemType.SilverfishSpawnEgg;
            mappings[25100288] = ItemType.SkeletonSpawnEgg;
            mappings[25100288] = ItemType.SlimeSpawnEgg;
            mappings[25100288] = ItemType.SpiderSpawnEgg;
            mappings[25100288] = ItemType.SquidSpawnEgg;
            mappings[25100288] = ItemType.VillagerSpawnEgg;
            mappings[25100288] = ItemType.WitchSpawnEgg;
            mappings[25100288] = ItemType.WolfSpawnEgg;
            mappings[25100288] = ItemType.ZombieSpawnEgg;
            mappings[25100288] = ItemType.ZombifiedPiglinSpawnEgg;
            mappings[25165824] = ItemType.ExperienceBottle;
            mappings[25231360] = ItemType.FireCharge;
            mappings[25296896] = ItemType.WritableBook;
            mappings[25362432] = ItemType.WrittenBook;
            mappings[25427968] = ItemType.Emerald;
            mappings[25493504] = ItemType.ItemFrame;
            mappings[25559040] = ItemType.FlowerPot;
            mappings[25624576] = ItemType.Carrot;
            mappings[25690112] = ItemType.Potato;
            mappings[25755648] = ItemType.BakedPotato;
            mappings[25821184] = ItemType.PoisonousPotato;
            mappings[25886720] = ItemType.Map;
            mappings[25952256] = ItemType.GoldenCarrot;
            mappings[26017792] = ItemType.SkeletonSkull;
            mappings[26017793] = ItemType.WitherSkeletonSkull;
            mappings[26017794] = ItemType.ZombieHead;
            mappings[26017795] = ItemType.PlayerHead;
            mappings[26017796] = ItemType.CreeperHead;
            mappings[26017797] = ItemType.DragonHead;
            mappings[26083328] = ItemType.CarrotOnAStick;
            mappings[26148864] = ItemType.NetherStar;
            mappings[26214400] = ItemType.PumpkinPie;
            mappings[26279936] = ItemType.FireworkRocket;
            mappings[26411008] = ItemType.EnchantedBook;
            mappings[26476544] = ItemType.Comparator;
            mappings[26542080] = ItemType.NetherBrick;
            mappings[26607616] = ItemType.Quartz;
            mappings[26673152] = ItemType.TntMinecart;
            mappings[26738688] = ItemType.HopperMinecart;
            mappings[26804224] = ItemType.PrismarineShard;
            mappings[26869760] = ItemType.PrismarineCrystals;
            mappings[26935296] = ItemType.Rabbit;
            mappings[27000832] = ItemType.CookedRabbit;
            mappings[27066368] = ItemType.RabbitStew;
            mappings[27131904] = ItemType.RabbitFoot;
            mappings[27197440] = ItemType.RabbitHide;
            mappings[27262976] = ItemType.ArmorStand;
            mappings[27328512] = ItemType.IronHorseArmor;
            mappings[27394048] = ItemType.GoldenHorseArmor;
            mappings[27459584] = ItemType.DiamondHorseArmor;
            mappings[27525120] = ItemType.Lead;
            mappings[27590656] = ItemType.NameTag;
            mappings[27656192] = ItemType.CommandBlockMinecart;
            mappings[27721728] = ItemType.Mutton;
            mappings[27787264] = ItemType.CookedMutton;
            mappings[27852800] = ItemType.BlackBanner;
            mappings[27852801] = ItemType.RedBanner;
            mappings[27852802] = ItemType.GreenBanner;
            mappings[27852803] = ItemType.BrownBanner;
            mappings[27852804] = ItemType.BlueBanner;
            mappings[27852805] = ItemType.PurpleBanner;
            mappings[27852806] = ItemType.CyanBanner;
            mappings[27852807] = ItemType.LightGrayBanner;
            mappings[27852808] = ItemType.GrayBanner;
            mappings[27852809] = ItemType.PinkBanner;
            mappings[27852810] = ItemType.LimeBanner;
            mappings[27852811] = ItemType.YellowBanner;
            mappings[27852812] = ItemType.LightBlueBanner;
            mappings[27852813] = ItemType.MagentaBanner;
            mappings[27852814] = ItemType.OrangeBanner;
            mappings[27852815] = ItemType.WhiteBanner;
            mappings[27918336] = ItemType.EndCrystal;
            mappings[27983872] = ItemType.SpruceDoor;
            mappings[28049408] = ItemType.BirchDoor;
            mappings[28114944] = ItemType.JungleDoor;
            mappings[28180480] = ItemType.AcaciaDoor;
            mappings[28246016] = ItemType.DarkOakDoor;
            mappings[28311552] = ItemType.ChorusFruit;
            mappings[28377088] = ItemType.PoppedChorusFruit;
            mappings[28442624] = ItemType.Beetroot;
            mappings[28508160] = ItemType.BeetrootSeeds;
            mappings[28573696] = ItemType.BeetrootSoup;
            mappings[28639232] = ItemType.DragonBreath;
            mappings[28704768] = ItemType.SplashPotion;
            mappings[28770304] = ItemType.SpectralArrow;
            mappings[28835840] = ItemType.Arrow;
            mappings[28901376] = ItemType.LingeringPotion;
            mappings[28966912] = ItemType.Shield;
            mappings[29032448] = ItemType.Elytra;
            mappings[29097984] = ItemType.SpruceBoat;
            mappings[29163520] = ItemType.BirchBoat;
            mappings[29229056] = ItemType.JungleBoat;
            mappings[29294592] = ItemType.AcaciaBoat;
            mappings[29360128] = ItemType.DarkOakBoat;
            mappings[147849216] = ItemType.MusicDisc13;
            mappings[147914752] = ItemType.MusicDiscCat;
            mappings[147980288] = ItemType.MusicDiscBlocks;
            mappings[148045824] = ItemType.MusicDiscChirp;
            mappings[148111360] = ItemType.MusicDiscFar;
            mappings[148176896] = ItemType.MusicDiscMall;
            mappings[148242432] = ItemType.MusicDiscMellohi;
            mappings[148307968] = ItemType.MusicDiscStal;
            mappings[148373504] = ItemType.MusicDiscStrad;
            mappings[148439040] = ItemType.MusicDiscWard;
            mappings[148504576] = ItemType.MusicDisc11;
            mappings[148570112] = ItemType.MusicDiscWait;
            mappings[9371648] = ItemType.OakButton;
            mappings[17563648] = ItemType.WoodenSword;
            mappings[17629184] = ItemType.WoodenShovel;
            mappings[17694720] = ItemType.WoodenPickaxe;
            mappings[17760256] = ItemType.WoodenAxe;
            mappings[19005440] = ItemType.WoodenHoe;
            mappings[19333120] = ItemType.WheatSeeds;
            mappings[19398656] = ItemType.Wheat;
            mappings[21233664] = ItemType.OakDoor;
            mappings[21364736] = ItemType.WaterBucket;
        }

        protected override Dictionary<int, ItemType> GetDict()
        {
            return mappings;
        }
    }
}