namespace Kliniken
{
    partial class frmArbeitsvertagListeAnzeigen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFilterWert = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagvArbeitsvertrag = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagvArbeitsvertrag)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilterWert
            // 
            this.cbFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterWert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbFilterWert.FormattingEnabled = true;
            this.cbFilterWert.Location = new System.Drawing.Point(184, 55);
            this.cbFilterWert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterWert.Name = "cbFilterWert";
            this.cbFilterWert.Size = new System.Drawing.Size(506, 28);
            this.cbFilterWert.TabIndex = 9;
            this.cbFilterWert.SelectedIndexChanged += new System.EventHandler(this.cbFilterWert_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter bei Abteilung:";
            // 
            // datagvArbeitsvertrag
            // 
            this.datagvArbeitsvertrag.AllowUserToAddRows = false;
            this.datagvArbeitsvertrag.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.datagvArbeitsvertrag.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagvArbeitsvertrag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvArbeitsvertrag.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.datagvArbeitsvertrag.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.datagvArbeitsvertrag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagvArbeitsvertrag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagvArbeitsvertrag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvArbeitsvertrag.Cursor = System.Windows.Forms.Cursors.Default;
            this.datagvArbeitsvertrag.EnableHeadersVisualStyles = false;
            this.datagvArbeitsvertrag.Location = new System.Drawing.Point(12, 96);
            this.datagvArbeitsvertrag.Name = "datagvArbeitsvertrag";
            this.datagvArbeitsvertrag.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagvArbeitsvertrag.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagvArbeitsvertrag.Size = new System.Drawing.Size(1600, 485);
            this.datagvArbeitsvertrag.TabIndex = 10;
            // 
            // frmArbeitsvertagListeAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 608);
            this.Controls.Add(this.datagvArbeitsvertrag);
            this.Controls.Add(this.cbFilterWert);
            this.Controls.Add(this.label2);
            this.Name = "frmArbeitsvertagListeAnzeigen";
            this.Text = "Arbeitsvertagliste-Anzeigen";
            this.Load += new System.EventHandler(this.frmArbeitsvertagListeAnzeigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagvArbeitsvertrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilterWert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagvArbeitsvertrag;
    }
}