namespace Prime_Minister_Simulator
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
            this.MenuMainText = new System.Windows.Forms.Label();
            this.Mmenu_NewGame = new System.Windows.Forms.Button();
            this.Mmenu_ContinueSave = new System.Windows.Forms.Button();
            this.Mmenu_Tutorial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuMainText
            // 
            this.MenuMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMainText.Location = new System.Drawing.Point(640, 156);
            this.MenuMainText.Name = "MenuMainText";
            this.MenuMainText.Size = new System.Drawing.Size(368, 39);
            this.MenuMainText.TabIndex = 0;
            this.MenuMainText.Text = "Prime Minister Simulator";
            this.MenuMainText.Click += new System.EventHandler(this.MenuMainText_Click);
            // 
            // Mmenu_NewGame
            // 
            this.Mmenu_NewGame.Location = new System.Drawing.Point(97, 486);
            this.Mmenu_NewGame.Name = "Mmenu_NewGame";
            this.Mmenu_NewGame.Size = new System.Drawing.Size(135, 66);
            this.Mmenu_NewGame.TabIndex = 1;
            this.Mmenu_NewGame.Text = "New Game";
            this.Mmenu_NewGame.UseVisualStyleBackColor = true;
            // 
            // Mmenu_ContinueSave
            // 
            this.Mmenu_ContinueSave.Location = new System.Drawing.Point(786, 486);
            this.Mmenu_ContinueSave.Name = "Mmenu_ContinueSave";
            this.Mmenu_ContinueSave.Size = new System.Drawing.Size(135, 66);
            this.Mmenu_ContinueSave.TabIndex = 2;
            this.Mmenu_ContinueSave.Text = "Continue Save";
            this.Mmenu_ContinueSave.UseVisualStyleBackColor = true;
            // 
            // Mmenu_Tutorial
            // 
            this.Mmenu_Tutorial.Location = new System.Drawing.Point(1297, 486);
            this.Mmenu_Tutorial.Name = "Mmenu_Tutorial";
            this.Mmenu_Tutorial.Size = new System.Drawing.Size(137, 66);
            this.Mmenu_Tutorial.TabIndex = 3;
            this.Mmenu_Tutorial.Text = "Tutorial";
            this.Mmenu_Tutorial.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1548, 665);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 681);
            this.Controls.Add(this.Mmenu_Tutorial);
            this.Controls.Add(this.Mmenu_ContinueSave);
            this.Controls.Add(this.Mmenu_NewGame);
            this.Controls.Add(this.MenuMainText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MenuMainText;
        private System.Windows.Forms.Button Mmenu_NewGame;
        private System.Windows.Forms.Button Mmenu_ContinueSave;
        private System.Windows.Forms.Button Mmenu_Tutorial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

