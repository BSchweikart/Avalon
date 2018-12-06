using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Engine
{
    public class Player : LivingCreature
    {
        private string _namePlayer;                         // To hold the player's name
        private string _classPlayer;                        // To hold the player's class
        private string _racePlayer;
        private int _gold;
        private int _xp;
        private int _level;
        private static Room _currentLocation;

        private string playerName;
        private string pC;
        private string pR;
        private int currentHitPoints;
        private int maximumHitPoints;
        private object equip;
        private bool v1;
        private bool v2;
        private int alignment;

        public string NamePlayer { get { return _namePlayer; } set { _namePlayer = value; } }
        public string ClassPlayer { get { return _classPlayer; } set { _classPlayer = value; } }
        public string RacePlayer { get { return _racePlayer; } set { _racePlayer = value; } }
        public int Gold { get { return _gold; } set { _gold = value; OnPropertyChanged("Gold"); } }
        public int XP { get { return _xp; } set { _xp = value; OnPropertyChanged("XP"); } }
        public int Level { get { return _level; } set { _level = value; OnPropertyChanged("Level"); } }
        public List<Inventory> Inventory { get; set; }
        public static Room CurrentLocation { get { return _currentLocation; } set { _currentLocation = value; } }


        public Item Equipt { get; internal set; }
        public static object _player { get; internal set; }

        //public Room CurrentLocation { get { return _currentLocation; } set { _currentLocation = value; } }

        public Player(string namePlayer, string classPlayer, string racePlayer, int gold, int xp, int level, Weapon equipt, int hpCurrent, int hpMax, bool isDead, bool attackable) : base(hpCurrent, hpMax, isDead, attackable)
        {
            NamePlayer = namePlayer;
            ClassPlayer = classPlayer;
            RacePlayer = RacePlayer;
            Gold = gold;
            XP = 0;
            Level = level;
            CurrentLocation = WorldGenerator.Location[0];
            //Engine.Player.CurrentLocation.get returned null
        }

        public Player(string playerName, string pC, string pR, int gold, int currentHitPoints, int maximumHitPoints, object equip, bool v1, bool v2, int alignment)
        {
            this.playerName = playerName;
            this.pC = pC;
            this.pR = pR;
            Gold = gold;
            this.currentHitPoints = currentHitPoints;
            this.maximumHitPoints = maximumHitPoints;
            this.equip = equip;
            this.v1 = v1;
            this.v2 = v2;
            this.alignment = alignment;
        }

        //public Player(string playerName, string pC, string pR, int gold, int currentHitPoints, int maximumHitPoints, Weapon equipt, bool v1, bool v2, int alignment)
        //{
        //    Gold = gold;
        //}

        public void AddXP(int xpToAdd) // Used to incress player health
        {
            //XP += xpToAdd;
            //HpMax = (Level * 2); // not used until LC can take over have to fix other parts for this to happen
        }

        public string ToXmlString()
        {
            XmlDocument playerData = new XmlDocument();

            // Create the top-level XML node
            XmlNode player = playerData.CreateElement("Player");
            playerData.AppendChild(player);

            // Create the "Stats" child node to hold the other player statistics nodes
            XmlNode stats = playerData.CreateElement("Stats");
            player.AppendChild(stats);

            XmlNode playerName = playerData.CreateElement("Name");
            playerName.AppendChild(playerData.CreateTextNode(this.playerName.ToString()));
            stats.AppendChild(playerName);

            XmlNode playerClass = playerData.CreateElement("Class");
            playerClass.AppendChild(playerData.CreateTextNode(this.ClassPlayer.ToString()));
            stats.AppendChild(playerClass);

            XmlNode playerRace = playerData.CreateElement("Race");
            playerRace.AppendChild(playerData.CreateTextNode(this.RacePlayer.ToString()));
            stats.AppendChild(playerRace);

            XmlNode currentHitPoints = playerData.CreateElement("CurrentHitPoints");
            currentHitPoints.AppendChild(playerData.CreateTextNode(this.currentHitPoints.ToString()));
            stats.AppendChild(currentHitPoints);

            XmlNode maximumHitPoints = playerData.CreateElement("MaximumHitPoints");
            maximumHitPoints.AppendChild(playerData.CreateTextNode(this.maximumHitPoints.ToString()));
            stats.AppendChild(maximumHitPoints);

            XmlNode gold = playerData.CreateElement("Gold");
            gold.AppendChild(playerData.CreateTextNode(this.Gold.ToString()));
            stats.AppendChild(gold);

            XmlNode experiencePoints = playerData.CreateElement("ExperiencePoints");
            experiencePoints.AppendChild(playerData.CreateTextNode(this.XP.ToString()));
            stats.AppendChild(experiencePoints);

            XmlNode currentLocation = playerData.CreateElement("CurrentLocation");
            currentLocation.AppendChild(playerData.CreateTextNode(CurrentLocation.ID.ToString()));
            stats.AppendChild(currentLocation);

            XmlNode alignment = playerData.CreateElement("Alignment");
            alignment.AppendChild(playerData.CreateTextNode(this.alignment.ToString()));
            stats.AppendChild(alignment);

            if (Equipt != null)
            {
                XmlNode currentWeapon = playerData.CreateElement("CurrentWeapon");
                currentWeapon.AppendChild(playerData.CreateTextNode(this.Equipt.ID.ToString()));
                stats.AppendChild(currentWeapon);
            }

            // Create the "InventoryItems" child node to hold each InventoryItem node
            XmlNode inventoryItems = playerData.CreateElement("Inventory");
            player.AppendChild(inventoryItems);

            // Create an "InventoryItem" node for each item in the player's inventory
            foreach (Inventory item in this.Inventory)
            {
                XmlNode inventoryItem = playerData.CreateElement("Inventory");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = item.Details.ID.ToString();
                inventoryItem.Attributes.Append(idAttribute);

                XmlAttribute quantityAttribute = playerData.CreateAttribute("Quantity");
                quantityAttribute.Value = item.Quantity.ToString();
                inventoryItem.Attributes.Append(quantityAttribute);

                inventoryItems.AppendChild(inventoryItem);
            }

            return playerData.InnerXml; // The XML document, as a string, so we can save the data to disk
        }


        public static string GetXMLFromObject(object o)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, o);
            }
            catch (Exception)
            {
                //Handle Exception Code
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }

        public static Object ObjectToXML(string xml, Type objectType)
        {
            StringReader strReader = null;
            XmlSerializer serializer = null;
            XmlTextReader xmlReader = null;
            Object obj = null;
            try
            {
                strReader = new StringReader(xml);
                serializer = new XmlSerializer(objectType);
                xmlReader = new XmlTextReader(strReader);
                obj = serializer.Deserialize(xmlReader);
            }
            catch (Exception)
            {
                //Handle Exception Code
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
                if (strReader != null)
                {
                    strReader.Close();
                }
            }
            return obj;
        }
                
        public void AddItemToInventory(Item itemToAdd, int quantity = 1)
        {
            Inventory item = Inventory.SingleOrDefault(ii => ii.Details.ID == itemToAdd.ID);

            if (item == null)
            {
                // They didn't have the item, so add it to their inventory
                Inventory.Add(new Inventory(itemToAdd, quantity));
            }
            else
            {
                // They have the item in their inventory, so increase the quantity
                item.Quantity += quantity;
            }

        }

        public void AddItemToInventory(Weapon itemToAdd, int quantity = 1)
        {
            Inventory item = Inventory.SingleOrDefault(ii => ii.Details.ID == itemToAdd.ID);

            if (item == null)
            {
                // They didn't have the item, so add it to their inventory
                Inventory.Add(new Inventory(itemToAdd, quantity));
            }
            else
            {
                // They have the item in their inventory, so increase the quantity
                item.Quantity += quantity;
            }
        }

        public void RemoveItemFromInventory(Item itemToRemove, int quantity = 1)
        {
            Inventory item = Inventory.SingleOrDefault(ii => ii.ItemID == itemToRemove.ID);

            if (item == null)
            {
                // The item is not in the player's inventory, so ignore it.
                // We might want to raise an error for this situation
                Console.WriteLine("Cannot drop an item you do not have.");
            }
            else
            {
                // They have the item in their inventory, so decrease the quantity
                item.Quantity -= quantity;

                // Don't allow negative quantities.
                // We might want to raise an error for this situation
                if (item.Quantity < 0)
                {
                    item.Quantity = 0;
                }

                // If the quantity is zero, remove the item from the list
                if (item.Quantity == 0)
                {
                    Inventory.Remove(item);
                }
            }
        }

        public void RemoveItemFromInventory(Weapon weaponToRemove, int quantity = 1)
        {
            Item weapon = weaponToRemove;
            Inventory item = Inventory.SingleOrDefault(ii => ii.ItemID == weapon.ID);

            if (item == null)
            {
                //Item is not in the player's inventory, ignore it.
             
            }
            else
            {
                // They have the item in their inventory, so decrease the quantity
                item.Quantity -= quantity;

                if (item.Quantity < 0)
                {
                    item.Quantity = 0;
                }

                // If the quantity is zero, remove the item from the list
                if (item.Quantity == 0)
                {
                    Inventory.Remove(item);
                }      
            }
        }
    }
}