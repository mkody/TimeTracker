namespace TimeTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.tbxAddEntry = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsBtnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackupNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.tslblProtip = new System.Windows.Forms.ToolStripLabel();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEntry.Location = new System.Drawing.Point(920, 33);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(75, 27);
            this.btnAddEntry.TabIndex = 1;
            this.btnAddEntry.Text = "Add";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // tbxAddEntry
            // 
            this.tbxAddEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAddEntry.Location = new System.Drawing.Point(12, 35);
            this.tbxAddEntry.Name = "tbxAddEntry";
            this.tbxAddEntry.Size = new System.Drawing.Size(901, 22);
            this.tbxAddEntry.TabIndex = 0;
            this.tbxAddEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAddEntry_KeyDown);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TimeTracker App";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFile,
            this.tslblProtip});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1007, 27);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "tsMain";
            // 
            // tsBtnFile
            // 
            this.tsBtnFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackup,
            this.tsmiBackupNew,
            this.tsmiQuit});
            this.tsBtnFile.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFile.Image")));
            this.tsBtnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFile.Name = "tsBtnFile";
            this.tsBtnFile.ShowDropDownArrow = false;
            this.tsBtnFile.Size = new System.Drawing.Size(45, 24);
            this.tsBtnFile.Text = "File...";
            // 
            // tsmiBackup
            // 
            this.tsmiBackup.Name = "tsmiBackup";
            this.tsmiBackup.Size = new System.Drawing.Size(192, 26);
            this.tsmiBackup.Text = "Backup";
            this.tsmiBackup.Click += new System.EventHandler(this.tsmiBackup_Click);
            // 
            // tsmiBackupNew
            // 
            this.tsmiBackupNew.Name = "tsmiBackupNew";
            this.tsmiBackupNew.Size = new System.Drawing.Size(192, 26);
            this.tsmiBackupNew.Text = "Backup and new";
            this.tsmiBackupNew.Click += new System.EventHandler(this.tsmiBackupNew_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(192, 26);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(12, 64);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersVisible = false;
            this.dtGrid.RowTemplate.Height = 24;
            this.dtGrid.Size = new System.Drawing.Size(983, 289);
            this.dtGrid.TabIndex = 3;
            this.dtGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtGrid_CellFormatting);
            this.dtGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellValueChanged);
            // 
            // tslblProtip
            // 
            this.tslblProtip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblProtip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.tslblProtip.Name = "tslblProtip";
            this.tslblProtip.Size = new System.Drawing.Size(280, 24);
            this.tslblProtip.Text = "Protip: CTRL+SHIFT+T to bring up the app";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 365);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tbxAddEntry);
            this.Controls.Add(this.btnAddEntry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TimeTracker";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.TextBox tbxAddEntry;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsBtnFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackup;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackupNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.ToolStripLabel tslblProtip;
    }
}

