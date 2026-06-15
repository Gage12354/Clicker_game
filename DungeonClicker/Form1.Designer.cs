namespace Assignment_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Goblin", "0" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Skeleton", "0" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Gargoyle", "0" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Wizard", "0" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Ogre", "0" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Elemental", "0" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Dragon", "0" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "Necromancer", "0" }, -1);
            TreeNode treeNode1 = new TreeNode("(300) Bronze Mouse");
            TreeNode treeNode2 = new TreeNode("(2,000) Silver Mouse");
            TreeNode treeNode3 = new TreeNode("(10,000) Golden Mouse");
            TreeNode treeNode4 = new TreeNode("(25,000) Magic Mouse");
            TreeNode treeNode5 = new TreeNode("Mouse Upgrades", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("(300) (Goblin) Mythril Pickaxes");
            TreeNode treeNode7 = new TreeNode("(750) (Skeleton) Calcium Supplements");
            TreeNode treeNode8 = new TreeNode("(2,500) (Gargoyle) Swarm Tactics");
            TreeNode treeNode9 = new TreeNode("(7,500) (Wizard) Necromatic Apprentices");
            TreeNode treeNode10 = new TreeNode("(15,000) (Ogre) Goblin Leaders");
            TreeNode treeNode11 = new TreeNode("(50,000) (Elemental) Channeling");
            TreeNode treeNode12 = new TreeNode("(300,000) (Dragon) Gold Hoarders");
            TreeNode treeNode13 = new TreeNode("(1,500,000) (Necromancer) Undead Mastery");
            TreeNode treeNode14 = new TreeNode("Minion Upgrades", new TreeNode[] { treeNode6, treeNode7, treeNode8, treeNode9, treeNode10, treeNode11, treeNode12, treeNode13 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabController = new TabControl();
            Home = new TabPage();
            CoinsPerClickLabel = new Label();
            CoinsPerSecLabel = new Label();
            CoinCountLabel = new LinkLabel();
            CoinCountLabelOLD = new Label();
            GoldCoinButton = new Button();
            Shop = new TabPage();
            CoinCountShopLabel = new Label();
            BuyButton = new Button();
            MinionStatsShopLabel = new Label();
            MinionDescriptionLabel = new Label();
            label1 = new Label();
            SummoningSelectionBox = new ComboBox();
            MinionsOwnedListView = new ListView();
            Minion = new ColumnHeader();
            AmountOwned = new ColumnHeader();
            Upgrades = new TabPage();
            UpgradesLabel = new Label();
            CoinCountUpgradesLabel = new Label();
            PurchaseButton = new Button();
            UpgradeDescriptionLabel = new Label();
            UpgradeTree = new TreeView();
            Settings = new TabPage();
            label2 = new Label();
            ImageAttributionLinkLabel = new LinkLabel();
            ThousandCoinsCheat = new Button();
            CheatsLabel = new Label();
            DoubleCoinsCheat = new Button();
            TabController.SuspendLayout();
            Home.SuspendLayout();
            Shop.SuspendLayout();
            Upgrades.SuspendLayout();
            Settings.SuspendLayout();
            SuspendLayout();
            // 
            // TabController
            // 
            TabController.Controls.Add(Home);
            TabController.Controls.Add(Shop);
            TabController.Controls.Add(Upgrades);
            TabController.Controls.Add(Settings);
            TabController.Location = new Point(1, 0);
            TabController.Name = "TabController";
            TabController.SelectedIndex = 0;
            TabController.Size = new Size(801, 451);
            TabController.TabIndex = 0;
            // 
            // Home
            // 
            Home.BackColor = Color.Moccasin;
            Home.Controls.Add(CoinsPerClickLabel);
            Home.Controls.Add(CoinsPerSecLabel);
            Home.Controls.Add(CoinCountLabel);
            Home.Controls.Add(CoinCountLabelOLD);
            Home.Controls.Add(GoldCoinButton);
            Home.Location = new Point(4, 29);
            Home.Name = "Home";
            Home.Padding = new Padding(3);
            Home.Size = new Size(793, 418);
            Home.TabIndex = 1;
            Home.Text = "Home";
            // 
            // CoinsPerClickLabel
            // 
            CoinsPerClickLabel.AutoSize = true;
            CoinsPerClickLabel.Font = new Font("Elephant", 12F);
            CoinsPerClickLabel.Location = new Point(341, 259);
            CoinsPerClickLabel.Name = "CoinsPerClickLabel";
            CoinsPerClickLabel.Size = new Size(147, 26);
            CoinsPerClickLabel.TabIndex = 4;
            CoinsPerClickLabel.Text = "Coins/click: 1";
            // 
            // CoinsPerSecLabel
            // 
            CoinsPerSecLabel.AutoSize = true;
            CoinsPerSecLabel.Font = new Font("Elephant", 12F);
            CoinsPerSecLabel.Location = new Point(342, 209);
            CoinsPerSecLabel.Name = "CoinsPerSecLabel";
            CoinsPerSecLabel.Size = new Size(134, 26);
            CoinsPerSecLabel.TabIndex = 3;
            CoinsPerSecLabel.Text = "Coins/sec: 0";
            // 
            // CoinCountLabel
            // 
            CoinCountLabel.AutoSize = true;
            CoinCountLabel.Font = new Font("Elephant", 16F);
            CoinCountLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            CoinCountLabel.LinkColor = Color.Black;
            CoinCountLabel.Location = new Point(341, 154);
            CoinCountLabel.Name = "CoinCountLabel";
            CoinCountLabel.Size = new Size(126, 35);
            CoinCountLabel.TabIndex = 2;
            CoinCountLabel.TabStop = true;
            CoinCountLabel.Text = "Coins: 0";
            CoinCountLabel.LinkClicked += CoinCountLabel_LinkClicked;
            // 
            // CoinCountLabelOLD
            // 
            CoinCountLabelOLD.AutoSize = true;
            CoinCountLabelOLD.Font = new Font("Elephant", 16F);
            CoinCountLabelOLD.Location = new Point(574, 186);
            CoinCountLabelOLD.Name = "CoinCountLabelOLD";
            CoinCountLabelOLD.Size = new Size(0, 35);
            CoinCountLabelOLD.TabIndex = 1;
            // 
            // GoldCoinButton
            // 
            GoldCoinButton.BackgroundImage = Properties.Resources.SkeletonCoin;
            GoldCoinButton.BackgroundImageLayout = ImageLayout.Zoom;
            GoldCoinButton.FlatAppearance.BorderSize = 0;
            GoldCoinButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GoldCoinButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GoldCoinButton.FlatStyle = FlatStyle.Flat;
            GoldCoinButton.Location = new Point(97, 97);
            GoldCoinButton.Name = "GoldCoinButton";
            GoldCoinButton.Size = new Size(200, 200);
            GoldCoinButton.TabIndex = 0;
            GoldCoinButton.TabStop = false;
            GoldCoinButton.UseVisualStyleBackColor = true;
            GoldCoinButton.Click += GoldCoinButton_Click;
            // 
            // Shop
            // 
            Shop.BackColor = Color.Moccasin;
            Shop.Controls.Add(CoinCountShopLabel);
            Shop.Controls.Add(BuyButton);
            Shop.Controls.Add(MinionStatsShopLabel);
            Shop.Controls.Add(MinionDescriptionLabel);
            Shop.Controls.Add(label1);
            Shop.Controls.Add(SummoningSelectionBox);
            Shop.Controls.Add(MinionsOwnedListView);
            Shop.Location = new Point(4, 29);
            Shop.Name = "Shop";
            Shop.Padding = new Padding(3);
            Shop.Size = new Size(793, 418);
            Shop.TabIndex = 2;
            Shop.Text = "Shop";
            // 
            // CoinCountShopLabel
            // 
            CoinCountShopLabel.AutoSize = true;
            CoinCountShopLabel.Font = new Font("Elephant", 12F);
            CoinCountShopLabel.Location = new Point(22, 341);
            CoinCountShopLabel.Name = "CoinCountShopLabel";
            CoinCountShopLabel.Size = new Size(95, 26);
            CoinCountShopLabel.TabIndex = 6;
            CoinCountShopLabel.Text = "Coins: 0";
            // 
            // BuyButton
            // 
            BuyButton.BackColor = Color.CornflowerBlue;
            BuyButton.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            BuyButton.Location = new Point(59, 243);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(99, 48);
            BuyButton.TabIndex = 5;
            BuyButton.Text = "Buy";
            BuyButton.UseVisualStyleBackColor = false;
            BuyButton.Click += BuyButton_Click;
            // 
            // MinionStatsShopLabel
            // 
            MinionStatsShopLabel.AutoSize = true;
            MinionStatsShopLabel.Font = new Font("Century Schoolbook", 12F);
            MinionStatsShopLabel.Location = new Point(59, 172);
            MinionStatsShopLabel.Name = "MinionStatsShopLabel";
            MinionStatsShopLabel.Size = new Size(107, 69);
            MinionStatsShopLabel.TabIndex = 4;
            MinionStatsShopLabel.Text = "Cost: \r\nCoins/sec: \r\n\r\n";
            // 
            // MinionDescriptionLabel
            // 
            MinionDescriptionLabel.BackColor = SystemColors.Window;
            MinionDescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
            MinionDescriptionLabel.Font = new Font("Segoe UI", 11F);
            MinionDescriptionLabel.Location = new Point(316, 27);
            MinionDescriptionLabel.Name = "MinionDescriptionLabel";
            MinionDescriptionLabel.Size = new Size(183, 362);
            MinionDescriptionLabel.TabIndex = 3;
            MinionDescriptionLabel.Text = "Choose a minion to summon. Its description will appear here.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 14F, FontStyle.Bold);
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(225, 30);
            label1.TabIndex = 2;
            label1.Text = "Summoning Pool";
            // 
            // SummoningSelectionBox
            // 
            SummoningSelectionBox.Font = new Font("Segoe UI", 12F);
            SummoningSelectionBox.FormattingEnabled = true;
            SummoningSelectionBox.Items.AddRange(new object[] { "Goblin", "Skeleton", "Gargoyle", "Wizard", "Ogre", "Elemental", "Dragon", "Necromancer" });
            SummoningSelectionBox.Location = new Point(59, 114);
            SummoningSelectionBox.Name = "SummoningSelectionBox";
            SummoningSelectionBox.Size = new Size(184, 36);
            SummoningSelectionBox.TabIndex = 1;
            SummoningSelectionBox.SelectedIndexChanged += SummoningSelectionBox_SelectedIndexChanged;
            // 
            // MinionsOwnedListView
            // 
            MinionsOwnedListView.Columns.AddRange(new ColumnHeader[] { Minion, AmountOwned });
            MinionsOwnedListView.Font = new Font("Segoe UI", 10F);
            MinionsOwnedListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8 });
            MinionsOwnedListView.Location = new Point(505, 27);
            MinionsOwnedListView.Name = "MinionsOwnedListView";
            MinionsOwnedListView.Scrollable = false;
            MinionsOwnedListView.Size = new Size(282, 365);
            MinionsOwnedListView.TabIndex = 0;
            MinionsOwnedListView.UseCompatibleStateImageBehavior = false;
            MinionsOwnedListView.View = View.Details;
            // 
            // Minion
            // 
            Minion.Text = "Minion";
            Minion.Width = 120;
            // 
            // AmountOwned
            // 
            AmountOwned.Text = "Amount Owned";
            AmountOwned.Width = 200;
            // 
            // Upgrades
            // 
            Upgrades.BackColor = Color.Moccasin;
            Upgrades.Controls.Add(UpgradesLabel);
            Upgrades.Controls.Add(CoinCountUpgradesLabel);
            Upgrades.Controls.Add(PurchaseButton);
            Upgrades.Controls.Add(UpgradeDescriptionLabel);
            Upgrades.Controls.Add(UpgradeTree);
            Upgrades.Location = new Point(4, 29);
            Upgrades.Name = "Upgrades";
            Upgrades.Size = new Size(793, 418);
            Upgrades.TabIndex = 3;
            Upgrades.Text = "Upgrades";
            // 
            // UpgradesLabel
            // 
            UpgradesLabel.AutoSize = true;
            UpgradesLabel.Font = new Font("Century Schoolbook", 14F, FontStyle.Bold);
            UpgradesLabel.Location = new Point(37, 11);
            UpgradesLabel.Name = "UpgradesLabel";
            UpgradesLabel.Size = new Size(133, 30);
            UpgradesLabel.TabIndex = 5;
            UpgradesLabel.Text = "Upgrades";
            // 
            // CoinCountUpgradesLabel
            // 
            CoinCountUpgradesLabel.AutoSize = true;
            CoinCountUpgradesLabel.Font = new Font("Elephant", 12F);
            CoinCountUpgradesLabel.Location = new Point(397, 319);
            CoinCountUpgradesLabel.Name = "CoinCountUpgradesLabel";
            CoinCountUpgradesLabel.Size = new Size(95, 26);
            CoinCountUpgradesLabel.TabIndex = 4;
            CoinCountUpgradesLabel.Text = "Coins: 0";
            // 
            // PurchaseButton
            // 
            PurchaseButton.BackColor = Color.CornflowerBlue;
            PurchaseButton.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            PurchaseButton.ForeColor = SystemColors.ButtonHighlight;
            PurchaseButton.Location = new Point(634, 319);
            PurchaseButton.Name = "PurchaseButton";
            PurchaseButton.Size = new Size(137, 48);
            PurchaseButton.TabIndex = 3;
            PurchaseButton.Text = "Buy";
            PurchaseButton.UseVisualStyleBackColor = false;
            PurchaseButton.Click += PurchaseButton_Click;
            // 
            // UpgradeDescriptionLabel
            // 
            UpgradeDescriptionLabel.BackColor = SystemColors.Window;
            UpgradeDescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
            UpgradeDescriptionLabel.Font = new Font("Segoe UI", 11F);
            UpgradeDescriptionLabel.Location = new Point(410, 48);
            UpgradeDescriptionLabel.Name = "UpgradeDescriptionLabel";
            UpgradeDescriptionLabel.Size = new Size(361, 243);
            UpgradeDescriptionLabel.TabIndex = 2;
            UpgradeDescriptionLabel.Text = "Choose an upgrade to view its description.";
            // 
            // UpgradeTree
            // 
            UpgradeTree.Location = new Point(34, 48);
            UpgradeTree.Name = "UpgradeTree";
            treeNode1.Name = "BronzeMouseUpgrade";
            treeNode1.Text = "(300) Bronze Mouse";
            treeNode2.Name = "SilverMouseUpgrade";
            treeNode2.Text = "(2,000) Silver Mouse";
            treeNode3.Name = "GoldenMouseUpgrade";
            treeNode3.Text = "(10,000) Golden Mouse";
            treeNode4.Name = "MagicMouseUpgrade";
            treeNode4.Text = "(25,000) Magic Mouse";
            treeNode5.Name = "MouseUpgrades";
            treeNode5.Text = "Mouse Upgrades";
            treeNode6.Name = "GoblinUpgrade";
            treeNode6.Text = "(300) (Goblin) Mythril Pickaxes";
            treeNode7.Name = "SkeletonUpgrade";
            treeNode7.Text = "(750) (Skeleton) Calcium Supplements";
            treeNode8.Name = "GargoyleUpgrade";
            treeNode8.Text = "(2,500) (Gargoyle) Swarm Tactics";
            treeNode9.Name = "WizardUpgrade";
            treeNode9.Text = "(7,500) (Wizard) Necromatic Apprentices";
            treeNode10.Name = "OgreUpgrade";
            treeNode10.Text = "(15,000) (Ogre) Goblin Leaders";
            treeNode11.Name = "ElementalUpgrade";
            treeNode11.Text = "(50,000) (Elemental) Channeling";
            treeNode12.Name = "DragonUpgrade";
            treeNode12.Text = "(300,000) (Dragon) Gold Hoarders";
            treeNode13.Name = "NecromancerUpgrade";
            treeNode13.Text = "(1,500,000) (Necromancer) Undead Mastery";
            treeNode14.Name = "MinionUpgrades";
            treeNode14.Text = "Minion Upgrades";
            UpgradeTree.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode14 });
            UpgradeTree.Size = new Size(353, 319);
            UpgradeTree.TabIndex = 1;
            UpgradeTree.AfterSelect += UpgradeTree_AfterSelect;
            // 
            // Settings
            // 
            Settings.BackColor = Color.Moccasin;
            Settings.Controls.Add(label2);
            Settings.Controls.Add(ImageAttributionLinkLabel);
            Settings.Controls.Add(ThousandCoinsCheat);
            Settings.Controls.Add(CheatsLabel);
            Settings.Controls.Add(DoubleCoinsCheat);
            Settings.Location = new Point(4, 29);
            Settings.Name = "Settings";
            Settings.Size = new Size(793, 418);
            Settings.TabIndex = 4;
            Settings.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 14F, FontStyle.Bold);
            label2.Location = new Point(348, 14);
            label2.Name = "label2";
            label2.Size = new Size(207, 30);
            label2.TabIndex = 4;
            label2.Text = "Info and Extras";
            // 
            // ImageAttributionLinkLabel
            // 
            ImageAttributionLinkLabel.AutoSize = true;
            ImageAttributionLinkLabel.LinkArea = new LinkArea(592, 17);
            ImageAttributionLinkLabel.Location = new Point(351, 50);
            ImageAttributionLinkLabel.Name = "ImageAttributionLinkLabel";
            ImageAttributionLinkLabel.Size = new Size(423, 364);
            ImageAttributionLinkLabel.TabIndex = 3;
            ImageAttributionLinkLabel.TabStop = true;
            ImageAttributionLinkLabel.Text = resources.GetString("ImageAttributionLinkLabel.Text");
            ImageAttributionLinkLabel.UseCompatibleTextRendering = true;
            ImageAttributionLinkLabel.LinkClicked += ImageAttributionLinkLabel_LinkClicked;
            // 
            // ThousandCoinsCheat
            // 
            ThousandCoinsCheat.Location = new Point(36, 230);
            ThousandCoinsCheat.Name = "ThousandCoinsCheat";
            ThousandCoinsCheat.Size = new Size(139, 86);
            ThousandCoinsCheat.TabIndex = 2;
            ThousandCoinsCheat.TabStop = false;
            ThousandCoinsCheat.Text = "+1000 Coins";
            ThousandCoinsCheat.UseVisualStyleBackColor = true;
            ThousandCoinsCheat.Click += ThousandCoinsCheat_Click;
            // 
            // CheatsLabel
            // 
            CheatsLabel.AutoSize = true;
            CheatsLabel.Font = new Font("Century Schoolbook", 14F, FontStyle.Bold);
            CheatsLabel.Location = new Point(36, 14);
            CheatsLabel.Name = "CheatsLabel";
            CheatsLabel.Size = new Size(99, 30);
            CheatsLabel.TabIndex = 1;
            CheatsLabel.Text = "Cheats";
            // 
            // DoubleCoinsCheat
            // 
            DoubleCoinsCheat.FlatAppearance.BorderSize = 0;
            DoubleCoinsCheat.Location = new Point(36, 112);
            DoubleCoinsCheat.Name = "DoubleCoinsCheat";
            DoubleCoinsCheat.Size = new Size(139, 86);
            DoubleCoinsCheat.TabIndex = 0;
            DoubleCoinsCheat.TabStop = false;
            DoubleCoinsCheat.Text = "Double Coins";
            DoubleCoinsCheat.UseVisualStyleBackColor = true;
            DoubleCoinsCheat.Click += DoubleCoinsCheat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabController);
            KeyPreview = true;
            Name = "Form1";
            Text = "Dungeon Clicker";
            KeyDown += Form1_KeyDown;
            TabController.ResumeLayout(false);
            Home.ResumeLayout(false);
            Home.PerformLayout();
            Shop.ResumeLayout(false);
            Shop.PerformLayout();
            Upgrades.ResumeLayout(false);
            Upgrades.PerformLayout();
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabController;
        private TabPage tabPage1;
        private TabPage Home;
        private TabPage Shop;
        private TabPage Upgrades;
        private TabPage Settings;
        private Button GoldCoinButton;
        private Label CoinCounterLinkLabel;
        private TreeView UpgradeTree;
        private ListView MinionsOwnedListView;
        private ColumnHeader Minion;
        private ColumnHeader AmountOwned;
        private ComboBox SummoningSelectionBox;
        private Label MinionDescriptionLabel;
        private Label label1;
        private Button BuyButton;
        private Label MinionStatsShopLabel;
        private Label UpgradeDescriptionLabel;
        private Button PurchaseButton;
        private Label CoinCountLabelOLD;
        private LinkLabel CoinCountLabel;
        private Button DoubleCoinsCheat;
        private Label CoinsPerSecLabel;
        private Label CoinCountShopLabel;
        private Label CoinCountUpgradesLabel;
        private Label UpgradesLabel;
        private Button ThousandCoinsCheat;
        private Label CheatsLabel;
        private LinkLabel ImageAttributionLinkLabel;
        private Label label2;
        private Label CoinsPerClickLabel;
    }
}
