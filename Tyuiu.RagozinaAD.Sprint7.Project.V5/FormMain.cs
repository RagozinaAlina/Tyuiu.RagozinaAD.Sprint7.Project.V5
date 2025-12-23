using Tyuiu.RagozinaAD.Sprint7.Project.V5.Lib;
namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    public partial class FormSprint : Form
    {
        public FormSprint()
        {
            InitializeComponent();
        }

        private void FormSprint_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            FormFile formFile = new FormFile();
            formFile.ShowDialog();
        }

        private void buttonFilePost_Click(object sender, EventArgs e)
        {
            FormPost formPost = new FormPost();
            formPost.ShowDialog();
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            FormChart formChart = new FormChart();
            formChart.ShowDialog();
        }
    }
}
