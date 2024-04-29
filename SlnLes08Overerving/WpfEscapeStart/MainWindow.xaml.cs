using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEscapeStart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   

    public partial class MainWindow : Window
    {
        String FilePath = "E:\\Visual Studio Projects\\WpfEscapeStart\\WpfEscapeStart\\";
        Room currentRoom; // will become useful in later versions
        Room livingRoom;
        Room computerRoom;
        // define room
        Room room1;
        public MainWindow()
        {
            InitializeComponent();
            // define room
             room1 = new Room("bedroom", "I seem to be in a medium sized bedroom. There is a locker to the left, a nice rug on the floor, and a bed to the right. ");
             room1.Screenshot = FilePath+"ss-bedroom.png";

            livingRoom = new Room("living room", "A cozy living room with a couch and a TV.");
            livingRoom.Screenshot = FilePath + "ss-living.png";
            computerRoom = new Room("computer room", "A room filled with computers and gadgets.");
            computerRoom.Screenshot = FilePath + "ss-computer.png";


            

            // define items
            Item key1 = new Item("small silver key", "A small silver key, makes me think of one I had at highschool.");
            Item key2 = new Item("large key", "A large key. Could this be my way out? ");
            Item locker = new Item("locker", "A locker. I wonder what's inside. ",false);
            Item chair = new Item("chair", "A comfortable-looking chair for sitting.",false);
            Item poster = new Item("poster", "A poster hanging on the wall, depicting a serene landscape."); ;
            Item tv = new Item("TV", "A widescreen TV showing some news.");
            Item couch = new Item("couch", "A soft and comfy couch.");

            locker.HiddenItem = key2;
            poster.HiddenItem = key1;
            locker.IsLocked = true;
            locker.Key = key1;
            Item bed = new Item("bed", "Just a bed. I am not tired right now. ", false); ;
            bed.HiddenItem = key1;
            // setup bedroom
            room1.Items.Add(new Item("floor mat", "A bit ragged floor mat, but still one of the most popular designs."));
            room1.Items.Add(bed);
            room1.Items.Add(locker);
            room1.Items.Add(chair);
            room1.Items.Add(poster);

            livingRoom.Items.Add(new Item("coffee table", "A small coffee table with magazines on top."));
            livingRoom.Items.Add(tv);
            livingRoom.Items.Add(couch);

            computerRoom.Items.Add(new Item("desktop computer", "A powerful desktop computer with multiple monitors."));
            computerRoom.Items.Add(new Item("laptop", "A sleek laptop sitting on the desk."));

            Door doorToLivingRoom = new Door(livingRoom, "closed", key2);
            room1.Doors.Add(doorToLivingRoom);
            Door doorToComputerRoom = new Door(computerRoom, "open");
            livingRoom.Doors.Add(doorToComputerRoom);
            Door doorToLivingRoomFromComputer = new Door(livingRoom, "open");
            computerRoom.Doors.Add(doorToLivingRoomFromComputer);
            Door doorToNull = new Door(null, "closed door", key1);
            livingRoom.Doors.Add(doorToNull);


            // start game
            currentRoom = room1;
            lblMessage.Content = "I am awake, but cannot remember who I am!? Must have been a hell of a party last night... ";
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(currentRoom.Screenshot);
            bitmapImage.EndInit();
            imgRoomScreenshot.Source = bitmapImage;

            txtRoomDesc.Text = currentRoom.Description;
            
            UpdateUI();
        }

        private void UpdateUI()
        {
            lstRoomItems.Items.Clear();
            foreach (Item itm in currentRoom.Items)
            {
                lstRoomItems.Items.Add(itm);
            }

            lstRoomDoors.Items.Clear();
            foreach (Door dor in currentRoom.Doors)
            {
                lstRoomDoors.Items.Add(dor);
            }
           
        }
        private void LstItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnCheck.IsEnabled = lstRoomItems.SelectedValue != null; // room item selected
            btnPickUp.IsEnabled = lstRoomItems.SelectedValue != null; // room item selected
            btnUseOn.IsEnabled = lstRoomItems.SelectedValue != null && lstMyItems.SelectedValue != null; // room item and picked up item selected
            btnDrop.IsEnabled = lstMyItems.SelectedItem!=null;
            btnEnter.IsEnabled = lstRoomDoors.SelectedItem != null;
            btnOpenWith.IsEnabled = lstRoomDoors.SelectedItem != null && lstMyItems.SelectedValue != null;
        }
        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            // 1. find item to check
            Item roomItem = (Item)lstRoomItems.SelectedItem;
            // 2. is it locked?
            if (roomItem.IsLocked)
            {
                lblMessage.Content = $"{roomItem.Description} {RandomMessageGenerator.GetRandomMessage(MessageType.Default)}";
                return;
            }
            // 3. does it contain a hidden item?
            Item foundItem = roomItem.HiddenItem;
            if (foundItem != null)
            {
                lblMessage.Content = $"Oh, look, I found a {foundItem.Name}. ";
                lstMyItems.Items.Add(foundItem);
                roomItem.HiddenItem = null;
                return;
            }
            // 4. just another item; show description
            lblMessage.Content = roomItem.Description;
        }
        private void BtnUseOn_Click(object sender, RoutedEventArgs e)
        {
            // 1. find both items
            Item myItem = (Item)lstMyItems.SelectedItem;
            Item roomItem = (Item)lstRoomItems.SelectedItem;
            // 2. item doesn't fit
            if (roomItem.Key != myItem)
            {
                lblMessage.Content = RandomMessageGenerator.GetRandomMessage(MessageType.ItemNotFit);
                return;
            }
            // 3. item fits; other item unlocked
            roomItem.IsLocked = false;
            roomItem.Key = null;
            lstMyItems.Items.Remove(myItem);
            lblMessage.Content = RandomMessageGenerator.GetRandomMessage(MessageType.ItemFit);
        }
        private void BtnPickUp_Click(object sender, RoutedEventArgs e)
        {
            if (lstRoomItems.SelectedValue != null)
            {
                
                Item selItem = (Item)lstRoomItems.SelectedItem;
                if (selItem.IsPortable)
                {
                    
                    lblMessage.Content = $"I just picked up the {selItem.Name}. ";
                    lstMyItems.Items.Add(selItem);
                    lstRoomItems.Items.Remove(selItem);
                    currentRoom.Items.Remove(selItem);

                }
                else
                {
                    lblMessage.Content = $"I can't pick up the {selItem.Name}. ";
                }
            }
        }
        private void BtnDrop_Click(object sender, RoutedEventArgs e)
        {
            if (lstMyItems.SelectedValue != null)
            {
                Item selectedItem = (Item)lstMyItems.SelectedItem;
                lblMessage.Content = $"I just dropped  the {selectedItem.Name}. ";
                currentRoom.Items.Add(selectedItem);
                lstMyItems.Items.Remove(selectedItem);
                UpdateUI();
            }
            
        }
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
           
            if (lstRoomDoors.SelectedItem is Door selectedDoor)
            {
               
                if (selectedDoor.IsOpen)
                {
                   
                    currentRoom = selectedDoor.ConnectedRoom;

                    var bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(currentRoom.Screenshot);
                    bitmapImage.EndInit();

                    imgRoomScreenshot.Source = bitmapImage;


                    txtRoomDesc.Text = currentRoom.Description;
                    UpdateUI();
                   
                }
                else
                {
                    lblMessage.Content = "The door is closed. You need to open it first.";
                }
            }
            else
            {
                lblMessage.Content = "Please select a door to enter.";
            }
        }

        private void BtnOpenWith_Click(object sender, RoutedEventArgs e)
        {
            
            if (lstRoomDoors.SelectedItem is Door selectedDoor)
            {
              
                if (lstMyItems.SelectedItem is Item selectedItem)
                {
                   
                    if (selectedDoor.Key == selectedItem)
                    {
                        
                        selectedDoor.Unlock(selectedItem);
                        lblMessage.Content = "You used the key to unlock the door.";
                    }
                    else
                    {
                        lblMessage.Content = "The selected item doesn't fit the door.";
                    }
                }
                else
                {
                    lblMessage.Content = "Please select an item to use with the door.";
                }
            }
            else
            {
                lblMessage.Content = "Please select a door to open with.";
            }
        }

    }


}