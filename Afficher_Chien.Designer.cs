namespace Examen_Final
{
    partial class Afficher_Chien
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
            this.btn_rechrche = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.txt_proprietaire = new System.Windows.Forms.TextBox();
            this.lbl_proprietaire = new System.Windows.Forms.Label();
            this.txt_race = new System.Windows.Forms.TextBox();
            this.ibi_race = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_rechrche
            // 
            this.btn_rechrche.Location = new System.Drawing.Point(447, 59);
            this.btn_rechrche.Name = "btn_rechrche";
            this.btn_rechrche.Size = new System.Drawing.Size(145, 25);
            this.btn_rechrche.TabIndex = 41;
            this.btn_rechrche.Text = "Recherche";
            this.btn_rechrche.UseVisualStyleBackColor = true;
            this.btn_rechrche.Click += new System.EventHandler(this.btn_rechrche_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(406, 356);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(131, 33);
            this.btn_retour.TabIndex = 40;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(140, 356);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(142, 32);
            this.btn_supprimer.TabIndex = 39;
            this.btn_supprimer.Text = "Afficher";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // txt_proprietaire
            // 
            this.txt_proprietaire.Location = new System.Drawing.Point(235, 284);
            this.txt_proprietaire.Name = "txt_proprietaire";
            this.txt_proprietaire.ReadOnly = true;
            this.txt_proprietaire.Size = new System.Drawing.Size(179, 22);
            this.txt_proprietaire.TabIndex = 38;
            // 
            // lbl_proprietaire
            // 
            this.lbl_proprietaire.AutoSize = true;
            this.lbl_proprietaire.Location = new System.Drawing.Point(60, 284);
            this.lbl_proprietaire.Name = "lbl_proprietaire";
            this.lbl_proprietaire.Size = new System.Drawing.Size(93, 16);
            this.lbl_proprietaire.TabIndex = 37;
            this.lbl_proprietaire.Text = "Proprietaire ID";
            // 
            // txt_race
            // 
            this.txt_race.Location = new System.Drawing.Point(235, 212);
            this.txt_race.Name = "txt_race";
            this.txt_race.ReadOnly = true;
            this.txt_race.Size = new System.Drawing.Size(179, 22);
            this.txt_race.TabIndex = 36;
            // 
            // ibi_race
            // 
            this.ibi_race.AutoSize = true;
            this.ibi_race.Location = new System.Drawing.Point(60, 212);
            this.ibi_race.Name = "ibi_race";
            this.ibi_race.Size = new System.Drawing.Size(40, 16);
            this.ibi_race.TabIndex = 35;
            this.ibi_race.Text = "Race";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(235, 134);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.ReadOnly = true;
            this.txt_nom.Size = new System.Drawing.Size(179, 22);
            this.txt_nom.TabIndex = 34;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(60, 134);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(36, 16);
            this.lbl_nom.TabIndex = 33;
            this.lbl_nom.Text = "Nom";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(235, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(179, 22);
            this.txt_id.TabIndex = 32;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(60, 59);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(63, 16);
            this.lbl_id.TabIndex = 31;
            this.lbl_id.Text = "Identifiant";
            // 
            // Afficher_Chien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_rechrche);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.txt_proprietaire);
            this.Controls.Add(this.lbl_proprietaire);
            this.Controls.Add(this.txt_race);
            this.Controls.Add(this.ibi_race);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "Afficher_Chien";
            this.Text = "Afficher chien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rechrche;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.TextBox txt_proprietaire;
        private System.Windows.Forms.Label lbl_proprietaire;
        private System.Windows.Forms.TextBox txt_race;
        private System.Windows.Forms.Label ibi_race;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}