namespace software_lab7
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvRaw = new DataGridView();
            dgvSummary = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRaw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            SuspendLayout();
            // 
            // dgvRaw
            // 
            dgvRaw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaw.Location = new Point(12, 12);
            dgvRaw.Name = "dgvRaw";
            dgvRaw.RowHeadersWidth = 62;
            dgvRaw.Size = new Size(480, 386);
            dgvRaw.TabIndex = 0;
            // 
            // dgvSummary
            // 
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Location = new Point(498, 12);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.RowHeadersWidth = 62;
            dgvSummary.Size = new Size(290, 386);
            dgvSummary.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 404);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(195, 34);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Загрузить данные";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(dgvSummary);
            Controls.Add(dgvRaw);
            Name = "Form1";
            Text = "Загрузка данных";
            ((System.ComponentModel.ISupportInitialize)dgvRaw).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRaw;
        private DataGridView dgvSummary;
        private Button btnLoad;
    }
}
