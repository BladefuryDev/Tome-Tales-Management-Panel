using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tome_Tales_Management_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenBoxesExec_Click(object sender, EventArgs e)
        {
            LootBoxOutput.Text = "";
            // Loot Box management system here, change things as needed.
            string selBox = BoxSelectionDropdown.Text;
            int rolls = ((int)NumOfBoxes.Value);
            LootBoxOutput.Text = ("Opening " +rolls +" " +selBox +Environment.NewLine);

            // BOX TYPES | Add, remove and do whatever right here.
            string[] SummerGiftBox = { "Slime Egg :sparkles:", "5,000 BP", "Bamboo Rod", "Cooked Makiyoa", "Blue Pearl", "Golden Shell", "Red Coral" };
            string[] SpookfestBox = { "5 Krackle Berriy", "5 Glum Berry", "Radile Pop", "Krackle Drops", "3 Ether", "Minhtment", "5 Radile Berry", "Bitter Soul", "Sizzle Pop", "Freezle Gum", "Haunt Attack :warning:", "Sour Soul", "5 Freezle Berry", "Glum Gum", "5 Sizzle Berry", "6,500 BP!", "Nymare Ambush :warning:", "Sweet Soul", "5 Minht Berry", "3 Health Potion" };
            string[] FoxDeluxeSurpriseBox = { "Companion Card: Bolt", "Velgha", "Golden Egg :sparkles:", "Super Kaboom", "Tokyo Key: Rainbow", "Slime Egg :sparkles:", "3 Leonade Deluxe", "Nodakime Nageku", "Job Bonus Key: Synergist Knight", "Companion Card: Aka", "50k BP!!!", "10 Golden Key!", "3 Companion Card: Leon", "Freeze Blast", "Nova Dominus", "Job Bonus Key: Guardian", "Rainbow Egg :sparkles:", "5 Diamond Key", "Foxxo Mode! :fox:", "Companion Card: Weiss", "Bouncy Time!", "Arma Gem", "Rappy Fever!", "Haunt Assault :warning:", "3 Job Token", "Nymare Onslaught :warning:", "Companion Card: Silene", "Gambler Pass", "Dread King's Arrival :warning:", "Double Double Mode!", "Altar Spin", "Slime Rampage", "25k BP!!!", "Bandit Attack! :warning:", "Jackpot!!!", "5 Job Token", "Job Key: Astrologian", "Rappy Egg! :sparkles:", "Companion Card: Lea", "Companion Card: Kumiki", "25 Asterisk Shards", "Radiant Virtue"};
            string[] AnniversaryBox = { "5 Slumber Orb", "5 Totter Orb", "10 Oracle Berry", "Diamond Key", "5 Silver Key", "5 Golden Key", "Old Scarf", "5 Sandy Orb", "5 Rainy Orb", "5 Sunny Orb", "20k BP!!!", "Golden Egg!!! :sparkles:", "25 Asterisk Shards", "15k BP!!", "Contract", "3 Revive All Orb" };

            for (int i = 0; i < rolls; i++)
            {

                Random BoxRnd = new Random();
                if (selBox.Equals("Gift Box (Summer)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + SummerGiftBox[BoxRnd.Next(SummerGiftBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Spookfest)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + SpookfestBox[BoxRnd.Next(SpookfestBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Leon's Super Surprise)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + FoxDeluxeSurpriseBox[BoxRnd.Next(FoxDeluxeSurpriseBox.Length)];
                }
                else if (selBox.Equals("Gift Box (Anniversary II)"))
                {
                    System.Threading.Thread.Sleep(15);
                    LootBoxOutput.Text = LootBoxOutput.Text + Environment.NewLine + AnniversaryBox[BoxRnd.Next(AnniversaryBox.Length)];
                }
            }
        }
    }
}
