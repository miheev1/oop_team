using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsAppOOP
{
    public partial class FormEdit : Form
    {

        NpgsqlConnection connection;
        int article;
        FormMain formMain;
        string selectedFilePath;
        Dictionary<string, int> materials = new Dictionary<string, int>();
        DataTable dataTableMaterials = new DataTable();
        string messageComplete = "Изменено";

        public FormEdit(NpgsqlConnection conn, int article, FormMain formMain)
        {
            InitializeComponent();
            connection = conn;
            this.article = article;
            this.formMain = formMain;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void ShowType(int indexType)
        {
            string sql = "select * from public.\"ProductType\"";

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                comboBoxType.Items.Add(dataReader.GetString(1));
            }

            dataReader.Close();

            comboBoxType.SelectedIndex = indexType - 1;

        }

        void LoadcomboBoxAddMat()
        {
            string sql = "select mat.name, mat.id from public.\"Material\" as mat\r\norder by mat.id asc\r\n";

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();


            while (dataReader.Read())
            {
                comboBoxAddMat.Items.Add(dataReader.GetString(0));
                materials.Add(dataReader.GetString(0), dataReader.GetInt32(1));
            }
            dataReader.Close();

            comboBoxAddMat.SelectedIndex = 0;


        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPrice.Text.Length > 4 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 - это код клавиши Backspace
            {
                e.Handled = true;
            }

        }

        private void textBoxPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPeople.Text.Length > 4 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 - это код клавиши Backspace
            {
                e.Handled = true;
            }

        }

        private void textBoxWorkshop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxWorkshop.Text.Length > 2 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 - это код клавиши Backspace
            {
                e.Handled = true;
            }

        }

        private void textBoxArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxArticle.Text.Length > 5 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 - это код клавиши Backspace
            {
                e.Handled = true;
            }

        }

        private void textBoxCellMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((TextBox)sender).Text.Length > 2 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 - это код клавиши Backspace
            {
                e.Handled = true;
            }
        }

        private void dataGridViewMaterials_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                 textBox.KeyPress += textBoxCellMaterial_KeyPress;
            }
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            textBoxArticle.KeyPress += textBoxArticle_KeyPress;
            textBoxPeople.KeyPress += textBoxPeople_KeyPress;
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            textBoxWorkshop.KeyPress += textBoxWorkshop_KeyPress;
            dataGridViewMaterials.EditingControlShowing += dataGridViewMaterials_EditingControlShowing;


            dataTableMaterials.Columns.Add("Название");
            dataTableMaterials.Columns.Add("Количество");
            dataTableMaterials.Columns.Add("id");


            dataGridViewMaterials.DataSource = dataTableMaterials;

            dataGridViewMaterials.Columns["id"].ReadOnly = true;
            dataGridViewMaterials.Columns["id"].Visible = false;
            dataGridViewMaterials.Columns["Название"].ReadOnly = true;
            dataGridViewMaterials.Columns["Название"].Width = 250;
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

            LoadcomboBoxAddMat();


            if (article == -1)
            {
                buttonEdit.Text = "Добавить";
                ShowType(1);
                textBoxPeople.Text = "0";
                textBoxPrice.Text = "0";
                textBoxWorkshop.Text = "0";
                messageComplete = "Добавлено";
                this.Text = "Добавить продукт";
                buttonDelete.Visible = false;
                return;
            }




            string sql = "select * from public.\"Product\" as pr " +
                    $"where pr.article = {article}";

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            textBoxName.Text = dataReader.GetString(0);
            textBoxArticle.Text = dataReader.GetInt32(1).ToString();
            textBoxPrice.Text = dataReader.GetInt32(2).ToString();
            textBoxPeople.Text = dataReader.GetInt32(5).ToString();
            textBoxWorkshop.Text = dataReader.GetInt32(6).ToString();



            string pathImage = "C:/Users/1/Desktop";
            if (dataReader.IsDBNull(3) || dataReader.GetString(3) == "")
            {
                pathImage = "C:/Users/1/Desktop/Picture.png";
                selectedFilePath = "";

                pictureBoxPhoto.Image = new Bitmap(pathImage);
            }
            else
            {

                string pathImagePlus = dataReader.GetString(3);
                selectedFilePath = pathImagePlus.Replace("\\", "/");
                pathImage += selectedFilePath;


                pictureBoxPhoto.Image = new Bitmap(pathImage);
            }

            int indexType = dataReader.GetInt32(4);
            dataReader.Close();
            ShowType(indexType);

            sql = "select mat.name as Название, prmat.count as Количество, mat.id from public.\"Material\" as mat " +
                    "join public.\"ProductMaterials\" as prmat on mat.id = prmat.material_id " +
                    $"where prmat.article = {article}";

            command = new NpgsqlCommand(sql, connection);

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);


            adapter.Fill(dataTableMaterials);





        }

        private void buttonPhotoOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Изображения (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|Все файлы (*.*)|*.*";

            string startFile = "C:\\Users\\1\\Desktop\\products\\";
            openFileDialog.InitialDirectory = startFile;
            startFile = startFile.Replace("\\products\\", "");
            DialogResult result = openFileDialog.ShowDialog();



            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                pictureBoxPhoto.Image = new Bitmap(selectedFilePath);

                selectedFilePath = selectedFilePath.Replace(startFile, "");



            }
        }

        void DeleteMatsArticle()
        {
            string sql = "delete from public.\"ProductMaterials\" as prmat " +
                $"where prmat.article = {article}";

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            command.ExecuteNonQuery();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteMatsArticle();

            string sql = "delete from public.\"Product\" as pr " +
                $"where pr.article = {article}";

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            command.ExecuteNonQuery();

            MessageBox.Show($"Товар {article} удален");

            formMain.ShowProducts();
        }

        private void buttonMaterialsClear_Click(object sender, EventArgs e)
        {
            dataTableMaterials.Clear();
        }

        private void buttonAddMat_Click(object sender, EventArgs e)
        {
            string name = comboBoxAddMat.Text;

            for (int i = 0; i < dataTableMaterials.Rows.Count; i++)
            {
                string nameInTable = dataTableMaterials.Rows[i][0].ToString();

                if (name == nameInTable)
                {
                    return;
                }
            }

            dataTableMaterials.Rows.Add(name, 0, materials[name]);



        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            string sql;
            NpgsqlCommand command;
            int articleProduct = Convert.ToInt32(textBoxArticle.Text);
            NpgsqlDataReader dataReader;


            sql = "select pr.article from public.\"Product\" as pr";
            
            command = new NpgsqlCommand(sql, connection);   

            dataReader = command.ExecuteReader();
            
            while(dataReader.Read())
            {
                if (dataReader.GetInt32(0) == articleProduct)
                {
                    MessageBox.Show("Данный артикль занят");
                    dataReader.Close();
                    return;
                }
            }

            dataReader.Close();

            


            string name = textBoxName.Text;
            int typePorduct = comboBoxType.SelectedIndex + 1;
            int price = Convert.ToInt32(textBoxPrice.Text);
            int people = Convert.ToInt32(textBoxPeople.Text);
            int workshop = Convert.ToInt32(textBoxWorkshop.Text);
            

            if (article == articleProduct)
            {
                sql = "UPDATE public.\"Product\" " +
                    "SET " +
                    $"name  = '{name}', " +
                    $"type_id = {typePorduct}, " +
                    $"mincost = {price}, " +
                    $"image = '{selectedFilePath}', " +
                    $"numpeopletoproduce = {people}, " +
                    $"workshop = {workshop} " +
                    $"WHERE article = {article}";

                command = new NpgsqlCommand(sql, connection);

                command.ExecuteNonQuery();

                DeleteMatsArticle();

            }
            else
            {
                DeleteMatsArticle();

                sql = "delete from public.\"Product\" " +
                    $"where article = {article}";

                command = new NpgsqlCommand(sql, connection);

                command.ExecuteNonQuery();

                sql = "insert into public.\"Product\" " +
                    "values " +
                    $"('{name}', {articleProduct}, {price}, '{selectedFilePath}', {typePorduct}, {people}, {workshop})";

                command = new NpgsqlCommand(sql, connection);

                command.ExecuteNonQuery();


            }

            
            if (dataTableMaterials.Rows.Count > 0)
            {
                sql = "insert into public.\"ProductMaterials\" " +
               "values ";

                foreach (DataRow row in dataTableMaterials.Rows)
                {

                    int idMat = Convert.ToInt32(row[2]);
                    int count = Convert.ToInt32(row[1]);

                    if (count == 0)
                    {
                        continue;
                    }

                    sql += $"({articleProduct}, {idMat}, {count}), ";
                }

                sql = sql.Substring(0, sql.Length - 2);



                command = new NpgsqlCommand(sql, connection);

                command.ExecuteNonQuery();
            }


            


            formMain.ShowProducts();
            MessageBox.Show(messageComplete);


        }
    }
}
