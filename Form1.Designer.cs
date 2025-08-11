namespace Async
{
    partial class frmAsync
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciar = new Button();
            lbResultados = new ListBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(517, 222);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(256, 41);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Tarefas";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_ClickAsync;
            // 
            // lbResultados
            // 
            lbResultados.FormattingEnabled = true;
            lbResultados.Location = new Point(12, 12);
            lbResultados.Name = "lbResultados";
            lbResultados.Size = new Size(761, 204);
            lbResultados.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 219);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status:";
            // 
            // frmAsync
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 279);
            Controls.Add(lblStatus);
            Controls.Add(lbResultados);
            Controls.Add(btnIniciar);
            Name = "frmAsync";
            Text = "Programação Assíncrona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private ListBox lbResultados;
        private Label lblStatus;
    }
}
