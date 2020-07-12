namespace SummerPractice
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormEllipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.MainWindowDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizeButton = new Guna.UI.WinForms.GunaCircleButton();
            this.CloseButton = new Guna.UI.WinForms.GunaCircleButton();
            this.ValueADatagrid = new System.Windows.Forms.DataGridView();
            this.ValueGroupBox = new System.Windows.Forms.GroupBox();
            this.TablesGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConcentrationAButton = new System.Windows.Forms.RadioButton();
            this.ConcentrationBButton = new System.Windows.Forms.RadioButton();
            this.ConcentrationCButton = new System.Windows.Forms.RadioButton();
            this.MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueADatagrid)).BeginInit();
            this.ValueGroupBox.SuspendLayout();
            this.TablesGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormEllipse
            // 
            this.MainFormEllipse.Radius = 10;
            this.MainFormEllipse.TargetControl = this;
            // 
            // MainWindowDragControl
            // 
            this.MainWindowDragControl.TargetControl = this.MainFormMenuStrip;
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(832, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Animated = true;
            this.MinimizeButton.AnimationHoverSpeed = 0.07F;
            this.MinimizeButton.AnimationSpeed = 0.03F;
            this.MinimizeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(213)))), ((int)(((byte)(110)))));
            this.MinimizeButton.BorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizeButton.FocusedColor = System.Drawing.Color.Empty;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Image = null;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(52, 52);
            this.MinimizeButton.Location = new System.Drawing.Point(765, 9);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(110)))));
            this.MinimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.MinimizeButton.OnHoverImage = null;
            this.MinimizeButton.OnPressedColor = System.Drawing.Color.Black;
            this.MinimizeButton.Size = new System.Drawing.Size(15, 15);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Animated = true;
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(52, 52);
            this.CloseButton.Location = new System.Drawing.Point(796, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Size = new System.Drawing.Size(15, 15);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ValueADatagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            this.ValueADatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ValueADatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.ValueADatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ValueADatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ValueADatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ValueADatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValueADatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.ValueADatagrid.Location = new System.Drawing.Point(6, 19);
            this.ValueADatagrid.Name = "ValueADatagrid";
            this.ValueADatagrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ValueADatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ValueADatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.ValueADatagrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ValueADatagrid.ShowEditingIcon = false;
            this.ValueADatagrid.Size = new System.Drawing.Size(229, 384);
            this.ValueADatagrid.TabIndex = 3;
            // 
            // ValueGroupBox
            // 
            this.ValueGroupBox.Controls.Add(this.ConcentrationCButton);
            this.ValueGroupBox.Controls.Add(this.ConcentrationBButton);
            this.ValueGroupBox.Controls.Add(this.ConcentrationAButton);
            this.ValueGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ValueGroupBox.Location = new System.Drawing.Point(260, 28);
            this.ValueGroupBox.Name = "ValueGroupBox";
            this.ValueGroupBox.Size = new System.Drawing.Size(200, 167);
            this.ValueGroupBox.TabIndex = 4;
            this.ValueGroupBox.TabStop = false;
            this.ValueGroupBox.Text = "Choose a value";
            // 
            // TablesGroupbox
            // 
            this.TablesGroupbox.Controls.Add(this.ValueADatagrid);
            this.TablesGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesGroupbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TablesGroupbox.Location = new System.Drawing.Point(12, 28);
            this.TablesGroupbox.Name = "TablesGroupbox";
            this.TablesGroupbox.Size = new System.Drawing.Size(242, 421);
            this.TablesGroupbox.TabIndex = 5;
            this.TablesGroupbox.TabStop = false;
            this.TablesGroupbox.Text = "Table of values";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(260, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 248);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a value";
            // 
            // ConcentrationAButton
            // 
            this.ConcentrationAButton.AutoSize = true;
            this.ConcentrationAButton.Checked = true;
            this.ConcentrationAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConcentrationAButton.Location = new System.Drawing.Point(18, 35);
            this.ConcentrationAButton.Name = "ConcentrationAButton";
            this.ConcentrationAButton.Size = new System.Drawing.Size(136, 22);
            this.ConcentrationAButton.TabIndex = 0;
            this.ConcentrationAButton.TabStop = true;
            this.ConcentrationAButton.Text = "Value of Conc. A";
            this.ConcentrationAButton.UseVisualStyleBackColor = true;
            // 
            // ConcentrationBButton
            // 
            this.ConcentrationBButton.AutoSize = true;
            this.ConcentrationBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConcentrationBButton.Location = new System.Drawing.Point(18, 77);
            this.ConcentrationBButton.Name = "ConcentrationBButton";
            this.ConcentrationBButton.Size = new System.Drawing.Size(137, 22);
            this.ConcentrationBButton.TabIndex = 1;
            this.ConcentrationBButton.Text = "Value of Conc. B";
            this.ConcentrationBButton.UseVisualStyleBackColor = true;
            // 
            // ConcentrationCButton
            // 
            this.ConcentrationCButton.AutoSize = true;
            this.ConcentrationCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConcentrationCButton.Location = new System.Drawing.Point(18, 119);
            this.ConcentrationCButton.Name = "ConcentrationCButton";
            this.ConcentrationCButton.Size = new System.Drawing.Size(138, 22);
            this.ConcentrationCButton.TabIndex = 2;
            this.ConcentrationCButton.Text = "Value of Conc. C";
            this.ConcentrationCButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(832, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TablesGroupbox);
            this.Controls.Add(this.ValueGroupBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.MainFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueADatagrid)).EndInit();
            this.ValueGroupBox.ResumeLayout(false);
            this.ValueGroupBox.PerformLayout();
            this.TablesGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse MainFormEllipse;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private Guna.UI.WinForms.GunaDragControl MainWindowDragControl;
        private Guna.UI.WinForms.GunaCircleButton CloseButton;
        private Guna.UI.WinForms.GunaCircleButton MinimizeButton;
        private System.Windows.Forms.DataGridView ValueADatagrid;
        private System.Windows.Forms.GroupBox ValueGroupBox;
        private System.Windows.Forms.GroupBox TablesGroupbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ConcentrationCButton;
        private System.Windows.Forms.RadioButton ConcentrationBButton;
        private System.Windows.Forms.RadioButton ConcentrationAButton;
    }
}

