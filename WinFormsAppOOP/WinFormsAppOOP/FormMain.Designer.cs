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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(206, 255, 249);
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
            panel1.Size = new Size(648, 386);
            panel1.TabIndex = 0;
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditProduct.Location = new Point(309, 353);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(171, 28);
            buttonEditProduct.TabIndex = 11;
            buttonEditProduct.Text = "Редактировать";
            buttonEditProduct.UseVisualStyleBackColor = true;
            buttonEditProduct.Visible = false;
            buttonEditProduct.Click += buttonEditProduct_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProduct.Location = new Point(132, 353);
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
            labelSelectedCount.Location = new Point(16, 358);
            labelSelectedCount.Name = "labelSelectedCount";
            labelSelectedCount.Size = new Size(73, 20);
            labelSelectedCount.TabIndex = 9;
            labelSelectedCount.Text = "Выбрано";
            // 
            // labelProductsCount
            // 
            labelProductsCount.AutoSize = true;
            labelProductsCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductsCount.Location = new Point(628, 10);
            labelProductsCount.Name = "labelProductsCount";
            labelProductsCount.Size = new Size(0, 20);
            labelProductsCount.TabIndex = 8;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(438, 11);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(121, 23);
            comboBoxFilter.TabIndex = 2;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // textBoxPage
            // 
            textBoxPage.Location = new Point(544, 354);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(59, 23);
            textBoxPage.TabIndex = 7;
            // 
            // labelPrev
            // 
            labelPrev.AutoSize = true;
            labelPrev.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrev.Location = new Point(519, 353);
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
            labelNext.Location = new Point(609, 353);
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
            comboBoxSort.Location = new Point(311, 11);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(121, 23);
            comboBoxSort.TabIndex = 3;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(16, 11);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(215, 23);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.Text = "Поиск";
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.BackColor = Color.White;
            flowLayoutPanelProducts.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelProducts.Location = new Point(16, 42);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(612, 308);
            flowLayoutPanelProducts.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(674, 414);
            Controls.Add(panel1);
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
    }
}