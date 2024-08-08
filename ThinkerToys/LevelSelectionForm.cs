namespace ThinkerToys
{
    public partial class LevelSelectionForm : Form
    {
        public LevelSelectionForm()
        {
            InitializeComponent();
            InitializeCustomComponents(); // Call the custom initialization method
        }

        private void LevelSelectionForm_Load(object sender, EventArgs e)
        {
            // Handle form load event if needed
        }

        private void InitializeCustomComponents()
        {



        }

        private void OpenLevel(char levelLetter)
        {
            HebrewGame1 gameForm = new HebrewGame1(levelLetter);
            gameForm.Show();
            this.Hide(); // Hide the selection form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenLevel('א');
        }

        private void בButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ב');

        }

        private void גButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ג');

        }

        private void דButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ד');

        }

        private void הButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ה');

        }
        private void וButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ו');

        }
        private void הזButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ז');

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenLevel('ז');

        }

        private void וButton_Click_1(object sender, EventArgs e)
        {
            OpenLevel('ו');

        }

        private void חButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ח');

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenLevel('ט');

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OpenLevel('ע');

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OpenLevel('צ');

        }

        private void יButton_Click(object sender, EventArgs e)
        {
            OpenLevel('י');

        }

        private void כButton_Click(object sender, EventArgs e)
        {
            OpenLevel('כ');

        }

        private void לButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ל');

        }

        private void מButton_Click(object sender, EventArgs e)
        {
            OpenLevel('מ');
        }

        private void נButton_Click(object sender, EventArgs e)
        {
            OpenLevel('נ');

        }

        private void סButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ס');

        }

        private void פButton_Click(object sender, EventArgs e)
        {
            OpenLevel('פ');

        }

        private void קButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ק');

        }

        private void רButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ר');

        }

        private void שButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ש');

        }

        private void תButton_Click(object sender, EventArgs e)
        {
            OpenLevel('ת');

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void דButton_Click_1(object sender, EventArgs e)
        {
            OpenLevel('ד');

        }

        private void הButton_Click_1(object sender, EventArgs e)
        {
            OpenLevel('ה');

        }
    }
}
