namespace KtubaDateToXML
{
    public partial class KtubaDateForm : Form
    {

        public KtubaDateForm()
        {
            InitializeComponent();
        }

        public void KtubaDateForm_Load(object sender, EventArgs e)
        {
            yearBox.SelectedIndex = 0;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (!validate())
                { return; }


        }

        private bool validate()
        {
            return yearBox.SelectedIndex != -1 && monthBox.SelectedIndex != -1 && dayMonthBox.SelectedIndex != -1 && dayWeekBox.SelectedIndex != -1;
        }
    }
}
