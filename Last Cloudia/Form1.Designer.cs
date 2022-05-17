
namespace Last_Cloudia
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPersonnage = new System.Windows.Forms.Button();
            this.button_listSkill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonnage
            // 
            this.buttonPersonnage.Location = new System.Drawing.Point(303, 155);
            this.buttonPersonnage.Name = "buttonPersonnage";
            this.buttonPersonnage.Size = new System.Drawing.Size(168, 40);
            this.buttonPersonnage.TabIndex = 0;
            this.buttonPersonnage.Text = "Liste de Personnages";
            this.buttonPersonnage.UseVisualStyleBackColor = true;
            this.buttonPersonnage.Click += new System.EventHandler(this.buttonPersonnage_Click);
            // 
            // button_listSkill
            // 
            this.button_listSkill.Location = new System.Drawing.Point(303, 227);
            this.button_listSkill.Name = "button_listSkill";
            this.button_listSkill.Size = new System.Drawing.Size(168, 40);
            this.button_listSkill.TabIndex = 1;
            this.button_listSkill.Text = "Liste des Compétences";
            this.button_listSkill.UseVisualStyleBackColor = true;
            this.button_listSkill.Click += new System.EventHandler(this.button_listSkill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_listSkill);
            this.Controls.Add(this.buttonPersonnage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPersonnage;
        private System.Windows.Forms.Button button_listSkill;
    }
}

