using ElevatorProject.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ElevatorProject.Lib.CustomControls.ControlPanel;
using static ElevatorProject.Lib.CustomControls.DisplayArea;

namespace ElevatorProject
{
    public partial class elevatorForm : Form
    {
        public elevatorForm()
        {
            InitializeComponent();
        }

        // Global Status 
        // Position 1 => Top (Default)
        // Position 0 => Bottom
        public int elevatorFloor = 1;
        public bool isMoving = false;

        // Main Properties
        public int tFloors = 2;
        public int totalFloors {
            get { return tFloors; }
            set { tFloors = value; }
        }

        // Easy to use method for adding items to the Events History List.
        public void createListItem(string eventAction)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = DateTime.Now.ToString("MM/dd/yyyy - hh:mm:ss tt"); // Current date and time.
            lvi.SubItems.Add(eventAction);

            eventHistoryList.Items.Add(lvi);

            saveEvents.Enabled = true; // Button enabled everytime a new item is added.
        }

        // Resize the form only when the elevator is NOT moving.
        private void mainWindow_ResizeBegin(object sender, EventArgs e)
        {
            if (isMoving == true)
            {
                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;
            }
            else
            {
                this.MaximumSize = new Size(0, 0);
                this.MinimumSize = new Size(827, 675);
            }
        }

