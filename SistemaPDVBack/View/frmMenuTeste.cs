using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

using FontAwesome.Sharp;

namespace SistemaPDVBack
{
    public partial class frmMenuTeste : Form
    {
        private IconButton iconButton;
        private Panel leftBorder;
        private Form formFilho;
        public frmMenuTeste()
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 60);
            pnMenuVertical.Controls.Add(leftBorder);
            DesignCustomizado();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        string produto = "Produto";
        string colaborador = "Colaborador";
        string dashBoard = "Dashboard";
        string relatorio = "Relatório";
        string salvar = "Salvar";
        string pesquisa = "Pesquisa";
        string fornecedor = "Fornecedor";

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DEsativarBotao();
                iconButton = (IconButton)senderBtn;
                iconButton.BackColor = Color.FromArgb(112, 128, 144);
                iconButton.ForeColor = color;
                iconButton.TextAlign = ContentAlignment.MiddleCenter;
                iconButton.IconColor = color;
                iconButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconButton.ImageAlign = ContentAlignment.MiddleRight;


                leftBorder.BackColor = color;
                leftBorder.Location = new Point(0, iconButton.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();

               


            }
        }
        public void MudaCorIcone(Color color)
        {
            iconFilho.IconChar = iconButton.IconChar;
            iconFilho.IconColor = color;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(77, 121, 255);
            public static Color color6 = Color.FromArgb(251, 100, 0);
            public static Color color7 = Color.FromArgb(230, 230, 0);
            public static Color color8 = Color.FromArgb(0, 0, 0);


        }

        private void DEsativarBotao()
        {
            if(iconButton != null)
            {
                iconButton.BackColor = Color.FromArgb(0, 0, 0);
                iconButton.ForeColor = Color.Gainsboro;
                iconButton.TextAlign = ContentAlignment.MiddleLeft;
                iconButton.IconColor = Color.Gainsboro;
                iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconButton.ImageAlign = ContentAlignment.MiddleLeft;
               

            }
        }



     

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmDashboard());

            ActivateButton(sender, RGBColors.color1);
            pnHorizontal.BackColor = RGBColors.color8;
            MudaCorIcone(RGBColors.color1);


            lblNomeForms.Text = dashBoard;
            OcultarSubMenu();


        }


        private void btnLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void Reset()
        {
            if (iconFilho != null)
            {
                DEsativarBotao();
                leftBorder.Visible = false;
                iconFilho.IconChar = IconChar.Home;
                iconFilho.IconColor = Color.White;
            }

        }
      

        private void pnHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.ReleaseCapture();
            MoverForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmMenuTeste_Load(object sender, EventArgs e)
        {

        }

        private void AbrirForm(Form formFilho)
        {
            if (this.formFilho != null)
            {
                this.formFilho.Close();
            }
            this.formFilho = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            pnForm.Controls.Add(formFilho);
            formFilho.BringToFront();
            formFilho.Show();
        }


        private void iconMenu_Click(object sender, EventArgs e)
        {
           



            if (pnMenuVertical.Width == 200)
            {


                btnColaborador.Text = "";
                btnHome.Text = "";
                btnProduto.Text = "";
                btnRelatorios.Text = "";
                btnPesquisaColaborador.Text = "";
                btnPesquisaProduto.Text = "";
                btnPesquisaRelatorios.Text = "";
                btnPesquisaFornecedor.Text = "";
                btnSalvarColaborador.Text = "";
                btnSalvarProduto.Text = "";
                btnSalvarFornecedor.Text = "";
                pnMenuVertical.Width = 70;
                btnFornecedor.Text = ""; 

            }
            else
            {
                btnColaborador.Text = colaborador;
                btnHome.Text = dashBoard;
                btnProduto.Text = produto;
                btnRelatorios.Text = relatorio;
                btnPesquisaColaborador.Text = pesquisa;
                btnPesquisaProduto.Text = pesquisa;
                btnPesquisaRelatorios.Text = pesquisa;
                btnSalvarColaborador.Text = salvar;
                btnSalvarProduto.Text = salvar;
                btnFornecedor.Text = fornecedor;
                btnPesquisaFornecedor.Text = pesquisa;
                btnSalvarFornecedor.Text = salvar;

                pnMenuVertical.Width = 200;
            }
        }

       

        private void pnHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DesignCustomizado()
        {
            pnSubMenuColaborador.Visible = false;
            pnSubMenuRelatorio.Visible = false;
            pnSubMenuProduto.Visible = false;
            pnSubMenuFornecedor.Visible = false;
            
        }

        private void OcultarSubMenu()
        {
            if (pnSubMenuColaborador.Visible == true)
                pnSubMenuColaborador.Visible = false;
            if (pnSubMenuProduto.Visible == true)
                pnSubMenuProduto.Visible = false;
            if (pnSubMenuRelatorio.Visible == true)
                pnSubMenuRelatorio.Visible = false; 
            if (pnSubMenuFornecedor.Visible == true)
                pnSubMenuFornecedor.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                OcultarSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnProduto_Click_1(object sender, EventArgs e)
        {

            showSubMenu(pnSubMenuProduto);


            ActivateButton(sender, RGBColors.color2);
            pnHorizontal.BackColor = RGBColors.color7;

           // lblNomeForms.Text = produto;
           
      
        }



        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPesquisaProduto());
            lblNomeForms.Text = produto;
            MudaCorIcone(RGBColors.color2);

        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProduto());
            lblNomeForms.Text = produto;
            MudaCorIcone(RGBColors.color2);




        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenuColaborador);

            ActivateButton(sender, RGBColors.color3);
            pnHorizontal.BackColor = RGBColors.color5;
            //lblNomeForms.Text = colaborador;
        }

        private void btnSalvarColaborador_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new frmColaborador());
            lblNomeForms.Text = colaborador;
            MudaCorIcone(RGBColors.color2);





        }

        private void btnPesquisaColaborador_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPesquisaColaborador());
            lblNomeForms.Text = colaborador;
            MudaCorIcone(RGBColors.color2);




        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenuRelatorio);

            ActivateButton(sender, RGBColors.color5);
            pnHorizontal.BackColor = RGBColors.color5;
           // lblNomeForms.Text = relatorio;

        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenuFornecedor);

            ActivateButton(sender, RGBColors.color4);
            pnHorizontal.BackColor = RGBColors.color5;
           // lblNomeForms.Text = fornecedor;
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmFornecedor());
            lblNomeForms.Text = fornecedor;
            MudaCorIcone(RGBColors.color4);


        }

        private void btnPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPesquisaFornecedor());
            lblNomeForms.Text = fornecedor;
            MudaCorIcone(RGBColors.color4);



        }

        private void btnPesquisaRelatorios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPesquisaRelatorio());
            lblNomeForms.Text = relatorio;
            MudaCorIcone(RGBColors.color6);



        }
    }
}
