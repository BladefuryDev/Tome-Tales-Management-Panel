using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tome_Tales_Management_Panel
{
    public partial class Form1 : Form
    {
        SoundPlayer bttnClick = new SoundPlayer(Properties.Resources.button_50);
        SoundPlayer completion = new SoundPlayer(Properties.Resources.research);
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenBoxesExec_Click(object sender, EventArgs e) // Loot Box Button
        {
            bttnClick.Play();
            LootBoxOutput.Text = "";
            // Loot Box management system here, change things as needed.
            string selBox = BoxSelectionDropdown.Text;
            int rolls = ((int)NumOfBoxes.Value);
            Random Rng = new Random();
            LootBoxOutput.Text = ("Opening " +rolls +" " +selBox +Environment.NewLine);

            // BOX TYPES | Add, remove and do whatever right here.

            string[] winterGiftBox = { "10 Cookies", "7500 BP!", "5 Clear Crystals", "Hail Orb", "Hot Cocoa", "Mistletoe Amulet", "3 Minhtment", "30 Snowballs", "Pola Cola", "5 Heart Shards", "5 Freezle Berries", "Freezle Blast", "10 Snow Balls", "Diamond Flake", "2 Frostire", "3 Milk", "Candycane Amulet", "Snow Orb", "10 Heart Shards", "Mythril Shard", "3 Frost Quartz"};
            string[] springGiftBox = { "Rain Lunelle", "3 Strawberry", "3 Lemon", "5 Oran Berry", "5K BP!", "5 Fairy Wing", "5 Radiant Heart", "5 Rue Crystal", "Plant Surprise!", "15 Flower Seeds" };
            string[] fallGiftBox = { "10 Radile Berries", "10 Freezle Berries", "3 Grapes", "10 Krackle Berries", "Maple Leaf", "5 Perism Berries", "10 Minht Berries", "Shrub Horde", "5 Chesto Berries", "3 Lemons", "10 Glum Berries", "10 Sizzle Berries", "Shrub Attack!", "5 Pecha Berries", "Rawst Berries", "3 Bottled Cinnamon", "3 Pumpkin", "5 Oran Berries", "Shrub Attack" };
            string[] friendGiftBox = { "Companion Card: Cole", "Companion Card: Kori", "Companion Card: Caelum", "Companion Card: Leanne", "Companion Card: Bolt", "Companion Card: Kumiki", "Companion Card: Silene", "Companion Card: Lea", "Companion Card: Weiss", "Companion Card: Aka", "Companion Card: Leon :fox:", "75000 BP!!!", "3 Festival of Light", "50 Gentle Boops", "3 Diamon Keys", "Companion Card: Random :warning:", "15 Asterisk Shards", "2 Silver Keys", "Companion Card: ???", "50 Soothing Hugs", "Gilded Ofesu", "25000 BP", "Lucky Egg!!! :star:" };
            string[] luckyGiftBox = { "10 Silver Clover", "5 Gold Clover", "1 Emerald Clover", "**Trait:** Super Lucky", "7777 BP!", "10 Tokens", "Shamrock Shake", "15 Clovers", "**Trait:** Super Unlucky", "3 Gold Ore", "Lucky Slime Hat!" };
            string[] summerGiftBox = { "Slime Egg :sparkles:", "5,000 BP", "Bamboo Rod", "Cooked Makiyoa", "Blue Pearl", "Golden Shell", "Red Coral" };
            string[] heartGiftBox = { "Trait: Charismatic", "Visit from Amera?", "15K BP!!!", "Pink Egg", "Wings of Eternity", "Cupid's Kiss", "Love Potion", "8000 BP!", "10 Asterisk Shards", "5 Heart Cookies", "1 Tokyo Bonus Key: Love Pass", "3x Chocolate Kiss" };
            string[] championGiftBox = { "30 Tokens", "10 Copper Keys", "7 Silver Keys", "5 Golden Keys", "3 Diamond Keys", "10 Survival Tickets", "30 Heart Shards", "30 Asterisk Shards", "Rainbow Egg!!! :star:", "25k BP!!!", "50k BP!!!", "35 Ether" };
            string[] spookfestBox = { "5 Krackle Berry", "5 Glum Berry", "Radile Pop", "Krackle Drops", "3 Ether", "Minhtment", "5 Radile Berry", "Bitter Soul", "Sizzle Pop", "Freezle Gum", "Haunt Attack :warning:", "Sour Soul", "5 Freezle Berry", "Glum Gum", "5 Sizzle Berry", "6,500 BP!", "Nymare Ambush :warning:", "Sweet Soul", "5 Minht Berry", "3 Health Potion" };
            string[] foxDeluxeSurpriseBox = { "Companion Card: Bolt", "Velgha", "Golden Egg :sparkles:", "Super Kaboom", "Tokyo Key: Rainbow", "Slime Egg :sparkles:", "3 Leonade Deluxe", "Nodakime Nageku", "Job Bonus Key: Synergist Knight", "Companion Card: Aka", "50k BP!!!", "10 Golden Key!", "3 Companion Card: Leon", "Freeze Blast", "Nova Dominus", "Job Bonus Key: Guardian", "Rainbow Egg :sparkles:", "5 Diamond Key", "Foxxo Mode! :fox:", "Companion Card: Weiss", "Bouncy Time!", "Arma Gem", "Rappy Fever!", "Haunt Assault :warning:", "3 Job Token", "Nymare Onslaught :warning:", "Companion Card: Silene", "Gambler Pass", "Dread King's Arrival :warning:", "Double Double Mode!", "Altar Spin", "Slime Rampage", "25k BP!!!", "Bandit Attack! :warning:", "Jackpot!!!", "5 Job Token", "Job Key: Astrologian", "Rappy Egg! :sparkles:", "Companion Card: Lea", "Companion Card: Kumiki", "25 Asterisk Shards", "Radiant Virtue"};
            string[] anniversaryBox = { "5 Slumber Orb", "5 Totter Orb", "10 Oracle Berry", "Diamond Key", "5 Silver Key", "5 Golden Key", "Old Scarf", "5 Sandy Orb", "5 Rainy Orb", "5 Sunny Orb", "20k BP!!!", "Golden Egg!!! :sparkles:", "25 Asterisk Shards", "15k BP!!", "Contract", "3 Revive All Orb" };
            string[] birthdayGiftBox = { "100K Bp", "5 Silver Starfruit", "Sweet Day", "Sweet Day", "10 Arma Gems", "50 Tokens", "Rainbow Egg", "50K Bp", "100 Asterisk Shard", "3 Golden Starfruit", "Celestial Starfruit", "x5 Tokyo Key: Rainbow" };

            for (int i = 0; i < rolls; i++)
            {
                if (selBox.Equals("Gift Box (Summer)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + summerGiftBox[Rng.Next(summerGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Spookfest)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + spookfestBox[Rng.Next(spookfestBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Leon's Super Surprise)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + foxDeluxeSurpriseBox[Rng.Next(foxDeluxeSurpriseBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Anniversary II)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + anniversaryBox[Rng.Next(anniversaryBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Champion)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + championGiftBox[Rng.Next(championGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Friendship)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + friendGiftBox[Rng.Next(friendGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Fall)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + fallGiftBox[Rng.Next(fallGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Winter)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + winterGiftBox[Rng.Next(winterGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Heart)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + heartGiftBox[Rng.Next(heartGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Spring)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + springGiftBox[Rng.Next(springGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Lucky)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + luckyGiftBox[Rng.Next(luckyGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Birthday)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + birthdayGiftBox[Rng.Next(birthdayGiftBox.Length)];
                }
            }
            //completion.Play();
        }


        private void EnemSpawnerSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void EnemSpawnExecute_Click(object sender, EventArgs e)
        {
            bttnClick.Play();
            EnemySpawnerOutput.Text = "Generating Foes...";
            // Enemy Spawn operations are here, same format as before, variables on top.
            string placeBox = PlaceSelectorEnemSpn.Text;
            int enemCountTT = ((int)EnemySpawnCountTT.Value);
            Random Rng = new Random();

            // Arrays or tables, whatever you want to call it. Same as above, add and remove things here.
            // Mirage Coastline
            string[] mirageCoastlineLoot = { "" };
            string[] mirageCoastlineNorm = { "Barraskewda - Swift Swim \r\nAqua Jet \r\nBounce \r\nDrill Run \r\nPeck", "Dreadnaw - Strong Jaw \r\nJaw Lock \r\nLiquidation \r\nHead Smash \r\nGastro Acid", "Dewpider - Water Bubble \r\nSpider Web \r\nBug Bite \r\nToxic \r\nBubble Beam", "Alolan Raichu - Surge Surfer \r\nPsychic \r\nElectric Terrain \r\nThunder \r\nSurf", "Rain Slime - Rain Dish \r\nRain Dance \r\nPounce \r\nCharm \r\nWater Gun" };
            string[] mirageCoastlineBoss = { "Luminos - Blinding Body \r\nThundaga \r\nWhirlpool \r\nBaneful Bunker \r\nVenom Drench \r\nReflect \r\nLight Screen \r\nSummon" };
            // Lonesome Resort
            string[] lonesomeResortLoot = { "" };
            string[] lonesomeResortNorm = { "> Mimikyu - Disguise \r\nCopycat \r\nShadow Claw \r\nPlay Rough \r\nConfide", "> Chandelure - Flash Fire \r\nWill O Wisp \r\nFlame Burst \r\nHaze \r\nCurse", "> Sinistea Swarm (1-3) - Weak Armor \r\nMega Drain \r\nWithdraw \r\nMemento", "> Shuppet Swarm (3-5) - Insomnia \r\nTorment \r\nHeadbutt \r\nDark Pulse", "> Spinarak Swarm (3-5) - Insomnia \r\nString Shot \r\nInfestation \r\nToxic Thread" };
            string[] lonesomeResortBoss = { "> Froslass(Eximus) - Cursed Body + 50 % \r\nDraining Kiss \r\nBlizzard \r\nSignal Beam \r\nFlash \r\nShadow Ball", " > Polteageist - Cursed Body + 50 % \r\nStrength Sap \r\nAromatherapy \r\nReflect \r\nLight Screen \r\nPsychic" };
            // Anville Void
            string[] anvilleLootTable = { "Oran Berry", "Pecha Berry", "Heccin Lolipop" };
            string[] anvilleTownVoidNorm = { "Slime - None \r\nTackle \r\nCall \r\nBite \r\nCharm", "Nickit - Run Away \r\nNight Slash \r\nThief \r\nQuick Attack \r\nHowl", "Gurdurr - Guts \r\nBulk Up \r\nSuperpower \r\nBlock \r\nThunder Punch", "Starly - Keen Eye \r\nAerial Ace x2 \r\nDouble Team \r\nSteel Wing \r\nAstonish x2", "Happiny - Serene Grace \r\nSweet Kiss \r\nAromatherapy \r\nHeadbutt \r\nWater Pulse" };
            string[] anvilleTownVoidBoss = { "" };

            for (int i = 0; i < enemCountTT; i++)
            {
                if (placeBox.Equals("Anville Town (Void Mission)"))
                {
                    System.Threading.Thread.Sleep(15);
                    if (EnemSpawnerSettings.GetItemChecked(1).Equals(true))
                    {
                        EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + Environment.NewLine + anvilleTownVoidBoss[Rng.Next(anvilleTownVoidBoss.Length)];
                        break;
                    }

                    EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + Environment.NewLine + anvilleTownVoidNorm[Rng.Next(anvilleTownVoidNorm.Length)];
                    if (EnemSpawnerSettings.GetItemChecked(0).Equals(true))
                    {
                        System.Threading.Thread.Sleep(15);
                        EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + "Loot Drop: " + anvilleLootTable[Rng.Next(anvilleLootTable.Length)] + Environment.NewLine;
                    }
                }
                else if (placeBox.Equals("Lonesome Resort"))
                {
                    System.Threading.Thread.Sleep(15);
                    if (EnemSpawnerSettings.GetItemChecked(1).Equals(true))
                    {
                        if (Rng.Next(100) < 25)
                        {
                            EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + Environment.NewLine + lonesomeResortBoss[Rng.Next(lonesomeResortBoss.Length)];
                            break;
                        }
                        EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + Environment.NewLine + lonesomeResortNorm[Rng.Next(lonesomeResortNorm.Length)];
                        if (EnemSpawnerSettings.GetItemChecked(0).Equals(true))
                        {
                            System.Threading.Thread.Sleep(15);
                            EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + "Loot Drop: " + lonesomeResortLoot[Rng.Next(lonesomeResortLoot.Length)] + Environment.NewLine;
                        }
                    }
                    else
                    {
                        EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + Environment.NewLine + lonesomeResortNorm[Rng.Next(lonesomeResortNorm.Length)];
                        if (EnemSpawnerSettings.GetItemChecked(0).Equals(true))
                        {
                            System.Threading.Thread.Sleep(15);
                            EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + "Loot Drop: " + lonesomeResortLoot[Rng.Next(lonesomeResortLoot.Length)] + Environment.NewLine;
                        }
                    }
                }
                else if (placeBox.Equals("Mirage Coastline"))
                {
                    System.Threading.Thread.Sleep(15);
                    if (EnemSpawnerSettings.GetItemChecked(1).Equals(true)) 
                    {
                        EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + Environment.NewLine + mirageCoastlineBoss[Rng.Next(mirageCoastlineBoss.Length)];
                        break;
                    }

                    EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + Environment.NewLine + mirageCoastlineNorm[Rng.Next(mirageCoastlineNorm.Length)];
                    if (EnemSpawnerSettings.GetItemChecked(0).Equals(true))
                    {
                        System.Threading.Thread.Sleep(15);
                        EnemySpawnerOutput.Text = EnemySpawnerOutput.Text + Environment.NewLine + "Loot Drop: " + mirageCoastlineLoot[Rng.Next(mirageCoastlineLoot.Length)] + Environment.NewLine;
                    }
                }
            }
        }

        // ETERNA PANEL STUFF


        // Store Inventory Generator
        private void Eterna_StoreGenerateButton_Click(object sender, EventArgs e)
        {
            bttnClick.Play();
            // Variables as usual, core ones though
            Eterna_StoreOutput.Text = "**Store Inventory | Cycled on: " + System.DateTime.Now.Date + "**" + Environment.NewLine;
            int storeInventory = ((int)Eterna_StoreNumOfItems.Value);
            bool rareToggle = Eterna_StoreRareItemToggle.Checked;
            string storeEvent = Eterna_StoreEvent.Text;
            var storeSettingsBerry = Eterna_StoreGenSettings.GetItemChecked(0); // 0 - Berries  |  1 - Scarfs  |  2 - Orbs  |  3 - Powerups  | | This part handles setting checkboxes. If new goods types are added, add a line here with "var storeSettingsBerry = Eterna_StoreGenSettings.GetItemChecked(#)" going up by one.
            var storeSettingsScarf = Eterna_StoreGenSettings.GetItemChecked(1);
            var storeSettingsOrb = Eterna_StoreGenSettings.GetItemChecked(2);
            var storeSettingsPowerups = Eterna_StoreGenSettings.GetItemChecked(3);
            var storeSettingsSeeds = Eterna_StoreGenSettings.GetItemChecked(4);
            Random Rng = new Random();

            // The ones you can change
            string[] berries = { "Oran Berry - 100", "Pecha Berry - 60", "Cheri Berry - 60", "Chesto Berry - 60", "Rawst Berry - 60", "Aspear Berry - 60", "Perism Berry - 60" };
            string[] rareBerries = { "Chilan Berry - 400", "Kee Berry - 300", "Lansat Berry - 280", "Leppa Berry - 110", "Lum Berry - 80" };
            string[] scarfs = { "Pecha Scarf - 1200", "Defense Scarf - 2000", "Special Band - 4000", "Power Band - 1000", "Heal Ribbon - 1100", "Prosper Ribbon - 4300" };
            string[] rareScarfs = { "Perism Scarf - 1500", "Coalition Scarf - 6200", "Choice Ribbon - 3000", "Efficient Bandanna - 3200" };
            string[] orbs = { "Blowback Orb - 300", "Decoy Orb - 300", "Escape Orb - 650", "Evasion Orb - 120", "Hail Orb - 320", "Health Orb - 460", "Lasso Orb - 260", "Petrify Orb - 2780", "Radar Orb - 1500", "Rainy Orb - 320", "Totter Orb - 2780" };
            string[] rareOrbs = { "All Dodge Orb - 3480", "All-Mach Orb - 2460", "All Protect Orb - 1600", "Foe Fear Orb - 1440", "Foe Hold Orb - 1620", "Itemizer Orb - 1200", "Invisify Orb - 6000", "Revive All Orb - 2600" };
            string[] powerups = {  };
            string[] seeds = { "Plain Seed - 50", "Blast Seed - 220", "Heal Seed - 150", "Energy Seed - 130", "Quick Seed - 200", "Sleep Seed - 200", "Stun Seed - 200", "Warp Seed - 450" };
            string[] rareSeeds = { "Violent Seed - 800", "Vile Seed - 1000", "Totter Seed - 300", "Reviver Seed - 800" };

            // Actual script stuff
            if (storeEvent.Equals("Berries Half Off"))
            {
                Eterna_StoreOutput.Text = Eterna_StoreOutput.Text + "All berries are half off! Enjoy great prices while supplies last!!!" + Environment.NewLine;
            }
            else if (storeEvent.Equals("Scarfs Half Off"))
            {
                Eterna_StoreOutput.Text = Eterna_StoreOutput.Text + "Our scarf manufactures have experienced a boom in business and have offered us limited time prices which we are now passing on to you! All scarfs are half off!" + Environment.NewLine;
            }
            else if (storeEvent.Equals("Orbs Half Off"))
            {
                Eterna_StoreOutput.Text = Eterna_StoreOutput.Text + "One of our crazy exploreres seemed to strike lucky and sold us more orbs than we can carry. All orbs are half off while we clear out some inventory!" + Environment.NewLine;
            }
            else if (storeEvent.Equals("Activated Orbs"))
            {
                Eterna_StoreOutput.Text = Eterna_StoreOutput.Text + "An anomaly in transit has resulted in orbs becoming activated. All orbs sold now are stronger than they usually are, handle with caution." + Environment.NewLine;
            }
            else if (storeEvent.Equals("Firesale"))
            {
                Eterna_StoreOutput.Text = Eterna_StoreOutput.Text + "Everything must go! These insane deals don't happen all the time! **All items are 25% their usual price!!!** Take it all!!!" + Environment.NewLine;
            }
            Eterna_StoreOutput.Text = Eterna_StoreOutput.Text + Environment.NewLine;

            List<string> mergedItems = new List<string>();
            if (storeSettingsBerry.Equals(true))
            {
                mergedItems.AddRange(berries);
                if (rareToggle.Equals(true))
                { mergedItems.AddRange(rareBerries); }
            }
            if (storeSettingsScarf.Equals(true))
            {
                mergedItems.AddRange(scarfs);
                if (rareToggle.Equals(true))
                { mergedItems.AddRange(rareScarfs); }
            }
            if (storeSettingsOrb.Equals(true))
            {
                mergedItems.AddRange(orbs);
                if (rareToggle.Equals(true))
                { mergedItems.AddRange(rareOrbs); }
            }

            if (storeSettingsPowerups.Equals(true))
            {
                mergedItems.AddRange(powerups);
                // if (rareToggle.Equals(true))
                // { mergedItems.AddRange(rareScarfs); }
            }

            if (storeSettingsSeeds.Equals(true))
            {
                mergedItems.AddRange(seeds);
                if (rareToggle.Equals(true))
                { mergedItems.AddRange(rareSeeds); }
            }

            for (int i = 0; i < storeInventory; i++ )
            {
                Eterna_StoreOutput.Text = Eterna_StoreOutput.Text + mergedItems[Rng.Next(mergedItems.Count)]+ ":pokemoney:" + Environment.NewLine;
            }
        }

        // Job Generator
        private void Eterna_JobExecuteGeneration_Click(object sender, EventArgs e)
        {
            bttnClick.Play();
            Eterna_JobOutput.Text = "";
            string jobLocation = Eterna_JobLocation.Text;
            string jobType = Eterna_JobType.Text;
            string jobBy = Eterna_JobIssuedBy.Text;
            int jobPay = ((int)Eterna_JobPay.Value);
            var toughBoss = Eterna_JobModifiers.GetItemChecked(0);
            var envHazard = Eterna_JobModifiers.GetItemChecked(1);
            var highValueTarget = Eterna_JobModifiers.GetItemChecked(2);

            string[] explorationHeader = { "Exploration of: ", "Mapping of: ", "Focused Observation of: ", "Discovery of: ", "Analysis of: " };
            string[] explorationL1 = { };
            string[] explorationL2 = { };
            string[] rescueHeader = { "Lost Pokemon at: ", "Rescue at: ", "Pokemon Stuck at: ", "Immediate Rescue Requested at: ", "I Can't Escape: " };
            string[] rescueL1 = { };
            string[] rescueL2 = { };
            string[] itemFetchHeader = { "Item Recovery at: ", "Find Lost Item at: ", "Lost and Found Services for: ", "Item Retrieval at: ", "Dropped Item at: " };
            string[] itemFetchL1 = { };
            string[] itemFetchL2 = { };
            string[] escortHeader = { "Bodyguard Wanted at: ", "Protection Services Requested at: ", "Assist my travels through: ", "Escort Me Through: " };
            string[] escortL1 = { };
            string[] escortL2 = { };
            string[] outlawHeader = { };
            string[] outlawL1 = { };
            string[] outlawL2 = { };
            string[] resourceHeader = { };
            string[] resourceL1 = { };
            string[] resourceSurvHeader = { };
            string[] resourceSurvL1 = { };

            string[] highVTLines = { };
            string[] envHazardLines = { };
            string[] toughBossLines = { };
        }
    }
}
