namespace VegaJuego
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            pictureLogoVG = new PictureBox();
            pictureLogoZelda = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            checkSonido = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogoVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogoZelda).BeginInit();
            SuspendLayout();
            // 
            // pictureLogoVG
            // 
            pictureLogoVG.BackColor = Color.Transparent;
            pictureLogoVG.BackgroundImage = Properties.Resources.LogoBueno;
            pictureLogoVG.BackgroundImageLayout = ImageLayout.Center;
            pictureLogoVG.Location = new Point(12, 12);
            pictureLogoVG.Name = "pictureLogoVG";
            pictureLogoVG.Size = new Size(214, 209);
            pictureLogoVG.TabIndex = 1;
            pictureLogoVG.TabStop = false;
            // 
            // pictureLogoZelda
            // 
            pictureLogoZelda.BackColor = Color.Transparent;
            pictureLogoZelda.BackgroundImage = Properties.Resources.ZeldaLogo;
            pictureLogoZelda.BackgroundImageLayout = ImageLayout.Center;
            pictureLogoZelda.Location = new Point(506, 45);
            pictureLogoZelda.Name = "pictureLogoZelda";
            pictureLogoZelda.Size = new Size(209, 91);
            pictureLogoZelda.TabIndex = 2;
            pictureLogoZelda.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(442, 19);
            label1.Name = "label1";
            label1.Size = new Size(346, 23);
            label1.TabIndex = 3;
            label1.Text = "Creado por Rony William Luzuriaga Acaro";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gold;
            button1.Image = Properties.Resources.Boton;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(285, 336);
            button1.Name = "button1";
            button1.Size = new Size(264, 51);
            button1.TabIndex = 4;
            button1.Text = "Comienza la aventura";
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // checkSonido
            // 
            checkSonido.AutoSize = true;
            checkSonido.BackColor = Color.Transparent;
            checkSonido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkSonido.Location = new Point(506, 152);
            checkSonido.Name = "checkSonido";
            checkSonido.Size = new Size(133, 24);
            checkSonido.TabIndex = 5;
            checkSonido.Text = "Sonido On/Off";
            checkSonido.UseVisualStyleBackColor = false;
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(checkSonido);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureLogoZelda);
            Controls.Add(pictureLogoVG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosed += PantallaInicio_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureLogoVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogoZelda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogoVG;
        private PictureBox pictureLogoZelda;
        private Label label1;
        private Button button1;
        private CheckBox checkSonido;
    }
}