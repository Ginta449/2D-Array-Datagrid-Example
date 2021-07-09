namespace Question_2_CA_by_GintaAndDeirdre
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dtgRainfall = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDryYear = new System.Windows.Forms.Button();
            this.btnWetYear = new System.Windows.Forms.Button();
            this.btnDrySeason = new System.Windows.Forms.Button();
            this.btnWetSeason = new System.Windows.Forms.Button();
            this.txtDryYear = new System.Windows.Forms.TextBox();
            this.txtWetYear = new System.Windows.Forms.TextBox();
            this.txtWetSeason = new System.Windows.Forms.TextBox();
            this.lstValues = new System.Windows.Forms.ListBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblRainfallCalc = new System.Windows.Forms.Label();
            this.lblRainfall = new System.Windows.Forms.Label();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtDrySeason = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRowSelect = new System.Windows.Forms.Button();
            this.btnColumnSelect = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtAll = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRainfall)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRainfall
            // 
            this.dtgRainfall.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgRainfall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRainfall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgRainfall.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgRainfall.Location = new System.Drawing.Point(9, 23);
            this.dtgRainfall.Margin = new System.Windows.Forms.Padding(2);
            this.dtgRainfall.Name = "dtgRainfall";
            this.dtgRainfall.RowHeadersWidth = 51;
            this.dtgRainfall.RowTemplate.Height = 24;
            this.dtgRainfall.Size = new System.Drawing.Size(683, 153);
            this.dtgRainfall.TabIndex = 0;
            this.dtgRainfall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DividerWidth = 3;
            this.Column1.HeaderText = "Year and Season";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DividerWidth = 3;
            this.Column2.HeaderText = "2016";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DividerWidth = 3;
            this.Column3.HeaderText = "2017";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DividerWidth = 3;
            this.Column4.HeaderText = "2018";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DividerWidth = 3;
            this.Column5.HeaderText = "2019";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 125;
            // 
            // btnDryYear
            // 
            this.btnDryYear.Location = new System.Drawing.Point(11, 337);
            this.btnDryYear.Margin = new System.Windows.Forms.Padding(2);
            this.btnDryYear.Name = "btnDryYear";
            this.btnDryYear.Size = new System.Drawing.Size(146, 43);
            this.btnDryYear.TabIndex = 1;
            this.btnDryYear.Text = "Driest Year";
            this.btnDryYear.UseVisualStyleBackColor = true;
            this.btnDryYear.Click += new System.EventHandler(this.btnDryYear_Click);
            // 
            // btnWetYear
            // 
            this.btnWetYear.Location = new System.Drawing.Point(186, 337);
            this.btnWetYear.Margin = new System.Windows.Forms.Padding(2);
            this.btnWetYear.Name = "btnWetYear";
            this.btnWetYear.Size = new System.Drawing.Size(146, 43);
            this.btnWetYear.TabIndex = 2;
            this.btnWetYear.Text = "Wettest Year";
            this.btnWetYear.UseVisualStyleBackColor = true;
            this.btnWetYear.Click += new System.EventHandler(this.btnWetYear_Click);
            // 
            // btnDrySeason
            // 
            this.btnDrySeason.Location = new System.Drawing.Point(368, 337);
            this.btnDrySeason.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrySeason.Name = "btnDrySeason";
            this.btnDrySeason.Size = new System.Drawing.Size(146, 43);
            this.btnDrySeason.TabIndex = 3;
            this.btnDrySeason.Text = "Driest Season";
            this.btnDrySeason.UseVisualStyleBackColor = true;
            this.btnDrySeason.Click += new System.EventHandler(this.btnDrySeason_Click);
            // 
            // btnWetSeason
            // 
            this.btnWetSeason.Location = new System.Drawing.Point(546, 337);
            this.btnWetSeason.Margin = new System.Windows.Forms.Padding(2);
            this.btnWetSeason.Name = "btnWetSeason";
            this.btnWetSeason.Size = new System.Drawing.Size(146, 43);
            this.btnWetSeason.TabIndex = 4;
            this.btnWetSeason.Text = "Wettest Season";
            this.btnWetSeason.UseVisualStyleBackColor = true;
            this.btnWetSeason.Click += new System.EventHandler(this.btnWetSeason_Click);
            // 
            // txtDryYear
            // 
            this.txtDryYear.Enabled = false;
            this.txtDryYear.Location = new System.Drawing.Point(11, 391);
            this.txtDryYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtDryYear.Name = "txtDryYear";
            this.txtDryYear.Size = new System.Drawing.Size(146, 20);
            this.txtDryYear.TabIndex = 5;
            // 
            // txtWetYear
            // 
            this.txtWetYear.Enabled = false;
            this.txtWetYear.Location = new System.Drawing.Point(186, 391);
            this.txtWetYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtWetYear.Name = "txtWetYear";
            this.txtWetYear.Size = new System.Drawing.Size(146, 20);
            this.txtWetYear.TabIndex = 6;
            this.txtWetYear.TextChanged += new System.EventHandler(this.txtWetYear_TextChanged);
            // 
            // txtWetSeason
            // 
            this.txtWetSeason.Enabled = false;
            this.txtWetSeason.Location = new System.Drawing.Point(546, 391);
            this.txtWetSeason.Margin = new System.Windows.Forms.Padding(2);
            this.txtWetSeason.Name = "txtWetSeason";
            this.txtWetSeason.Size = new System.Drawing.Size(146, 20);
            this.txtWetSeason.TabIndex = 8;
            // 
            // lstValues
            // 
            this.lstValues.FormattingEnabled = true;
            this.lstValues.Location = new System.Drawing.Point(794, 11);
            this.lstValues.Margin = new System.Windows.Forms.Padding(2);
            this.lstValues.Name = "lstValues";
            this.lstValues.Size = new System.Drawing.Size(91, 30);
            this.lstValues.TabIndex = 9;
            this.lstValues.Visible = false;
            this.lstValues.SelectedIndexChanged += new System.EventHandler(this.lstValues_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(617, 180);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(74, 25);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblRainfallCalc
            // 
            this.lblRainfallCalc.AutoSize = true;
            this.lblRainfallCalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRainfallCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRainfallCalc.Location = new System.Drawing.Point(819, 127);
            this.lblRainfallCalc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRainfallCalc.Name = "lblRainfallCalc";
            this.lblRainfallCalc.Size = new System.Drawing.Size(2, 15);
            this.lblRainfallCalc.TabIndex = 12;
            // 
            // lblRainfall
            // 
            this.lblRainfall.AutoSize = true;
            this.lblRainfall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRainfall.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRainfall.Location = new System.Drawing.Point(727, 127);
            this.lblRainfall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRainfall.Name = "lblRainfall";
            this.lblRainfall.Size = new System.Drawing.Size(47, 15);
            this.lblRainfall.TabIndex = 13;
            this.lblRainfall.Text = "Rainfall:";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DividerWidth = 3;
            this.dataGridViewButtonColumn1.HeaderText = "Year and Season";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DividerWidth = 3;
            this.dataGridViewTextBoxColumn1.HeaderText = "2016";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DividerWidth = 3;
            this.dataGridViewTextBoxColumn2.HeaderText = "2017";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DividerWidth = 3;
            this.dataGridViewTextBoxColumn3.HeaderText = "2018";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DividerWidth = 3;
            this.dataGridViewTextBoxColumn4.HeaderText = "2019";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(577, 308);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 18;
            // 
            // txtDrySeason
            // 
            this.txtDrySeason.Enabled = false;
            this.txtDrySeason.Location = new System.Drawing.Point(368, 391);
            this.txtDrySeason.Margin = new System.Windows.Forms.Padding(2);
            this.txtDrySeason.Name = "txtDrySeason";
            this.txtDrySeason.Size = new System.Drawing.Size(146, 20);
            this.txtDrySeason.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnRowSelect
            // 
            this.btnRowSelect.Location = new System.Drawing.Point(234, 180);
            this.btnRowSelect.Name = "btnRowSelect";
            this.btnRowSelect.Size = new System.Drawing.Size(196, 25);
            this.btnRowSelect.TabIndex = 21;
            this.btnRowSelect.Text = "Enable Row Selection";
            this.btnRowSelect.UseVisualStyleBackColor = true;
            this.btnRowSelect.Click += new System.EventHandler(this.btnRowSelect_Click);
            // 
            // btnColumnSelect
            // 
            this.btnColumnSelect.Location = new System.Drawing.Point(436, 180);
            this.btnColumnSelect.Name = "btnColumnSelect";
            this.btnColumnSelect.Size = new System.Drawing.Size(176, 25);
            this.btnColumnSelect.TabIndex = 22;
            this.btnColumnSelect.Text = "Enable Column Selection";
            this.btnColumnSelect.UseVisualStyleBackColor = true;
            this.btnColumnSelect.Click += new System.EventHandler(this.btnColumnSelect_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(727, 46);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(148, 62);
            this.btnGet.TabIndex = 23;
            this.btnGet.Text = "Get Overall Rainfall for Selected Season or Year";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(727, 337);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(142, 43);
            this.btnAll.TabIndex = 24;
            this.btnAll.Text = "Overall Rainfall for All Years and Seasons";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txtAll
            // 
            this.txtAll.Enabled = false;
            this.txtAll.Location = new System.Drawing.Point(727, 391);
            this.txtAll.Name = "txtAll";
            this.txtAll.Size = new System.Drawing.Size(142, 20);
            this.txtAll.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 430);
            this.Controls.Add(this.txtAll);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnColumnSelect);
            this.Controls.Add(this.btnRowSelect);
            this.Controls.Add(this.txtDrySeason);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblRainfall);
            this.Controls.Add(this.lblRainfallCalc);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lstValues);
            this.Controls.Add(this.txtWetSeason);
            this.Controls.Add(this.txtWetYear);
            this.Controls.Add(this.txtDryYear);
            this.Controls.Add(this.btnWetSeason);
            this.Controls.Add(this.btnDrySeason);
            this.Controls.Add(this.btnWetYear);
            this.Controls.Add(this.btnDryYear);
            this.Controls.Add(this.dtgRainfall);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Rainfall Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRainfall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRainfall;
        private System.Windows.Forms.Button btnDryYear;
        private System.Windows.Forms.Button btnWetYear;
        private System.Windows.Forms.Button btnDrySeason;
        private System.Windows.Forms.Button btnWetSeason;
        private System.Windows.Forms.TextBox txtDryYear;
        private System.Windows.Forms.TextBox txtWetYear;
        private System.Windows.Forms.TextBox txtWetSeason;
        private System.Windows.Forms.ListBox lstValues;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblRainfallCalc;
        private System.Windows.Forms.Label lblRainfall;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtDrySeason;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnRowSelect;
        private System.Windows.Forms.Button btnColumnSelect;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtAll;
    }
}

