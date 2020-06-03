using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace Labs
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class AppForm : System.Windows.Forms.Form
	{		
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.Panel panel1;
		private IContainer components;
		private ContextMenuStrip contextMenuStrip2;
		private ToolStripMenuItem viewPersonToolStripMenuItem;
		private MenuItem menuItem1;
		private MainMenu mainMenu1;
		private int indexOfLabelInUse;


		public AppForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			listView1.AllowDrop = true;
			listView1.DragEnter += new DragEventHandler(listView1_DragEnter);
			listView1.DragDrop += new DragEventHandler(listView1_DragDrop);

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenu = this.contextMenu1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(326, 355);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.DoubleClick += new System.EventHandler(this.ShowPersonData_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 128;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ContextMenuStrip = this.contextMenuStrip2;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(326, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 355);
            this.panel1.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPersonToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(158, 28);
            // 
            // viewPersonToolStripMenuItem
            // 
            this.viewPersonToolStripMenuItem.Name = "viewPersonToolStripMenuItem";
            this.viewPersonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.viewPersonToolStripMenuItem.Text = "View Person";
			this.viewPersonToolStripMenuItem.Click += new System.EventHandler(this.viewPersonToolStripMenuItem_Click);
			//this.viewPersonToolStripMenuItem.Click += new System.EventHandler(this.viewPersonToolStripMenuItem_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
            this.menuItem1.Text = "New Person";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // AppForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(576, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Menu = this.mainMenu1;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab3_4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new AppForm());
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			PersonPropertiesForm ppf=new PersonPropertiesForm();
			ppf.ShowDialog(this);
			if(ppf.DialogResult==DialogResult.OK)
			{
				try
				{
					string name=ppf.getNameTextBoxText();
					string lastName=ppf.getLastNameTextBoxText();
					int age=System.Convert.ToInt32(ppf.getAgeTextBoxText());
					string city=ppf.getCityComboBoxText();
					Person p=new Person(name,lastName,age,city);

					string[] str=new string[2]{name,lastName};
					ListViewItem lvi=new ListViewItem(str);
					lvi.Tag=p;
					listView1.Items.Add(lvi);

					///
					MyLabel label=new MyLabel(p.Index);
					label.MouseDown += new MouseEventHandler(label1_MouseDown);

					panel1.Controls.Add(label);
					


				}
				catch
				{
					
				}

			}
			ppf.Dispose();
		
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			if(listView1.SelectedItems.Count>0)
			{
				contextMenu1.MenuItems.Clear();

				MenuItem menuItem1 = new MenuItem("Show Person data");
				menuItem1.Click += new System.EventHandler(this.ShowPersonData_Click);
				contextMenu1.MenuItems.Add(menuItem1);				

			}
		}

		private void ShowPersonData_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedItems.Count>0)
			{
				ListViewItem lvi=listView1.SelectedItems[0];
				Person p=(Person)lvi.Tag;

				PersonPropertiesForm ppf=new PersonPropertiesForm(p);
				ppf.ShowDialog(this);
				if(ppf.DialogResult==DialogResult.OK)
				{
					try
					{
						p.Name=ppf.getNameTextBoxText();
						p.LastName=ppf.getLastNameTextBoxText();
						p.Age=System.Convert.ToInt32(ppf.getAgeTextBoxText());
						p.City=ppf.getCityComboBoxText();
					
						lvi.SubItems[0].Text=p.Name;
						lvi.SubItems[1].Text=p.LastName;
					}
					catch
					{
					
					}

				}
				ppf.Dispose();
			}

		}

		private void listView1_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
		{
			
			ListViewItem dragedLvi = (ListViewItem)e.Item;
										
			if(DragDropEffects.Move==listView1.DoDragDrop(dragedLvi,DragDropEffects.Move)) 
			{
				listView1.Items.Remove(dragedLvi);
			}
		}
		void label1_MouseDown(object sender, MouseEventArgs e)
		{

			Label label = (Label)sender;
			indexOfLabelInUse = label.TabIndex;

			DoDragDrop(panel1.Controls[indexOfLabelInUse].Tag, DragDropEffects.Move);

			if (e.Button.ToString() == "Right")
			{
				contextMenuStrip2.Show(this, new Point(e.X, e.Y));
			}
		}

		void listView1_DragEnter(object sender, DragEventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			listViewItem = (ListViewItem)e.Data.GetData(DataFormats.Serializable);
			
			if (!listView1.Items.Contains(listViewItem))
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
			
		}

		
		void listView1_DragDrop(object sender, DragEventArgs e)
		{
			

		}

		private void viewPersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListViewItem lvi = (ListViewItem)panel1.Controls[indexOfLabelInUse].Tag;
			Person p = (Person)lvi.Tag;

			PersonPropertiesForm ppf = new PersonPropertiesForm(p);
			ppf.ShowDialog(this);
		}
	}
}
