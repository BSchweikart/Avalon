using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class MovePlayer
    {
        public class Character
        {
            public int location = 1;
        }

        public class Room
        {
            public int roomID;
            public string roomDescription;
            public string roomName;
        }

        static void Main(string[] args)
        {
            string movement;
            string isActive;
            string currentRoom = "";
            string currentRoomDescription = "";


            Room roomOne = new Room();
            roomOne.roomID = 1;
            roomOne.roomName = "Blue Room";
            roomOne.roomDescription = "a blue room.";

            Room roomTwo = new Room();
            roomTwo.roomID = 2;
            roomTwo.roomName = "Red Room";
            roomTwo.roomDescription = "a red room.";

            Room roomThree = new Room();
            roomThree.roomID = 3;
            roomThree.roomName = "Black Room";
            roomThree.roomDescription = "a black room.";

            Room roomFour = new Room();
            roomFour.roomID = 4;
            roomFour.roomName = "White Room";
            roomFour.roomDescription = "a white room.";

            Room roomFive = new Room();
            roomFive.roomID = 5;
            roomFive.roomName = "Mirror Room";
            roomFive.roomDescription = "a room of mirrors. Hey, where are your pants!?";

            Character myCharacter = new Character();
            myCharacter.location = roomOne.roomID;

            Console.WriteLine("This is simple example of how we can make a character move north and south through a series of rooms");
            Console.WriteLine("Type North to move forward and South to move back through the rooms.");
            Console.WriteLine("You are currently in the Blue Room. To start this journey type North. Type Exit to close this application.");

            do
            {
                isActive = Console.ReadLine().ToUpper();
                movement = Console.ReadLine().ToUpper();

                Console.Clear();

                if (isActive == "EXIT")
                {
                    return;
                }
                else
                {
                    if (movement == "NORTH")
                    {
                        if (myCharacter.location == 5)
                        {
                            Console.WriteLine("You have reached the end of this journey. Type South to make your way back to the beginning.");
                        }
                        else
                        {
                            myCharacter.location++;

                            if (myCharacter.location == 1)
                            {
                                currentRoom = roomOne.roomName;
                                currentRoomDescription = roomOne.roomDescription;
                            }
                            else if (myCharacter.location == 2)
                            {
                                currentRoom = roomTwo.roomName;
                                currentRoomDescription = roomTwo.roomDescription;
                            }
                            else if (myCharacter.location == 3)
                            {
                                currentRoom = roomThree.roomName;
                                currentRoomDescription = roomThree.roomDescription;
                            }
                            else if (myCharacter.location == 4)
                            {
                                currentRoom = roomFour.roomName;
                                currentRoomDescription = roomFour.roomDescription;
                            }
                            else if (myCharacter.location == 5)
                            {
                                currentRoom = roomFive.roomName;
                                currentRoomDescription = roomFive.roomDescription;
                            }
                            else { }
                            Console.WriteLine("You have entered the " + currentRoom + ". " + "It is " + currentRoomDescription);
                            Console.WriteLine("Type North to move forward and South to move back through the rooms.");

                        }

                    }

                    if (movement == "SOUTH")
                    {
                        {
                            if (myCharacter.location == 1)
                            {
                                Console.WriteLine("You at the beginning of your journey. Type North move forward.");
                            }
                            else
                            {
                                myCharacter.location--;

                                if (myCharacter.location == 1)
                                {
                                    currentRoom = roomOne.roomName;
                                    currentRoomDescription = roomOne.roomDescription;
                                }
                                if (myCharacter.location == 2)
                                {
                                    currentRoom = roomTwo.roomName;
                                    currentRoomDescription = roomTwo.roomDescription;
                                }
                                if (myCharacter.location == 3)
                                {
                                    currentRoom = roomThree.roomName;
                                    currentRoomDescription = roomThree.roomDescription;
                                }
                                if (myCharacter.location == 4)
                                {
                                    currentRoom = roomFour.roomName;
                                    currentRoomDescription = roomFour.roomDescription;
                                }
                                if (myCharacter.location == 5)
                                {
                                    currentRoom = roomFive.roomName;
                                    currentRoomDescription = roomFive.roomDescription;
                                }

                                Console.WriteLine("You have entered the " + currentRoom + ". " + "It is " + currentRoomDescription);
                                Console.WriteLine("Type North to move forward and South to move back through the rooms.");

                            }
                        }
                    }
                }
            } while (isActive != "EXIT");
        }

    }
}
