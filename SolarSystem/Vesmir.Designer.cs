namespace SolarSystem
{
    partial class Vesmir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vesmir));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.presnost = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.rychlost = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_merkur_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_venusa_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_zem_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_mars_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_jupiter_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_saturn_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_uran_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_neptun_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_slnko_stopa = new System.Windows.Forms.CheckBox();
            this.checkBox_sun = new System.Windows.Forms.CheckBox();
            this.checkBox_neptun = new System.Windows.Forms.CheckBox();
            this.checkBox_uran = new System.Windows.Forms.CheckBox();
            this.checkBox_saturn = new System.Windows.Forms.CheckBox();
            this.checkBox_jupiter = new System.Windows.Forms.CheckBox();
            this.checkBox_mars = new System.Windows.Forms.CheckBox();
            this.checkBox_zem = new System.Windows.Forms.CheckBox();
            this.checkBox_venusa = new System.Windows.Forms.CheckBox();
            this.checkBox_merkur = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presnost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rychlost)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(1450, 895);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 73);
            this.label5.TabIndex = 100002;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "    very accurate                                        not very accurate\r\n(slow" +
    "ers rendering)                               (fasters rendering)\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.presnost);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rychlost);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(1450, 603);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 289);
            this.groupBox3.TabIndex = 100001;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendering options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "slow                       medium                      fast\r\n";
            // 
            // presnost
            // 
            this.presnost.LargeChange = 100000;
            this.presnost.Location = new System.Drawing.Point(21, 211);
            this.presnost.Maximum = 5000000;
            this.presnost.Minimum = 5000;
            this.presnost.Name = "presnost";
            this.presnost.Size = new System.Drawing.Size(382, 56);
            this.presnost.SmallChange = 10000;
            this.presnost.TabIndex = 100000;
            this.presnost.TabStop = false;
            this.presnost.TickFrequency = 75000;
            this.presnost.Value = 300000;
            this.presnost.Scroll += new System.EventHandler(this.presnost_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Accuracy:";
            // 
            // rychlost
            // 
            this.rychlost.LargeChange = 1;
            this.rychlost.Location = new System.Drawing.Point(22, 82);
            this.rychlost.Maximum = 3;
            this.rychlost.Minimum = 1;
            this.rychlost.Name = "rychlost";
            this.rychlost.Size = new System.Drawing.Size(381, 56);
            this.rychlost.TabIndex = 20;
            this.rychlost.Value = 3;
            this.rychlost.Scroll += new System.EventHandler(this.rychlost_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Speed:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_merkur_stopa);
            this.groupBox1.Controls.Add(this.checkBox_venusa_stopa);
            this.groupBox1.Controls.Add(this.checkBox_zem_stopa);
            this.groupBox1.Controls.Add(this.checkBox_mars_stopa);
            this.groupBox1.Controls.Add(this.checkBox_jupiter_stopa);
            this.groupBox1.Controls.Add(this.checkBox_saturn_stopa);
            this.groupBox1.Controls.Add(this.checkBox_uran_stopa);
            this.groupBox1.Controls.Add(this.checkBox_neptun_stopa);
            this.groupBox1.Controls.Add(this.checkBox_slnko_stopa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(1670, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visible trace";
            // 
            // checkBox_merkur_stopa
            // 
            this.checkBox_merkur_stopa.AutoSize = true;
            this.checkBox_merkur_stopa.Checked = true;
            this.checkBox_merkur_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_merkur_stopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_merkur_stopa.Location = new System.Drawing.Point(18, 100);
            this.checkBox_merkur_stopa.Name = "checkBox_merkur_stopa";
            this.checkBox_merkur_stopa.Size = new System.Drawing.Size(126, 33);
            this.checkBox_merkur_stopa.TabIndex = 17;
            this.checkBox_merkur_stopa.Text = "Mercury";
            this.checkBox_merkur_stopa.UseVisualStyleBackColor = true;
            this.checkBox_merkur_stopa.CheckedChanged += new System.EventHandler(this.checkBox_merkur_stopa_CheckedChanged);
            // 
            // checkBox_venusa_stopa
            // 
            this.checkBox_venusa_stopa.AutoSize = true;
            this.checkBox_venusa_stopa.Checked = true;
            this.checkBox_venusa_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_venusa_stopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_venusa_stopa.Location = new System.Drawing.Point(18, 139);
            this.checkBox_venusa_stopa.Name = "checkBox_venusa_stopa";
            this.checkBox_venusa_stopa.Size = new System.Drawing.Size(107, 33);
            this.checkBox_venusa_stopa.TabIndex = 16;
            this.checkBox_venusa_stopa.Text = "Venus";
            this.checkBox_venusa_stopa.UseVisualStyleBackColor = true;
            this.checkBox_venusa_stopa.CheckedChanged += new System.EventHandler(this.checkBox_venusa_stopa_CheckedChanged);
            // 
            // checkBox_zem_stopa
            // 
            this.checkBox_zem_stopa.AutoSize = true;
            this.checkBox_zem_stopa.Checked = true;
            this.checkBox_zem_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_zem_stopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_zem_stopa.Location = new System.Drawing.Point(18, 178);
            this.checkBox_zem_stopa.Name = "checkBox_zem_stopa";
            this.checkBox_zem_stopa.Size = new System.Drawing.Size(95, 33);
            this.checkBox_zem_stopa.TabIndex = 15;
            this.checkBox_zem_stopa.Text = "Earth";
            this.checkBox_zem_stopa.UseVisualStyleBackColor = true;
            this.checkBox_zem_stopa.CheckedChanged += new System.EventHandler(this.checkBox_zem_stopa_CheckedChanged);
            // 
            // checkBox_mars_stopa
            // 
            this.checkBox_mars_stopa.AutoSize = true;
            this.checkBox_mars_stopa.Checked = true;
            this.checkBox_mars_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_mars_stopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_mars_stopa.Location = new System.Drawing.Point(18, 217);
            this.checkBox_mars_stopa.Name = "checkBox_mars_stopa";
            this.checkBox_mars_stopa.Size = new System.Drawing.Size(91, 33);
            this.checkBox_mars_stopa.TabIndex = 14;
            this.checkBox_mars_stopa.Text = "Mars";
            this.checkBox_mars_stopa.UseVisualStyleBackColor = true;
            this.checkBox_mars_stopa.CheckedChanged += new System.EventHandler(this.checkBox_mars_stopa_CheckedChanged);
            // 
            // checkBox_jupiter_stopa
            // 
            this.checkBox_jupiter_stopa.AutoSize = true;
            this.checkBox_jupiter_stopa.Checked = true;
            this.checkBox_jupiter_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_jupiter_stopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_jupiter_stopa.Location = new System.Drawing.Point(18, 256);
            this.checkBox_jupiter_stopa.Name = "checkBox_jupiter_stopa";
            this.checkBox_jupiter_stopa.Size = new System.Drawing.Size(111, 33);
            this.checkBox_jupiter_stopa.TabIndex = 13;
            this.checkBox_jupiter_stopa.Text = "Jupiter";
            this.checkBox_jupiter_stopa.UseVisualStyleBackColor = true;
            this.checkBox_jupiter_stopa.CheckedChanged += new System.EventHandler(this.checkBox_jupiter_stopa_CheckedChanged);
            // 
            // checkBox_saturn_stopa
            // 
            this.checkBox_saturn_stopa.AutoSize = true;
            this.checkBox_saturn_stopa.Checked = true;
            this.checkBox_saturn_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_saturn_stopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_saturn_stopa.Location = new System.Drawing.Point(18, 295);
            this.checkBox_saturn_stopa.Name = "checkBox_saturn_stopa";
            this.checkBox_saturn_stopa.Size = new System.Drawing.Size(109, 33);
            this.checkBox_saturn_stopa.TabIndex = 12;
            this.checkBox_saturn_stopa.Text = "Saturn";
            this.checkBox_saturn_stopa.UseVisualStyleBackColor = true;
            this.checkBox_saturn_stopa.CheckedChanged += new System.EventHandler(this.checkBox_saturn_stopa_CheckedChanged);
            // 
            // checkBox_uran_stopa
            // 
            this.checkBox_uran_stopa.AutoSize = true;
            this.checkBox_uran_stopa.Checked = true;
            this.checkBox_uran_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_uran_stopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_uran_stopa.Location = new System.Drawing.Point(18, 334);
            this.checkBox_uran_stopa.Name = "checkBox_uran_stopa";
            this.checkBox_uran_stopa.Size = new System.Drawing.Size(116, 33);
            this.checkBox_uran_stopa.TabIndex = 11;
            this.checkBox_uran_stopa.Text = "Uranus";
            this.checkBox_uran_stopa.UseVisualStyleBackColor = true;
            this.checkBox_uran_stopa.CheckedChanged += new System.EventHandler(this.checkBox_uran_stopa_CheckedChanged);
            // 
            // checkBox_neptun_stopa
            // 
            this.checkBox_neptun_stopa.AutoSize = true;
            this.checkBox_neptun_stopa.Checked = true;
            this.checkBox_neptun_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_neptun_stopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_neptun_stopa.Location = new System.Drawing.Point(18, 373);
            this.checkBox_neptun_stopa.Name = "checkBox_neptun_stopa";
            this.checkBox_neptun_stopa.Size = new System.Drawing.Size(130, 33);
            this.checkBox_neptun_stopa.TabIndex = 10;
            this.checkBox_neptun_stopa.Text = "Neptune";
            this.checkBox_neptun_stopa.UseVisualStyleBackColor = true;
            this.checkBox_neptun_stopa.CheckedChanged += new System.EventHandler(this.checkBox_neptun_stopa_CheckedChanged);
            // 
            // checkBox_slnko_stopa
            // 
            this.checkBox_slnko_stopa.AutoSize = true;
            this.checkBox_slnko_stopa.Checked = true;
            this.checkBox_slnko_stopa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_slnko_stopa.Location = new System.Drawing.Point(18, 61);
            this.checkBox_slnko_stopa.Name = "checkBox_slnko_stopa";
            this.checkBox_slnko_stopa.Size = new System.Drawing.Size(83, 33);
            this.checkBox_slnko_stopa.TabIndex = 9;
            this.checkBox_slnko_stopa.Text = "Sun";
            this.checkBox_slnko_stopa.UseVisualStyleBackColor = true;
            this.checkBox_slnko_stopa.CheckedChanged += new System.EventHandler(this.checkBox_slnko_stopa_CheckedChanged);
            // 
            // checkBox_sun
            // 
            this.checkBox_sun.AutoSize = true;
            this.checkBox_sun.Checked = true;
            this.checkBox_sun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sun.Location = new System.Drawing.Point(18, 61);
            this.checkBox_sun.Name = "checkBox_sun";
            this.checkBox_sun.Size = new System.Drawing.Size(83, 33);
            this.checkBox_sun.TabIndex = 9;
            this.checkBox_sun.Text = "Sun";
            this.checkBox_sun.UseVisualStyleBackColor = true;
            this.checkBox_sun.CheckedChanged += new System.EventHandler(this.checkBox_slnko_CheckedChanged);
            // 
            // checkBox_neptun
            // 
            this.checkBox_neptun.AutoSize = true;
            this.checkBox_neptun.Checked = true;
            this.checkBox_neptun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_neptun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_neptun.Location = new System.Drawing.Point(18, 373);
            this.checkBox_neptun.Name = "checkBox_neptun";
            this.checkBox_neptun.Size = new System.Drawing.Size(130, 33);
            this.checkBox_neptun.TabIndex = 10;
            this.checkBox_neptun.Text = "Neptune";
            this.checkBox_neptun.UseVisualStyleBackColor = true;
            this.checkBox_neptun.CheckedChanged += new System.EventHandler(this.checkBox_neptun_CheckedChanged);
            // 
            // checkBox_uran
            // 
            this.checkBox_uran.AutoSize = true;
            this.checkBox_uran.Checked = true;
            this.checkBox_uran.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_uran.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_uran.Location = new System.Drawing.Point(18, 334);
            this.checkBox_uran.Name = "checkBox_uran";
            this.checkBox_uran.Size = new System.Drawing.Size(116, 33);
            this.checkBox_uran.TabIndex = 11;
            this.checkBox_uran.Text = "Uranus";
            this.checkBox_uran.UseVisualStyleBackColor = true;
            this.checkBox_uran.CheckedChanged += new System.EventHandler(this.checkBox_uran_CheckedChanged);
            // 
            // checkBox_saturn
            // 
            this.checkBox_saturn.AutoSize = true;
            this.checkBox_saturn.Checked = true;
            this.checkBox_saturn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_saturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_saturn.Location = new System.Drawing.Point(18, 295);
            this.checkBox_saturn.Name = "checkBox_saturn";
            this.checkBox_saturn.Size = new System.Drawing.Size(109, 33);
            this.checkBox_saturn.TabIndex = 12;
            this.checkBox_saturn.Text = "Saturn";
            this.checkBox_saturn.UseVisualStyleBackColor = true;
            this.checkBox_saturn.CheckedChanged += new System.EventHandler(this.checkBox_saturn_CheckedChanged);
            // 
            // checkBox_jupiter
            // 
            this.checkBox_jupiter.AutoSize = true;
            this.checkBox_jupiter.Checked = true;
            this.checkBox_jupiter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_jupiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_jupiter.Location = new System.Drawing.Point(18, 256);
            this.checkBox_jupiter.Name = "checkBox_jupiter";
            this.checkBox_jupiter.Size = new System.Drawing.Size(111, 33);
            this.checkBox_jupiter.TabIndex = 13;
            this.checkBox_jupiter.Text = "Jupiter";
            this.checkBox_jupiter.UseVisualStyleBackColor = true;
            this.checkBox_jupiter.CheckedChanged += new System.EventHandler(this.checkBox_jupiter_CheckedChanged);
            // 
            // checkBox_mars
            // 
            this.checkBox_mars.AutoSize = true;
            this.checkBox_mars.Checked = true;
            this.checkBox_mars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_mars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_mars.Location = new System.Drawing.Point(18, 217);
            this.checkBox_mars.Name = "checkBox_mars";
            this.checkBox_mars.Size = new System.Drawing.Size(91, 33);
            this.checkBox_mars.TabIndex = 14;
            this.checkBox_mars.Text = "Mars";
            this.checkBox_mars.UseVisualStyleBackColor = true;
            this.checkBox_mars.CheckedChanged += new System.EventHandler(this.checkBox_mars_CheckedChanged);
            // 
            // checkBox_zem
            // 
            this.checkBox_zem.AutoSize = true;
            this.checkBox_zem.Checked = true;
            this.checkBox_zem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_zem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_zem.Location = new System.Drawing.Point(18, 178);
            this.checkBox_zem.Name = "checkBox_zem";
            this.checkBox_zem.Size = new System.Drawing.Size(95, 33);
            this.checkBox_zem.TabIndex = 15;
            this.checkBox_zem.Text = "Earth";
            this.checkBox_zem.UseVisualStyleBackColor = true;
            this.checkBox_zem.CheckedChanged += new System.EventHandler(this.checkBox_zem_CheckedChanged);
            // 
            // checkBox_venusa
            // 
            this.checkBox_venusa.AutoSize = true;
            this.checkBox_venusa.Checked = true;
            this.checkBox_venusa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_venusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_venusa.Location = new System.Drawing.Point(18, 139);
            this.checkBox_venusa.Name = "checkBox_venusa";
            this.checkBox_venusa.Size = new System.Drawing.Size(107, 33);
            this.checkBox_venusa.TabIndex = 16;
            this.checkBox_venusa.Text = "Venus";
            this.checkBox_venusa.UseVisualStyleBackColor = true;
            this.checkBox_venusa.CheckedChanged += new System.EventHandler(this.checkBox_venusa_CheckedChanged);
            // 
            // checkBox_merkur
            // 
            this.checkBox_merkur.AutoSize = true;
            this.checkBox_merkur.Checked = true;
            this.checkBox_merkur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_merkur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_merkur.Location = new System.Drawing.Point(18, 100);
            this.checkBox_merkur.Name = "checkBox_merkur";
            this.checkBox_merkur.Size = new System.Drawing.Size(126, 33);
            this.checkBox_merkur.TabIndex = 17;
            this.checkBox_merkur.Text = "Mercury";
            this.checkBox_merkur.UseVisualStyleBackColor = true;
            this.checkBox_merkur.CheckedChanged += new System.EventHandler(this.checkBox_merkur_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_merkur);
            this.groupBox2.Controls.Add(this.checkBox_venusa);
            this.groupBox2.Controls.Add(this.checkBox_zem);
            this.groupBox2.Controls.Add(this.checkBox_mars);
            this.groupBox2.Controls.Add(this.checkBox_jupiter);
            this.groupBox2.Controls.Add(this.checkBox_saturn);
            this.groupBox2.Controls.Add(this.checkBox_uran);
            this.groupBox2.Controls.Add(this.checkBox_neptun);
            this.groupBox2.Controls.Add(this.checkBox_sun);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(1450, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 472);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visible objects";
            // 
            // Vesmir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vesmir";
            this.Text = "Solar System Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presnost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rychlost)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar presnost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar rychlost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_merkur_stopa;
        private System.Windows.Forms.CheckBox checkBox_venusa_stopa;
        private System.Windows.Forms.CheckBox checkBox_zem_stopa;
        private System.Windows.Forms.CheckBox checkBox_mars_stopa;
        private System.Windows.Forms.CheckBox checkBox_jupiter_stopa;
        private System.Windows.Forms.CheckBox checkBox_saturn_stopa;
        private System.Windows.Forms.CheckBox checkBox_uran_stopa;
        private System.Windows.Forms.CheckBox checkBox_neptun_stopa;
        private System.Windows.Forms.CheckBox checkBox_slnko_stopa;
        private System.Windows.Forms.CheckBox checkBox_sun;
        private System.Windows.Forms.CheckBox checkBox_neptun;
        private System.Windows.Forms.CheckBox checkBox_uran;
        private System.Windows.Forms.CheckBox checkBox_saturn;
        private System.Windows.Forms.CheckBox checkBox_jupiter;
        private System.Windows.Forms.CheckBox checkBox_mars;
        private System.Windows.Forms.CheckBox checkBox_zem;
        private System.Windows.Forms.CheckBox checkBox_venusa;
        private System.Windows.Forms.CheckBox checkBox_merkur;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

