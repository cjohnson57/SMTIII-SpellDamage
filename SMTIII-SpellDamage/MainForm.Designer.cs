namespace SMTIII_SpellDamage
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DamageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SelectedSpell = new System.Windows.Forms.ComboBox();
            this.MagicStatBar = new System.Windows.Forms.TrackBar();
            this.SpellLabel = new System.Windows.Forms.Label();
            this.MagicStatLabel = new System.Windows.Forms.Label();
            this.MagicStat = new System.Windows.Forms.NumericUpDown();
            this.PowerBox = new System.Windows.Forms.TextBox();
            this.LimitBox = new System.Windows.Forms.TextBox();
            this.CorrectionBox = new System.Windows.Forms.TextBox();
            this.PeakBox = new System.Windows.Forms.TextBox();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.LimitLabel = new System.Windows.Forms.Label();
            this.CorrectionLabel = new System.Windows.Forms.Label();
            this.PeakLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DamageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicStatBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicStat)).BeginInit();
            this.SuspendLayout();
            // 
            // DamageChart
            // 
            chartArea1.AxisX.Title = "Level";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Damage";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.DamageChart.ChartAreas.Add(chartArea1);
            this.DamageChart.Location = new System.Drawing.Point(11, 154);
            this.DamageChart.Name = "DamageChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.DamageChart.Series.Add(series1);
            this.DamageChart.Size = new System.Drawing.Size(779, 485);
            this.DamageChart.TabIndex = 0;
            this.DamageChart.Text = "chart1";
            // 
            // SelectedSpell
            // 
            this.SelectedSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedSpell.FormattingEnabled = true;
            this.SelectedSpell.Location = new System.Drawing.Point(15, 27);
            this.SelectedSpell.Name = "SelectedSpell";
            this.SelectedSpell.Size = new System.Drawing.Size(120, 21);
            this.SelectedSpell.TabIndex = 1;
            this.SelectedSpell.SelectedIndexChanged += new System.EventHandler(this.SelectedSpell_SelectedIndexChanged);
            // 
            // MagicStatBar
            // 
            this.MagicStatBar.Location = new System.Drawing.Point(12, 103);
            this.MagicStatBar.Maximum = 40;
            this.MagicStatBar.Minimum = 1;
            this.MagicStatBar.Name = "MagicStatBar";
            this.MagicStatBar.Size = new System.Drawing.Size(544, 45);
            this.MagicStatBar.TabIndex = 3;
            this.MagicStatBar.Value = 40;
            this.MagicStatBar.Scroll += new System.EventHandler(this.MagicStatBar_Scroll);
            // 
            // SpellLabel
            // 
            this.SpellLabel.AutoSize = true;
            this.SpellLabel.Location = new System.Drawing.Point(12, 11);
            this.SpellLabel.Name = "SpellLabel";
            this.SpellLabel.Size = new System.Drawing.Size(30, 13);
            this.SpellLabel.TabIndex = 3;
            this.SpellLabel.Text = "Spell";
            // 
            // MagicStatLabel
            // 
            this.MagicStatLabel.AutoSize = true;
            this.MagicStatLabel.Location = new System.Drawing.Point(12, 61);
            this.MagicStatLabel.Name = "MagicStatLabel";
            this.MagicStatLabel.Size = new System.Drawing.Size(58, 13);
            this.MagicStatLabel.TabIndex = 4;
            this.MagicStatLabel.Text = "Magic Stat";
            // 
            // MagicStat
            // 
            this.MagicStat.Location = new System.Drawing.Point(15, 77);
            this.MagicStat.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.MagicStat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MagicStat.Name = "MagicStat";
            this.MagicStat.Size = new System.Drawing.Size(120, 20);
            this.MagicStat.TabIndex = 2;
            this.MagicStat.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.MagicStat.ValueChanged += new System.EventHandler(this.MagicStat_ValueChanged);
            // 
            // PowerBox
            // 
            this.PowerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PowerBox.Location = new System.Drawing.Point(173, 27);
            this.PowerBox.Multiline = true;
            this.PowerBox.Name = "PowerBox";
            this.PowerBox.ReadOnly = true;
            this.PowerBox.Size = new System.Drawing.Size(100, 21);
            this.PowerBox.TabIndex = 5;
            // 
            // LimitBox
            // 
            this.LimitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LimitBox.Location = new System.Drawing.Point(311, 27);
            this.LimitBox.Multiline = true;
            this.LimitBox.Name = "LimitBox";
            this.LimitBox.ReadOnly = true;
            this.LimitBox.Size = new System.Drawing.Size(100, 21);
            this.LimitBox.TabIndex = 6;
            // 
            // CorrectionBox
            // 
            this.CorrectionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorrectionBox.Location = new System.Drawing.Point(449, 27);
            this.CorrectionBox.Multiline = true;
            this.CorrectionBox.Name = "CorrectionBox";
            this.CorrectionBox.ReadOnly = true;
            this.CorrectionBox.Size = new System.Drawing.Size(100, 21);
            this.CorrectionBox.TabIndex = 7;
            // 
            // PeakBox
            // 
            this.PeakBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PeakBox.Location = new System.Drawing.Point(587, 27);
            this.PeakBox.Multiline = true;
            this.PeakBox.Name = "PeakBox";
            this.PeakBox.ReadOnly = true;
            this.PeakBox.Size = new System.Drawing.Size(100, 21);
            this.PeakBox.TabIndex = 8;
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(170, 11);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(37, 13);
            this.PowerLabel.TabIndex = 9;
            this.PowerLabel.Text = "Power";
            // 
            // LimitLabel
            // 
            this.LimitLabel.AutoSize = true;
            this.LimitLabel.Location = new System.Drawing.Point(308, 11);
            this.LimitLabel.Name = "LimitLabel";
            this.LimitLabel.Size = new System.Drawing.Size(28, 13);
            this.LimitLabel.TabIndex = 10;
            this.LimitLabel.Text = "Limit";
            // 
            // CorrectionLabel
            // 
            this.CorrectionLabel.AutoSize = true;
            this.CorrectionLabel.Location = new System.Drawing.Point(446, 11);
            this.CorrectionLabel.Name = "CorrectionLabel";
            this.CorrectionLabel.Size = new System.Drawing.Size(55, 13);
            this.CorrectionLabel.TabIndex = 11;
            this.CorrectionLabel.Text = "Correction";
            // 
            // PeakLabel
            // 
            this.PeakLabel.AutoSize = true;
            this.PeakLabel.Location = new System.Drawing.Point(584, 11);
            this.PeakLabel.Name = "PeakLabel";
            this.PeakLabel.Size = new System.Drawing.Size(32, 13);
            this.PeakLabel.TabIndex = 12;
            this.PeakLabel.Text = "Peak";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.PeakLabel);
            this.Controls.Add(this.CorrectionLabel);
            this.Controls.Add(this.LimitLabel);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.PeakBox);
            this.Controls.Add(this.CorrectionBox);
            this.Controls.Add(this.LimitBox);
            this.Controls.Add(this.PowerBox);
            this.Controls.Add(this.MagicStat);
            this.Controls.Add(this.MagicStatLabel);
            this.Controls.Add(this.SpellLabel);
            this.Controls.Add(this.MagicStatBar);
            this.Controls.Add(this.SelectedSpell);
            this.Controls.Add(this.DamageChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SMTIII Spell Damage";
            ((System.ComponentModel.ISupportInitialize)(this.DamageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicStatBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DamageChart;
        private System.Windows.Forms.ComboBox SelectedSpell;
        private System.Windows.Forms.TrackBar MagicStatBar;
        private System.Windows.Forms.Label SpellLabel;
        private System.Windows.Forms.Label MagicStatLabel;
        private System.Windows.Forms.NumericUpDown MagicStat;
        private System.Windows.Forms.TextBox PowerBox;
        private System.Windows.Forms.TextBox LimitBox;
        private System.Windows.Forms.TextBox CorrectionBox;
        private System.Windows.Forms.TextBox PeakBox;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label LimitLabel;
        private System.Windows.Forms.Label CorrectionLabel;
        private System.Windows.Forms.Label PeakLabel;
    }
}

