namespace PapyCupOverlay
{
    partial class ControlForm
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
         this.mShowHideButton = new System.Windows.Forms.Button();
         this.mTopMostBox = new System.Windows.Forms.CheckBox();
         this.mPreviousButton = new System.Windows.Forms.Button();
         this.mQuestionLabel = new System.Windows.Forms.Label();
         this.mNextButton = new System.Windows.Forms.Button();
         this.mTable = new System.Windows.Forms.TableLayoutPanel();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.mScore0Box = new System.Windows.Forms.TextBox();
         this.mScore1Box = new System.Windows.Forms.TextBox();
         this.mScore2Box = new System.Windows.Forms.TextBox();
         this.mScore3Box = new System.Windows.Forms.TextBox();
         this.mPreviousSlide = new System.Windows.Forms.Button();
         this.mNextSlide = new System.Windows.Forms.Button();
         this.mTable.SuspendLayout();
         this.SuspendLayout();
         // 
         // mShowHideButton
         // 
         this.mShowHideButton.Location = new System.Drawing.Point(12, 12);
         this.mShowHideButton.Name = "mShowHideButton";
         this.mShowHideButton.Size = new System.Drawing.Size(159, 23);
         this.mShowHideButton.TabIndex = 0;
         this.mShowHideButton.Text = "Show / Hide scores";
         this.mShowHideButton.UseVisualStyleBackColor = true;
         this.mShowHideButton.Click += new System.EventHandler(this.ShowHideButtonClick);
         // 
         // mTopMostBox
         // 
         this.mTopMostBox.Appearance = System.Windows.Forms.Appearance.Button;
         this.mTopMostBox.Location = new System.Drawing.Point(177, 12);
         this.mTopMostBox.Name = "mTopMostBox";
         this.mTopMostBox.Size = new System.Drawing.Size(159, 23);
         this.mTopMostBox.TabIndex = 1;
         this.mTopMostBox.Text = "Top most";
         this.mTopMostBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.mTopMostBox.UseVisualStyleBackColor = true;
         this.mTopMostBox.CheckedChanged += new System.EventHandler(this.TopMostBoxCheckedChanged);
         // 
         // mPreviousButton
         // 
         this.mPreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.mPreviousButton.Location = new System.Drawing.Point(12, 61);
         this.mPreviousButton.Name = "mPreviousButton";
         this.mPreviousButton.Size = new System.Drawing.Size(72, 361);
         this.mPreviousButton.TabIndex = 2;
         this.mPreviousButton.Text = "<<";
         this.mPreviousButton.UseVisualStyleBackColor = true;
         this.mPreviousButton.Click += new System.EventHandler(this.mPreviousButton_Click);
         // 
         // mQuestionLabel
         // 
         this.mQuestionLabel.AutoSize = true;
         this.mQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mQuestionLabel.Location = new System.Drawing.Point(12, 38);
         this.mQuestionLabel.Name = "mQuestionLabel";
         this.mQuestionLabel.Size = new System.Drawing.Size(50, 20);
         this.mQuestionLabel.TabIndex = 3;
         this.mQuestionLabel.Text = "label1";
         // 
         // mNextButton
         // 
         this.mNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.mNextButton.Location = new System.Drawing.Point(575, 61);
         this.mNextButton.Name = "mNextButton";
         this.mNextButton.Size = new System.Drawing.Size(72, 361);
         this.mNextButton.TabIndex = 4;
         this.mNextButton.Text = ">>";
         this.mNextButton.UseVisualStyleBackColor = true;
         this.mNextButton.Click += new System.EventHandler(this.mNextButton_Click);
         // 
         // mTable
         // 
         this.mTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.mTable.ColumnCount = 5;
         this.mTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
         this.mTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.mTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.mTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.mTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.mTable.Controls.Add(this.label5, 4, 0);
         this.mTable.Controls.Add(this.label4, 3, 0);
         this.mTable.Controls.Add(this.label3, 2, 0);
         this.mTable.Controls.Add(this.label1, 1, 0);
         this.mTable.Controls.Add(this.mScore0Box, 1, 1);
         this.mTable.Controls.Add(this.mScore1Box, 2, 1);
         this.mTable.Controls.Add(this.mScore2Box, 3, 1);
         this.mTable.Controls.Add(this.mScore3Box, 4, 1);
         this.mTable.Location = new System.Drawing.Point(90, 61);
         this.mTable.Name = "mTable";
         this.mTable.RowCount = 18;
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.mTable.Size = new System.Drawing.Size(479, 361);
         this.mTable.TabIndex = 5;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.LightGreen;
         this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label5.Location = new System.Drawing.Point(387, 0);
         this.label5.Margin = new System.Windows.Forms.Padding(0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(92, 18);
         this.label5.TabIndex = 4;
         this.label5.Text = "Rennes";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
         this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label4.Location = new System.Drawing.Point(298, 0);
         this.label4.Margin = new System.Windows.Forms.Padding(0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(89, 18);
         this.label4.TabIndex = 3;
         this.label4.Text = "Parasols";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
         this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label3.Location = new System.Drawing.Point(209, 0);
         this.label3.Margin = new System.Windows.Forms.Padding(0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(89, 18);
         this.label3.TabIndex = 2;
         this.label3.Text = "Bon. neige";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Salmon;
         this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label1.Location = new System.Drawing.Point(120, 0);
         this.label1.Margin = new System.Windows.Forms.Padding(0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(89, 18);
         this.label1.TabIndex = 0;
         this.label1.Text = "Rois mages";
         // 
         // mScore0Box
         // 
         this.mScore0Box.Location = new System.Drawing.Point(123, 21);
         this.mScore0Box.Name = "mScore0Box";
         this.mScore0Box.Size = new System.Drawing.Size(59, 20);
         this.mScore0Box.TabIndex = 5;
         this.mScore0Box.Text = "0";
         this.mScore0Box.TextChanged += new System.EventHandler(this.mScore0Box_TextChanged);
         // 
         // mScore1Box
         // 
         this.mScore1Box.Location = new System.Drawing.Point(212, 21);
         this.mScore1Box.Name = "mScore1Box";
         this.mScore1Box.Size = new System.Drawing.Size(59, 20);
         this.mScore1Box.TabIndex = 6;
         this.mScore1Box.Text = "0";
         this.mScore1Box.TextChanged += new System.EventHandler(this.mScore1Box_TextChanged);
         // 
         // mScore2Box
         // 
         this.mScore2Box.Location = new System.Drawing.Point(301, 21);
         this.mScore2Box.Name = "mScore2Box";
         this.mScore2Box.Size = new System.Drawing.Size(59, 20);
         this.mScore2Box.TabIndex = 7;
         this.mScore2Box.Text = "0";
         this.mScore2Box.TextChanged += new System.EventHandler(this.mScore2Box_TextChanged);
         // 
         // mScore3Box
         // 
         this.mScore3Box.Location = new System.Drawing.Point(390, 21);
         this.mScore3Box.Name = "mScore3Box";
         this.mScore3Box.Size = new System.Drawing.Size(60, 20);
         this.mScore3Box.TabIndex = 8;
         this.mScore3Box.Tag = "";
         this.mScore3Box.Text = "0";
         this.mScore3Box.TextChanged += new System.EventHandler(this.mScore3Box_TextChanged);
         // 
         // mPreviousSlide
         // 
         this.mPreviousSlide.Location = new System.Drawing.Point(455, 12);
         this.mPreviousSlide.Name = "mPreviousSlide";
         this.mPreviousSlide.Size = new System.Drawing.Size(100, 23);
         this.mPreviousSlide.TabIndex = 6;
         this.mPreviousSlide.Text = "Previous slide";
         this.mPreviousSlide.UseVisualStyleBackColor = true;
         this.mPreviousSlide.Click += new System.EventHandler(this.PreviousSlideClick);
         // 
         // mNextSlide
         // 
         this.mNextSlide.Location = new System.Drawing.Point(561, 12);
         this.mNextSlide.Name = "mNextSlide";
         this.mNextSlide.Size = new System.Drawing.Size(75, 23);
         this.mNextSlide.TabIndex = 7;
         this.mNextSlide.Text = "Next slide";
         this.mNextSlide.UseVisualStyleBackColor = true;
         this.mNextSlide.Click += new System.EventHandler(this.NextSlideClick);
         // 
         // ControlForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(661, 434);
         this.Controls.Add(this.mNextSlide);
         this.Controls.Add(this.mPreviousSlide);
         this.Controls.Add(this.mTable);
         this.Controls.Add(this.mNextButton);
         this.Controls.Add(this.mQuestionLabel);
         this.Controls.Add(this.mPreviousButton);
         this.Controls.Add(this.mTopMostBox);
         this.Controls.Add(this.mShowHideButton);
         this.Name = "ControlForm";
         this.Text = "PapyCup 2014";
         this.LocationChanged += new System.EventHandler(this.ControlFormLocationChanged);
         this.mTable.ResumeLayout(false);
         this.mTable.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mShowHideButton;
        private System.Windows.Forms.CheckBox mTopMostBox;
        private System.Windows.Forms.Button mPreviousButton;
        private System.Windows.Forms.Label mQuestionLabel;
        private System.Windows.Forms.Button mNextButton;
        private System.Windows.Forms.TableLayoutPanel mTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mScore0Box;
        private System.Windows.Forms.TextBox mScore1Box;
        private System.Windows.Forms.TextBox mScore2Box;
        private System.Windows.Forms.TextBox mScore3Box;
        private System.Windows.Forms.Button mPreviousSlide;
        private System.Windows.Forms.Button mNextSlide;
    }
}

