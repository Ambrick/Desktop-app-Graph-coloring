namespace Graph_coloring
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
            this.ifSlowModeCheckBox = new System.Windows.Forms.CheckBox();
            this.openGraphFromFileButton = new System.Windows.Forms.Button();
            this.saveGraphButton = new System.Windows.Forms.Button();
            this.addVertexButton = new System.Windows.Forms.Button();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.colorGraphButton = new System.Windows.Forms.Button();
            this.createGraphButton = new System.Windows.Forms.Button();
            this.deleteEdgeButton = new System.Windows.Forms.Button();
            this.deleteVertexButon = new System.Windows.Forms.Button();
            this.MoveVertexButton = new System.Windows.Forms.Button();
            this.editorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ifSlowModeCheckBox
            // 
            this.ifSlowModeCheckBox.AutoSize = true;
            this.ifSlowModeCheckBox.Location = new System.Drawing.Point(669, 462);
            this.ifSlowModeCheckBox.Name = "ifSlowModeCheckBox";
            this.ifSlowModeCheckBox.Size = new System.Drawing.Size(128, 17);
            this.ifSlowModeCheckBox.TabIndex = 1;
            this.ifSlowModeCheckBox.Text = "Режим \"Обучения\"";
            this.ifSlowModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // openGraphFromFileButton
            // 
            this.openGraphFromFileButton.Location = new System.Drawing.Point(669, 13);
            this.openGraphFromFileButton.Name = "openGraphFromFileButton";
            this.openGraphFromFileButton.Size = new System.Drawing.Size(171, 25);
            this.openGraphFromFileButton.TabIndex = 2;
            this.openGraphFromFileButton.Text = "Открыть граф";
            this.openGraphFromFileButton.UseVisualStyleBackColor = true;
            this.openGraphFromFileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Open_MouseClick);
            // 
            // saveGraphButton
            // 
            this.saveGraphButton.Location = new System.Drawing.Point(669, 75);
            this.saveGraphButton.Name = "saveGraphButton";
            this.saveGraphButton.Size = new System.Drawing.Size(171, 25);
            this.saveGraphButton.TabIndex = 3;
            this.saveGraphButton.Text = "Сохранить граф";
            this.saveGraphButton.UseVisualStyleBackColor = true;
            this.saveGraphButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Save_MouseClick);
            // 
            // addVertexButton
            // 
            this.addVertexButton.Location = new System.Drawing.Point(669, 106);
            this.addVertexButton.Name = "addVertexButton";
            this.addVertexButton.Size = new System.Drawing.Size(171, 25);
            this.addVertexButton.TabIndex = 4;
            this.addVertexButton.Text = "Добавить вершину";
            this.addVertexButton.UseVisualStyleBackColor = true;
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Location = new System.Drawing.Point(669, 137);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(171, 25);
            this.addEdgeButton.TabIndex = 5;
            this.addEdgeButton.Text = "Добавить ребро";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            // 
            // colorGraphButton
            // 
            this.colorGraphButton.Location = new System.Drawing.Point(669, 485);
            this.colorGraphButton.Name = "colorGraphButton";
            this.colorGraphButton.Size = new System.Drawing.Size(171, 25);
            this.colorGraphButton.TabIndex = 6;
            this.colorGraphButton.Text = "Раскраска";
            this.colorGraphButton.UseVisualStyleBackColor = true;
            this.colorGraphButton.Leave += new System.EventHandler(this.colorGraphButton_Leave);
            this.colorGraphButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_graph_MouseClick);
            // 
            // createGraphButton
            // 
            this.createGraphButton.Location = new System.Drawing.Point(669, 44);
            this.createGraphButton.Name = "createGraphButton";
            this.createGraphButton.Size = new System.Drawing.Size(171, 25);
            this.createGraphButton.TabIndex = 7;
            this.createGraphButton.Text = "Создать / Очистить";
            this.createGraphButton.UseVisualStyleBackColor = true;
            this.createGraphButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Create_MouseClick);
            // 
            // deleteEdgeButton
            // 
            this.deleteEdgeButton.Location = new System.Drawing.Point(669, 199);
            this.deleteEdgeButton.Name = "deleteEdgeButton";
            this.deleteEdgeButton.Size = new System.Drawing.Size(171, 25);
            this.deleteEdgeButton.TabIndex = 8;
            this.deleteEdgeButton.Text = "Удалить ребро";
            this.deleteEdgeButton.UseVisualStyleBackColor = true;
            // 
            // deleteVertexButon
            // 
            this.deleteVertexButon.Location = new System.Drawing.Point(669, 168);
            this.deleteVertexButon.Name = "deleteVertexButon";
            this.deleteVertexButon.Size = new System.Drawing.Size(171, 25);
            this.deleteVertexButon.TabIndex = 9;
            this.deleteVertexButon.Text = "Удалить вершину";
            this.deleteVertexButon.UseVisualStyleBackColor = true;
            // 
            // MoveVertexButton
            // 
            this.MoveVertexButton.Location = new System.Drawing.Point(669, 230);
            this.MoveVertexButton.Name = "MoveVertexButton";
            this.MoveVertexButton.Size = new System.Drawing.Size(171, 25);
            this.MoveVertexButton.TabIndex = 10;
            this.MoveVertexButton.Text = "Переместить вершину";
            this.MoveVertexButton.UseVisualStyleBackColor = true;
            // 
            // editorPictureBox
            // 
            this.editorPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editorPictureBox.Location = new System.Drawing.Point(13, 13);
            this.editorPictureBox.Name = "editorPictureBox";
            this.editorPictureBox.Size = new System.Drawing.Size(650, 497);
            this.editorPictureBox.TabIndex = 11;
            this.editorPictureBox.TabStop = false;
            this.editorPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.editorPictureBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 522);
            this.Controls.Add(this.editorPictureBox);
            this.Controls.Add(this.MoveVertexButton);
            this.Controls.Add(this.deleteVertexButon);
            this.Controls.Add(this.deleteEdgeButton);
            this.Controls.Add(this.createGraphButton);
            this.Controls.Add(this.colorGraphButton);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.addVertexButton);
            this.Controls.Add(this.saveGraphButton);
            this.Controls.Add(this.openGraphFromFileButton);
            this.Controls.Add(this.ifSlowModeCheckBox);
            this.Name = "Form1";
            this.Text = "Desktop app: Graph coloring";
            ((System.ComponentModel.ISupportInitialize)(this.editorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ifSlowModeCheckBox;
        private System.Windows.Forms.Button openGraphFromFileButton;
        private System.Windows.Forms.Button saveGraphButton;
        private System.Windows.Forms.Button addVertexButton;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.Button colorGraphButton;
        private System.Windows.Forms.Button createGraphButton;
        private System.Windows.Forms.Button deleteEdgeButton;
        private System.Windows.Forms.Button deleteVertexButon;
        private System.Windows.Forms.Button MoveVertexButton;
        private System.Windows.Forms.PictureBox editorPictureBox;
    }
}

