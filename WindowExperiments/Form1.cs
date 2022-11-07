using TestLibrary;

namespace WindowExperiments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var annotator = new Annotator();
            var pdtAnnotator = new PDTAnnotator();

            var obj = GetRatio(pdtAnnotator);

            MessageBox.Show(obj.ToString());
        }


        private int GetRatio(IImageAnnotator image)
        {
            var annotatorWithPriority = image as IImageAnnotatorExtended;
            return annotatorWithPriority.Priority;
        }
    }
}