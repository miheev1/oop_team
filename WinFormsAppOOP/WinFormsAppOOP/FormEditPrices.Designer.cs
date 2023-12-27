namespace WinFormsAppOOP
{
    partial class FormEditPrices
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
            buttonEdit = new Button();
            textBoxPrice = new TextBox();
            label1 = new Label();
            buttonClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(206, 255, 249);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 127);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(14, 78);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 32);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(14, 49);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(142, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Новая цена";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(133, 78);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 32);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Отмена";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormEditPrices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 150);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormEditPrices";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменить цену на";
            Load += FormEditPricecs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonEdit;
        private TextBox textBoxPrice;
        private Label label1;
        private Button buttonClose;
    }
}