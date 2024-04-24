using FigurasGeometricasWINFORM.Views;

namespace FigurasGeometricasWINFORM
{
    public partial class MainViewForm : Form
    {
        public MainViewForm()
        {
            InitializeComponent();
        }

        /********************************************************************/
        /********************************************************************/

        private void btnCreateSquare_Click(object sender, EventArgs e)
        {
            CuadradoView newFrame = new CuadradoView();
            newFrame.Show();
            this.Hide();   
            
        }

        private void btnCreateTriangle_Click(object sender, EventArgs e)
        {
            TrianguloView newFrame = new TrianguloView();
            newFrame.Show();
            this.Hide();
        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            CirculoView newFrame = new CirculoView();   
            newFrame.Show();
            this.Hide();
        }


        /********************************************************************/
        /********************************************************************/
    }
}
