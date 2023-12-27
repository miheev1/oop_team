namespace WinFormsAppOOP
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonEditPrice = new Button();
            buttonEditProduct = new Button();
            buttonAddProduct = new Button();
            labelSelectedCount = new Label();
            labelProductsCount = new Label();
            comboBoxFilter = new ComboBox();
            textBoxPage = new TextBox();
            labelPrev = new Label();
            labelNext = new Label();
            comboBoxSort = new ComboBox();
            textBoxSearch = new TextBox();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(206, 255, 249);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonEditPrice);
            panel1.Controls.Add(buttonEditProduct);
            panel1.Controls.Add(buttonAddProduct);
            panel1.Controls.Add(labelSelectedCount);
            panel1.Controls.Add(labelProductsCount);
            panel1.Controls.Add(comboBoxFilter);
            panel1.Controls.Add(textBoxPage);
            panel1.Controls.Add(labelPrev);
            panel1.Controls.Add(labelNext);
            panel1.Controls.Add(comboBoxSort);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(flowLayoutPanelProducts);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 470);
            panel1.TabIndex = 0;
            // 
            // buttonEditPrice
            // 
            buttonEditPrice.Enabled = false;
            buttonEditPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditPrice.Location = new Point(455, 422);
            buttonEditPrice.Name = "buttonEditPrice";
            buttonEditPrice.Size = new Size(171, 28);
            buttonEditPrice.TabIndex = 12;
            buttonEditPrice.Text = "Изменить цену на";
            buttonEditPrice.UseVisualStyleBackColor = true;
            buttonEditPrice.Click += buttonEditPrice_Click;
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Enabled = false;
            buttonEditProduct.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditProduct.Location = new Point(236, 422);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(171, 28);
            buttonEditProduct.TabIndex = 11;
            buttonEditProduct.Text = "Редактировать";
            buttonEditProduct.UseVisualStyleBackColor = true;
            buttonEditProduct.Click += buttonEditProduct_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProduct.Location = new Point(18, 422);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(171, 28);
            buttonAddProduct.TabIndex = 10;
            buttonAddProduct.Text = "Добавить";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // labelSelectedCount
            // 
            labelSelectedCount.AutoSize = true;
            labelSelectedCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedCount.Location = new Point(18, 382);
            labelSelectedCount.Name = "labelSelectedCount";
            labelSelectedCount.Size = new Size(73, 20);
            labelSelectedCount.TabIndex = 9;
            labelSelectedCount.Text = "Выбрано";
            // 
            // labelProductsCount
            // 
            labelProductsCount.AutoSize = true;
            labelProductsCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductsCount.Location = new Point(630, 34);
            labelProductsCount.Name = "labelProductsCount";
            labelProductsCount.Size = new Size(0, 20);
            labelProductsCount.TabIndex = 8;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(440, 35);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(121, 23);
            comboBoxFilter.TabIndex = 2;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // textBoxPage
            // 
            textBoxPage.Location = new Point(546, 378);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(59, 23);
            textBoxPage.TabIndex = 7;
            // 
            // labelPrev
            // 
            labelPrev.AutoSize = true;
            labelPrev.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrev.Location = new Point(521, 377);
            labelPrev.Name = "labelPrev";
            labelPrev.Size = new Size(19, 20);
            labelPrev.TabIndex = 6;
            labelPrev.Text = "<";
            labelPrev.Click += labelPrev_Click;
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelNext.Location = new Point(611, 377);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(19, 20);
            labelNext.TabIndex = 4;
            labelNext.Text = ">";
            labelNext.Click += labelNext_Click;
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(313, 35);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(121, 23);
            comboBoxSort.TabIndex = 3;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(18, 37);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(215, 23);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.BackColor = Color.White;
            flowLayoutPanelProducts.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelProducts.Location = new Point(18, 66);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(612, 308);
            flowLayoutPanelProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 13;
            label1.Text = "Поиск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(313, 12);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 14;
            label2.Text = "Сортировка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(440, 12);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 15;
            label3.Text = "Фильтр";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(674, 497);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Продукты";
            FormClosed += FormMain_Closed;
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxSort;
        private ComboBox comboBoxFilter;
        private TextBox textBoxSearch;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private Label labelNext;
        private Label labelPrev;
        private TextBox textBoxPage;
        private Label labelProductsCount;
        private Label labelSelectedCount;
        private Button buttonEditProduct;
        private Button buttonAddProduct;
        private Button buttonEditPrice;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}