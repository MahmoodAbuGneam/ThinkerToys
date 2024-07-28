using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;


namespace ThinkerToys
{
    public partial class StoreSectForm1 : Form
    {
        private Market market;
        private int storeCoins = 400;

        //To-Do:
        //1.Change the storeCoins to real user storeCoins 
        //     storeCoins=UserSession.Instance.Coins;
        //2.Create new Field to the user to store the purchased Items 
        //        private Dictionary<string, int> storePurchasedItems = new Dictionary<string, int>();
        //3.Display Username:
        //          storeSectionlabel1.Text=UserSession.Instance.Username;
        //4.Complete Logout button fuction

        private Dictionary<string, int> storePurchasedItems = new Dictionary<string, int>();

        public StoreSectForm1()
        {
            InitializeComponent();
            market = new Market();
            LoadAllItems();
            storeCoinsValueLabel.Text = storeCoins.ToString();
            updateRealUserCoins();
        }
        private void updateRealUserCoins()
        {
            UserSession.Instance.Coins = storeCoins;
        }

        private void LoadAllItems()
        {
            Bitmap hulk = Properties.Resources.angry_hulk_ready_for_battle_marvel_sticker;
            Bitmap toySet1 = Properties.Resources.hand_drawn_flat_christmas_toys_collection;
            Bitmap yellowHat = Properties.Resources.u93b_5ebo_210528;
            Bitmap sunglases = Properties.Resources._9036324;
            Bitmap spiderman = Properties.Resources.spider_man_head_blue_stroke_sticker;
            Bitmap toySet2 = Properties.Resources.girlsToys;
            Bitmap stickersSet1 = Properties.Resources.sticker_icons_hand_drawn_doodle;
            Bitmap stickersSet2 = Properties.Resources.sticker_icons_hand_drawn_doodle__1_;
            Bitmap toysSet3 = Properties.Resources.christmas_toy_collection_flat_design;
            Bitmap superGirl = Properties.Resources.young_superhero_girl_costume;
            Bitmap girlsStickers = Properties.Resources.funny_stickers_collection;
            Bitmap tiddyBear = Properties.Resources.teddy_bear__1_;
            Bitmap teddyBear = Properties.Resources.teddy_bear;
            //new
            Bitmap keep_learning = Properties.Resources.learning;
            Bitmap be_creative = Properties.Resources.light_bulb;
            Bitmap think_different = Properties.Resources.think_different;
            Bitmap gold_star = Properties.Resources.gold_star;
            Bitmap super_cat = Properties.Resources.superCat;
            Bitmap super_unicorn = Properties.Resources.superUnicorn;
            Bitmap super_woman = Properties.Resources.superwoman;
            Bitmap baby_shoes = Properties.Resources.baby_shoes;
            Bitmap shoess = Properties.Resources.shoes;
            Bitmap yoyoo = Properties.Resources.yoyo;
            Bitmap microphone = Properties.Resources.microphones;
            Bitmap rocking_horse = Properties.Resources.rocking_horse;
            Bitmap roboot = Properties.Resources.robot;


            market.AddItem(new Item("Hulk", 30, "Heroes", hulk, ItemBuy_Click));
            market.AddItem(new Item("Toy-Set1", 5, "Toys", toySet1, ItemBuy_Click));
            market.AddItem(new Item("Yellow Hat", 20, "Clothes", yellowHat, ItemBuy_Click));
            market.AddItem(new Item("Sunglasses", 10, "Clothes", sunglases, ItemBuy_Click));
            market.AddItem(new Item("Spider-Man", 50, "Heroes", spiderman, ItemBuy_Click));
            market.AddItem(new Item("Toy-Set2", 5, "Toys", toySet2, ItemBuy_Click));
            market.AddItem(new Item("Stickers-Set1", 15, "Stickers", stickersSet1, ItemBuy_Click));
            market.AddItem(new Item("Stickers-Set2", 10, "Stickers", stickersSet2, ItemBuy_Click));
            market.AddItem(new Item("Toy-Set3", 20, "Toys", toysSet3, ItemBuy_Click));
            market.AddItem(new Item("Super-Girl", 30, "Heroes", superGirl, ItemBuy_Click));
            market.AddItem(new Item("Stickers-Set3", 10, "Stickers", girlsStickers, ItemBuy_Click));
            market.AddItem(new Item("Teddy-Bear", 20, "Toys", tiddyBear, ItemBuy_Click));
            market.AddItem(new Item("keep-Learning", 20, "Stickers", keep_learning, ItemBuy_Click));
            market.AddItem(new Item("Be-Creative", 20, "Stickers", be_creative, ItemBuy_Click));
            market.AddItem(new Item("Think-Different", 20, "Stickers", think_different, ItemBuy_Click));
            market.AddItem(new Item("Gold-Star", 20, "Stickers", gold_star, ItemBuy_Click));
            market.AddItem(new Item("Super-Cat", 20, "Heroes", super_cat, ItemBuy_Click));
            market.AddItem(new Item("Super-Unicorn", 20, "Heroes", super_unicorn, ItemBuy_Click));
            market.AddItem(new Item("Super-Woman", 20, "Heroes", super_woman, ItemBuy_Click));
            market.AddItem(new Item("Baby-Shoes", 20, "Clothes", baby_shoes, ItemBuy_Click));
            market.AddItem(new Item("Shoes", 20, "Clothes", shoess, ItemBuy_Click));
            market.AddItem(new Item("Yoyo", 20, "Toys", yoyoo, ItemBuy_Click));
            market.AddItem(new Item("Microphone", 20, "Toys", microphone, ItemBuy_Click));
            market.AddItem(new Item("Rocking-Horse", 20, "Toys", rocking_horse, ItemBuy_Click));
            market.AddItem(new Item("Robot", 20, "Toys", roboot, ItemBuy_Click));




            DisplayItems(market.GetAllItems());
        }

