using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Dashboard : Form
    {
        private List<People> _peoples = new List<People>();
        public Dashboard()
        {
            InitializeComponent();
           
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            PeopleFoundList.DataSource = _peoples;
            PeopleFoundList.DisplayMember = "FullInfo";
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();
            _peoples = db.GetPeople(LastNameText.Text);
            
            UpdateBinding();
        }
    }
}