namespace MeaningOfLife
{
    public partial class MOL_Form : Form
    {
        public MOL_Form()
        {
            InitializeComponent();
        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            this.textLabel.Visible = false;
            this.revealButton.Visible = false;

            this.newTextLabel.Visible = true;
            this.secondNewTextLabel.Visible = true;
        }
    }
}
