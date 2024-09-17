namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] locations = { "Ulaanbaatar", "Monaco" };
            Loc.Items.AddRange(locations);

            string[] destinations = { "Ulaanbaatar", "Monaco" };
            Des.Items.AddRange(destinations);

            string[] services = { "BABYSIT", "Nurse" };
            Serv.Items.AddRange(services);

            string[] services2 = { "Business", "Economy" };
            Type.Items.AddRange(services2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Des.SelectedItem != null && Loc.SelectedItem != null)
            {
                if (Des.SelectedItem.ToString() == Loc.SelectedItem.ToString())
                {
                    MessageBox.Show("Ochih gazar, yawah gazar ijil baih bolomjgui.");
                }
            }
            else`
            {
                MessageBox.Show("Bairshilaa songonuu.");
            }
        }

        private void цэвэрлэх_Click(object sender, EventArgs e)
        {
            Flno.Text = "";
            Cusno.Text = "";
            Pasno.Text = "";
            Loc.SelectedIndex = -1;
            Des.SelectedIndex = -1;
            Serv.SelectedIndex = -1;
            Type.SelectedIndex = -1;
        }
    }
}