        // Functions and methods responsible for moving the elevator & closing the doors.
        #region "Elevator Movement"
        // Function responsible for moving the elevator to the first floor.
        public async void gotoFloor1()
        {
            if (isMoving == false && groundFloorDoors.doorStatus == 1)
            {
                if (elevatorFloor == 0)
                {
                    isMoving = true;
                    callBtn_Floor1.isCalling = true;

                    elevatorControlPanel.ArrowDirection = arrDir.Up;

                    firstDisplay.FloorDisplay = floorStat.GoingFirst;
                    groundDisplay.FloorDisplay = floorStat.GoingFirst;
                    
                    createListItem("Elevator doors closing at Ground floor.");
                    groundFloorDoors.closeDoors();

                    try
                    {
                        SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.doorsClosing);
                        soundEffect.Play();
                    }
                    finally { }

                    await Task.Delay(3000);

                    try
                    {
                        SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.elevatorMoving);
                        soundEffect.Play();
                    }
                    finally { }

                    createListItem("Elevator going up.");
                    animateUp.Start();
                }
            }
        }

        // Function responsible for moving the elevator to the ground floor.
        public async void gotoFloorG()
        {
            if (isMoving == false && firstFloorDoors.doorStatus == 1)
            {
                if (elevatorFloor == 1)
                {
                    isMoving = true;
                    callBtn_FloorG.isCalling = true;

                    elevatorControlPanel.ArrowDirection = arrDir.Down;

                    firstDisplay.FloorDisplay = floorStat.GoingGround;
                    groundDisplay.FloorDisplay = floorStat.GoingGround;

                    createListItem("Elevator doors closing at First floor.");
                    firstFloorDoors.closeDoors();

                    try
                    {
                        SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.doorsClosing);
                        soundEffect.Play();
                    }
                    finally { }

                    await Task.Delay(3000);

                    try
                    {
                        SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.elevatorMoving);
                        soundEffect.Play();
                    }
                    finally { }

                    createListItem("Elevator going down.");
                    animateDown.Start();
                }
            }
        }

        // Animated movement of the elevator for going to the first floor using timer.
        private async void animateUp_Tick(object sender, EventArgs e)
        {
            mainElevator.Top -= 2;

            if (mainElevator.Location.Y <= firstFloorDoors.Location.Y)
            {
                createListItem("Elevator stopped at First floor.");
                animateUp.Stop();

                mainElevator.Location = firstFloorDoors.Location;

                isMoving = false;
                callBtn_Floor1.isCalling = false;

                elevatorControlPanel.ArrowDirection = arrDir.Stopped;
                elevatorControlPanel.floorNumberDisplay = "1";

                firstDisplay.FloorDisplay = floorStat.First;
                groundDisplay.FloorDisplay = floorStat.First;

                await Task.Delay(500);

                try
                {
                    SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.tingSound);
                    soundEffect.Play();
                }
                finally { }

                await Task.Delay(2000);

                createListItem("Elevator doors opening at First floor.");
                firstFloorDoors.openDoors();

                try
                {
                    SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.doorsOpening);
                    soundEffect.Play();
                } finally { }

                elevatorFloor = 1;

                mainElevator.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            }
        }

        // Animated movement of the elevator for going to the ground floor using timer.
        private async void animateDown_Tick(object sender, EventArgs e)
        {
            mainElevator.Top += 2;

            if (mainElevator.Location.Y >= groundFloorDoors.Location.Y)
            {
                createListItem("Elevator stopped at Gound floor.");
                animateDown.Stop();

                mainElevator.Location = groundFloorDoors.Location;

                isMoving = false;
                callBtn_FloorG.isCalling = false;

                elevatorControlPanel.ArrowDirection = arrDir.Stopped;
                elevatorControlPanel.floorNumberDisplay = "G";

                firstDisplay.FloorDisplay = floorStat.Ground;
                groundDisplay.FloorDisplay = floorStat.Ground;

                await Task.Delay(500);

                try
                {
                    SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.tingSound);
                    soundEffect.Play();
                }
                finally { }

                await Task.Delay(2000);

                createListItem("Elevator doors opening at Ground floor.");
                groundFloorDoors.openDoors();

                try
                {
                    SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.doorsOpening);
                    soundEffect.Play();
                }
                finally { }

                elevatorFloor = 0;

                mainElevator.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            }
        }
        #endregion

        // Elevator call floor 1.
        private async void callBtn_Floor1_CallClicked(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.clickSound);
                soundEffect.Play();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            await Task.Delay(700);

            gotoFloor1();
        }

        // Elevator call floor G.
        private async void callBtn_FloorG_CallClicked(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.clickSound);
                soundEffect.Play();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            await Task.Delay(700);

            gotoFloorG();
        }

        // Elevator pressed first floor button.
        private async void elevatorControlPanel_UpClicked(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.clickSound);
                soundEffect.Play();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            await Task.Delay(700);

            gotoFloor1();
        }

        // Elevator pressed ground floor button.
        private async void elevatorControlPanel_DownClicked(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.clickSound);
                soundEffect.Play();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            await Task.Delay(700);

            gotoFloorG();
        }

        #region "Events History List"
        // Global Database Required Variables.
        private OleDbConnection dbConn = new OleDbConnection();
        private string connectionString;
        private string query;
        private OleDbDataAdapter dataAdapt;
        private OleDbCommand dbComm = new OleDbCommand();
        private DataSet dataSt = new DataSet();
        private OleDbCommandBuilder builder;

        // Initialize database connection.
        // Open elevator doors when form is loaded.
        private void elevatorForm_Load(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundEffect = new SoundPlayer(Properties.Resources.doorsOpening);
                soundEffect.Play();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            // Create a new thread to process the database connection.
            Thread newThread = new Thread(() => {
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=elevatorDB.accdb;Persist Security Info=False;";
                dbConn = new OleDbConnection(connectionString);

                query = "Select * From eventList;"; // Selecting all the rows from the specified table.

                dbComm = new OleDbCommand(query, dbConn);
                dataAdapt = new OleDbDataAdapter(dbComm);

                loadDatabaseData();
                
                Invoke(new Action(() => { displayData(); })); // Cross-Thread protection.
                
                // Stops the application from crashing due to syntax error 'insert into'.
                builder = new OleDbCommandBuilder(dataAdapt);
                builder.QuotePrefix = "[";
                builder.QuoteSuffix = "]";
            });
            newThread.Start(); // Start the new thread.
            
            firstFloorDoors.openDoors(); // Open the doors of the elevator once the project loads.
        }

        // When the loadEvents button is clicked the items from the list are cleared.
        // Displays all the data from the Database into the ListView.
        private void loadEvents_Click(object sender, EventArgs e)
        {
            if (eventHistoryList.Items.Count > 0)
            {
                DialogResult msg = MessageBox.Show("Are you sure you want to load new data to the Events History List? All current Events will not be saved.", "Delete History?", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    eventHistoryList.Items.Clear(); // Clear all the items from the ListView.

                    // Create a new thread to display the data on the ListView.
                    Thread saveDataTh = new Thread(() => Invoke(new Action(() => { displayData(); })));
                    saveDataTh.Start(); // Start the new thread.
                }
            }
            else {
                eventHistoryList.Items.Clear(); // Clear all the items from the ListView.

                // Create a new thread to display the data on the ListView.
                Thread saveDataTh = new Thread(() => Invoke(new Action(() => { displayData(); })));
                saveDataTh.Start(); // Start the new thread.
            }
        }

        // Save all the data from the ListView into the Access Database
        private void saveEvents_Click(object sender, EventArgs e)
        {
            // Create a new thread to work with saving the data on the Access Database.
            Thread saveDataTh = new Thread(() => Invoke(new Action(() => { saveData(); })));
            saveDataTh.Start(); // Start the new thread.
        }

        // When the clearEvents button is clicked, all the items from the Events History List get deleted.
        // Does not save the items on the database, but asks the user if he wants to save before deleting.
        private void clearEvents_Click(object sender, EventArgs e)
        {
            if (eventHistoryList.Items.Count > 0)
            {
                DialogResult msg = MessageBox.Show("Are you sure you want to clear the Events History List?", "Delete History?", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    eventHistoryList.Items.Clear();
                }
            }
        }
        #endregion

        // Functions responsible for displaying data into the ListView and Saving data into the DataSet.
        // Using the disconnect model.
        #region "Save & Load Events into the Event History List"
        // Load data from the Database to the DataSet.
        private void loadDatabaseData()
        {
            try
            {
                dataAdapt.Fill(dataSt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Sava data to the database.
        public void saveDatabaseData()
        {
            int rowsUpdated = 0;

            if (dataSt.Tables[0].Rows.Count != 0)
            {
                try
                {
                    DataSet newDataSt = dataSt.GetChanges();
                    rowsUpdated = dataAdapt.Update(newDataSt);
                    dataSt.Tables[0].AcceptChanges();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            if (rowsUpdated < 1)
            {
                reloadDataSet();
            }
        }

        // Reload the data into the DataSet from the Database.
        private void reloadDataSet()
        {
            dataSt.Clear();
            loadDatabaseData();
        }

        // Function responsible for loading data from the Access Database to the Events History List.
        public void displayData()
        {
            try
            {
                foreach (DataRow rowItem in dataSt.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = rowItem["dateTime"].ToString();
                    lvi.SubItems.Add(rowItem["Event"].ToString());

                    eventHistoryList.Items.Add(lvi);
                }
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        // Save data from the ListView to the DataSet.
        private void saveData()
        {
            DataRow newRow;
            foreach (ListViewItem item in eventHistoryList.Items) {
                newRow = dataSt.Tables[0].NewRow();
                newRow["dateTime"] = item.Text;
                newRow["Event"] = item.SubItems[1].Text;

                dataSt.Tables[0].Rows.Add(newRow);
            }
            
            saveDatabaseData(); // Call function to save the data to the database.
            
            saveEvents.Enabled = false; // Disable the button until a new item is added.
        }
        #endregion

    }
}
