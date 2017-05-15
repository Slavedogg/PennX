namespace AForgeCastingOrienation
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
            this.components = new System.ComponentModel.Container();
            this.pbCapture = new AForge.Controls.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vpSource = new AForge.Controls.VideoSourcePlayer();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.camera1Combo = new System.Windows.Forms.ComboBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbImgFilters = new System.Windows.Forms.GroupBox();
            this.cbBW = new System.Windows.Forms.CheckBox();
            this.cbSkeletonization = new System.Windows.Forms.CheckBox();
            this.cbSepia = new System.Windows.Forms.CheckBox();
            this.cbHSL = new System.Windows.Forms.CheckBox();
            this.cbInvert = new System.Windows.Forms.CheckBox();
            this.cbConservativeSmoothing = new System.Windows.Forms.CheckBox();
            this.cbFindShapes = new System.Windows.Forms.CheckBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.pbShapes = new AForge.Controls.PictureBox();
            this.gbEdgeFilters = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbSobelEdgeDetector = new System.Windows.Forms.RadioButton();
            this.rbHomogenityEdgeDetector = new System.Windows.Forms.RadioButton();
            this.rbDifferenceEdgeDetector = new System.Windows.Forms.RadioButton();
            this.rbCannyEdgeDetector = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.gbImgFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShapes)).BeginInit();
            this.gbEdgeFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCapture
            // 
            this.pbCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCapture.Image = null;
            this.pbCapture.Location = new System.Drawing.Point(12, 214);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(294, 294);
            this.pbCapture.TabIndex = 1;
            this.pbCapture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtered Image";
            // 
            // vpSource
            // 
            this.vpSource.Location = new System.Drawing.Point(368, 7);
            this.vpSource.Name = "vpSource";
            this.vpSource.Size = new System.Drawing.Size(157, 149);
            this.vpSource.TabIndex = 4;
            this.vpSource.Text = "Live Feed:";
            this.vpSource.VideoSource = null;
            this.vpSource.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.vpSource_NewFrame);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.camera1Combo);
            this.groupBox8.Controls.Add(this.btnActivate);
            this.groupBox8.Controls.Add(this.btnCancel);
            this.groupBox8.Location = new System.Drawing.Point(12, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(350, 71);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Video Source";
            // 
            // camera1Combo
            // 
            this.camera1Combo.FormattingEnabled = true;
            this.camera1Combo.Location = new System.Drawing.Point(20, 19);
            this.camera1Combo.Name = "camera1Combo";
            this.camera1Combo.Size = new System.Drawing.Size(318, 21);
            this.camera1Combo.TabIndex = 4;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(20, 45);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(119, 21);
            this.btnActivate.TabIndex = 5;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(219, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 21);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // gbImgFilters
            // 
            this.gbImgFilters.Controls.Add(this.cbBW);
            this.gbImgFilters.Controls.Add(this.cbSkeletonization);
            this.gbImgFilters.Controls.Add(this.cbSepia);
            this.gbImgFilters.Controls.Add(this.cbHSL);
            this.gbImgFilters.Controls.Add(this.cbInvert);
            this.gbImgFilters.Controls.Add(this.cbConservativeSmoothing);
            this.gbImgFilters.Enabled = false;
            this.gbImgFilters.Location = new System.Drawing.Point(12, 74);
            this.gbImgFilters.Name = "gbImgFilters";
            this.gbImgFilters.Size = new System.Drawing.Size(160, 124);
            this.gbImgFilters.TabIndex = 29;
            this.gbImgFilters.TabStop = false;
            this.gbImgFilters.Text = "Image Filters";
            // 
            // cbBW
            // 
            this.cbBW.AutoSize = true;
            this.cbBW.Location = new System.Drawing.Point(6, 83);
            this.cbBW.Name = "cbBW";
            this.cbBW.Size = new System.Drawing.Size(119, 17);
            this.cbBW.TabIndex = 6;
            this.cbBW.Text = "Black/White switch";
            this.cbBW.UseVisualStyleBackColor = true;
            this.cbBW.CheckedChanged += new System.EventHandler(this.cbBW_CheckedChanged);
            // 
            // cbSkeletonization
            // 
            this.cbSkeletonization.AutoSize = true;
            this.cbSkeletonization.Location = new System.Drawing.Point(6, 65);
            this.cbSkeletonization.Name = "cbSkeletonization";
            this.cbSkeletonization.Size = new System.Drawing.Size(98, 17);
            this.cbSkeletonization.TabIndex = 5;
            this.cbSkeletonization.Text = "Skeletonization";
            this.cbSkeletonization.UseVisualStyleBackColor = true;
            this.cbSkeletonization.CheckedChanged += new System.EventHandler(this.cbSkeletonization_CheckedChanged);
            // 
            // cbSepia
            // 
            this.cbSepia.AutoSize = true;
            this.cbSepia.Location = new System.Drawing.Point(6, 47);
            this.cbSepia.Name = "cbSepia";
            this.cbSepia.Size = new System.Drawing.Size(53, 17);
            this.cbSepia.TabIndex = 4;
            this.cbSepia.Text = "Sepia";
            this.cbSepia.UseVisualStyleBackColor = true;
            this.cbSepia.CheckedChanged += new System.EventHandler(this.cbSepia_CheckedChanged);
            // 
            // cbHSL
            // 
            this.cbHSL.AutoSize = true;
            this.cbHSL.Location = new System.Drawing.Point(6, 30);
            this.cbHSL.Name = "cbHSL";
            this.cbHSL.Size = new System.Drawing.Size(47, 17);
            this.cbHSL.TabIndex = 3;
            this.cbHSL.Text = "HSL";
            this.cbHSL.UseVisualStyleBackColor = true;
            this.cbHSL.CheckedChanged += new System.EventHandler(this.cbHSL_CheckedChanged);
            // 
            // cbInvert
            // 
            this.cbInvert.AutoSize = true;
            this.cbInvert.Location = new System.Drawing.Point(6, 14);
            this.cbInvert.Name = "cbInvert";
            this.cbInvert.Size = new System.Drawing.Size(53, 17);
            this.cbInvert.TabIndex = 2;
            this.cbInvert.Text = "Invert";
            this.cbInvert.UseVisualStyleBackColor = true;
            this.cbInvert.CheckedChanged += new System.EventHandler(this.cbInvert_CheckedChanged);
            // 
            // cbConservativeSmoothing
            // 
            this.cbConservativeSmoothing.AutoSize = true;
            this.cbConservativeSmoothing.Location = new System.Drawing.Point(6, 101);
            this.cbConservativeSmoothing.Name = "cbConservativeSmoothing";
            this.cbConservativeSmoothing.Size = new System.Drawing.Size(138, 17);
            this.cbConservativeSmoothing.TabIndex = 1;
            this.cbConservativeSmoothing.Text = "ConservativeSmoothing";
            this.cbConservativeSmoothing.UseVisualStyleBackColor = true;
            this.cbConservativeSmoothing.CheckedChanged += new System.EventHandler(this.cbConservativeSmoothing_CheckedChanged);
            // 
            // cbFindShapes
            // 
            this.cbFindShapes.AutoSize = true;
            this.cbFindShapes.Location = new System.Drawing.Point(449, 169);
            this.cbFindShapes.Name = "cbFindShapes";
            this.cbFindShapes.Size = new System.Drawing.Size(82, 17);
            this.cbFindShapes.TabIndex = 7;
            this.cbFindShapes.Text = "FindShapes";
            this.cbFindShapes.UseVisualStyleBackColor = true;
            this.cbFindShapes.CheckedChanged += new System.EventHandler(this.cbFindShapes_CheckedChanged);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(368, 168);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // pbShapes
            // 
            this.pbShapes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbShapes.Image = null;
            this.pbShapes.Location = new System.Drawing.Point(312, 214);
            this.pbShapes.Name = "pbShapes";
            this.pbShapes.Size = new System.Drawing.Size(596, 479);
            this.pbShapes.TabIndex = 41;
            this.pbShapes.TabStop = false;
            // 
            // gbEdgeFilters
            // 
            this.gbEdgeFilters.Controls.Add(this.rbNone);
            this.gbEdgeFilters.Controls.Add(this.rbSobelEdgeDetector);
            this.gbEdgeFilters.Controls.Add(this.rbHomogenityEdgeDetector);
            this.gbEdgeFilters.Controls.Add(this.rbDifferenceEdgeDetector);
            this.gbEdgeFilters.Controls.Add(this.rbCannyEdgeDetector);
            this.gbEdgeFilters.Enabled = false;
            this.gbEdgeFilters.Location = new System.Drawing.Point(178, 74);
            this.gbEdgeFilters.Name = "gbEdgeFilters";
            this.gbEdgeFilters.Size = new System.Drawing.Size(184, 123);
            this.gbEdgeFilters.TabIndex = 42;
            this.gbEdgeFilters.TabStop = false;
            this.gbEdgeFilters.Text = "Edge Filters";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(25, 15);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 4;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rbSobelEdgeDetector
            // 
            this.rbSobelEdgeDetector.AutoSize = true;
            this.rbSobelEdgeDetector.Location = new System.Drawing.Point(25, 94);
            this.rbSobelEdgeDetector.Name = "rbSobelEdgeDetector";
            this.rbSobelEdgeDetector.Size = new System.Drawing.Size(118, 17);
            this.rbSobelEdgeDetector.TabIndex = 3;
            this.rbSobelEdgeDetector.Text = "SobelEdgeDetector";
            this.rbSobelEdgeDetector.UseVisualStyleBackColor = true;
            this.rbSobelEdgeDetector.CheckedChanged += new System.EventHandler(this.rbSobelEdgeDetector_CheckedChanged);
            // 
            // rbHomogenityEdgeDetector
            // 
            this.rbHomogenityEdgeDetector.AutoSize = true;
            this.rbHomogenityEdgeDetector.Location = new System.Drawing.Point(25, 73);
            this.rbHomogenityEdgeDetector.Name = "rbHomogenityEdgeDetector";
            this.rbHomogenityEdgeDetector.Size = new System.Drawing.Size(147, 17);
            this.rbHomogenityEdgeDetector.TabIndex = 2;
            this.rbHomogenityEdgeDetector.Text = "HomogenityEdgeDetector";
            this.rbHomogenityEdgeDetector.UseVisualStyleBackColor = true;
            this.rbHomogenityEdgeDetector.CheckedChanged += new System.EventHandler(this.rbHomogenityEdgeDetector_CheckedChanged);
            // 
            // rbDifferenceEdgeDetector
            // 
            this.rbDifferenceEdgeDetector.AutoSize = true;
            this.rbDifferenceEdgeDetector.Location = new System.Drawing.Point(25, 54);
            this.rbDifferenceEdgeDetector.Name = "rbDifferenceEdgeDetector";
            this.rbDifferenceEdgeDetector.Size = new System.Drawing.Size(140, 17);
            this.rbDifferenceEdgeDetector.TabIndex = 1;
            this.rbDifferenceEdgeDetector.Text = "DifferenceEdgeDetector";
            this.rbDifferenceEdgeDetector.UseVisualStyleBackColor = true;
            this.rbDifferenceEdgeDetector.CheckedChanged += new System.EventHandler(this.rbDifferenceEdgeDetector_CheckedChanged);
            // 
            // rbCannyEdgeDetector
            // 
            this.rbCannyEdgeDetector.AutoSize = true;
            this.rbCannyEdgeDetector.Location = new System.Drawing.Point(25, 34);
            this.rbCannyEdgeDetector.Name = "rbCannyEdgeDetector";
            this.rbCannyEdgeDetector.Size = new System.Drawing.Size(121, 17);
            this.rbCannyEdgeDetector.TabIndex = 0;
            this.rbCannyEdgeDetector.Text = "CannyEdgeDetector";
            this.rbCannyEdgeDetector.UseVisualStyleBackColor = true;
            this.rbCannyEdgeDetector.CheckedChanged += new System.EventHandler(this.rbCannyEdgeDetector_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Live Feed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 855);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbEdgeFilters);
            this.Controls.Add(this.pbShapes);
            this.Controls.Add(this.cbFindShapes);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.gbImgFilters);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.vpSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.gbImgFilters.ResumeLayout(false);
            this.gbImgFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShapes)).EndInit();
            this.gbEdgeFilters.ResumeLayout(false);
            this.gbEdgeFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.PictureBox pbCapture;
        private System.Windows.Forms.Label label2;
        private AForge.Controls.VideoSourcePlayer vpSource;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox camera1Combo;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox gbImgFilters;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.CheckBox cbConservativeSmoothing;
        private System.Windows.Forms.CheckBox cbInvert;
        private System.Windows.Forms.CheckBox cbHSL;
        private System.Windows.Forms.CheckBox cbSepia;
        private System.Windows.Forms.CheckBox cbSkeletonization;
        private System.Windows.Forms.CheckBox cbBW;
        private System.Windows.Forms.CheckBox cbFindShapes;
        private AForge.Controls.PictureBox pbShapes;
        private System.Windows.Forms.GroupBox gbEdgeFilters;
        private System.Windows.Forms.RadioButton rbSobelEdgeDetector;
        private System.Windows.Forms.RadioButton rbHomogenityEdgeDetector;
        private System.Windows.Forms.RadioButton rbDifferenceEdgeDetector;
        private System.Windows.Forms.RadioButton rbCannyEdgeDetector;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

