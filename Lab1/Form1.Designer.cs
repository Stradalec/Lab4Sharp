﻿namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dichotomyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GoldenRatioButton = new System.Windows.Forms.Button();
            this.NewtonButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dichotomyButton
            // 
            this.dichotomyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dichotomyButton.AutoSize = true;
            this.dichotomyButton.Location = new System.Drawing.Point(29, 3);
            this.dichotomyButton.Name = "dichotomyButton";
            this.dichotomyButton.Size = new System.Drawing.Size(109, 74);
            this.dichotomyButton.TabIndex = 0;
            this.dichotomyButton.Text = "Метод Дихотомии";
            this.dichotomyButton.UseVisualStyleBackColor = true;
            this.dichotomyButton.Click += new System.EventHandler(this.dichotomyButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.NewtonButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dichotomyButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GoldenRatioButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 390);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GoldenRatioButton
            // 
            this.GoldenRatioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GoldenRatioButton.AutoSize = true;
            this.GoldenRatioButton.Location = new System.Drawing.Point(178, 3);
            this.GoldenRatioButton.Name = "GoldenRatioButton";
            this.GoldenRatioButton.Size = new System.Drawing.Size(144, 74);
            this.GoldenRatioButton.TabIndex = 1;
            this.GoldenRatioButton.Text = "Метод Золотого Сечения";
            this.GoldenRatioButton.UseVisualStyleBackColor = true;
            this.GoldenRatioButton.Click += new System.EventHandler(this.GoldenRatioButton_Click);
            // 
            // NewtonButton
            // 
            this.NewtonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NewtonButton.AutoSize = true;
            this.NewtonButton.Location = new System.Drawing.Point(29, 83);
            this.NewtonButton.Name = "NewtonButton";
            this.NewtonButton.Size = new System.Drawing.Size(109, 64);
            this.NewtonButton.TabIndex = 2;
            this.NewtonButton.Text = "Метод Ньютона";
            this.NewtonButton.UseVisualStyleBackColor = true;
            this.NewtonButton.Click += new System.EventHandler(this.NewtonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Приложение";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dichotomyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GoldenRatioButton;
        private System.Windows.Forms.Button NewtonButton;
    }
}

