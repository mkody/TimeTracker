using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;
using CsvHelper;
using GlobalHotKey;

// sorry, no comments in this code (except this one)
namespace TimeTracker
{
    public partial class MainForm : Form
    {
        private List<TimeElement> ourElements = new List<TimeElement>();
        private HotKeyManager hotKeyManager;

        public MainForm()
        {
            try
            {
                using (var sr = new StreamReader(@"elements.csv"))
                {
                    var reader = new CsvReader(sr);
                    reader.Configuration.HasHeaderRecord = false;

                    var records = reader.GetRecords<TimeElement>();
                    foreach (var record in records)
                    {
                        this.ourElements.Add(record);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Elements.csv doesn't exists.");
            }

            InitializeComponent();
            CreatingGrid();

            this.hotKeyManager = new HotKeyManager();
            var hotKey = this.hotKeyManager.Register(Key.T, System.Windows.Input.ModifierKeys.Shift | System.Windows.Input.ModifierKeys.Control);
            this.hotKeyManager.KeyPressed += HotKeyManagerPressed;
        }

        public void CreatingGrid()
        {
            dtGrid.AutoGenerateColumns = false;
            dtGrid.DataSource = this.ourElements;

            DataGridViewTextBoxColumn colTs = new DataGridViewTextBoxColumn();
            colTs.Name = "Timestamp";
            colTs.HeaderText = "Date";
            colTs.DataPropertyName = "Timestamp";
            colTs.ReadOnly = true;
            colTs.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGrid.Columns.Add(colTs);

            DataGridViewTextBoxColumn colDesc = new DataGridViewTextBoxColumn();
            colDesc.Name = "Description";
            colDesc.HeaderText = "Description";
            colDesc.DataPropertyName = "Description";
            colDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGrid.Columns.Add(colDesc);
        }
        
        private void addEntry()
        {
            long timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
            String description = tbxAddEntry.Text;

            this.ourElements.Add(new TimeElement(timestamp, description));

            saveElements();
            tbxAddEntry.ResetText();
        }

        private void saveElements()
        {
            using (var sw = new StreamWriter(@"elements.csv"))
            {
                var writer = new CsvWriter(sw);
                writer.Configuration.HasHeaderRecord = false;
                writer.WriteRecords<TimeElement>(this.ourElements);
            }

            dtGrid.DataSource = null;
            dtGrid.DataSource = this.ourElements;
            dtGrid.FirstDisplayedScrollingRowIndex = dtGrid.RowCount - 1;
        }

        private void saveBackup()
        {
            long ts = DateTimeOffset.Now.ToUnixTimeSeconds();
            using (var sw = new StreamWriter(@"elements." + ts.ToString() + ".csv"))
            {
                var writer = new CsvWriter(sw);
                writer.Configuration.HasHeaderRecord = false;
                writer.WriteRecords<TimeElement>(this.ourElements);
            }
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            addEntry();
        }

        private void tbxAddEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addEntry();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tsmiBackup_Click(object sender, EventArgs e)
        {
            saveBackup();
        }

        private void tsmiBackupNew_Click(object sender, EventArgs e)
        {
            saveBackup();
            this.ourElements = new List<TimeElement>();
            dtGrid.DataSource = null;
            dtGrid.DataSource = this.ourElements;
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            saveElements();
        }

        private void dtGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtGrid.Columns[e.ColumnIndex].Name == "Timestamp")
            {
                if (e.Value != null)
                {
                    long temp = (long)e.Value;
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(temp);
                    e.Value = dateTimeOffset.ToLocalTime();
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (dtGrid.RowCount > 0)
            {
                dtGrid.FirstDisplayedScrollingRowIndex = dtGrid.RowCount - 1;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void HotKeyManagerPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.HotKey.Key == Key.T)
            {
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }
    }
}
