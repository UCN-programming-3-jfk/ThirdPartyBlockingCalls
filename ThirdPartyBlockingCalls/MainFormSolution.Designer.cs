
namespace ThirdPartyBlockingCalls
{
    partial class MainFormSolution
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
            btnGetCarsSingleThreaded = new System.Windows.Forms.Button();
            btnGetCarsMultiThreaded = new System.Windows.Forms.Button();
            btnGetCarsMultiThreadedWithLock = new System.Windows.Forms.Button();
            statusBar = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            lstCars = new System.Windows.Forms.ListBox();
            btnGetCarsInSeparateThread = new System.Windows.Forms.Button();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetCarsSingleThreaded
            // 
            btnGetCarsSingleThreaded.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnGetCarsSingleThreaded.Location = new System.Drawing.Point(444, 14);
            btnGetCarsSingleThreaded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGetCarsSingleThreaded.Name = "btnGetCarsSingleThreaded";
            btnGetCarsSingleThreaded.Size = new System.Drawing.Size(450, 52);
            btnGetCarsSingleThreaded.TabIndex = 1;
            btnGetCarsSingleThreaded.Text = "&Get cars single threaded";
            btnGetCarsSingleThreaded.UseVisualStyleBackColor = true;
            btnGetCarsSingleThreaded.Click += btnGetCars_Click;
            // 
            // btnGetCarsMultiThreaded
            // 
            btnGetCarsMultiThreaded.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnGetCarsMultiThreaded.Location = new System.Drawing.Point(447, 164);
            btnGetCarsMultiThreaded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGetCarsMultiThreaded.Name = "btnGetCarsMultiThreaded";
            btnGetCarsMultiThreaded.Size = new System.Drawing.Size(450, 52);
            btnGetCarsMultiThreaded.TabIndex = 2;
            btnGetCarsMultiThreaded.Text = "Get cars &multi threaded";
            btnGetCarsMultiThreaded.UseVisualStyleBackColor = true;
            btnGetCarsMultiThreaded.Click += btnGetCarsMultiThreaded_Click;
            // 
            // btnGetCarsMultiThreadedWithLock
            // 
            btnGetCarsMultiThreadedWithLock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnGetCarsMultiThreadedWithLock.Location = new System.Drawing.Point(444, 255);
            btnGetCarsMultiThreadedWithLock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGetCarsMultiThreadedWithLock.Name = "btnGetCarsMultiThreadedWithLock";
            btnGetCarsMultiThreadedWithLock.Size = new System.Drawing.Size(450, 52);
            btnGetCarsMultiThreadedWithLock.TabIndex = 3;
            btnGetCarsMultiThreadedWithLock.Text = "Get cars multi threaded w. &lock";
            btnGetCarsMultiThreadedWithLock.UseVisualStyleBackColor = true;
            btnGetCarsMultiThreadedWithLock.Click += btnGetCarsMultiThreadedWithLock_Click;
            // 
            // statusBar
            // 
            statusBar.Font = new System.Drawing.Font("Segoe UI", 14F);
            statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
            statusBar.Location = new System.Drawing.Point(0, 617);
            statusBar.Name = "statusBar";
            statusBar.Size = new System.Drawing.Size(910, 22);
            statusBar.TabIndex = 4;
            statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lstCars
            // 
            lstCars.Dock = System.Windows.Forms.DockStyle.Left;
            lstCars.FormattingEnabled = true;
            lstCars.IntegralHeight = false;
            lstCars.ItemHeight = 25;
            lstCars.Location = new System.Drawing.Point(0, 0);
            lstCars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstCars.Name = "lstCars";
            lstCars.Size = new System.Drawing.Size(436, 617);
            lstCars.TabIndex = 5;
            // 
            // btnGetCarsInSeparateThread
            // 
            btnGetCarsInSeparateThread.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnGetCarsInSeparateThread.Location = new System.Drawing.Point(447, 87);
            btnGetCarsInSeparateThread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGetCarsInSeparateThread.Name = "btnGetCarsInSeparateThread";
            btnGetCarsInSeparateThread.Size = new System.Drawing.Size(450, 52);
            btnGetCarsInSeparateThread.TabIndex = 2;
            btnGetCarsInSeparateThread.Text = "Get cars in &separate thread";
            btnGetCarsInSeparateThread.UseVisualStyleBackColor = true;
            btnGetCarsInSeparateThread.Click += btnGetCarsInSeparateThread_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(910, 639);
            Controls.Add(lstCars);
            Controls.Add(statusBar);
            Controls.Add(btnGetCarsMultiThreadedWithLock);
            Controls.Add(btnGetCarsInSeparateThread);
            Controls.Add(btnGetCarsMultiThreaded);
            Controls.Add(btnGetCarsSingleThreaded);
            Font = new System.Drawing.Font("Segoe UI", 14F);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Threaded car services";
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnGetCarsSingleThreaded;
        private System.Windows.Forms.Button btnGetCarsMultiThreaded;
        private System.Windows.Forms.Button btnGetCarsMultiThreadedWithLock;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnGetCarsInSeparateThread;
    }
}

