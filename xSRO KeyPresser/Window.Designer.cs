using System.Windows.Forms;

namespace xSRO_KeyPresser
{
	partial class Window
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.rbBuffer = new System.Windows.Forms.RadioButton();
			this.rbAttacker = new System.Windows.Forms.RadioButton();
			this.lblTimer = new System.Windows.Forms.Label();
			this.lstKeys = new xSRO_KeyPresser.ListViewEx();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mKeys = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.keyEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSRemoveOne = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSScript = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSScriptSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSScriptLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.mKSScriptReload = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbRandom = new System.Windows.Forms.RadioButton();
			this.rbOrder = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddKeySetting = new System.Windows.Forms.Button();
			this.tbxKSDesc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbxKSCasttime = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxKSCooldown = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxKSNumber = new System.Windows.Forms.ComboBox();
			this.cbxKSFKey = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lstBuffs = new xSRO_KeyPresser.ListViewEx();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mBuffs = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSRemoveOne = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSScript = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSScriptSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSScriptLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.mSSScriptReload = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnAddSkillSetting = new System.Windows.Forms.Button();
			this.tbxSSDesc = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbxSSCasttime = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbxSSCooldown = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbxSSNumber = new System.Windows.Forms.ComboBox();
			this.cbxSSFKey = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnEditNick = new System.Windows.Forms.Button();
			this.tbxNickname = new System.Windows.Forms.TextBox();
			this.lstParty = new xSRO_KeyPresser.ListViewEx();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.tbxBetweenBuffs = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbxCastOwnLast = new System.Windows.Forms.CheckBox();
			this.tbxBackToClient = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnSaveSettings = new System.Windows.Forms.Button();
			this.tbxClientTitle = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.tbxClientProcessName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnHideClient = new System.Windows.Forms.Button();
			this.btnReduceMemory = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnKill = new System.Windows.Forms.Button();
			this.lstClients = new System.Windows.Forms.ListView();
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnShowClient = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.lblAbout04 = new System.Windows.Forms.Label();
			this.lblAbout03 = new System.Windows.Forms.Label();
			this.lblAbout02 = new System.Windows.Forms.Label();
			this.lblAbout01 = new System.Windows.Forms.Label();
			this.btnSupportMe = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.mNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mHideWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.mKeys.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.mBuffs.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.mNotifyIcon.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Controls.Add(this.tabPage4);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(397, 452);
			this.tabControl.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.lstKeys);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(389, 421);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "AutoAttacker";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnStartStop);
			this.groupBox3.Controls.Add(this.rbBuffer);
			this.groupBox3.Controls.Add(this.rbAttacker);
			this.groupBox3.Controls.Add(this.lblTimer);
			this.groupBox3.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.Gray;
			this.groupBox3.Location = new System.Drawing.Point(197, 57);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(185, 92);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "KeyPresser Status";
			// 
			// btnStartStop
			// 
			this.btnStartStop.BackColor = System.Drawing.Color.Green;
			this.btnStartStop.FlatAppearance.BorderSize = 0;
			this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartStop.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnStartStop.ForeColor = System.Drawing.Color.White;
			this.btnStartStop.Location = new System.Drawing.Point(6, 42);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(173, 23);
			this.btnStartStop.TabIndex = 0;
			this.btnStartStop.Text = "START";
			this.toolTip.SetToolTip(this.btnStartStop, "Press F5 to start/stop");
			this.btnStartStop.UseVisualStyleBackColor = false;
			this.btnStartStop.Click += new System.EventHandler(this.btn_Click);
			// 
			// rbBuffer
			// 
			this.rbBuffer.Font = new System.Drawing.Font("Corbel", 9.75F);
			this.rbBuffer.ForeColor = System.Drawing.Color.Black;
			this.rbBuffer.Location = new System.Drawing.Point(99, 20);
			this.rbBuffer.Name = "rbBuffer";
			this.rbBuffer.Size = new System.Drawing.Size(80, 19);
			this.rbBuffer.TabIndex = 6;
			this.rbBuffer.TabStop = true;
			this.rbBuffer.Text = "Buffer";
			this.rbBuffer.UseVisualStyleBackColor = true;
			// 
			// rbAttacker
			// 
			this.rbAttacker.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rbAttacker.Font = new System.Drawing.Font("Corbel", 9.75F);
			this.rbAttacker.ForeColor = System.Drawing.Color.Black;
			this.rbAttacker.Location = new System.Drawing.Point(6, 20);
			this.rbAttacker.Name = "rbAttacker";
			this.rbAttacker.Size = new System.Drawing.Size(80, 19);
			this.rbAttacker.TabIndex = 5;
			this.rbAttacker.TabStop = true;
			this.rbAttacker.Text = "Attacker";
			this.rbAttacker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rbAttacker.UseVisualStyleBackColor = true;
			// 
			// lblTimer
			// 
			this.lblTimer.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.ForeColor = System.Drawing.Color.Black;
			this.lblTimer.Location = new System.Drawing.Point(6, 66);
			this.lblTimer.Margin = new System.Windows.Forms.Padding(0);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(173, 25);
			this.lblTimer.TabIndex = 4;
			this.lblTimer.Text = "Time :  00:00:00";
			this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstKeys
			// 
			this.lstKeys.CheckBoxes = true;
			this.lstKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lstKeys.ContextMenuStrip = this.mKeys;
			this.lstKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstKeys.FullRowSelect = true;
			this.lstKeys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstKeys.LineAfter = -1;
			this.lstKeys.LineBefore = -1;
			this.lstKeys.Location = new System.Drawing.Point(6, 155);
			this.lstKeys.MultiSelect = false;
			this.lstKeys.Name = "lstKeys";
			this.lstKeys.Size = new System.Drawing.Size(376, 263);
			this.lstKeys.TabIndex = 2;
			this.lstKeys.UseCompatibleStateImageBehavior = false;
			this.lstKeys.View = System.Windows.Forms.View.Details;
			this.lstKeys.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumWidthChanging);
			this.lstKeys.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListView_ItemChecked);
			this.lstKeys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewDrag_MouseDown);
			this.lstKeys.MouseEnter += new System.EventHandler(this.menuKeys_Enter);
			this.lstKeys.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewDrag_MouseMove);
			this.lstKeys.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewDrag_MouseUp);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Keys to use";
			this.columnHeader1.Width = 95;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Cooldown";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 69;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Cast time";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 63;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Skill Description";
			this.columnHeader4.Width = 128;
			// 
			// mKeys
			// 
			this.mKeys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyEditToolStripMenuItem,
            this.mKSRemove,
            this.mKSScript});
			this.mKeys.Name = "contextMenuStrip1";
			this.mKeys.ShowImageMargin = false;
			this.mKeys.Size = new System.Drawing.Size(102, 70);
			// 
			// keyEditToolStripMenuItem
			// 
			this.keyEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKSLoad,
            this.mKSSave});
			this.keyEditToolStripMenuItem.Name = "keyEditToolStripMenuItem";
			this.keyEditToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.keyEditToolStripMenuItem.Text = "Edit";
			// 
			// mKSLoad
			// 
			this.mKSLoad.Name = "mKSLoad";
			this.mKSLoad.Size = new System.Drawing.Size(100, 22);
			this.mKSLoad.Text = "Load";
			this.mKSLoad.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mKSSave
			// 
			this.mKSSave.Name = "mKSSave";
			this.mKSSave.Size = new System.Drawing.Size(100, 22);
			this.mKSSave.Text = "Save";
			this.mKSSave.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mKSRemove
			// 
			this.mKSRemove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKSRemoveOne,
            this.mKSRemoveAll});
			this.mKSRemove.Name = "mKSRemove";
			this.mKSRemove.Size = new System.Drawing.Size(101, 22);
			this.mKSRemove.Text = "Remove";
			// 
			// mKSRemoveOne
			// 
			this.mKSRemoveOne.Name = "mKSRemoveOne";
			this.mKSRemoveOne.Size = new System.Drawing.Size(139, 22);
			this.mKSRemoveOne.Text = "Remove Key";
			this.mKSRemoveOne.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mKSRemoveAll
			// 
			this.mKSRemoveAll.Name = "mKSRemoveAll";
			this.mKSRemoveAll.Size = new System.Drawing.Size(139, 22);
			this.mKSRemoveAll.Text = "Remove All";
			this.mKSRemoveAll.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mKSScript
			// 
			this.mKSScript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKSScriptSave,
            this.mKSScriptLoad,
            this.mKSScriptReload});
			this.mKSScript.Name = "mKSScript";
			this.mKSScript.Size = new System.Drawing.Size(101, 22);
			this.mKSScript.Text = "Key Script";
			// 
			// mKSScriptSave
			// 
			this.mKSScriptSave.Name = "mKSScriptSave";
			this.mKSScriptSave.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
			this.mKSScriptSave.Size = new System.Drawing.Size(110, 22);
			this.mKSScriptSave.Text = "Save";
			this.mKSScriptSave.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mKSScriptLoad
			// 
			this.mKSScriptLoad.Name = "mKSScriptLoad";
			this.mKSScriptLoad.Size = new System.Drawing.Size(110, 22);
			this.mKSScriptLoad.Text = "Load";
			this.mKSScriptLoad.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mKSScriptReload
			// 
			this.mKSScriptReload.Name = "mKSScriptReload";
			this.mKSScriptReload.Size = new System.Drawing.Size(110, 22);
			this.mKSScriptReload.Text = "Reload";
			this.mKSScriptReload.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbRandom);
			this.groupBox2.Controls.Add(this.rbOrder);
			this.groupBox2.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Gray;
			this.groupBox2.Location = new System.Drawing.Point(197, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(185, 45);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Casting Type";
			// 
			// rbRandom
			// 
			this.rbRandom.Font = new System.Drawing.Font("Corbel", 9.75F);
			this.rbRandom.ForeColor = System.Drawing.Color.Black;
			this.rbRandom.Location = new System.Drawing.Point(99, 20);
			this.rbRandom.Name = "rbRandom";
			this.rbRandom.Size = new System.Drawing.Size(80, 19);
			this.rbRandom.TabIndex = 1;
			this.rbRandom.TabStop = true;
			this.rbRandom.Text = "Random";
			this.rbRandom.UseVisualStyleBackColor = true;
			// 
			// rbOrder
			// 
			this.rbOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rbOrder.Font = new System.Drawing.Font("Corbel", 9.75F);
			this.rbOrder.ForeColor = System.Drawing.Color.Black;
			this.rbOrder.Location = new System.Drawing.Point(6, 20);
			this.rbOrder.Name = "rbOrder";
			this.rbOrder.Size = new System.Drawing.Size(80, 19);
			this.rbOrder.TabIndex = 0;
			this.rbOrder.TabStop = true;
			this.rbOrder.Text = "In Order";
			this.rbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rbOrder.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddKeySetting);
			this.groupBox1.Controls.Add(this.tbxKSDesc);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbxKSCasttime);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbxKSCooldown);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbxKSNumber);
			this.groupBox1.Controls.Add(this.cbxKSFKey);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Gray;
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(185, 143);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Key Setting";
			// 
			// btnAddKeySetting
			// 
			this.btnAddKeySetting.AutoSize = true;
			this.btnAddKeySetting.BackColor = System.Drawing.Color.Green;
			this.btnAddKeySetting.FlatAppearance.BorderSize = 0;
			this.btnAddKeySetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddKeySetting.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddKeySetting.ForeColor = System.Drawing.Color.White;
			this.btnAddKeySetting.Location = new System.Drawing.Point(155, 108);
			this.btnAddKeySetting.Name = "btnAddKeySetting";
			this.btnAddKeySetting.Size = new System.Drawing.Size(24, 25);
			this.btnAddKeySetting.TabIndex = 9;
			this.btnAddKeySetting.Text = "+";
			this.btnAddKeySetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddKeySetting.UseVisualStyleBackColor = false;
			this.btnAddKeySetting.Click += new System.EventHandler(this.btn_Click);
			// 
			// tbxKSDesc
			// 
			this.tbxKSDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxKSDesc.Location = new System.Drawing.Point(78, 109);
			this.tbxKSDesc.MaxLength = 20;
			this.tbxKSDesc.Name = "tbxKSDesc";
			this.tbxKSDesc.Size = new System.Drawing.Size(70, 21);
			this.tbxKSDesc.TabIndex = 8;
			this.tbxKSDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(6, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Description  [ - - - - - - ]  ";
			// 
			// tbxKSCasttime
			// 
			this.tbxKSCasttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxKSCasttime.Location = new System.Drawing.Point(108, 79);
			this.tbxKSCasttime.MaxLength = 4;
			this.tbxKSCasttime.Name = "tbxKSCasttime";
			this.tbxKSCasttime.Size = new System.Drawing.Size(40, 21);
			this.tbxKSCasttime.TabIndex = 6;
			this.tbxKSCasttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbxKSCasttime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumber_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(6, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Skill casting time  [ - - - - ]  ms";
			// 
			// tbxKSCooldown
			// 
			this.tbxKSCooldown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxKSCooldown.Location = new System.Drawing.Point(72, 49);
			this.tbxKSCooldown.MaxLength = 4;
			this.tbxKSCooldown.Name = "tbxKSCooldown";
			this.tbxKSCooldown.Size = new System.Drawing.Size(40, 21);
			this.tbxKSCooldown.TabIndex = 4;
			this.tbxKSCooldown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbxKSCooldown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumber_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(6, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cooldown   [ - - - - ]  seconds";
			// 
			// cbxKSNumber
			// 
			this.cbxKSNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxKSNumber.DropDownWidth = 72;
			this.cbxKSNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbxKSNumber.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxKSNumber.IntegralHeight = false;
			this.cbxKSNumber.Location = new System.Drawing.Point(128, 19);
			this.cbxKSNumber.MaxDropDownItems = 10;
			this.cbxKSNumber.Name = "cbxKSNumber";
			this.cbxKSNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbxKSNumber.Size = new System.Drawing.Size(40, 23);
			this.cbxKSNumber.TabIndex = 2;
			// 
			// cbxKSFKey
			// 
			this.cbxKSFKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxKSFKey.DropDownWidth = 72;
			this.cbxKSFKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbxKSFKey.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxKSFKey.IntegralHeight = false;
			this.cbxKSFKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "Custom Key"});
			this.cbxKSFKey.Location = new System.Drawing.Point(45, 19);
			this.cbxKSFKey.MaxDropDownItems = 10;
			this.cbxKSFKey.Name = "cbxKSFKey";
			this.cbxKSFKey.Size = new System.Drawing.Size(40, 23);
			this.cbxKSFKey.TabIndex = 1;
			this.cbxKSFKey.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectionChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Using  [ - - - - ]   Press  [ - - - - ]";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lstBuffs);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(389, 421);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "AutoBuffer";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lstBuffs
			// 
			this.lstBuffs.CheckBoxes = true;
			this.lstBuffs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.lstBuffs.ContextMenuStrip = this.mBuffs;
			this.lstBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstBuffs.FullRowSelect = true;
			this.lstBuffs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstBuffs.LineAfter = -1;
			this.lstBuffs.LineBefore = -1;
			this.lstBuffs.Location = new System.Drawing.Point(6, 216);
			this.lstBuffs.MultiSelect = false;
			this.lstBuffs.Name = "lstBuffs";
			this.lstBuffs.Size = new System.Drawing.Size(376, 198);
			this.lstBuffs.TabIndex = 5;
			this.lstBuffs.UseCompatibleStateImageBehavior = false;
			this.lstBuffs.View = System.Windows.Forms.View.Details;
			this.lstBuffs.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumWidthChanging);
			this.lstBuffs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewDrag_MouseDown);
			this.lstBuffs.MouseEnter += new System.EventHandler(this.menuKeys_Enter);
			this.lstBuffs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewDrag_MouseMove);
			this.lstBuffs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewDrag_MouseUp);
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Keys to use";
			this.columnHeader7.Width = 95;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Cooldown";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 69;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Cast time";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 63;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Skill Description";
			this.columnHeader10.Width = 128;
			// 
			// mBuffs
			// 
			this.mBuffs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.mSSRemove,
            this.mSSScript});
			this.mBuffs.Name = "contextMenuStrip1";
			this.mBuffs.ShowImageMargin = false;
			this.mBuffs.Size = new System.Drawing.Size(102, 70);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSSLoad,
            this.mSSSave});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// mSSLoad
			// 
			this.mSSLoad.Name = "mSSLoad";
			this.mSSLoad.Size = new System.Drawing.Size(100, 22);
			this.mSSLoad.Text = "Load";
			this.mSSLoad.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mSSSave
			// 
			this.mSSSave.Name = "mSSSave";
			this.mSSSave.Size = new System.Drawing.Size(100, 22);
			this.mSSSave.Text = "Save";
			this.mSSSave.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mSSRemove
			// 
			this.mSSRemove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSSRemoveOne,
            this.mSSRemoveAll});
			this.mSSRemove.Name = "mSSRemove";
			this.mSSRemove.Size = new System.Drawing.Size(101, 22);
			this.mSSRemove.Text = "Remove";
			// 
			// mSSRemoveOne
			// 
			this.mSSRemoveOne.Name = "mSSRemoveOne";
			this.mSSRemoveOne.Size = new System.Drawing.Size(139, 22);
			this.mSSRemoveOne.Text = "Remove Key";
			this.mSSRemoveOne.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mSSRemoveAll
			// 
			this.mSSRemoveAll.Name = "mSSRemoveAll";
			this.mSSRemoveAll.Size = new System.Drawing.Size(139, 22);
			this.mSSRemoveAll.Text = "Remove All";
			this.mSSRemoveAll.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mSSScript
			// 
			this.mSSScript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSSScriptSave,
            this.mSSScriptLoad,
            this.mSSScriptReload});
			this.mSSScript.Name = "mSSScript";
			this.mSSScript.Size = new System.Drawing.Size(101, 22);
			this.mSSScript.Text = "Key Script";
			// 
			// mSSScriptSave
			// 
			this.mSSScriptSave.Name = "mSSScriptSave";
			this.mSSScriptSave.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
			this.mSSScriptSave.Size = new System.Drawing.Size(110, 22);
			this.mSSScriptSave.Text = "Save";
			this.mSSScriptSave.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mSSScriptLoad
			// 
			this.mSSScriptLoad.Name = "mSSScriptLoad";
			this.mSSScriptLoad.Size = new System.Drawing.Size(110, 22);
			this.mSSScriptLoad.Text = "Load";
			this.mSSScriptLoad.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// mSSScriptReload
			// 
			this.mSSScriptReload.Name = "mSSScriptReload";
			this.mSSScriptReload.Size = new System.Drawing.Size(110, 22);
			this.mSSScriptReload.Text = "Reload";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.groupBox5);
			this.groupBox4.Controls.Add(this.btnEditNick);
			this.groupBox4.Controls.Add(this.tbxNickname);
			this.groupBox4.Controls.Add(this.lstParty);
			this.groupBox4.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.Gray;
			this.groupBox4.Location = new System.Drawing.Point(6, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(376, 204);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Party Setting";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btnAddSkillSetting);
			this.groupBox5.Controls.Add(this.tbxSSDesc);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.tbxSSCasttime);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.tbxSSCooldown);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.cbxSSNumber);
			this.groupBox5.Controls.Add(this.cbxSSFKey);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.ForeColor = System.Drawing.Color.Gray;
			this.groupBox5.Location = new System.Drawing.Point(185, 55);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(185, 143);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Skill Setting";
			// 
			// btnAddSkillSetting
			// 
			this.btnAddSkillSetting.BackColor = System.Drawing.Color.Green;
			this.btnAddSkillSetting.FlatAppearance.BorderSize = 0;
			this.btnAddSkillSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddSkillSetting.Font = new System.Drawing.Font("Corbel", 9.75F);
			this.btnAddSkillSetting.ForeColor = System.Drawing.Color.White;
			this.btnAddSkillSetting.Location = new System.Drawing.Point(155, 108);
			this.btnAddSkillSetting.Name = "btnAddSkillSetting";
			this.btnAddSkillSetting.Size = new System.Drawing.Size(23, 25);
			this.btnAddSkillSetting.TabIndex = 9;
			this.btnAddSkillSetting.Text = "+";
			this.btnAddSkillSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddSkillSetting.UseVisualStyleBackColor = false;
			this.btnAddSkillSetting.Click += new System.EventHandler(this.btn_Click);
			// 
			// tbxSSDesc
			// 
			this.tbxSSDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSSDesc.Location = new System.Drawing.Point(78, 109);
			this.tbxSSDesc.MaxLength = 20;
			this.tbxSSDesc.Name = "tbxSSDesc";
			this.tbxSSDesc.Size = new System.Drawing.Size(70, 21);
			this.tbxSSDesc.TabIndex = 8;
			this.tbxSSDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Corbel", 9.75F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(6, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "Description  [ - - - - - - ]  ";
			// 
			// tbxSSCasttime
			// 
			this.tbxSSCasttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSSCasttime.Location = new System.Drawing.Point(108, 78);
			this.tbxSSCasttime.MaxLength = 4;
			this.tbxSSCasttime.Name = "tbxSSCasttime";
			this.tbxSSCasttime.Size = new System.Drawing.Size(40, 21);
			this.tbxSSCasttime.TabIndex = 6;
			this.tbxSSCasttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Corbel", 9.75F);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(6, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(166, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Skill casting time  [ - - - - ]  ms";
			// 
			// tbxSSCooldown
			// 
			this.tbxSSCooldown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSSCooldown.Location = new System.Drawing.Point(72, 48);
			this.tbxSSCooldown.MaxLength = 4;
			this.tbxSSCooldown.Name = "tbxSSCooldown";
			this.tbxSSCooldown.Size = new System.Drawing.Size(40, 21);
			this.tbxSSCooldown.TabIndex = 4;
			this.tbxSSCooldown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Corbel", 9.75F);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(6, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(159, 15);
			this.label7.TabIndex = 3;
			this.label7.Text = "Cooldown   [ - - - - ]  seconds";
			// 
			// cbxSSNumber
			// 
			this.cbxSSNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSSNumber.DropDownWidth = 72;
			this.cbxSSNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbxSSNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSSNumber.IntegralHeight = false;
			this.cbxSSNumber.Location = new System.Drawing.Point(128, 19);
			this.cbxSSNumber.MaxDropDownItems = 10;
			this.cbxSSNumber.Name = "cbxSSNumber";
			this.cbxSSNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbxSSNumber.Size = new System.Drawing.Size(40, 23);
			this.cbxSSNumber.TabIndex = 2;
			// 
			// cbxSSFKey
			// 
			this.cbxSSFKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSSFKey.DropDownWidth = 72;
			this.cbxSSFKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbxSSFKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSSFKey.IntegralHeight = false;
			this.cbxSSFKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "Custom Key"});
			this.cbxSSFKey.Location = new System.Drawing.Point(45, 19);
			this.cbxSSFKey.MaxDropDownItems = 10;
			this.cbxSSFKey.Name = "cbxSSFKey";
			this.cbxSSFKey.Size = new System.Drawing.Size(40, 23);
			this.cbxSSFKey.TabIndex = 1;
			this.cbxSSFKey.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectionChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(6, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(164, 15);
			this.label8.TabIndex = 0;
			this.label8.Text = "Using  [ - - - - ]   Press  [ - - - - ]";
			// 
			// btnEditNick
			// 
			this.btnEditNick.AutoSize = true;
			this.btnEditNick.BackColor = System.Drawing.Color.Green;
			this.btnEditNick.FlatAppearance.BorderSize = 0;
			this.btnEditNick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditNick.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditNick.ForeColor = System.Drawing.Color.White;
			this.btnEditNick.Location = new System.Drawing.Point(331, 17);
			this.btnEditNick.Name = "btnEditNick";
			this.btnEditNick.Size = new System.Drawing.Size(39, 25);
			this.btnEditNick.TabIndex = 10;
			this.btnEditNick.Text = "Edit";
			this.btnEditNick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditNick.UseVisualStyleBackColor = false;
			this.btnEditNick.Click += new System.EventHandler(this.btn_Click);
			// 
			// tbxNickname
			// 
			this.tbxNickname.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxNickname.Location = new System.Drawing.Point(185, 17);
			this.tbxNickname.MaxLength = 16;
			this.tbxNickname.Name = "tbxNickname";
			this.tbxNickname.Size = new System.Drawing.Size(140, 26);
			this.tbxNickname.TabIndex = 9;
			this.tbxNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lstParty
			// 
			this.lstParty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
			this.lstParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstParty.FullRowSelect = true;
			this.lstParty.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstParty.HideSelection = false;
			this.lstParty.LineAfter = -1;
			this.lstParty.LineBefore = -1;
			this.lstParty.Location = new System.Drawing.Point(6, 17);
			this.lstParty.MultiSelect = false;
			this.lstParty.Name = "lstParty";
			this.lstParty.Size = new System.Drawing.Size(173, 180);
			this.lstParty.TabIndex = 3;
			this.lstParty.UseCompatibleStateImageBehavior = false;
			this.lstParty.View = System.Windows.Forms.View.Details;
			this.lstParty.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumWidthChanging);
			this.lstParty.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_SelectionChanged);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "#";
			this.columnHeader5.Width = 21;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Nickname";
			this.columnHeader6.Width = 131;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox6);
			this.tabPage3.Controls.Add(this.groupBox7);
			this.tabPage3.Location = new System.Drawing.Point(4, 27);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(389, 421);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Settings";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.tbxBetweenBuffs);
			this.groupBox6.Controls.Add(this.label10);
			this.groupBox6.Controls.Add(this.cbxCastOwnLast);
			this.groupBox6.Controls.Add(this.tbxBackToClient);
			this.groupBox6.Controls.Add(this.label9);
			this.groupBox6.Controls.Add(this.btnSaveSettings);
			this.groupBox6.Controls.Add(this.tbxClientTitle);
			this.groupBox6.Controls.Add(this.label12);
			this.groupBox6.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.groupBox6.ForeColor = System.Drawing.Color.Gray;
			this.groupBox6.Location = new System.Drawing.Point(6, 3);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(377, 143);
			this.groupBox6.TabIndex = 3;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Client Settings";
			// 
			// tbxBetweenBuffs
			// 
			this.tbxBetweenBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxBetweenBuffs.Location = new System.Drawing.Point(264, 79);
			this.tbxBetweenBuffs.MaxLength = 2;
			this.tbxBetweenBuffs.Name = "tbxBetweenBuffs";
			this.tbxBetweenBuffs.Size = new System.Drawing.Size(37, 22);
			this.tbxBetweenBuffs.TabIndex = 17;
			this.tbxBetweenBuffs.Text = "0";
			this.tbxBetweenBuffs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(6, 82);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(350, 15);
			this.label10.TabIndex = 16;
			this.label10.Text = "Waiting time between each teammate buffs  [ - - - ]   seconds";
			// 
			// cbxCastOwnLast
			// 
			this.cbxCastOwnLast.AutoSize = true;
			this.cbxCastOwnLast.Checked = true;
			this.cbxCastOwnLast.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxCastOwnLast.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCastOwnLast.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbxCastOwnLast.Location = new System.Drawing.Point(10, 112);
			this.cbxCastOwnLast.Name = "cbxCastOwnLast";
			this.cbxCastOwnLast.Size = new System.Drawing.Size(351, 19);
			this.cbxCastOwnLast.TabIndex = 15;
			this.cbxCastOwnLast.Text = "Cast your own buffs after all your teammates (in reverse)";
			this.cbxCastOwnLast.UseVisualStyleBackColor = true;
			// 
			// tbxBackToClient
			// 
			this.tbxBackToClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxBackToClient.Location = new System.Drawing.Point(41, 49);
			this.tbxBackToClient.MaxLength = 3;
			this.tbxBackToClient.Name = "tbxBackToClient";
			this.tbxBackToClient.Size = new System.Drawing.Size(37, 22);
			this.tbxBackToClient.TabIndex = 14;
			this.tbxBackToClient.Text = "3";
			this.tbxBackToClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(6, 52);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(358, 15);
			this.label9.TabIndex = 13;
			this.label9.Text = "Wait  [ - - - ]   seconds to get back to the window when running";
			// 
			// btnSaveSettings
			// 
			this.btnSaveSettings.AutoSize = true;
			this.btnSaveSettings.BackColor = System.Drawing.Color.Gray;
			this.btnSaveSettings.FlatAppearance.BorderSize = 0;
			this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveSettings.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
			this.btnSaveSettings.Location = new System.Drawing.Point(273, 17);
			this.btnSaveSettings.Name = "btnSaveSettings";
			this.btnSaveSettings.Size = new System.Drawing.Size(96, 26);
			this.btnSaveSettings.TabIndex = 11;
			this.btnSaveSettings.Text = "Save Settings";
			this.btnSaveSettings.UseVisualStyleBackColor = false;
			this.btnSaveSettings.Click += new System.EventHandler(this.btn_Click);
			// 
			// tbxClientTitle
			// 
			this.tbxClientTitle.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxClientTitle.Location = new System.Drawing.Point(139, 19);
			this.tbxClientTitle.MaxLength = 256;
			this.tbxClientTitle.Name = "tbxClientTitle";
			this.tbxClientTitle.Size = new System.Drawing.Size(126, 23);
			this.tbxClientTitle.TabIndex = 10;
			this.tbxClientTitle.Text = "SRO_Client";
			this.tbxClientTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(6, 22);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(134, 15);
			this.label12.TabIndex = 0;
			this.label12.Text = "Silkroad window title :";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.tbxClientProcessName);
			this.groupBox7.Controls.Add(this.label11);
			this.groupBox7.Controls.Add(this.btnHideClient);
			this.groupBox7.Controls.Add(this.btnReduceMemory);
			this.groupBox7.Controls.Add(this.btnRefresh);
			this.groupBox7.Controls.Add(this.btnKill);
			this.groupBox7.Controls.Add(this.lstClients);
			this.groupBox7.Controls.Add(this.btnShowClient);
			this.groupBox7.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.groupBox7.ForeColor = System.Drawing.Color.Gray;
			this.groupBox7.Location = new System.Drawing.Point(6, 152);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(377, 113);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Silkroad Process";
			// 
			// tbxClientProcessName
			// 
			this.tbxClientProcessName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxClientProcessName.Location = new System.Drawing.Point(286, 82);
			this.tbxClientProcessName.MaxLength = 256;
			this.tbxClientProcessName.Name = "tbxClientProcessName";
			this.tbxClientProcessName.Size = new System.Drawing.Size(83, 23);
			this.tbxClientProcessName.TabIndex = 19;
			this.tbxClientProcessName.Text = "sro_client";
			this.tbxClientProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(188, 83);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 18);
			this.label11.TabIndex = 18;
			this.label11.Text = "Process name :";
			// 
			// btnHideClient
			// 
			this.btnHideClient.AutoSize = true;
			this.btnHideClient.BackColor = System.Drawing.Color.Gray;
			this.btnHideClient.FlatAppearance.BorderSize = 0;
			this.btnHideClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHideClient.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnHideClient.ForeColor = System.Drawing.Color.White;
			this.btnHideClient.Location = new System.Drawing.Point(191, 47);
			this.btnHideClient.Margin = new System.Windows.Forms.Padding(2);
			this.btnHideClient.Name = "btnHideClient";
			this.btnHideClient.Size = new System.Drawing.Size(57, 26);
			this.btnHideClient.TabIndex = 17;
			this.btnHideClient.Text = "Hide";
			this.btnHideClient.UseVisualStyleBackColor = false;
			this.btnHideClient.Click += new System.EventHandler(this.btn_Click);
			// 
			// btnReduceMemory
			// 
			this.btnReduceMemory.AutoSize = true;
			this.btnReduceMemory.BackColor = System.Drawing.Color.Gray;
			this.btnReduceMemory.FlatAppearance.BorderSize = 0;
			this.btnReduceMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReduceMemory.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnReduceMemory.ForeColor = System.Drawing.Color.White;
			this.btnReduceMemory.Location = new System.Drawing.Point(257, 17);
			this.btnReduceMemory.Margin = new System.Windows.Forms.Padding(2);
			this.btnReduceMemory.Name = "btnReduceMemory";
			this.btnReduceMemory.Size = new System.Drawing.Size(113, 26);
			this.btnReduceMemory.TabIndex = 16;
			this.btnReduceMemory.Text = "Reduce Memory";
			this.btnReduceMemory.UseVisualStyleBackColor = false;
			this.btnReduceMemory.Click += new System.EventHandler(this.btn_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.AutoSize = true;
			this.btnRefresh.BackColor = System.Drawing.Color.Gray;
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Location = new System.Drawing.Point(191, 17);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(62, 26);
			this.btnRefresh.TabIndex = 14;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btn_Click);
			// 
			// btnKill
			// 
			this.btnKill.AutoSize = true;
			this.btnKill.BackColor = System.Drawing.Color.Gray;
			this.btnKill.FlatAppearance.BorderSize = 0;
			this.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKill.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnKill.ForeColor = System.Drawing.Color.White;
			this.btnKill.Location = new System.Drawing.Point(313, 47);
			this.btnKill.Margin = new System.Windows.Forms.Padding(2);
			this.btnKill.Name = "btnKill";
			this.btnKill.Size = new System.Drawing.Size(57, 26);
			this.btnKill.TabIndex = 13;
			this.btnKill.Text = "Kill";
			this.btnKill.UseVisualStyleBackColor = false;
			this.btnKill.Click += new System.EventHandler(this.btn_Click);
			// 
			// lstClients
			// 
			this.lstClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
			this.lstClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstClients.FullRowSelect = true;
			this.lstClients.HideSelection = false;
			this.lstClients.Location = new System.Drawing.Point(6, 17);
			this.lstClients.MultiSelect = false;
			this.lstClients.Name = "lstClients";
			this.lstClients.Size = new System.Drawing.Size(180, 88);
			this.lstClients.TabIndex = 0;
			this.lstClients.UseCompatibleStateImageBehavior = false;
			this.lstClients.View = System.Windows.Forms.View.Details;
			this.lstClients.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumWidthChanging);
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "PID";
			this.columnHeader11.Width = 40;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Window Title";
			this.columnHeader12.Width = 119;
			// 
			// btnShowClient
			// 
			this.btnShowClient.AutoSize = true;
			this.btnShowClient.BackColor = System.Drawing.Color.Gray;
			this.btnShowClient.FlatAppearance.BorderSize = 0;
			this.btnShowClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowClient.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnShowClient.ForeColor = System.Drawing.Color.White;
			this.btnShowClient.Location = new System.Drawing.Point(252, 47);
			this.btnShowClient.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowClient.Name = "btnShowClient";
			this.btnShowClient.Size = new System.Drawing.Size(57, 26);
			this.btnShowClient.TabIndex = 12;
			this.btnShowClient.Text = "Show";
			this.btnShowClient.UseVisualStyleBackColor = false;
			this.btnShowClient.Click += new System.EventHandler(this.btn_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.panel1);
			this.tabPage4.Location = new System.Drawing.Point(4, 27);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(389, 421);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "About";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::xSROKeyPresser.Properties.Resources.coffee;
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.lblAbout04);
			this.panel1.Controls.Add(this.lblAbout03);
			this.panel1.Controls.Add(this.lblAbout02);
			this.panel1.Controls.Add(this.lblAbout01);
			this.panel1.Controls.Add(this.btnSupportMe);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(389, 421);
			this.panel1.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.label13.Location = new System.Drawing.Point(3, 401);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label13.Size = new System.Drawing.Size(253, 20);
			this.label13.TabIndex = 6;
			this.label13.Text = "Contact me! Discord: JellyBitz#7645";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lblAbout04
			// 
			this.lblAbout04.AutoSize = true;
			this.lblAbout04.Font = new System.Drawing.Font("Corbel", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lblAbout04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.lblAbout04.Location = new System.Drawing.Point(57, 301);
			this.lblAbout04.Name = "lblAbout04";
			this.lblAbout04.Size = new System.Drawing.Size(109, 32);
			this.lblAbout04.TabIndex = 5;
			this.lblAbout04.Text = "JellyBitz";
			this.lblAbout04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAbout03
			// 
			this.lblAbout03.AutoSize = true;
			this.lblAbout03.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lblAbout03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.lblAbout03.Location = new System.Drawing.Point(33, 273);
			this.lblAbout03.Name = "lblAbout03";
			this.lblAbout03.Size = new System.Drawing.Size(77, 22);
			this.lblAbout03.TabIndex = 4;
			this.lblAbout03.Text = "Made By";
			this.lblAbout03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAbout02
			// 
			this.lblAbout02.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAbout02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblAbout02.Location = new System.Drawing.Point(20, 76);
			this.lblAbout02.Name = "lblAbout02";
			this.lblAbout02.Size = new System.Drawing.Size(174, 32);
			this.lblAbout02.TabIndex = 3;
			this.lblAbout02.Text = "Support my work!";
			this.lblAbout02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAbout01
			// 
			this.lblAbout01.Font = new System.Drawing.Font("Corbel", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lblAbout01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblAbout01.Location = new System.Drawing.Point(8, 29);
			this.lblAbout01.Name = "lblAbout01";
			this.lblAbout01.Size = new System.Drawing.Size(373, 47);
			this.lblAbout01.TabIndex = 2;
			this.lblAbout01.Text = "Do you like this software?";
			this.lblAbout01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSupportMe
			// 
			this.btnSupportMe.BackColor = System.Drawing.Color.Green;
			this.btnSupportMe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSupportMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSupportMe.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnSupportMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.btnSupportMe.Location = new System.Drawing.Point(25, 120);
			this.btnSupportMe.Name = "btnSupportMe";
			this.btnSupportMe.Size = new System.Drawing.Size(124, 30);
			this.btnSupportMe.TabIndex = 1;
			this.btnSupportMe.Text = "Buy me a coffee!";
			this.btnSupportMe.UseVisualStyleBackColor = false;
			this.btnSupportMe.Click += new System.EventHandler(this.btn_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.mNotifyIcon;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Chrome";
			this.notifyIcon.Visible = true;
			// 
			// mNotifyIcon
			// 
			this.mNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHideWindow});
			this.mNotifyIcon.Name = "mNotifyIcon";
			this.mNotifyIcon.Size = new System.Drawing.Size(100, 26);
			// 
			// mHideWindow
			// 
			this.mHideWindow.Name = "mHideWindow";
			this.mHideWindow.Size = new System.Drawing.Size(99, 22);
			this.mHideWindow.Text = "Hide";
			this.mHideWindow.Click += new System.EventHandler(this.menuKeys_Click);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 452);
			this.Controls.Add(this.tabControl);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Window";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "Key Presser for Origin Online.\\nAll versions supported.\\nOpening your eyes since " +
    "a year\\nCopyright © JellyBitz 2019";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
			this.Load += new System.EventHandler(this.Window_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.mKeys.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.mBuffs.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.mNotifyIcon.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControl;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private RadioButton rbOrder;
		private ComboBox cbxKSFKey;
		private Label label1;
		private ComboBox cbxKSNumber;
		private TextBox tbxKSCooldown;
		private Label label2;
		private TextBox tbxKSCasttime;
		private Label label3;
		private RadioButton rbRandom;
		private ListViewEx lstKeys;
		private NotifyIcon notifyIcon;
		private GroupBox groupBox3;
		private Button btnStartStop;
		private ContextMenuStrip mKeys;
		private ToolStripMenuItem mKSRemove;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private TextBox tbxKSDesc;
		private Label label4;
		private Button btnAddKeySetting;
		private Label lblTimer;
		private System.Windows.Forms.Timer timer;
		private ToolStripMenuItem mKSRemoveOne;
		private ToolStripMenuItem mKSRemoveAll;
		private ToolStripMenuItem mKSScript;
		private ToolStripMenuItem mKSScriptSave;
		private ToolStripMenuItem mKSScriptLoad;
		private GroupBox groupBox4;
		private ListViewEx lstParty;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private Button btnEditNick;
		private TextBox tbxNickname;
		private GroupBox groupBox5;
		private TextBox tbxSSDesc;
		private Label label5;
		private TextBox tbxSSCasttime;
		private Label label6;
		private TextBox tbxSSCooldown;
		private Label label7;
		private ComboBox cbxSSNumber;
		private ComboBox cbxSSFKey;
		private Label label8;
		private Button btnAddSkillSetting;
		private ListViewEx lstBuffs;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader10;
		private RadioButton rbBuffer;
		private RadioButton rbAttacker;
		private ContextMenuStrip mBuffs;
		private ToolStripMenuItem mSSRemove;
		private ToolStripMenuItem mSSRemoveOne;
		private ToolStripMenuItem mSSRemoveAll;
		private ToolStripMenuItem mSSScript;
		private ToolStripMenuItem mSSScriptSave;
		private ToolStripMenuItem mSSScriptLoad;
		private ToolTip toolTip;
		private ListView lstClients;
		private GroupBox groupBox7;
		private Button btnKill;
		private Button btnShowClient;
		private Button btnRefresh;
		private ColumnHeader columnHeader11;
		private ColumnHeader columnHeader12;
		private Button btnReduceMemory;
		private Button btnHideClient;
		private ContextMenuStrip mNotifyIcon;
		private ToolStripMenuItem mHideWindow;
		private TextBox tbxClientProcessName;
		private Label label11;
		private ToolStripMenuItem keyEditToolStripMenuItem;
		private ToolStripMenuItem mKSScriptReload;
		private ToolStripMenuItem mSSScriptReload;
		private ToolStripMenuItem mKSLoad;
		private ToolStripMenuItem mKSSave;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem mSSLoad;
		private ToolStripMenuItem mSSSave;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox tbxBetweenBuffs;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox cbxCastOwnLast;
		private System.Windows.Forms.TextBox tbxBackToClient;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnSaveSettings;
		private System.Windows.Forms.TextBox tbxClientTitle;
		private System.Windows.Forms.Label label12;
		private Panel panel1;
		private Button btnSupportMe;
		private Label lblAbout02;
		private Label lblAbout01;
		private Label label13;
		private Label lblAbout04;
		private Label lblAbout03;
	}
}

