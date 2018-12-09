﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Inventory : INotifyPropertyChanged
    {
        private Item _details;
        private int _quantity;
        private string _wName;
        private string _wDesc;
        private string _wDamage;
        private string _wDamageType;
        private int _wPrice;

        public Item Details { get { return _details; } set { _details = value; OnPropertyChanged("Details"); } }
        public int Quantity { get {return _quantity; } set {_quantity = value; OnPropertyChanged("Quantity"); } }
        public int ItemID { get { return Details.ID; } }
        //public string Description { get { return Quantity > 1 ? Details.NamePlural : Details.Name; } }
        public int Price { get { return Details.Price; } }
        public string WeaponName { get { return _wName; } set { _wName = value; } }
        public string WeaponDesc { get { return _wDesc; } set { _wDesc = value; } }
        public string WeaponDamage { get { return _wDamage; } set { _wDamage = value; } }
        public string WeaponDamageType { get { return _wDamageType; } set { _wDamageType = value; } }
        public int WeaponPrice { get { return _wPrice; } set { _wPrice = value; } }

        public Inventory(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    
        public Inventory(Weapon weapon, int quantity)
        {
            WeaponName = weapon.Name;
            WeaponDesc = weapon.Description;
            WeaponDamage = weapon.DamageMax;
            WeaponDamageType = weapon.DamageType;
            WeaponPrice = weapon.Price;
            Details = weapon;
            Quantity = quantity;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
