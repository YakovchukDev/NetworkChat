
namespace Client
{
    partial class Form1
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
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RemotePortTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LocalPortTB = new System.Windows.Forms.TextBox();
            this.Conect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameTB
            // 
            this.UserNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameTB.Location = new System.Drawing.Point(55, 99);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(150, 24);
            this.UserNameTB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter user name";
            // 
            // RemotePortTB
            // 
            this.RemotePortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemotePortTB.Location = new System.Drawing.Point(109, 34);
            this.RemotePortTB.Name = "RemotePortTB";
            this.RemotePortTB.Size = new System.Drawing.Size(140, 24);
            this.RemotePortTB.TabIndex = 11;
            this.RemotePortTB.Text = "23456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Remote port";
            // 
            // LocalPortTB
            // 
            this.LocalPortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocalPortTB.Location = new System.Drawing.Point(109, 6);
            this.LocalPortTB.Name = "LocalPortTB";
            this.LocalPortTB.Size = new System.Drawing.Size(140, 24);
            this.LocalPortTB.TabIndex = 9;
            // 
            // Conect
            // 
            this.Conect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conect.Location = new System.Drawing.Point(55, 127);
            this.Conect.Name = "Conect";
            this.Conect.Size = new System.Drawing.Size(150, 32);
            this.Conect.TabIndex = 8;
            this.Conect.Text = "Conect";
            this.Conect.UseVisualStyleBackColor = true;
            this.Conect.Click += new System.EventHandler(this.Conect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Local port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 171);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemotePortTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocalPortTB);
            this.Controls.Add(this.Conect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RemotePortTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LocalPortTB;
        private System.Windows.Forms.Button Conect;
        private System.Windows.Forms.Label label1;
    }
}

