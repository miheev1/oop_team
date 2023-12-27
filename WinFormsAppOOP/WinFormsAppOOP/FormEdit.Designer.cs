namespace WinFormsAppOOP
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonPhotoOpen = new Button();
            pictureBoxPhoto = new PictureBox();
            label7 = new Label();
            textBoxWorkshop = new TextBox();
            label6 = new Label();
            textBoxPeople = new TextBox();
            label5 = new Label();
            textBoxPrice = new TextBox();
            label4 = new Label();
            comboBoxType = new ComboBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxArticle = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            buttonAddMat = new Button();
            buttonMaterialsClear = new Button();
            label9 = new Label();
            comboBoxAddMat = new ComboBox();
            dataGridViewMaterials = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(206, 255, 249);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonPhotoOpen);
            panel1.Controls.Add(pictureBoxPhoto);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxWorkshop);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxPeople);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxType);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxArticle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 356);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(289, 312);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(121, 28);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(13, 312);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(121, 28);
            buttonEdit.TabIndex = 15;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonPhotoOpen
            // 
            buttonPhotoOpen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPhotoOpen.Location = new Point(289, 145);
            buttonPhotoOpen.Name = "buttonPhotoOpen";
            buttonPhotoOpen.Size = new Size(121, 28);
            buttonPhotoOpen.TabIndex = 14;
            buttonPhotoOpen.Text = "Открыть";
            buttonPhotoOpen.UseVisualStyleBackColor = true;
            buttonPhotoOpen.Click += buttonPhotoOpen_Click;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(289, 29);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(121, 110);
            pictureBoxPhoto.TabIndex = 13;
            pictureBoxPhoto.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(289, 6);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 12;
            label7.Text = "Фото";
            // 
            // textBoxWorkshop
            // 
            textBoxWorkshop.Location = new Point(13, 274);
            textBoxWorkshop.Name = "textBoxWorkshop";
            textBoxWorkshop.Size = new Size(260, 23);
            textBoxWorkshop.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 251);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 10;
            label6.Text = "Номер цеха";
            // 
            // textBoxPeople
            // 
            textBoxPeople.Location = new Point(13, 225);
            textBoxPeople.Name = "textBoxPeople";
            textBoxPeople.Size = new Size(260, 23);
            textBoxPeople.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 202);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 8;
            label5.Text = "Количество людей";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(13, 176);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(260, 23);
            textBoxPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 153);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Цена";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(13, 127);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(260, 23);
            comboBoxType.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 104);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 4;
            label3.Text = "Тип продукта";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(13, 78);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(260, 23);
            textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 55);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Название";
            // 
            // textBoxArticle
            // 
            textBoxArticle.Location = new Point(13, 29);
            textBoxArticle.Name = "textBoxArticle";
            textBoxArticle.Size = new Size(260, 23);
            textBoxArticle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Артикль";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(206, 255, 249);
            panel2.Controls.Add(buttonAddMat);
            panel2.Controls.Add(buttonMaterialsClear);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBoxAddMat);
            panel2.Controls.Add(dataGridViewMaterials);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(452, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 356);
            panel2.TabIndex = 1;
            // 
            // buttonAddMat
            // 
            buttonAddMat.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddMat.Location = new Point(17, 254);
            buttonAddMat.Name = "buttonAddMat";
            buttonAddMat.Size = new Size(185, 28);
            buttonAddMat.TabIndex = 19;
            buttonAddMat.Text = "Добавить материал";
            buttonAddMat.UseVisualStyleBackColor = true;
            buttonAddMat.Click += buttonAddMat_Click;
            // 
            // buttonMaterialsClear
            // 
            buttonMaterialsClear.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMaterialsClear.Location = new Point(17, 312);
            buttonMaterialsClear.Name = "buttonMaterialsClear";
            buttonMaterialsClear.Size = new Size(185, 28);
            buttonMaterialsClear.TabIndex = 18;
            buttonMaterialsClear.Text = "Очистить материалы";
            buttonMaterialsClear.UseVisualStyleBackColor = true;
            buttonMaterialsClear.Click += buttonMaterialsClear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 202);
            label9.Name = "label9";
            label9.Size = new Size(147, 20);
            label9.TabIndex = 3;
            label9.Text = "Добавить материал";
            // 
            // comboBoxAddMat
            // 
            comboBoxAddMat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddMat.FormattingEnabled = true;
            comboBoxAddMat.Location = new Point(17, 225);
            comboBoxAddMat.Name = "comboBoxAddMat";
            comboBoxAddMat.Size = new Size(263, 23);
            comboBoxAddMat.TabIndex = 2;
            // 
            // dataGridViewMaterials
            // 
            dataGridViewMaterials.BackgroundColor = Color.White;
            dataGridViewMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterials.Location = new Point(17, 38);
            dataGridViewMaterials.Name = "dataGridViewMaterials";
            dataGridViewMaterials.RowTemplate.Height = 25;
            dataGridViewMaterials.Size = new Size(394, 150);
            dataGridViewMaterials.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(181, 6);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 0;
            label8.Text = "Материалы";
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 383);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменить продукт";
            Load += FormEdit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private TextBox textBoxWorkshop;
        private Label label6;
        private TextBox textBoxPeople;
        private Label label5;
        private TextBox textBoxPrice;
        private Label label4;
        private ComboBox comboBoxType;
        private Label label3;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxArticle;
        private Label label1;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonPhotoOpen;
        private PictureBox pictureBoxPhoto;
        private Panel panel2;
        private Button buttonMaterialsClear;
        private Label label9;
        private ComboBox comboBoxAddMat;
        private DataGridView dataGridViewMaterials;
        private Label label8;
        private Button buttonAddMat;
    }
}