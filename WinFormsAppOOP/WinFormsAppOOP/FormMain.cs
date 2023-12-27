using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Collections.Specialized;
using System.Data;
using System.Data.Common;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppOOP
{
    public partial class FormMain : Form
    {


        NpgsqlConnection connection;
        DataTable dataTable;
        List<int> selectArticles;

        int currentPage = 1;
        int sizePage = 20;

        int productCountMax = -1;
        int productCount = -1;
        int labelProductsCountX = -1;



        public FormMain()
        {
            InitializeComponent();
            try
            {
                string server = "localhost";
                string database = "oop";
                string username = "postgres";
                string password = "12345678";
                int port = 5432;

                string connectionString = $"Host={server};Port={port};Database={database};Username={username};Password={password}";
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FormMain_Closed(object sender, EventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        void loadFilterType()
        {
            string sql = "SELECT * FROM public.\"ProductType\"\r\nORDER BY id ASC";

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            comboBoxFilter.Items.Add("Все типы");

            while (dataReader.Read())
            {
                comboBoxFilter.Items.Add(dataReader.GetString(1));
            }

            dataReader.Close();

            comboBoxFilter.SelectedIndex = 0;



        }

        void loadSort()
        {
            comboBoxSort.Items.Add("Наз. возрастание");
            comboBoxSort.Items.Add("Наз. убывание");
            comboBoxSort.Items.Add("Цена возрастание");
            comboBoxSort.Items.Add("Цена убывание");

            comboBoxSort.SelectedIndex = 0;
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            selectArticles = new List<int>();
            dataTable = new DataTable();
            labelProductsCountX = labelProductsCount.Left;

            loadFilterType();
            loadSort();




            textBoxPage.KeyPress += TextBoxPage_KeyPress;
            textBoxPage.TextChanged += TextBoxPage_TextChanged;



            ShowProducts();



        }


        DataTable ProductsFromTB()
        {
            string sql = "select pr.article, prtype.name as type, pr.name, pr.mincost, pr.image, pr.type_id from public.\"Product\" as pr\r\njoin public.\"ProductType\" as prtype on pr.type_id = prtype.id\r\norder by pr.article asc";

            NpgsqlCommand command = new NpgsqlCommand(sql);

            command.Connection = connection;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);



            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);



            string search = textBoxSearch.Text;




            int indexFilter = comboBoxFilter.SelectedIndex;
            int indexSort = comboBoxSort.SelectedIndex;


            productCountMax = dataTable.Rows.Count;



            dataTable.Columns.Add("materials");
            dataTable.Columns["materials"].SetOrdinal(3);



            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {

                DataRow row = dataTable.Rows[i];

                if (search != "")
                {

                    string name = row[2].ToString();
                    string type = row[1].ToString();

                    if (!$"{type} | {name}".Contains(search))
                    {
                        dataTable.Rows.RemoveAt(i);
                        continue;
                    }

                }

                if (indexFilter != 0)
                {

                    if (Convert.ToInt32(row[6]) != indexFilter)
                    {
                        dataTable.Rows.RemoveAt(i);
                        continue;
                    }
                }


                int article = Convert.ToInt32(row[0]);

                string sqlMat = "select mat.name from public.\"ProductMaterials\" as prmat\r\njoin public.\"Material\" " +
                    $"as mat on prmat.material_id = mat.id\r\nwhere prmat.article = {article}";

                NpgsqlCommand commnand = new NpgsqlCommand(sqlMat, connection);

                NpgsqlDataReader dataReader = commnand.ExecuteReader();


                while (dataReader.Read())
                {
                    row["materials"] += dataReader.GetString(0) + ", ";
                }

                StringBuilder stringBuilder = new StringBuilder(row["materials"].ToString());

                int chunkSize = 50;
                for (int i2 = chunkSize; i2 < stringBuilder.Length; i2 += chunkSize)
                {
                    stringBuilder.Insert(i2, '\n');
                }

                row["materials"] = stringBuilder;



                dataReader.Close();

                if (row["materials"].ToString().Length == 0)
                {
                    row["materials"] = "Материалы не указаны";
                }
                else
                {
                    row["materials"] = row["materials"].ToString().Substring(0, row["materials"].ToString().Length - 2);
                }





            }


            switch (indexSort)
            {
                case 0:
                    dataTable.DefaultView.Sort = "name ASC";
                    break;
                case 1:
                    dataTable.DefaultView.Sort = "name DESC";
                    break;
                case 2:
                    dataTable.DefaultView.Sort = "mincost ASC";
                    break;
                case 3:
                    dataTable.DefaultView.Sort = "mincost DESC";
                    break;

                default:
                    break;
            }

            dataTable = dataTable.DefaultView.ToTable();


            productCount = dataTable.Rows.Count;

            return dataTable;
        }

        void selectProduct(int article, bool input = true)
        {

            if (input)
            {
                selectArticles.Add(article);
            }
            else
            {
                selectArticles.Remove(article);
            }
            labelSelectedCount.Text = $"Выбрано {selectArticles.Count}";

            if (selectArticles.Count == 1)
            {
                buttonEditProduct.Enabled = true;

            }
            else
            {
                buttonEditProduct.Enabled = false;
            }
            if (selectArticles.Count > 1)
            {
                buttonEditPrice.Enabled = true;
            }
            else
            {
                buttonEditPrice.Enabled = false;
            }


        }

        private void TableLayoutPanel_Click(object sender, EventArgs e)
        {

            int index = -1;

            if (sender is PictureBox clickedPictureBox)
            {

                if (clickedPictureBox.Parent is TableLayoutPanel panel1)
                {
                    if (panel1.Parent is FlowLayoutPanel parent1)
                    {
                        index = parent1.Controls.IndexOf(panel1);
                    }
                }

            }

            if (sender is System.Windows.Forms.Label clickedLabel)
            {

                if (clickedLabel.Parent is Panel labelParentPanel1)
                {
                    if (labelParentPanel1.Parent is TableLayoutPanel panel1)
                    {
                        if (panel1.Parent is FlowLayoutPanel parent1)
                        {
                            index = parent1.Controls.IndexOf(panel1);
                        }
                    }
                }
            }

            if (sender is Panel labelParentPanel2)
            {
                if (labelParentPanel2.Parent is TableLayoutPanel panel1)
                {
                    if (panel1.Parent is FlowLayoutPanel parent1)
                    {
                        index = parent1.Controls.IndexOf(panel1);
                    }
                }
            }

            if (sender is TableLayoutPanel panel2)
            {
                if (panel2.Parent is FlowLayoutPanel parent1)
                {
                    index = parent1.Controls.IndexOf(panel2);
                }
            }

            int indexCount = 0;

            foreach (Control control in flowLayoutPanelProducts.Controls)
            {
                if (control is TableLayoutPanel && indexCount == index)
                {
                    TableLayoutPanel tableLayoutPanel = (TableLayoutPanel)control;

                    int indexProduct = (currentPage - 1) * sizePage + index;
                    int article = Convert.ToInt32(dataTable.Rows[indexProduct][0]);

                    if (tableLayoutPanel.BackColor == Color.FromArgb(206, 255, 249))
                    {
                        tableLayoutPanel.BackColor = Color.FromArgb(0, 204, 118);
                        selectProduct(article);
                    }
                    else
                    {
                        tableLayoutPanel.BackColor = Color.FromArgb(206, 255, 249);
                        selectProduct(article, false);
                    }



                    break;
                }

                indexCount++;
            }







        }


        private Panel CreatePanel(string text)
        {
            Panel panel = new Panel();
            panel.Margin = new Padding(0, 10, 10, 10);
            panel.Height = 78;
            panel.BackColor = Color.Transparent;



            return panel;
        }

        private TableLayoutPanel CreateTableLayoutPanel(DataRow dataRow)
        {


            TableLayoutPanel panel = new TableLayoutPanel();

            panel.BackColor = Color.FromArgb(206, 255, 249);
            panel.BorderStyle = BorderStyle.FixedSingle;

            panel.Width = flowLayoutPanelProducts.Width - 40;
            panel.Height = 100;
            panel.Margin = new Padding(10, 10, 0, 0);
            panel.Padding = new Padding(10, 0, 0, 0);

            PictureBox leftPanel = new PictureBox();

            leftPanel.Margin = new Padding(0, 10, 10, 10);
            leftPanel.Height = 78;
            leftPanel.BackColor = Color.Transparent;
            leftPanel.SizeMode = PictureBoxSizeMode.StretchImage;

            string pathImage = "C:/Users/1/Desktop";

            if (dataRow[5].ToString() == "")
            {

                pathImage = "C:/Users/1/Desktop/Picture.png";


                leftPanel.Image = new Bitmap(pathImage);
            }
            else
            {

                string pathImagePlus = dataRow[5].ToString();
                pathImage += pathImagePlus.Replace("\\", "/");

                leftPanel.Image = new Bitmap(pathImage);

            }




            Panel centerPanel = CreatePanel("Center Panel");
            Panel rightPanel = CreatePanel("Right Panel");



            leftPanel.Width = 90;
            rightPanel.Width = 120;
            centerPanel.Width = panel.Width - leftPanel.Width - rightPanel.Width - 40;



            panel.Controls.Add(leftPanel, 0, 0);
            panel.Controls.Add(centerPanel, 1, 0);
            panel.Controls.Add(rightPanel, 2, 0);

            Point labelPriceLocation = new Point();



            for (int i = 0; i < 3; i++)
            {
                System.Windows.Forms.Label name = new System.Windows.Forms.Label();
                name.Font = new Font(name.Font.FontFamily, 11);
                name.ForeColor = Color.Black;
                name.BackColor = Color.Transparent;

                switch (i)
                {
                    case 0:
                        name.Font = new Font(name.Font.FontFamily, 12, FontStyle.Bold);
                        string type = dataRow[1].ToString();
                        string nameProduct = dataRow[2].ToString();
                        name.Text = $"{type} | {nameProduct}";
                        break;
                    case 1:
                        name.Text = dataRow[0].ToString();
                        break;
                    case 2:
                        name.Font = new Font(name.Font.FontFamily, 8);
                        name.Text = dataRow[3].ToString();
                        break;
                    default:
                        break;
                }



                name.Top = i * 20;
                name.Left = 5;
                name.AutoSize = true;
                name.Click += TableLayoutPanel_Click;

                centerPanel.Controls.Add(name);
            }




            System.Windows.Forms.Label LabelPrice = new System.Windows.Forms.Label();
            LabelPrice.Font = new Font(LabelPrice.Font.FontFamily, 25);
            LabelPrice.Text = dataRow[4].ToString() + "р.";
            LabelPrice.AutoSize = true;
            LabelPrice.Click += TableLayoutPanel_Click;
            rightPanel.Controls.Add(LabelPrice);



            LabelPrice.Location = new Point(rightPanel.Width / 2 -
                LabelPrice.Width / 2, rightPanel.Height / 2 -
                LabelPrice.Height / 2);



            panel.Click += TableLayoutPanel_Click;
            leftPanel.Click += TableLayoutPanel_Click;
            centerPanel.Click += TableLayoutPanel_Click;
            rightPanel.Click += TableLayoutPanel_Click;

            return panel;
        }

        public void ShowProducts()
        {
            flowLayoutPanelProducts.Controls.Clear();


            dataTable = ProductsFromTB();



            int pageMin = (currentPage - 1) * sizePage;
            int pageMax = currentPage * sizePage;


            for (int i = pageMin; i < pageMax; i++)
            {
                if (i >= dataTable.Rows.Count)
                {
                    break;
                }

                DataRow row = dataTable.Rows[i];


                TableLayoutPanel panel = CreateTableLayoutPanel(row);
                flowLayoutPanelProducts.Controls.Add(panel);

                if (selectArticles.Contains(Convert.ToInt32(row[0])))
                {
                    panel.BackColor = Color.FromArgb(0, 204, 118);
                }



            }

            labelProductsCount.Text = $"{productCount}/{productCountMax}";
            labelProductsCount.Left = labelProductsCountX - labelProductsCount.Width;


            textBoxPage.Text = currentPage.ToString();
        }

        private void TextBoxPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 - это код клавиши Backspace
            {
                e.Handled = true;
            }
            if (textBoxPage.Text.Length >= 3 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
        private void TextBoxPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxPage.Text) == 0)
                {
                    return;
                }

                currentPage = Convert.ToInt32(textBoxPage.Text);
                ShowProducts();
            }
            catch
            {

            }


        }


        private void labelNext_Click(object sender, EventArgs e)
        {
            currentPage++;

            ShowProducts();
        }

        private void labelPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ShowProducts();
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            FormEdit form = new FormEdit(connection, selectArticles[0], this);

            form.ShowDialog();

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormEdit form = new FormEdit(connection, -1, this);

            form.ShowDialog();
        }

        private void buttonEditPrice_Click(object sender, EventArgs e)
        {
            FormEditPrices form = new FormEditPrices(connection, selectArticles, this);

            form.ShowDialog();

        }
    }
}