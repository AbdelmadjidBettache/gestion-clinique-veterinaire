namespace Examen_Final
{
    partial class Afficher_Chat
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
            this.dgr_chats = new System.Windows.Forms.DataGridView();
            this.Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Race = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proprietaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_chats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr_chats
            // 
            this.dgr_chats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_chats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identifiant,
            this.Nom,
            this.Race,
            this.Proprietaire});
            this.dgr_chats.Location = new System.Drawing.Point(0, 0);
            this.dgr_chats.Name = "dgr_chats";
            this.dgr_chats.RowHeadersWidth = 51;
            this.dgr_chats.RowTemplate.Height = 24;
            this.dgr_chats.Size = new System.Drawing.Size(662, 151);
            this.dgr_chats.TabIndex = 0;
            this.dgr_chats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Identifiant
            // 
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.MinimumWidth = 6;
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Width = 125;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Race
            // 
            this.Race.HeaderText = "Race";
            this.Race.MinimumWidth = 6;
            this.Race.Name = "Race";
            this.Race.Width = 125;
            // 
            // Proprietaire
            // 
            this.Proprietaire.HeaderText = "Proprietaire";
            this.Proprietaire.MinimumWidth = 6;
            this.Proprietaire.Name = "Proprietaire";
            this.Proprietaire.Width = 125;
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(330, 269);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(160, 36);
            this.btn_retour.TabIndex = 1;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // Afficher_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dgr_chats);
            this.Name = "Afficher_Chat";
            this.Text = "Afficher chat";
            ((System.ComponentModel.ISupportInitialize)(this.dgr_chats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_chats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Race;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proprietaire;
        private System.Windows.Forms.Button btn_retour;
    }
}