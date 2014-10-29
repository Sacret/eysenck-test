namespace METR4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pGraph = new System.Windows.Forms.Panel();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // pGraph
            // 
            this.pGraph.BackColor = System.Drawing.Color.White;
            this.pGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGraph.Location = new System.Drawing.Point(0, 0);
            this.pGraph.Name = "pGraph";
            this.pGraph.Size = new System.Drawing.Size(386, 190);
            this.pGraph.TabIndex = 0;
            this.pGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pGraph_Paint);
            // 
            // rtbDesc
            // 
            this.rtbDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbDesc.Location = new System.Drawing.Point(0, 196);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(386, 79);
            this.rtbDesc.TabIndex = 1;
            this.rtbDesc.Text = "";
            // 
            // ttHelp
            // 
            this.ttHelp.IsBalloon = true;
            this.ttHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttHelp.ToolTipTitle = "Подсказка";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 275);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.pGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "~Результат~";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGraph;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.ToolTip ttHelp;
    }
}