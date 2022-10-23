using LibSQLiteData;

namespace SQLiteTESTwithDapper
{
    public partial class FrmMain : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public FrmMain()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            //people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            //people.Add(new PersonModel { FirstName = "John", LastName = "Doe" });
            //people.Add(new PersonModel { FirstName = "Mary", LastName = "Smith" });
            people = SQLiteDataAccess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            lbxPeopleListBox.DataSource = null;
            lbxPeopleListBox.DataSource = people;
            lbxPeopleListBox.DisplayMember = "FullName";
        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel();
            person.FirstName = txbFirstName.Text;
            person.LastName = txbLastName.Text;

            //people.Add(person);
            SQLiteDataAccess.SavePerson(person);

            txbFirstName.Text = "";
            txbLastName.Text = "";
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }
    }
}