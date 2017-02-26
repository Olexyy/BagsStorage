using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace BagsStorage
{
    public delegate void BagsStorageEventHandler(object sender, BagsStorgeEventArgs args);
    public class BagsStorgeEventArgs : EventArgs
    {
        public List<Bag> Bags { get; set; }
        public string Message { get; set; }
        public BagsStorgeEventArgs(List<Bag> bags, string message = null)
        {
            this.Bags = bags;
            this.Message = message;
        }
    }
    public class BagsStorage
    {
        public List<Bag> Bags { get; private set; }
        public event BagsStorageEventHandler BagsStorageEvent;
        public const string DefaultFilePath = DefaultDataDirectory + "\\bags.data";
        public const string DefaultDataDirectory = "data";
        public static List<string> BagItemTypes = new List<string>()
        {
            "Взуття", "Штани", "Сорочки", "Боді", "Білизна", "Футболки", "Шорти", "Спідниці", "Сукні",
            "Светри", "Куртки", "Пальто", "Костюми", "Тканина", "Інше"
        };
        public static Dictionary<string, List<string>> BagItemSizes = new Dictionary<string, List<string>>()
        {
            { "Взуття", new List<string> { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42+", } },
            { "Ріст", new List<string> { "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", } },
            { "Вік", new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", } },
        };
        public BagsStorage(BagsStorageEventHandler bagStorageEventHandler)
        {
            this.BagsStorageEvent += bagStorageEventHandler;
            this.Bags = new List<Bag>();
            this.LoadFromFile();
        }
        ~BagsStorage()
        {
            this.SaveToFile();
        }
        private void SaveToFile(FileMode filemode = FileMode.Truncate)
        {
            try
            {
                using (FileStream file = new FileStream(DefaultFilePath, filemode))
                {
                    new SoapFormatter().Serialize(file, this.Bags.ToArray());
                }
            }
            catch (Exception ex)
            {
                this.BagsStorageEvent(this, new BagsStorgeEventArgs(this.Bags, "Збереження не вдалось."));
            }
        }
        private void LoadFromFile()
        {
            Directory.CreateDirectory(BagsStorage.DefaultDataDirectory);
            try
            {
                using (FileStream file = new FileStream(BagsStorage.DefaultFilePath, FileMode.OpenOrCreate))
                {
                    if (file.Length != 0)
                    {
                        this.Bags = (new SoapFormatter().Deserialize(file) as Bag[]).ToList();
                        if (this.BagsStorageEvent != null)
                            this.BagsStorageEvent(this, new BagsStorgeEventArgs(this.Bags, "Список завантажено."));
                    }
                }
            }
            catch (Exception ex)
            {
                this.BagsStorageEvent(this, new BagsStorgeEventArgs(this.Bags, "Завантаження не вдалось."));
            }
        }
        public void AddBag(string name = "")
        {
            Bag bag = new Bag(this.NextId(), name);
            this.Bags.Add(bag);
            this.SaveToFile();
            this.LoadFromFile();
        }
        public void RemoveBag(int Id)
        {
            this.Bags.RemoveAll(i=>i.Id == Id);
            this.SaveToFile();
            this.LoadFromFile();
        }
        public void RemoveBag(Bag bag)
        {
            this.Bags.Remove(bag);
            this.SaveToFile();
            this.LoadFromFile();
        }
        public void AddBagItem(int bagId, string type, string sizeType, string sizeFrom, string sizeTo, string details = null)
        {
            Bag bag = this.Bags.Where(i => i.Id == bagId).First();
            bag.AddBagItem(type, sizeType, sizeFrom, sizeTo, details);
            this.SaveToFile();
            this.LoadFromFile();
        }
        public void UpdateBagItem(int bagId, int bagItemId, string type, string sizeType, string sizeFrom, string sizeTo, string details = null)
        {
            Bag bag = this.Bags.Where(i => i.Id == bagId).First();
            bag.UpdateBagItem(bagItemId, type, sizeType, sizeFrom, sizeTo, details);
            this.SaveToFile();
            this.LoadFromFile();
        }
        public void RemoveBagItem(int bagId, int bagItemId)
        {
            Bag bag = this.Bags.Where(i => i.Id == bagId).First();
            bag.RemoveBagItem(bagItemId);
            this.SaveToFile();
            this.LoadFromFile();
        }
        private int NextId()
        {
            if (this.Bags.Count == 0)
                return 1;
            return this.Bags.Max(i=>i.Id) + 1;
        }
    }
    [Serializable]
    public class BagItem
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string SizeFrom { get; set; }
        public string SizeTo { get; set; }
        public string Details { get; set; }
        public string SizeType { get; set; }
        public BagItem() { }
        public BagItem(int id, string type, string sizeType, string sizeFrom, string sizeTo, string details = "")
        {
            this.Id = id;
            this.Type = type;
            this.SizeFrom = sizeFrom;
            this.SizeTo = sizeTo;
            this.Details = details;
            this.SizeType = sizeType;
        }
    }
    [Serializable]
    public class Bag
    {
        public int IdCounter { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public BagItem[] ItemsArray { get; set; }
        public List<BagItem> Items { get { return this.ItemsArray.ToList(); } set { this.ItemsArray = value.ToArray(); } }
        public Bag()
        {
            this.Items = new List<BagItem>();
        }
        public Bag(int id, string name = "")
        {
            this.Id = id;
            this.Name = name;
            this.Items = new List<BagItem>();
        }
        private int NextId()
        {
            return ++this.IdCounter;
        }
        public void AddBagItem(string type, string sizeType, string sizeFrom, string sizeTo, string details = null)
        {
            var temp = this.ItemsArray.ToList();
            temp.Add(new BagItem(this.NextId(), type, sizeType, sizeFrom, sizeTo, details));
            this.ItemsArray = temp.ToArray();
        }
        public void RemoveBagItem(int id)
        {
            var temp = this.ItemsArray.ToList();
            temp.RemoveAll(i => i.Id == id);
            this.ItemsArray = temp.ToArray();
        }
        public void UpdateBagItem(int id, string type, string sizeType, string sizeFrom, string sizeTo, string details = null)
        {
            BagItem bagItem = this.ItemsArray.ToList().Where(i => i.Id == id).First();
            bagItem.Type = type;
            bagItem.SizeType = sizeType;
            bagItem.SizeFrom = sizeFrom;
            bagItem.SizeTo = sizeTo;
            bagItem.Details = details;
        }
    }
}