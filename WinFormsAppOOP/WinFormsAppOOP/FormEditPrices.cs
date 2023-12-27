using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppOOP
{

    public partial class FormEditPrices : Form
    {

        NpgsqlConnection connection;
        List<int> selectedArticles;
        FormMain mainForm;

        public FormEditPrices(NpgsqlConnection conn, List<int> selectArticles, FormMain mainForm)
        {
            InitializeComponent();
            connection = conn;
            selectedArticles = selectArticles;
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void FormEditPricecs_Load(object sender, EventArgs e)
        {
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;



            string sql = "select pr.article, pr.mincost from public.\"Product\" as pr " +
                "where ";

            foreach (int i in selectedArticles)
            {
                sql += $"pr.article = {i} or ";
            }

            sql = sql.Substring(0, sql.Length - 3);

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();


            int sumPrice = 0;
            int count = 0;

            while (dataReader.Read())
            {
                sumPrice += dataReader.GetInt32(1);
                count++;
            }

            dataReader.Close();

            textBoxPrice.Text = (sumPrice / count).ToString();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            int cost = Convert.ToInt32(textBoxPrice.Text);

            string sql = "UPDATE public.\"Product\" " +
                $"SET mincost = {cost} " +
                "WHERE ";

            foreach (int i in selectedArticles)
            {
                sql += $"article = {i} or ";
            }
            sql = sql.Substring(0, sql.Length - 3);

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            command.ExecuteNonQuery();

            mainForm.ShowProducts();

            MessageBox.Show($"Цена изменена на {cost}");




        }
    }
}
