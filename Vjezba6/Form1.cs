using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba6
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();

        public Form1()
        { 
            InitializeComponent();
        }
        
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void editPersonDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm((Person)listView1.SelectedItems[0].Tag);
            addPersonForm.ShowDialog(this);

            if (addPersonForm.DialogResult == DialogResult.OK)
            {
                var newPerson = addPersonForm.getNewPerson();
                listView1.Items.Clear();
                foreach (var person in persons)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = person.name;
                    item.Tag = person;
                    item.SubItems.Add(person.lastName);
                    listView1.Items.Add(item);
                }
                addPersonForm.Dispose();
            }
            else
            {
                addPersonForm.Dispose();
            }
        }

        private void newPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.ShowDialog(this);

            if (addPersonForm.DialogResult == DialogResult.OK)
            {
                Person newPerson = addPersonForm.getNewPerson();
                persons.Add(newPerson);
                listView1.Items.Clear();
                foreach (var person in persons)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = person.name;
                    item.Tag = person;
                    item.SubItems.Add(person.lastName);
                    listView1.Items.Add(item);
                }
                addPersonForm.Dispose();
            }
            else
            {
                addPersonForm.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