        private void ItemBuy_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string itemName = button.Tag.ToString();
                Item item = market.GetItem(itemName);
                if (item != null && storeCoins >= item.Price)
                {
                    storeCoins -= item.Price;
                    storeCoinsValueLabel.Text = storeCoins.ToString();

                    if (storePurchasedItems.ContainsKey(item.Name))
                    {
                        storePurchasedItems[item.Name]++;
                    }
                    else
                    {
                        storePurchasedItems[item.Name] = 1;
                    }

                    MessageBox.Show($"Purchased {item.Name}!");
                }
                else
                {
                    MessageBox.Show("Not enough storeCoins.");
                }
            }
            updateRealUserCoins();
        }

        private void DisplayItems(List<Item> items)
        {
            Storepanel1.Controls.Clear();

            int x = 10;
            int y = 10;
            int margin = 10;

            foreach (var item in items)
            {
                Bunifu.Framework.UI.BunifuCards card = new Bunifu.Framework.UI.BunifuCards();
                card.Size = new Size(212, 300);
                card.Location = new Point(x, y);
                card.BorderRadius = 5;
                card.BottomSahddow = true;
                card.color = Color.RoyalBlue;
                card.LeftSahddow = false;
                card.RightSahddow = true;
                card.ShadowDepth = 50;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = item.Image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(190, 180);
                pictureBox.Location = new Point(11, 10);
                card.Controls.Add(pictureBox);

                Label titleLabel = new Label();
                titleLabel.Text = item.Name;
                titleLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular);
                titleLabel.ForeColor = SystemColors.ControlDarkDark;
                titleLabel.Location = new Point(11, 200);
                titleLabel.Size = new Size(190, 23);
                card.Controls.Add(titleLabel);

                Label categoryLabel = new Label();
                categoryLabel.Text = item.Category;
                categoryLabel.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
                categoryLabel.ForeColor = SystemColors.ControlDarkDark;
                categoryLabel.Location = new Point(11, 228);
                categoryLabel.Size = new Size(90, 16);
                card.Controls.Add(categoryLabel);

                Label priceLabel = new Label();
                priceLabel.Text = item.Price.ToString();
                priceLabel.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
                priceLabel.ForeColor = Color.DarkOrange;
                priceLabel.Location = new Point(150, 228);
                priceLabel.Size = new Size(50, 16);
                card.Controls.Add(priceLabel);

                Button buyButton = new Button();
                buyButton.Text = "BUY";
                buyButton.BackColor = Color.RoyalBlue;
                buyButton.FlatStyle = FlatStyle.Flat;
                buyButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
                buyButton.ForeColor = Color.White;
                buyButton.Size = new Size(212, 50);
                buyButton.Location = new Point(0, 250);
                buyButton.Tag = item.Name;
                buyButton.Click += new EventHandler(ItemBuy_Click);
                card.Controls.Add(buyButton);

                Storepanel1.Controls.Add(card);

                x += card.Width + margin;
                if (x + card.Width + margin > Storepanel1.Width)
                {
                    x = 10;
                    y += card.Height + margin;
                }
            }
        }

        private void DisplayPurchasedItems()
        {
            Storepanel1.Controls.Clear();

            int x = 10;
            int y = 10;
            int margin = 10;

            foreach (var kvp in storePurchasedItems)
            {
                string itemName = kvp.Key;
                int itemCount = kvp.Value;

                Item item = market.GetItem(itemName);
                if (item != null)
                {
                    Bunifu.Framework.UI.BunifuCards card = new Bunifu.Framework.UI.BunifuCards();
                    card.Size = new Size(212, 251);
                    card.Location = new Point(x, y);
                    card.BorderRadius = 5;
                    card.BottomSahddow = true;
                    card.color = Color.RoyalBlue;
                    card.LeftSahddow = false;
                    card.RightSahddow = true;
                    card.ShadowDepth = 50;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = item.Image;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Size = new Size(190, 180);
                    pictureBox.Location = new Point(11, 10);
                    card.Controls.Add(pictureBox);

                    Label titleLabel = new Label();
                    titleLabel.Text = item.Name;
                    titleLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular);
                    titleLabel.ForeColor = SystemColors.ControlDarkDark;
                    titleLabel.Location = new Point(11, 200);
                    titleLabel.Size = new Size(190, 23);
                    card.Controls.Add(titleLabel);

                    Label countLabel = new Label();
                    countLabel.Text = $"Count: {itemCount}";
                    countLabel.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
                    countLabel.ForeColor = SystemColors.ControlDarkDark;
                    countLabel.Location = new Point(11, 228);
                    countLabel.Size = new Size(190, 16);
                    card.Controls.Add(countLabel);

                    Storepanel1.Controls.Add(card);

                    x += card.Width + margin;
                    if (x + card.Width + margin > Storepanel1.Width)
                    {
                        x = 10;
                        y += card.Height + margin;
                    }
                }
            }
        }

        private void stHomeBtn_Click(object sender, EventArgs e)
        {
            //DisplayItems(market.GetAllItems());
            //To-Do:
            //Link this with Home-Page 
        }

        private void stClothesBtn_Click(object sender, EventArgs e)
        {
            DisplayItems(market.GetItemsByCategory("Clothes"));
        }

        private void stHeroessBtn_Click(object sender, EventArgs e)
        {
            DisplayItems(market.GetItemsByCategory("Heroes"));
        }

        private void stStickersBtn_Click(object sender, EventArgs e)
        {
            DisplayItems(market.GetItemsByCategory("Stickers"));
        }

        private void stToysBtn_Click(object sender, EventArgs e)
        {
            DisplayItems(market.GetItemsByCategory("Toys"));
        }

        private void StorePurhacedCard_Click(object sender, EventArgs e)
        {
            DisplayPurchasedItems();
        }

        private void StoreSectForm1_Load(object sender, EventArgs e)
        {
            DisplayItems(market.GetAllItems());
        }

        private void storeLogoutBtn_Click(object sender, EventArgs e)
        {
            //logoutButton_Click()(found in Homepage.cs)
        }

        private void storeUserImage_Click(object sender, EventArgs e)
        {
            //To-Do:
            //Link this with show profile
        }

        private void storeSectionlabel1_Click(object sender, EventArgs e)
        {
            //To-Do:
            //Link this with show profile and show the real username
        }

        private void storeAllItemsButton_Click(object sender, EventArgs e)
        {
            DisplayItems(market.GetAllItems());
        }
    }
}
