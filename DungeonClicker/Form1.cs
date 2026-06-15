using System.Diagnostics;


/* Some notes:
 *  - Form1 class handles all of the UI and user interaction
 *  - GameController handles all of the game logic
 *  - Because GameController can't update the UI, some upgrades had to be implemented in Form1.
 *    This could've been prevented with better planning of architecture, but it still works.
 *    
 * GUI items used:
 *  - LinkLabel, for going to the image source and for swapping 
 *    between scientific notation mode.
 *  - ComboBox, as a drop-down menu to select different minions
 *  - ListView, for displaying the number of each minion owned
 *  - TreeView, for categorizing upgrades by type
 */


namespace Assignment_7
{
    public partial class Form1 : Form
    {
        private GameController gameController;
        private System.Windows.Forms.Timer timer;
        private bool ScientificNotationMode;
        private int TimeElapsed;

        public Form1()
        {
            InitializeComponent();

            gameController = new GameController();
            ScientificNotationMode = false;

            TimeElapsed = 0;
            // Creating the timer, which loops every second and updates the coin counter
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Also updates the coins/sec and coins/click labels
        private void UpdateCoinCountLabel()
        {

            string coinCountText;
            if (ScientificNotationMode)
            {
                coinCountText = $"Coins: {gameController.CurrentCoins:E2}";
                CoinsPerSecLabel.Text = $"Coins/sec: {gameController.CoinsPerSecond:E2}";
                CoinsPerClickLabel.Text = $"Coins/click: {gameController.CoinsPerClick:E2}";

            }
            else
            {
                coinCountText = $"Coins: {gameController.CurrentCoins:N1}";
                CoinsPerSecLabel.Text = $"Coins/sec: {gameController.CoinsPerSecond:N1}";
                CoinsPerClickLabel.Text = $"Coins/click: {gameController.CoinsPerClick:N1}";
            }

            CoinCountLabel.Text = coinCountText;
            CoinCountShopLabel.Text = coinCountText;
            CoinCountUpgradesLabel.Text = coinCountText;
        }

        private void GoldCoinButton_Click(object sender, EventArgs e)
        {
            gameController.Click();
            UpdateCoinCountLabel();
            GoldCoinButtonAnimation();
        }

        private void SummoningSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string m = SummoningSelectionBox.Text;
            MinionStatsShopLabel.Text = $"Cost: {gameController.GetMinionCost(m)}\nCoins/sec: {gameController.GetMinionCoinsPerSec(m)}";
            MinionDescriptionLabel.Text = gameController.GetMinionDescription(m);
        }

        // For buying minions
        private void BuyButton_Click(object sender, EventArgs e)
        {
            string m = SummoningSelectionBox.Text;
            bool purchaseSuccess = gameController.Purchase(m);

            if (purchaseSuccess)
            {
                MinionStatsShopLabel.Text = $"Cost: {gameController.GetMinionCost(m)}\nCoins/sec: {gameController.GetMinionCoinsPerSec(m)}";

                // Updating the corresponding row
                ListViewItem row = MinionsOwnedListView.FindItemWithText(m);
                row.SubItems[1].Text = $"{gameController.Minions[m].Count}";
            }
        }

        // This runs every second
        private void Timer_Tick(object sender, EventArgs e)
        {
            gameController.GameTick();
            UpdateCoinCountLabel();
            TimeElapsed++;


            // If the player has the necromancer upgrade, activate its effects
            if (gameController.Upgrades["NecromancerUpgrade"].Owned && (TimeElapsed % 20 == 0))
            {
                NecromancerUpgrade();
            }

            if (gameController.Upgrades["DragonUpgrade"].Owned)
            {
                gameController.DragonUpgradeUpdate();
            }
        }

        // Manages the upgrade tree
        private void UpgradeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0) // If the chosen node is a parent node
            {
                UpgradeDescriptionLabel.Text = "Choose an upgrade to view its description.";
                return;
            }

            string chosenUpgrade = e.Node.Name;
            UpgradeDescriptionLabel.Text = gameController.GetUpgradeDescription(chosenUpgrade);
            UpdatePurchaseButton(chosenUpgrade);
        }

        // Updates the buy/purchase button based on whether an upgrade has been purchased or not
        private void UpdatePurchaseButton(string chosenUpgrade)
        {
            if (gameController.Upgrades[chosenUpgrade].Owned)
            {
                PurchaseButton.Text = "Bought";
                PurchaseButton.BackColor = Color.Gray;
            }
            else
            {
                PurchaseButton.Text = "Buy";
                PurchaseButton.BackColor = Color.CornflowerBlue;
            }
        }


        // For upgrades
        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            if (UpgradeTree.SelectedNode.Nodes.Count > 0) { return; }
            string chosenUpgrade = UpgradeTree.SelectedNode.Name;
            bool success = gameController.PurchaseUpgrade(chosenUpgrade);
            if (success)
            {
                UpgradeTree.SelectedNode.ForeColor = Color.Green;
                UpdatePurchaseButton(chosenUpgrade);
            }
        }

        private void CoinCountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScientificNotationMode = !ScientificNotationMode;
            UpdateCoinCountLabel();
        }

        private void DoubleCoinsCheat_Click(object sender, EventArgs e)
        {
            gameController.CurrentCoins *= 2;
        }

        private void ThousandCoinsCheat_Click(object sender, EventArgs e)
        {
            gameController.CurrentCoins += 1000;
        }

        // Causes the coin to "pulse" a bit when clicked
        private async Task GoldCoinButtonAnimation()
        {
            Size currentSize = GoldCoinButton.Size;

            GoldCoinButton.Size = new Size(currentSize.Width + 8, currentSize.Height + 8);

            await Task.Delay(50); // Waits about 0.05 seconds

            GoldCoinButton.Size = currentSize;
        }

        // Purchases 1 skeleton per necromancer owned -- must be handled in form class since GameController can't update the count table
        private void NecromancerUpgrade() 
        {
            for (int i=0; i < gameController.Minions["Necromancer"].Count; i++)
            {
                gameController.Purchase("Skeleton", true);
            }

            // Updating the corresponding row
            ListViewItem row = MinionsOwnedListView.FindItemWithText("Skeleton");
            row.SubItems[1].Text = $"{gameController.Minions["Skeleton"].Count}";
        }

        // Opens the specified link in the user's browser
        private void ImageAttributionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo p = new ProcessStartInfo
            {
                FileName = "https://raymanpc.com//wiki//en//File:SkullcoinHD.png",
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(p);
            ImageAttributionLinkLabel.LinkVisited = true;
        }

        // Allows switching between tabs with hotkeys 1, 2, 3, & 4
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    TabController.SelectedIndex = 0; break;
                case Keys.D2:
                    TabController.SelectedIndex = 1; break;
                case Keys.D3:
                    TabController.SelectedIndex = 2; break;
                case Keys.D4:
                    TabController.SelectedIndex = 3; break;
            }

        }
    }
}
