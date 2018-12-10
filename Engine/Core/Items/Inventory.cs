using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Inventory : INotifyPropertyChanged
    {
        #region Fields
        private Item _details;
        private int _quantity;
        #endregion

        #region Prop
        public Item Details { get { return _details; } set { _details = value; OnPropertyChanged("Details"); } }
        public int Quantity { get { return _quantity; } set { _quantity = value; OnPropertyChanged("Quantity"); } }
        public int ItemID { get { return Details.ID; } }
        public string Description { get { return Quantity > 1 ? Details.Name : Details.Description; } }
        public int Price { get { return Details.Price; } }
        public string WeaponName { get; set; }
        public string WeaponDesc { get; set; }
        public string WeaponDamage { get; set; }
        public int WeaponPrice { get; set; }
        #endregion

        #region Const Item
        public Inventory(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
        #endregion

        #region Const Weapon
        public Inventory(Weapon weapon, int quantity)
        {
            WeaponName = weapon.Name;
            WeaponDesc = weapon.Description;
            WeaponDamage = weapon.DamageMax;
            WeaponPrice = weapon.Price;
            Details = weapon;
            Quantity = quantity;
        }
        #endregion

        #region Chnage Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
