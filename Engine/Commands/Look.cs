using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public static class Look
    {
        public static void Looking (string noun)
            {

            string CapNoun = CapWord.FirstCharToUpper(moun);
            determineVerbType(CapNoun);

            }

        public static void Looking()
            {

            CurrentLocationClass.DisplayCurrentLocation();

            }

        public static void determineVerbType (string noun)
            {
            Item itemToLook = World.ItemByName(noun);
            Weapon weaponToLook = World.WeaponByName(noun);
            Monster monsterToLook = World.MonsterByName(noun);
            NPC npcToLook = World.NPCByName(noun);

            if (itemToLook != null)
                {
                foreach (InventoryItem item in Player.player.Inventory.ToList())
                    {
                    if (item.Details.Name == itemToLook.ToString())
                        {
                        LookAtItem(item);
}

}
                foreach (Item rmItem in Player.CurrentLocation.RoomLoot.ToList())
                    {
                    if (rmItem.Name == itemToLook.Name)
                        {
                        LookAtItem(rmItem);
}
}
}               
}
    }
}
