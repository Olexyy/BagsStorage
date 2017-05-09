using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BagsStorage
{

    public partial class BagsStorageForm : Form
    {
        private BagsStorage BagsStorage { get; set; }
        public BagsStorageForm()
        {
            this.InitializeComponent();
            this.BagsStorage = new BagsStorage(this.BagsStorageEventHandler);
            this.comboBoxBagItemType.Items.AddRange(BagsStorage.BagItemTypes.ToArray());
            this.comboBoxBagItemType.SelectedIndex = 0;
            this.comboBoxSizesTypes.Items.AddRange(BagsStorage.BagItemSizes.Keys.ToArray());
            this.comboBoxSizesTypes.SelectedIndex = 0;
            this.comboBoxSizeFrom.Items.AddRange(BagsStorage.BagItemSizes["Взуття"].ToArray());
            this.comboBoxSizeFrom.SelectedIndex = 0;
            this.comboBoxSizeTo.Items.AddRange(BagsStorage.BagItemSizes["Взуття"].ToArray());
            this.comboBoxSizeTo.SelectedIndex = 0;
        }
        private void BagsStorageEventHandler(object sender, BagsStorgeEventArgs args)
        {
            this.toolStripStatusMessage.Text = args.Message;
            this.ProcessBags(args.Bags);
            if (this.listViewBagDetails.Tag != null)
                this.ShowBag(this.listViewBagDetails.Tag as Bag);
        }
        private void ProcessBags(List<Bag> bags)
        {
            this.listViewBags.Items.Clear();
            bags.ForEach(i => this.LoadBag(i));
        }
        private void LoadBag(Bag bag)
        {
            ListViewItem item = new ListViewItem("Номер: " + bag.Id.ToString() + ", назва: " + bag.Name);
            item.Tag = bag;
            this.listViewBags.Items.Add(item);
        }
        private void LoadBagItem(BagItem bagItem)
        {
            ListViewItem item = new ListViewItem("Номер: " + bagItem.Id.ToString() + ", назва: " + bagItem.Type);
            item.Tag = bagItem;
            this.listViewBagDetails.Items.Add(item);
        }
        private void RemoveBag(Bag bag)
        {
            this.BagsStorage.RemoveBag(bag);
        }
        private void ChangeBag(Bag bag, string name)
        {
            this.BagsStorage.ChangeBag(bag, name);
        }
        private void AddBag(string name)
        {
            this.BagsStorage.AddBag(name);
        }
        private void ShowBag(Bag bag)
        {
            this.listViewBagDetails.Items.Clear();
            this.listViewBagDetails.Tag = bag;
            bag.Items.ForEach(i => this.LoadBagItem(i));
        }
        private void AddBagItem(Bag bag)
        {
            this.BagsStorage.AddBagItem(bag.Id, this.comboBoxBagItemType.SelectedItem.ToString(), this.comboBoxSizesTypes.SelectedItem.ToString(), this.comboBoxSizeFrom.SelectedItem.ToString(), 
                this.comboBoxSizeTo.SelectedItem.ToString(), this.textBoxDetails.Text );
        }
        private void UpdateBagItem(Bag bag, BagItem bagItem)
        {
            this.BagsStorage.UpdateBagItem(bag.Id, bagItem.Id, this.comboBoxBagItemType.SelectedItem.ToString(), this.comboBoxSizesTypes.SelectedItem.ToString(), this.comboBoxSizeFrom.SelectedItem.ToString(),
                this.comboBoxSizeTo.SelectedItem.ToString(), this.textBoxDetails.Text);
        }
        private void ShowBagItem(BagItem bagItem)
        {
            this.comboBoxBagItemType.SelectedIndex = BagsStorage.BagItemTypes.IndexOf(bagItem.Type);
            this.comboBoxSizesTypes.SelectedIndex = BagsStorage.BagItemSizes.Keys.ToList().IndexOf(bagItem.SizeType);
            this.comboBoxSizeFrom.SelectedIndex = BagsStorage.BagItemSizes[bagItem.SizeType].IndexOf(bagItem.SizeFrom);
            this.comboBoxSizeTo.SelectedIndex = BagsStorage.BagItemSizes[bagItem.SizeType].IndexOf(bagItem.SizeTo);
            this.textBoxDetails.Text = bagItem.Details;
        }
        // Event handlers //
        private void buttonAddBag_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBoxNewBagName.Text) &&
                this.textBoxNewBagName.Text != "назва мішка...")
            {
                this.AddBag(this.textBoxNewBagName.Text);
                this.textBoxNewBagName.Text = "назва мішка...";
            }
            else
                this.toolStripStatusMessage.Text = "Введіть назву нового мішка.";
        }
        private void buttonRemoveBag_Click(object sender, EventArgs e)
        {
            if (this.listViewBags.SelectedItems.Count == 1)
                this.RemoveBag(this.listViewBags.SelectedItems[0].Tag as Bag);
        }
        private void listViewBags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewBags.SelectedItems.Count == 1)
                this.ShowBag(this.listViewBags.SelectedItems[0].Tag as Bag);
        }
        private void buttonAddBagItem_Click(object sender, EventArgs e)
        {
            if (this.listViewBags.SelectedItems.Count == 1)
                this.AddBagItem(this.listViewBags.SelectedItems[0].Tag as Bag);
            else
                this.toolStripStatusMessage.Text = "Оберіть мішок.";
        }
        private void listViewBagDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewBagDetails.SelectedItems.Count == 1)
                this.ShowBagItem(this.listViewBagDetails.SelectedItems[0].Tag as BagItem);
        }
        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if(this.listViewBagDetails.SelectedItems.Count == 1)
                this.BagsStorage.RemoveBagItem((this.listViewBagDetails.Tag as Bag).Id, (this.listViewBagDetails.SelectedItems[0].Tag as BagItem).Id);
            else
                this.toolStripStatusMessage.Text = "Оберіть мотлох.";
        }
        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            if (this.listViewBagDetails.SelectedItems.Count == 1)
                this.UpdateBagItem(this.listViewBagDetails.Tag as Bag, this.listViewBagDetails.SelectedItems[0].Tag as BagItem);
            else
                this.toolStripStatusMessage.Text = "Оберіть мотлох.";
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxSizesTypes.SelectedIndex != -1)
            {
                this.comboBoxSizeFrom.Items.Clear();
                this.comboBoxSizeFrom.Items.AddRange(BagsStorage.BagItemSizes[this.comboBoxSizesTypes.SelectedItem.ToString()].ToArray());
                this.comboBoxSizeFrom.SelectedIndex = 0;
                this.comboBoxSizeTo.Items.Clear();
                this.comboBoxSizeTo.Items.AddRange(BagsStorage.BagItemSizes[this.comboBoxSizesTypes.SelectedItem.ToString()].ToArray());
                this.comboBoxSizeTo.SelectedIndex = 0;
            }
        }

        private void buttonChangeBag_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBoxNewBagName.Text) &&
                this.textBoxNewBagName.Text != "назва мішка...")
            {
                if (this.listViewBags.SelectedItems.Count == 1)
                {
                    this.ChangeBag(this.listViewBags.SelectedItems[0].Tag as Bag, this.textBoxNewBagName.Text);
                    this.textBoxNewBagName.Text = "назва мішка...";
                }
                else
                    this.toolStripStatusMessage.Text = "Оберіть мішок.";
            }
            else
                this.toolStripStatusMessage.Text = "Введіть назву нового мішка.";
        }
    }
}
