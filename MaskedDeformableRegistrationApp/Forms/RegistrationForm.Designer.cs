﻿namespace MaskedDeformableRegistrationApp.Forms
{
    partial class RegistrationForm
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
            this.buttonSegmentationInnerstructures = new System.Windows.Forms.Button();
            this.buttonSegmentationParams = new System.Windows.Forms.Button();
            this.backgroundWorkerRigid = new System.ComponentModel.BackgroundWorker();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBoxMaskingGeneral = new System.Windows.Forms.GroupBox();
            this.buttonLoadMasks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPreDefMasks = new System.Windows.Forms.RadioButton();
            this.radioButtonInnerStructures = new System.Windows.Forms.RadioButton();
            this.radioButtonWholeTissue = new System.Windows.Forms.RadioButton();
            this.radioButtonFixedAndMovingMask = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyMovingMask = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyFixedMask = new System.Windows.Forms.RadioButton();
            this.radioButtonNoMask = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRegOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonUsePrevInStack = new System.Windows.Forms.RadioButton();
            this.radioButtonMiddleStack = new System.Windows.Forms.RadioButton();
            this.radioButtonLastInStack = new System.Windows.Forms.RadioButton();
            this.radioButtonFirstFromStack = new System.Windows.Forms.RadioButton();
            this.backgroundWorkerNonRigid = new System.ComponentModel.BackgroundWorker();
            this.openFileDialogTransformParam = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorkerSequential = new System.ComponentModel.BackgroundWorker();
            this.openFileDialogParamFile = new System.Windows.Forms.OpenFileDialog();
            this.tabPageSequentialReg = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.progressBarRegSequential = new System.Windows.Forms.ProgressBar();
            this.textBoxRegSequential = new System.Windows.Forms.TextBox();
            this.buttonCancelRegSequential = new System.Windows.Forms.Button();
            this.buttonStartRegSequential = new System.Windows.Forms.Button();
            this.buttonEvaluateRegSequential = new System.Windows.Forms.Button();
            this.labelParamFiles = new System.Windows.Forms.Label();
            this.buttonAddParamFile = new System.Windows.Forms.Button();
            this.buttonShowFile = new System.Windows.Forms.Button();
            this.buttonRemoveParamFile = new System.Windows.Forms.Button();
            this.treeViewParamFiles = new System.Windows.Forms.TreeView();
            this.tabPageTransform = new System.Windows.Forms.TabPage();
            this.textBoxTransformParams = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChooseParamFiles = new System.Windows.Forms.Button();
            this.groupBoxHowToCompose = new System.Windows.Forms.GroupBox();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonCompose = new System.Windows.Forms.RadioButton();
            this.groupBoxInterpolation = new System.Windows.Forms.GroupBox();
            this.radioButtonLinear = new System.Windows.Forms.RadioButton();
            this.radioButtonNN = new System.Windows.Forms.RadioButton();
            this.radioButtonBSpline = new System.Windows.Forms.RadioButton();
            this.comboBoxInterpolationOrder = new System.Windows.Forms.ComboBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDefaultPixelValue = new System.Windows.Forms.NumericUpDown();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.tabPageNonRigid = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.progressBarNonRigid = new System.Windows.Forms.ProgressBar();
            this.textBoxConsoleNonRigid = new System.Windows.Forms.TextBox();
            this.buttonCancelNonRigidReg = new System.Windows.Forms.Button();
            this.buttonStartNonRigidRegistration = new System.Windows.Forms.Button();
            this.buttonEvaluateNonRigidReg = new System.Windows.Forms.Button();
            this.groupBoxTransformationNonRigid = new System.Windows.Forms.GroupBox();
            this.radioButtonAdvancedBspline = new System.Windows.Forms.RadioButton();
            this.radioButtonBsplineDiffusion = new System.Windows.Forms.RadioButton();
            this.radioButtonKernelSpline = new System.Windows.Forms.RadioButton();
            this.radioButtonSplineRecursive = new System.Windows.Forms.RadioButton();
            this.groupBoxPenalty = new System.Windows.Forms.GroupBox();
            this.radioButtonNoPenalties = new System.Windows.Forms.RadioButton();
            this.radioButtonTransformRigidity = new System.Windows.Forms.RadioButton();
            this.radioButtonBendEnergy = new System.Windows.Forms.RadioButton();
            this.radioButtonDistancePreserving = new System.Windows.Forms.RadioButton();
            this.buttonEditParamsNonRigid = new System.Windows.Forms.Button();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.checkBoxJaccobian = new System.Windows.Forms.CheckBox();
            this.checkBoxUseCoefficientmap = new System.Windows.Forms.CheckBox();
            this.tabPageRigid = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.progressBarRigid = new System.Windows.Forms.ProgressBar();
            this.textBoxConsoleRigid = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonStartRegistration = new System.Windows.Forms.Button();
            this.buttonEvaluation = new System.Windows.Forms.Button();
            this.groupBoxTransformationRigid = new System.Windows.Forms.GroupBox();
            this.radioButtonTranslation = new System.Windows.Forms.RadioButton();
            this.radioButtonSimilarity = new System.Windows.Forms.RadioButton();
            this.radioButtonRigid = new System.Windows.Forms.RadioButton();
            this.radioButtonAffine = new System.Windows.Forms.RadioButton();
            this.groupBoxMaskRigid = new System.Windows.Forms.GroupBox();
            this.radioButtonMaskWhole = new System.Windows.Forms.RadioButton();
            this.radioButtonMaskInner = new System.Windows.Forms.RadioButton();
            this.radioButtonComponent = new System.Windows.Forms.RadioButton();
            this.radioButtonRigidNoMasking = new System.Windows.Forms.RadioButton();
            this.buttonEditParameters = new System.Windows.Forms.Button();
            this.tabControlRegistration = new System.Windows.Forms.TabControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonSeqNoMasking = new System.Windows.Forms.RadioButton();
            this.radioButtonSeqInnerMasks = new System.Windows.Forms.RadioButton();
            this.radioButtonSeqWholeMasks = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBoxMaskingGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRegOrder.SuspendLayout();
            this.tabPageSequentialReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tabPageTransform.SuspendLayout();
            this.groupBoxHowToCompose.SuspendLayout();
            this.groupBoxInterpolation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefaultPixelValue)).BeginInit();
            this.tabPageNonRigid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBoxTransformationNonRigid.SuspendLayout();
            this.groupBoxPenalty.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
            this.tabPageRigid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxTransformationRigid.SuspendLayout();
            this.groupBoxMaskRigid.SuspendLayout();
            this.tabControlRegistration.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSegmentationInnerstructures
            // 
            this.buttonSegmentationInnerstructures.Location = new System.Drawing.Point(303, 46);
            this.buttonSegmentationInnerstructures.Name = "buttonSegmentationInnerstructures";
            this.buttonSegmentationInnerstructures.Size = new System.Drawing.Size(211, 28);
            this.buttonSegmentationInnerstructures.TabIndex = 4;
            this.buttonSegmentationInnerstructures.Text = "Adjust inner structures params";
            this.buttonSegmentationInnerstructures.UseVisualStyleBackColor = true;
            this.buttonSegmentationInnerstructures.Click += new System.EventHandler(this.buttonSegmentationInnerstructures_Click);
            // 
            // buttonSegmentationParams
            // 
            this.buttonSegmentationParams.Location = new System.Drawing.Point(303, 14);
            this.buttonSegmentationParams.Name = "buttonSegmentationParams";
            this.buttonSegmentationParams.Size = new System.Drawing.Size(211, 28);
            this.buttonSegmentationParams.TabIndex = 4;
            this.buttonSegmentationParams.Text = "Adjust fore-/ background params";
            this.buttonSegmentationParams.UseVisualStyleBackColor = true;
            this.buttonSegmentationParams.Click += new System.EventHandler(this.buttonSegmentationParams_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBoxMaskingGeneral);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.groupBoxRegOrder);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControlRegistration);
            this.splitContainer3.Size = new System.Drawing.Size(790, 501);
            this.splitContainer3.SplitterDistance = 149;
            this.splitContainer3.TabIndex = 1;
            // 
            // groupBoxMaskingGeneral
            // 
            this.groupBoxMaskingGeneral.Controls.Add(this.buttonLoadMasks);
            this.groupBoxMaskingGeneral.Controls.Add(this.groupBox1);
            this.groupBoxMaskingGeneral.Controls.Add(this.radioButtonFixedAndMovingMask);
            this.groupBoxMaskingGeneral.Controls.Add(this.buttonSegmentationInnerstructures);
            this.groupBoxMaskingGeneral.Controls.Add(this.buttonSegmentationParams);
            this.groupBoxMaskingGeneral.Controls.Add(this.radioButtonOnlyMovingMask);
            this.groupBoxMaskingGeneral.Controls.Add(this.radioButtonOnlyFixedMask);
            this.groupBoxMaskingGeneral.Controls.Add(this.radioButtonNoMask);
            this.groupBoxMaskingGeneral.Location = new System.Drawing.Point(263, 28);
            this.groupBoxMaskingGeneral.Name = "groupBoxMaskingGeneral";
            this.groupBoxMaskingGeneral.Size = new System.Drawing.Size(520, 113);
            this.groupBoxMaskingGeneral.TabIndex = 3;
            this.groupBoxMaskingGeneral.TabStop = false;
            this.groupBoxMaskingGeneral.Text = "Masking";
            // 
            // buttonLoadMasks
            // 
            this.buttonLoadMasks.Location = new System.Drawing.Point(303, 79);
            this.buttonLoadMasks.Name = "buttonLoadMasks";
            this.buttonLoadMasks.Size = new System.Drawing.Size(211, 28);
            this.buttonLoadMasks.TabIndex = 12;
            this.buttonLoadMasks.Text = "Load masks from disk";
            this.buttonLoadMasks.UseVisualStyleBackColor = true;
            this.buttonLoadMasks.Click += new System.EventHandler(this.buttonLoadMasks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPreDefMasks);
            this.groupBox1.Controls.Add(this.radioButtonInnerStructures);
            this.groupBox1.Controls.Add(this.radioButtonWholeTissue);
            this.groupBox1.Location = new System.Drawing.Point(167, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 96);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mask option";
            // 
            // radioButtonPreDefMasks
            // 
            this.radioButtonPreDefMasks.AutoSize = true;
            this.radioButtonPreDefMasks.Location = new System.Drawing.Point(7, 68);
            this.radioButtonPreDefMasks.Name = "radioButtonPreDefMasks";
            this.radioButtonPreDefMasks.Size = new System.Drawing.Size(115, 17);
            this.radioButtonPreDefMasks.TabIndex = 2;
            this.radioButtonPreDefMasks.TabStop = true;
            this.radioButtonPreDefMasks.Text = "Load predef masks";
            this.radioButtonPreDefMasks.UseVisualStyleBackColor = true;
            this.radioButtonPreDefMasks.CheckedChanged += new System.EventHandler(this.radioButtonPreDefMasks_CheckedChanged);
            // 
            // radioButtonInnerStructures
            // 
            this.radioButtonInnerStructures.AutoSize = true;
            this.radioButtonInnerStructures.Location = new System.Drawing.Point(7, 44);
            this.radioButtonInnerStructures.Name = "radioButtonInnerStructures";
            this.radioButtonInnerStructures.Size = new System.Drawing.Size(119, 17);
            this.radioButtonInnerStructures.TabIndex = 1;
            this.radioButtonInnerStructures.TabStop = true;
            this.radioButtonInnerStructures.Text = "Use inner structures";
            this.radioButtonInnerStructures.UseVisualStyleBackColor = true;
            // 
            // radioButtonWholeTissue
            // 
            this.radioButtonWholeTissue.AutoSize = true;
            this.radioButtonWholeTissue.Location = new System.Drawing.Point(7, 20);
            this.radioButtonWholeTissue.Name = "radioButtonWholeTissue";
            this.radioButtonWholeTissue.Size = new System.Drawing.Size(105, 17);
            this.radioButtonWholeTissue.TabIndex = 0;
            this.radioButtonWholeTissue.TabStop = true;
            this.radioButtonWholeTissue.Text = "Use whole tissue";
            this.radioButtonWholeTissue.UseVisualStyleBackColor = true;
            // 
            // radioButtonFixedAndMovingMask
            // 
            this.radioButtonFixedAndMovingMask.AutoSize = true;
            this.radioButtonFixedAndMovingMask.Location = new System.Drawing.Point(6, 90);
            this.radioButtonFixedAndMovingMask.Name = "radioButtonFixedAndMovingMask";
            this.radioButtonFixedAndMovingMask.Size = new System.Drawing.Size(155, 17);
            this.radioButtonFixedAndMovingMask.TabIndex = 8;
            this.radioButtonFixedAndMovingMask.TabStop = true;
            this.radioButtonFixedAndMovingMask.Text = "Use fixed and moving mask";
            this.radioButtonFixedAndMovingMask.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnlyMovingMask
            // 
            this.radioButtonOnlyMovingMask.AutoSize = true;
            this.radioButtonOnlyMovingMask.Location = new System.Drawing.Point(6, 68);
            this.radioButtonOnlyMovingMask.Name = "radioButtonOnlyMovingMask";
            this.radioButtonOnlyMovingMask.Size = new System.Drawing.Size(109, 17);
            this.radioButtonOnlyMovingMask.TabIndex = 7;
            this.radioButtonOnlyMovingMask.TabStop = true;
            this.radioButtonOnlyMovingMask.Text = "Use moving mask";
            this.radioButtonOnlyMovingMask.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnlyFixedMask
            // 
            this.radioButtonOnlyFixedMask.AutoSize = true;
            this.radioButtonOnlyFixedMask.Location = new System.Drawing.Point(6, 44);
            this.radioButtonOnlyFixedMask.Name = "radioButtonOnlyFixedMask";
            this.radioButtonOnlyFixedMask.Size = new System.Drawing.Size(97, 17);
            this.radioButtonOnlyFixedMask.TabIndex = 6;
            this.radioButtonOnlyFixedMask.TabStop = true;
            this.radioButtonOnlyFixedMask.Text = "Use fixed mask";
            this.radioButtonOnlyFixedMask.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoMask
            // 
            this.radioButtonNoMask.AutoSize = true;
            this.radioButtonNoMask.Location = new System.Drawing.Point(6, 20);
            this.radioButtonNoMask.Name = "radioButtonNoMask";
            this.radioButtonNoMask.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNoMask.TabIndex = 5;
            this.radioButtonNoMask.TabStop = true;
            this.radioButtonNoMask.Text = "None";
            this.radioButtonNoMask.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "General registration settings";
            // 
            // groupBoxRegOrder
            // 
            this.groupBoxRegOrder.Controls.Add(this.radioButtonUsePrevInStack);
            this.groupBoxRegOrder.Controls.Add(this.radioButtonMiddleStack);
            this.groupBoxRegOrder.Controls.Add(this.radioButtonLastInStack);
            this.groupBoxRegOrder.Controls.Add(this.radioButtonFirstFromStack);
            this.groupBoxRegOrder.Location = new System.Drawing.Point(12, 28);
            this.groupBoxRegOrder.Name = "groupBoxRegOrder";
            this.groupBoxRegOrder.Size = new System.Drawing.Size(245, 113);
            this.groupBoxRegOrder.TabIndex = 0;
            this.groupBoxRegOrder.TabStop = false;
            this.groupBoxRegOrder.Text = "Registration order";
            // 
            // radioButtonUsePrevInStack
            // 
            this.radioButtonUsePrevInStack.AutoSize = true;
            this.radioButtonUsePrevInStack.Location = new System.Drawing.Point(8, 90);
            this.radioButtonUsePrevInStack.Name = "radioButtonUsePrevInStack";
            this.radioButtonUsePrevInStack.Size = new System.Drawing.Size(220, 17);
            this.radioButtonUsePrevInStack.TabIndex = 3;
            this.radioButtonUsePrevInStack.Text = "Use previous image in stack as reference";
            this.radioButtonUsePrevInStack.UseVisualStyleBackColor = true;
            // 
            // radioButtonMiddleStack
            // 
            this.radioButtonMiddleStack.AutoSize = true;
            this.radioButtonMiddleStack.Location = new System.Drawing.Point(7, 68);
            this.radioButtonMiddleStack.Name = "radioButtonMiddleStack";
            this.radioButtonMiddleStack.Size = new System.Drawing.Size(210, 17);
            this.radioButtonMiddleStack.TabIndex = 2;
            this.radioButtonMiddleStack.Text = "Use middle image in stack as reference";
            this.radioButtonMiddleStack.UseVisualStyleBackColor = true;
            // 
            // radioButtonLastInStack
            // 
            this.radioButtonLastInStack.AutoSize = true;
            this.radioButtonLastInStack.Location = new System.Drawing.Point(7, 44);
            this.radioButtonLastInStack.Name = "radioButtonLastInStack";
            this.radioButtonLastInStack.Size = new System.Drawing.Size(196, 17);
            this.radioButtonLastInStack.TabIndex = 1;
            this.radioButtonLastInStack.Text = "Use last image in stack as reference";
            this.radioButtonLastInStack.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirstFromStack
            // 
            this.radioButtonFirstFromStack.AutoSize = true;
            this.radioButtonFirstFromStack.Checked = true;
            this.radioButtonFirstFromStack.Location = new System.Drawing.Point(8, 20);
            this.radioButtonFirstFromStack.Name = "radioButtonFirstFromStack";
            this.radioButtonFirstFromStack.Size = new System.Drawing.Size(196, 17);
            this.radioButtonFirstFromStack.TabIndex = 0;
            this.radioButtonFirstFromStack.TabStop = true;
            this.radioButtonFirstFromStack.Text = "Use first image in stack as reference";
            this.radioButtonFirstFromStack.UseVisualStyleBackColor = true;
            // 
            // openFileDialogTransformParam
            // 
            this.openFileDialogTransformParam.FileName = "openFileDialog1";
            // 
            // openFileDialogParamFile
            // 
            this.openFileDialogParamFile.FileName = "openFileDialog1";
            // 
            // tabPageSequentialReg
            // 
            this.tabPageSequentialReg.Controls.Add(this.splitContainer6);
            this.tabPageSequentialReg.Location = new System.Drawing.Point(4, 22);
            this.tabPageSequentialReg.Name = "tabPageSequentialReg";
            this.tabPageSequentialReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSequentialReg.Size = new System.Drawing.Size(782, 322);
            this.tabPageSequentialReg.TabIndex = 4;
            this.tabPageSequentialReg.Text = "Sequential registration";
            this.tabPageSequentialReg.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer6.Panel1.Controls.Add(this.treeViewParamFiles);
            this.splitContainer6.Panel1.Controls.Add(this.buttonRemoveParamFile);
            this.splitContainer6.Panel1.Controls.Add(this.buttonShowFile);
            this.splitContainer6.Panel1.Controls.Add(this.buttonAddParamFile);
            this.splitContainer6.Panel1.Controls.Add(this.labelParamFiles);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer6.Size = new System.Drawing.Size(776, 316);
            this.splitContainer6.SplitterDistance = 133;
            this.splitContainer6.TabIndex = 0;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.buttonEvaluateRegSequential);
            this.splitContainer7.Panel1.Controls.Add(this.buttonStartRegSequential);
            this.splitContainer7.Panel1.Controls.Add(this.buttonCancelRegSequential);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.textBoxRegSequential);
            this.splitContainer7.Panel2.Controls.Add(this.progressBarRegSequential);
            this.splitContainer7.Size = new System.Drawing.Size(776, 179);
            this.splitContainer7.SplitterDistance = 168;
            this.splitContainer7.TabIndex = 2;
            // 
            // progressBarRegSequential
            // 
            this.progressBarRegSequential.Location = new System.Drawing.Point(20, 13);
            this.progressBarRegSequential.Name = "progressBarRegSequential";
            this.progressBarRegSequential.Size = new System.Drawing.Size(569, 23);
            this.progressBarRegSequential.TabIndex = 0;
            // 
            // textBoxRegSequential
            // 
            this.textBoxRegSequential.Location = new System.Drawing.Point(20, 45);
            this.textBoxRegSequential.Multiline = true;
            this.textBoxRegSequential.Name = "textBoxRegSequential";
            this.textBoxRegSequential.Size = new System.Drawing.Size(569, 119);
            this.textBoxRegSequential.TabIndex = 1;
            // 
            // buttonCancelRegSequential
            // 
            this.buttonCancelRegSequential.Location = new System.Drawing.Point(13, 43);
            this.buttonCancelRegSequential.Name = "buttonCancelRegSequential";
            this.buttonCancelRegSequential.Size = new System.Drawing.Size(142, 23);
            this.buttonCancelRegSequential.TabIndex = 1;
            this.buttonCancelRegSequential.Text = "Cancel Registration";
            this.buttonCancelRegSequential.UseVisualStyleBackColor = true;
            this.buttonCancelRegSequential.Click += new System.EventHandler(this.buttonCancelRegSequential_Click);
            // 
            // buttonStartRegSequential
            // 
            this.buttonStartRegSequential.Location = new System.Drawing.Point(13, 14);
            this.buttonStartRegSequential.Name = "buttonStartRegSequential";
            this.buttonStartRegSequential.Size = new System.Drawing.Size(142, 23);
            this.buttonStartRegSequential.TabIndex = 0;
            this.buttonStartRegSequential.Text = "Start Registration";
            this.buttonStartRegSequential.UseVisualStyleBackColor = true;
            this.buttonStartRegSequential.Click += new System.EventHandler(this.buttonStartRegSequential_Click);
            // 
            // buttonEvaluateRegSequential
            // 
            this.buttonEvaluateRegSequential.Location = new System.Drawing.Point(13, 141);
            this.buttonEvaluateRegSequential.Name = "buttonEvaluateRegSequential";
            this.buttonEvaluateRegSequential.Size = new System.Drawing.Size(142, 23);
            this.buttonEvaluateRegSequential.TabIndex = 2;
            this.buttonEvaluateRegSequential.Text = "Evaluate Registration";
            this.buttonEvaluateRegSequential.UseVisualStyleBackColor = true;
            this.buttonEvaluateRegSequential.Click += new System.EventHandler(this.buttonEvaluateRegSequential_Click);
            // 
            // labelParamFiles
            // 
            this.labelParamFiles.AutoSize = true;
            this.labelParamFiles.Location = new System.Drawing.Point(9, 10);
            this.labelParamFiles.Name = "labelParamFiles";
            this.labelParamFiles.Size = new System.Drawing.Size(79, 13);
            this.labelParamFiles.TabIndex = 1;
            this.labelParamFiles.Text = "Parameter files:";
            // 
            // buttonAddParamFile
            // 
            this.buttonAddParamFile.Location = new System.Drawing.Point(203, 30);
            this.buttonAddParamFile.Name = "buttonAddParamFile";
            this.buttonAddParamFile.Size = new System.Drawing.Size(156, 23);
            this.buttonAddParamFile.TabIndex = 2;
            this.buttonAddParamFile.Text = "Add parameter files";
            this.buttonAddParamFile.UseVisualStyleBackColor = true;
            this.buttonAddParamFile.Click += new System.EventHandler(this.buttonAddParamFile_Click);
            // 
            // buttonShowFile
            // 
            this.buttonShowFile.Location = new System.Drawing.Point(203, 59);
            this.buttonShowFile.Name = "buttonShowFile";
            this.buttonShowFile.Size = new System.Drawing.Size(156, 23);
            this.buttonShowFile.TabIndex = 4;
            this.buttonShowFile.Text = "Show selected file";
            this.buttonShowFile.UseVisualStyleBackColor = true;
            this.buttonShowFile.Click += new System.EventHandler(this.buttonShowFile_Click);
            // 
            // buttonRemoveParamFile
            // 
            this.buttonRemoveParamFile.Location = new System.Drawing.Point(203, 88);
            this.buttonRemoveParamFile.Name = "buttonRemoveParamFile";
            this.buttonRemoveParamFile.Size = new System.Drawing.Size(156, 23);
            this.buttonRemoveParamFile.TabIndex = 5;
            this.buttonRemoveParamFile.Text = "Remove selected file";
            this.buttonRemoveParamFile.UseVisualStyleBackColor = true;
            this.buttonRemoveParamFile.Click += new System.EventHandler(this.buttonRemoveParamFile_Click);
            // 
            // treeViewParamFiles
            // 
            this.treeViewParamFiles.Location = new System.Drawing.Point(8, 26);
            this.treeViewParamFiles.Name = "treeViewParamFiles";
            this.treeViewParamFiles.Size = new System.Drawing.Size(189, 97);
            this.treeViewParamFiles.TabIndex = 6;
            // 
            // tabPageTransform
            // 
            this.tabPageTransform.Controls.Add(this.buttonTransform);
            this.tabPageTransform.Controls.Add(this.groupBox2);
            this.tabPageTransform.Controls.Add(this.groupBoxInterpolation);
            this.tabPageTransform.Controls.Add(this.groupBoxHowToCompose);
            this.tabPageTransform.Controls.Add(this.buttonChooseParamFiles);
            this.tabPageTransform.Controls.Add(this.label2);
            this.tabPageTransform.Controls.Add(this.textBoxTransformParams);
            this.tabPageTransform.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransform.Name = "tabPageTransform";
            this.tabPageTransform.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransform.Size = new System.Drawing.Size(782, 322);
            this.tabPageTransform.TabIndex = 2;
            this.tabPageTransform.Text = "Transform";
            this.tabPageTransform.UseVisualStyleBackColor = true;
            // 
            // textBoxTransformParams
            // 
            this.textBoxTransformParams.Location = new System.Drawing.Point(11, 28);
            this.textBoxTransformParams.Name = "textBoxTransformParams";
            this.textBoxTransformParams.Size = new System.Drawing.Size(180, 20);
            this.textBoxTransformParams.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transform parameter files:";
            // 
            // buttonChooseParamFiles
            // 
            this.buttonChooseParamFiles.Location = new System.Drawing.Point(197, 28);
            this.buttonChooseParamFiles.Name = "buttonChooseParamFiles";
            this.buttonChooseParamFiles.Size = new System.Drawing.Size(90, 20);
            this.buttonChooseParamFiles.TabIndex = 2;
            this.buttonChooseParamFiles.Text = "Choose";
            this.buttonChooseParamFiles.UseVisualStyleBackColor = true;
            this.buttonChooseParamFiles.Click += new System.EventHandler(this.buttonChooseParamFiles_Click);
            // 
            // groupBoxHowToCompose
            // 
            this.groupBoxHowToCompose.Controls.Add(this.radioButtonCompose);
            this.groupBoxHowToCompose.Controls.Add(this.radioButtonAdd);
            this.groupBoxHowToCompose.Location = new System.Drawing.Point(11, 55);
            this.groupBoxHowToCompose.Name = "groupBoxHowToCompose";
            this.groupBoxHowToCompose.Size = new System.Drawing.Size(276, 72);
            this.groupBoxHowToCompose.TabIndex = 3;
            this.groupBoxHowToCompose.TabStop = false;
            this.groupBoxHowToCompose.Text = "How to compose";
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAdd.TabIndex = 0;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonCompose
            // 
            this.radioButtonCompose.AutoSize = true;
            this.radioButtonCompose.Location = new System.Drawing.Point(7, 44);
            this.radioButtonCompose.Name = "radioButtonCompose";
            this.radioButtonCompose.Size = new System.Drawing.Size(69, 17);
            this.radioButtonCompose.TabIndex = 1;
            this.radioButtonCompose.TabStop = true;
            this.radioButtonCompose.Text = "Compose";
            this.radioButtonCompose.UseVisualStyleBackColor = true;
            // 
            // groupBoxInterpolation
            // 
            this.groupBoxInterpolation.Controls.Add(this.labelOrder);
            this.groupBoxInterpolation.Controls.Add(this.comboBoxInterpolationOrder);
            this.groupBoxInterpolation.Controls.Add(this.radioButtonBSpline);
            this.groupBoxInterpolation.Controls.Add(this.radioButtonNN);
            this.groupBoxInterpolation.Controls.Add(this.radioButtonLinear);
            this.groupBoxInterpolation.Location = new System.Drawing.Point(11, 134);
            this.groupBoxInterpolation.Name = "groupBoxInterpolation";
            this.groupBoxInterpolation.Size = new System.Drawing.Size(276, 93);
            this.groupBoxInterpolation.TabIndex = 4;
            this.groupBoxInterpolation.TabStop = false;
            this.groupBoxInterpolation.Text = "Interpolation";
            // 
            // radioButtonLinear
            // 
            this.radioButtonLinear.AutoSize = true;
            this.radioButtonLinear.Location = new System.Drawing.Point(7, 20);
            this.radioButtonLinear.Name = "radioButtonLinear";
            this.radioButtonLinear.Size = new System.Drawing.Size(54, 17);
            this.radioButtonLinear.TabIndex = 0;
            this.radioButtonLinear.TabStop = true;
            this.radioButtonLinear.Text = "Linear";
            this.radioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // radioButtonNN
            // 
            this.radioButtonNN.AutoSize = true;
            this.radioButtonNN.Location = new System.Drawing.Point(7, 44);
            this.radioButtonNN.Name = "radioButtonNN";
            this.radioButtonNN.Size = new System.Drawing.Size(108, 17);
            this.radioButtonNN.TabIndex = 1;
            this.radioButtonNN.TabStop = true;
            this.radioButtonNN.Text = "Nearest Neighbor";
            this.radioButtonNN.UseVisualStyleBackColor = true;
            // 
            // radioButtonBSpline
            // 
            this.radioButtonBSpline.AutoSize = true;
            this.radioButtonBSpline.Location = new System.Drawing.Point(7, 67);
            this.radioButtonBSpline.Name = "radioButtonBSpline";
            this.radioButtonBSpline.Size = new System.Drawing.Size(61, 17);
            this.radioButtonBSpline.TabIndex = 2;
            this.radioButtonBSpline.TabStop = true;
            this.radioButtonBSpline.Text = "BSpline";
            this.radioButtonBSpline.UseVisualStyleBackColor = true;
            this.radioButtonBSpline.CheckedChanged += new System.EventHandler(this.radioButtonBSpline_CheckedChanged);
            // 
            // comboBoxInterpolationOrder
            // 
            this.comboBoxInterpolationOrder.FormattingEnabled = true;
            this.comboBoxInterpolationOrder.Location = new System.Drawing.Point(149, 63);
            this.comboBoxInterpolationOrder.Name = "comboBoxInterpolationOrder";
            this.comboBoxInterpolationOrder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInterpolationOrder.TabIndex = 3;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(107, 69);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(36, 13);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Order:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownDefaultPixelValue);
            this.groupBox2.Location = new System.Drawing.Point(11, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default pixel value";
            // 
            // numericUpDownDefaultPixelValue
            // 
            this.numericUpDownDefaultPixelValue.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownDefaultPixelValue.Name = "numericUpDownDefaultPixelValue";
            this.numericUpDownDefaultPixelValue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDefaultPixelValue.TabIndex = 0;
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(11, 287);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(276, 23);
            this.buttonTransform.TabIndex = 6;
            this.buttonTransform.Text = "Transform";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // tabPageNonRigid
            // 
            this.tabPageNonRigid.Controls.Add(this.splitContainer4);
            this.tabPageNonRigid.Location = new System.Drawing.Point(4, 22);
            this.tabPageNonRigid.Name = "tabPageNonRigid";
            this.tabPageNonRigid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNonRigid.Size = new System.Drawing.Size(782, 322);
            this.tabPageNonRigid.TabIndex = 1;
            this.tabPageNonRigid.Text = "Non rigid registration";
            this.tabPageNonRigid.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBoxMisc);
            this.splitContainer4.Panel1.Controls.Add(this.buttonEditParamsNonRigid);
            this.splitContainer4.Panel1.Controls.Add(this.groupBoxPenalty);
            this.splitContainer4.Panel1.Controls.Add(this.groupBoxTransformationNonRigid);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(776, 316);
            this.splitContainer4.SplitterDistance = 134;
            this.splitContainer4.TabIndex = 1;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.buttonEvaluateNonRigidReg);
            this.splitContainer5.Panel1.Controls.Add(this.buttonStartNonRigidRegistration);
            this.splitContainer5.Panel1.Controls.Add(this.buttonCancelNonRigidReg);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.textBoxConsoleNonRigid);
            this.splitContainer5.Panel2.Controls.Add(this.progressBarNonRigid);
            this.splitContainer5.Size = new System.Drawing.Size(776, 178);
            this.splitContainer5.SplitterDistance = 168;
            this.splitContainer5.TabIndex = 2;
            // 
            // progressBarNonRigid
            // 
            this.progressBarNonRigid.Location = new System.Drawing.Point(20, 13);
            this.progressBarNonRigid.Name = "progressBarNonRigid";
            this.progressBarNonRigid.Size = new System.Drawing.Size(569, 23);
            this.progressBarNonRigid.TabIndex = 0;
            // 
            // textBoxConsoleNonRigid
            // 
            this.textBoxConsoleNonRigid.Location = new System.Drawing.Point(20, 45);
            this.textBoxConsoleNonRigid.Multiline = true;
            this.textBoxConsoleNonRigid.Name = "textBoxConsoleNonRigid";
            this.textBoxConsoleNonRigid.Size = new System.Drawing.Size(569, 130);
            this.textBoxConsoleNonRigid.TabIndex = 1;
            // 
            // buttonCancelNonRigidReg
            // 
            this.buttonCancelNonRigidReg.Location = new System.Drawing.Point(13, 42);
            this.buttonCancelNonRigidReg.Name = "buttonCancelNonRigidReg";
            this.buttonCancelNonRigidReg.Size = new System.Drawing.Size(142, 23);
            this.buttonCancelNonRigidReg.TabIndex = 1;
            this.buttonCancelNonRigidReg.Text = "Cancel Registration";
            this.buttonCancelNonRigidReg.UseVisualStyleBackColor = true;
            this.buttonCancelNonRigidReg.Click += new System.EventHandler(this.buttonCancelNonRigidReg_Click);
            // 
            // buttonStartNonRigidRegistration
            // 
            this.buttonStartNonRigidRegistration.Location = new System.Drawing.Point(13, 13);
            this.buttonStartNonRigidRegistration.Name = "buttonStartNonRigidRegistration";
            this.buttonStartNonRigidRegistration.Size = new System.Drawing.Size(142, 23);
            this.buttonStartNonRigidRegistration.TabIndex = 0;
            this.buttonStartNonRigidRegistration.Text = "Start Registration";
            this.buttonStartNonRigidRegistration.UseVisualStyleBackColor = true;
            this.buttonStartNonRigidRegistration.Click += new System.EventHandler(this.buttonStartNonRigidRegistration_Click);
            // 
            // buttonEvaluateNonRigidReg
            // 
            this.buttonEvaluateNonRigidReg.Location = new System.Drawing.Point(13, 140);
            this.buttonEvaluateNonRigidReg.Name = "buttonEvaluateNonRigidReg";
            this.buttonEvaluateNonRigidReg.Size = new System.Drawing.Size(142, 23);
            this.buttonEvaluateNonRigidReg.TabIndex = 2;
            this.buttonEvaluateNonRigidReg.Text = "Evaluate Registration";
            this.buttonEvaluateNonRigidReg.UseVisualStyleBackColor = true;
            this.buttonEvaluateNonRigidReg.Click += new System.EventHandler(this.buttonEvaluateNonRigidReg_Click);
            // 
            // groupBoxTransformationNonRigid
            // 
            this.groupBoxTransformationNonRigid.Controls.Add(this.radioButtonSplineRecursive);
            this.groupBoxTransformationNonRigid.Controls.Add(this.radioButtonKernelSpline);
            this.groupBoxTransformationNonRigid.Controls.Add(this.radioButtonBsplineDiffusion);
            this.groupBoxTransformationNonRigid.Controls.Add(this.radioButtonAdvancedBspline);
            this.groupBoxTransformationNonRigid.Location = new System.Drawing.Point(5, 3);
            this.groupBoxTransformationNonRigid.Name = "groupBoxTransformationNonRigid";
            this.groupBoxTransformationNonRigid.Size = new System.Drawing.Size(174, 125);
            this.groupBoxTransformationNonRigid.TabIndex = 1;
            this.groupBoxTransformationNonRigid.TabStop = false;
            this.groupBoxTransformationNonRigid.Text = "Transformation";
            // 
            // radioButtonAdvancedBspline
            // 
            this.radioButtonAdvancedBspline.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAdvancedBspline.Name = "radioButtonAdvancedBspline";
            this.radioButtonAdvancedBspline.Size = new System.Drawing.Size(135, 17);
            this.radioButtonAdvancedBspline.TabIndex = 0;
            this.radioButtonAdvancedBspline.Text = "Advanced Bspline (def)";
            this.radioButtonAdvancedBspline.UseVisualStyleBackColor = true;
            this.radioButtonAdvancedBspline.CheckedChanged += new System.EventHandler(this.radioButtonAdvancedBspline_CheckedChanged);
            // 
            // radioButtonBsplineDiffusion
            // 
            this.radioButtonBsplineDiffusion.AutoSize = true;
            this.radioButtonBsplineDiffusion.Location = new System.Drawing.Point(7, 44);
            this.radioButtonBsplineDiffusion.Name = "radioButtonBsplineDiffusion";
            this.radioButtonBsplineDiffusion.Size = new System.Drawing.Size(123, 17);
            this.radioButtonBsplineDiffusion.TabIndex = 1;
            this.radioButtonBsplineDiffusion.Text = "Bspline with diffusion";
            this.radioButtonBsplineDiffusion.UseVisualStyleBackColor = true;
            this.radioButtonBsplineDiffusion.CheckedChanged += new System.EventHandler(this.radioButtonBsplineDiffusion_CheckedChanged);
            // 
            // radioButtonKernelSpline
            // 
            this.radioButtonKernelSpline.AutoSize = true;
            this.radioButtonKernelSpline.Location = new System.Drawing.Point(7, 68);
            this.radioButtonKernelSpline.Name = "radioButtonKernelSpline";
            this.radioButtonKernelSpline.Size = new System.Drawing.Size(84, 17);
            this.radioButtonKernelSpline.TabIndex = 2;
            this.radioButtonKernelSpline.Text = "SplineKernel";
            this.radioButtonKernelSpline.UseVisualStyleBackColor = true;
            // 
            // radioButtonSplineRecursive
            // 
            this.radioButtonSplineRecursive.AutoSize = true;
            this.radioButtonSplineRecursive.Location = new System.Drawing.Point(7, 92);
            this.radioButtonSplineRecursive.Name = "radioButtonSplineRecursive";
            this.radioButtonSplineRecursive.Size = new System.Drawing.Size(105, 17);
            this.radioButtonSplineRecursive.TabIndex = 3;
            this.radioButtonSplineRecursive.Text = "Recursive Spline";
            this.radioButtonSplineRecursive.UseVisualStyleBackColor = true;
            // 
            // groupBoxPenalty
            // 
            this.groupBoxPenalty.Controls.Add(this.radioButtonDistancePreserving);
            this.groupBoxPenalty.Controls.Add(this.radioButtonBendEnergy);
            this.groupBoxPenalty.Controls.Add(this.radioButtonTransformRigidity);
            this.groupBoxPenalty.Controls.Add(this.radioButtonNoPenalties);
            this.groupBoxPenalty.Location = new System.Drawing.Point(185, 3);
            this.groupBoxPenalty.Name = "groupBoxPenalty";
            this.groupBoxPenalty.Size = new System.Drawing.Size(159, 125);
            this.groupBoxPenalty.TabIndex = 2;
            this.groupBoxPenalty.TabStop = false;
            this.groupBoxPenalty.Text = "Penalty";
            // 
            // radioButtonNoPenalties
            // 
            this.radioButtonNoPenalties.AutoSize = true;
            this.radioButtonNoPenalties.Location = new System.Drawing.Point(7, 20);
            this.radioButtonNoPenalties.Name = "radioButtonNoPenalties";
            this.radioButtonNoPenalties.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNoPenalties.TabIndex = 5;
            this.radioButtonNoPenalties.TabStop = true;
            this.radioButtonNoPenalties.Text = "None";
            this.radioButtonNoPenalties.UseVisualStyleBackColor = true;
            this.radioButtonNoPenalties.CheckedChanged += new System.EventHandler(this.radioButtonNoPenalties_CheckedChanged);
            // 
            // radioButtonTransformRigidity
            // 
            this.radioButtonTransformRigidity.AutoSize = true;
            this.radioButtonTransformRigidity.Location = new System.Drawing.Point(7, 44);
            this.radioButtonTransformRigidity.Name = "radioButtonTransformRigidity";
            this.radioButtonTransformRigidity.Size = new System.Drawing.Size(109, 17);
            this.radioButtonTransformRigidity.TabIndex = 6;
            this.radioButtonTransformRigidity.TabStop = true;
            this.radioButtonTransformRigidity.Text = "Transform Rigidity";
            this.radioButtonTransformRigidity.UseVisualStyleBackColor = true;
            this.radioButtonTransformRigidity.CheckedChanged += new System.EventHandler(this.radioButtonTransformRigidity_CheckedChanged);
            // 
            // radioButtonBendEnergy
            // 
            this.radioButtonBendEnergy.AutoSize = true;
            this.radioButtonBendEnergy.Location = new System.Drawing.Point(7, 68);
            this.radioButtonBendEnergy.Name = "radioButtonBendEnergy";
            this.radioButtonBendEnergy.Size = new System.Drawing.Size(100, 17);
            this.radioButtonBendEnergy.TabIndex = 7;
            this.radioButtonBendEnergy.TabStop = true;
            this.radioButtonBendEnergy.Text = "Bending Energy";
            this.radioButtonBendEnergy.UseVisualStyleBackColor = true;
            this.radioButtonBendEnergy.CheckedChanged += new System.EventHandler(this.radioButtonBendEnergy_CheckedChanged);
            // 
            // radioButtonDistancePreserving
            // 
            this.radioButtonDistancePreserving.AutoSize = true;
            this.radioButtonDistancePreserving.Location = new System.Drawing.Point(7, 92);
            this.radioButtonDistancePreserving.Name = "radioButtonDistancePreserving";
            this.radioButtonDistancePreserving.Size = new System.Drawing.Size(120, 17);
            this.radioButtonDistancePreserving.TabIndex = 8;
            this.radioButtonDistancePreserving.TabStop = true;
            this.radioButtonDistancePreserving.Text = "Distance Preserving";
            this.radioButtonDistancePreserving.UseVisualStyleBackColor = true;
            this.radioButtonDistancePreserving.CheckedChanged += new System.EventHandler(this.radioButtonDistancePreserving_CheckedChanged);
            // 
            // buttonEditParamsNonRigid
            // 
            this.buttonEditParamsNonRigid.Location = new System.Drawing.Point(633, 83);
            this.buttonEditParamsNonRigid.Name = "buttonEditParamsNonRigid";
            this.buttonEditParamsNonRigid.Size = new System.Drawing.Size(128, 41);
            this.buttonEditParamsNonRigid.TabIndex = 3;
            this.buttonEditParamsNonRigid.Text = "Edit registration parameters";
            this.buttonEditParamsNonRigid.UseVisualStyleBackColor = true;
            this.buttonEditParamsNonRigid.Click += new System.EventHandler(this.buttonEditParamsNonRigid_Click);
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Controls.Add(this.checkBoxUseCoefficientmap);
            this.groupBoxMisc.Controls.Add(this.checkBoxJaccobian);
            this.groupBoxMisc.Location = new System.Drawing.Point(350, 3);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(195, 125);
            this.groupBoxMisc.TabIndex = 4;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc";
            // 
            // checkBoxJaccobian
            // 
            this.checkBoxJaccobian.AutoSize = true;
            this.checkBoxJaccobian.Location = new System.Drawing.Point(7, 20);
            this.checkBoxJaccobian.Name = "checkBoxJaccobian";
            this.checkBoxJaccobian.Size = new System.Drawing.Size(180, 17);
            this.checkBoxJaccobian.TabIndex = 0;
            this.checkBoxJaccobian.Text = "Compute Jaccobian Determinant";
            this.checkBoxJaccobian.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseCoefficientmap
            // 
            this.checkBoxUseCoefficientmap.AutoSize = true;
            this.checkBoxUseCoefficientmap.Location = new System.Drawing.Point(7, 44);
            this.checkBoxUseCoefficientmap.Name = "checkBoxUseCoefficientmap";
            this.checkBoxUseCoefficientmap.Size = new System.Drawing.Size(120, 17);
            this.checkBoxUseCoefficientmap.TabIndex = 1;
            this.checkBoxUseCoefficientmap.Text = "Use coefficient map";
            this.checkBoxUseCoefficientmap.UseVisualStyleBackColor = true;
            this.checkBoxUseCoefficientmap.CheckedChanged += new System.EventHandler(this.checkBoxUseCoefficientmap_CheckedChanged);
            // 
            // tabPageRigid
            // 
            this.tabPageRigid.Controls.Add(this.splitContainer1);
            this.tabPageRigid.Location = new System.Drawing.Point(4, 22);
            this.tabPageRigid.Name = "tabPageRigid";
            this.tabPageRigid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRigid.Size = new System.Drawing.Size(782, 322);
            this.tabPageRigid.TabIndex = 0;
            this.tabPageRigid.Text = "Rigid registration";
            this.tabPageRigid.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonEditParameters);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMaskRigid);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTransformationRigid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(776, 316);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonEvaluation);
            this.splitContainer2.Panel1.Controls.Add(this.buttonStartRegistration);
            this.splitContainer2.Panel1.Controls.Add(this.buttonCancel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBoxConsoleRigid);
            this.splitContainer2.Panel2.Controls.Add(this.progressBarRigid);
            this.splitContainer2.Size = new System.Drawing.Size(776, 179);
            this.splitContainer2.SplitterDistance = 168;
            this.splitContainer2.TabIndex = 2;
            // 
            // progressBarRigid
            // 
            this.progressBarRigid.Location = new System.Drawing.Point(20, 13);
            this.progressBarRigid.Name = "progressBarRigid";
            this.progressBarRigid.Size = new System.Drawing.Size(569, 23);
            this.progressBarRigid.TabIndex = 0;
            // 
            // textBoxConsoleRigid
            // 
            this.textBoxConsoleRigid.Location = new System.Drawing.Point(20, 45);
            this.textBoxConsoleRigid.Multiline = true;
            this.textBoxConsoleRigid.Name = "textBoxConsoleRigid";
            this.textBoxConsoleRigid.Size = new System.Drawing.Size(569, 119);
            this.textBoxConsoleRigid.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(13, 43);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel Registration";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonStartRegistration
            // 
            this.buttonStartRegistration.Location = new System.Drawing.Point(13, 14);
            this.buttonStartRegistration.Name = "buttonStartRegistration";
            this.buttonStartRegistration.Size = new System.Drawing.Size(142, 23);
            this.buttonStartRegistration.TabIndex = 0;
            this.buttonStartRegistration.Text = "Start Registration";
            this.buttonStartRegistration.UseVisualStyleBackColor = true;
            this.buttonStartRegistration.Click += new System.EventHandler(this.buttonStartRegistration_Click);
            // 
            // buttonEvaluation
            // 
            this.buttonEvaluation.Location = new System.Drawing.Point(13, 141);
            this.buttonEvaluation.Name = "buttonEvaluation";
            this.buttonEvaluation.Size = new System.Drawing.Size(142, 23);
            this.buttonEvaluation.TabIndex = 2;
            this.buttonEvaluation.Text = "Evaluate Registration";
            this.buttonEvaluation.UseVisualStyleBackColor = true;
            this.buttonEvaluation.Click += new System.EventHandler(this.buttonEvaluation_Click);
            // 
            // groupBoxTransformationRigid
            // 
            this.groupBoxTransformationRigid.Controls.Add(this.radioButtonAffine);
            this.groupBoxTransformationRigid.Controls.Add(this.radioButtonRigid);
            this.groupBoxTransformationRigid.Controls.Add(this.radioButtonSimilarity);
            this.groupBoxTransformationRigid.Controls.Add(this.radioButtonTranslation);
            this.groupBoxTransformationRigid.Location = new System.Drawing.Point(5, 3);
            this.groupBoxTransformationRigid.Name = "groupBoxTransformationRigid";
            this.groupBoxTransformationRigid.Size = new System.Drawing.Size(174, 125);
            this.groupBoxTransformationRigid.TabIndex = 1;
            this.groupBoxTransformationRigid.TabStop = false;
            this.groupBoxTransformationRigid.Text = "Transformation";
            // 
            // radioButtonTranslation
            // 
            this.radioButtonTranslation.AutoSize = true;
            this.radioButtonTranslation.Location = new System.Drawing.Point(7, 20);
            this.radioButtonTranslation.Name = "radioButtonTranslation";
            this.radioButtonTranslation.Size = new System.Drawing.Size(77, 17);
            this.radioButtonTranslation.TabIndex = 0;
            this.radioButtonTranslation.Text = "Translation";
            this.radioButtonTranslation.UseVisualStyleBackColor = true;
            this.radioButtonTranslation.CheckedChanged += new System.EventHandler(this.radioButtonTranslation_CheckedChanged);
            // 
            // radioButtonSimilarity
            // 
            this.radioButtonSimilarity.AutoSize = true;
            this.radioButtonSimilarity.Location = new System.Drawing.Point(7, 44);
            this.radioButtonSimilarity.Name = "radioButtonSimilarity";
            this.radioButtonSimilarity.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSimilarity.TabIndex = 1;
            this.radioButtonSimilarity.Text = "Similarity";
            this.radioButtonSimilarity.UseVisualStyleBackColor = true;
            this.radioButtonSimilarity.CheckedChanged += new System.EventHandler(this.radioButtonSimilarity_CheckedChanged);
            // 
            // radioButtonRigid
            // 
            this.radioButtonRigid.AutoSize = true;
            this.radioButtonRigid.Location = new System.Drawing.Point(7, 68);
            this.radioButtonRigid.Name = "radioButtonRigid";
            this.radioButtonRigid.Size = new System.Drawing.Size(49, 17);
            this.radioButtonRigid.TabIndex = 2;
            this.radioButtonRigid.Text = "Rigid";
            this.radioButtonRigid.UseVisualStyleBackColor = true;
            this.radioButtonRigid.CheckedChanged += new System.EventHandler(this.radioButtonRigid_CheckedChanged);
            // 
            // radioButtonAffine
            // 
            this.radioButtonAffine.AutoSize = true;
            this.radioButtonAffine.Location = new System.Drawing.Point(7, 92);
            this.radioButtonAffine.Name = "radioButtonAffine";
            this.radioButtonAffine.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAffine.TabIndex = 3;
            this.radioButtonAffine.Text = "Affine";
            this.radioButtonAffine.UseVisualStyleBackColor = true;
            this.radioButtonAffine.CheckedChanged += new System.EventHandler(this.radioButtonAffine_CheckedChanged);
            // 
            // groupBoxMaskRigid
            // 
            this.groupBoxMaskRigid.Controls.Add(this.radioButtonRigidNoMasking);
            this.groupBoxMaskRigid.Controls.Add(this.radioButtonComponent);
            this.groupBoxMaskRigid.Controls.Add(this.radioButtonMaskInner);
            this.groupBoxMaskRigid.Controls.Add(this.radioButtonMaskWhole);
            this.groupBoxMaskRigid.Location = new System.Drawing.Point(185, 3);
            this.groupBoxMaskRigid.Name = "groupBoxMaskRigid";
            this.groupBoxMaskRigid.Size = new System.Drawing.Size(194, 125);
            this.groupBoxMaskRigid.TabIndex = 2;
            this.groupBoxMaskRigid.TabStop = false;
            this.groupBoxMaskRigid.Text = "Masking Rigid";
            // 
            // radioButtonMaskWhole
            // 
            this.radioButtonMaskWhole.AutoSize = true;
            this.radioButtonMaskWhole.Checked = true;
            this.radioButtonMaskWhole.Location = new System.Drawing.Point(7, 44);
            this.radioButtonMaskWhole.Name = "radioButtonMaskWhole";
            this.radioButtonMaskWhole.Size = new System.Drawing.Size(169, 17);
            this.radioButtonMaskWhole.TabIndex = 11;
            this.radioButtonMaskWhole.TabStop = true;
            this.radioButtonMaskWhole.Text = "Do registration of whole masks";
            this.radioButtonMaskWhole.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaskInner
            // 
            this.radioButtonMaskInner.AutoSize = true;
            this.radioButtonMaskInner.Location = new System.Drawing.Point(7, 68);
            this.radioButtonMaskInner.Name = "radioButtonMaskInner";
            this.radioButtonMaskInner.Size = new System.Drawing.Size(180, 17);
            this.radioButtonMaskInner.TabIndex = 12;
            this.radioButtonMaskInner.Text = "Do registration of inner structures";
            this.radioButtonMaskInner.UseVisualStyleBackColor = true;
            // 
            // radioButtonComponent
            // 
            this.radioButtonComponent.AutoSize = true;
            this.radioButtonComponent.Location = new System.Drawing.Point(7, 92);
            this.radioButtonComponent.Name = "radioButtonComponent";
            this.radioButtonComponent.Size = new System.Drawing.Size(173, 17);
            this.radioButtonComponent.TabIndex = 13;
            this.radioButtonComponent.Text = "Do component-wise registration";
            this.radioButtonComponent.UseVisualStyleBackColor = true;
            // 
            // radioButtonRigidNoMasking
            // 
            this.radioButtonRigidNoMasking.AutoSize = true;
            this.radioButtonRigidNoMasking.Location = new System.Drawing.Point(7, 21);
            this.radioButtonRigidNoMasking.Name = "radioButtonRigidNoMasking";
            this.radioButtonRigidNoMasking.Size = new System.Drawing.Size(51, 17);
            this.radioButtonRigidNoMasking.TabIndex = 14;
            this.radioButtonRigidNoMasking.Text = "None";
            this.radioButtonRigidNoMasking.UseVisualStyleBackColor = true;
            // 
            // buttonEditParameters
            // 
            this.buttonEditParameters.Location = new System.Drawing.Point(633, 83);
            this.buttonEditParameters.Name = "buttonEditParameters";
            this.buttonEditParameters.Size = new System.Drawing.Size(128, 41);
            this.buttonEditParameters.TabIndex = 3;
            this.buttonEditParameters.Text = "Edit registration parameters";
            this.buttonEditParameters.UseVisualStyleBackColor = true;
            this.buttonEditParameters.Click += new System.EventHandler(this.buttonEditParameters_Click);
            // 
            // tabControlRegistration
            // 
            this.tabControlRegistration.Controls.Add(this.tabPageRigid);
            this.tabControlRegistration.Controls.Add(this.tabPageNonRigid);
            this.tabControlRegistration.Controls.Add(this.tabPageTransform);
            this.tabControlRegistration.Controls.Add(this.tabPageSequentialReg);
            this.tabControlRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRegistration.Location = new System.Drawing.Point(0, 0);
            this.tabControlRegistration.Name = "tabControlRegistration";
            this.tabControlRegistration.SelectedIndex = 0;
            this.tabControlRegistration.Size = new System.Drawing.Size(790, 348);
            this.tabControlRegistration.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonSeqNoMasking);
            this.groupBox3.Controls.Add(this.radioButtonSeqInnerMasks);
            this.groupBox3.Controls.Add(this.radioButtonSeqWholeMasks);
            this.groupBox3.Location = new System.Drawing.Point(384, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 95);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Masking Rigid";
            // 
            // radioButtonSeqNoMasking
            // 
            this.radioButtonSeqNoMasking.AutoSize = true;
            this.radioButtonSeqNoMasking.Location = new System.Drawing.Point(7, 21);
            this.radioButtonSeqNoMasking.Name = "radioButtonSeqNoMasking";
            this.radioButtonSeqNoMasking.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSeqNoMasking.TabIndex = 14;
            this.radioButtonSeqNoMasking.Text = "None";
            this.radioButtonSeqNoMasking.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeqInnerMasks
            // 
            this.radioButtonSeqInnerMasks.AutoSize = true;
            this.radioButtonSeqInnerMasks.Location = new System.Drawing.Point(7, 68);
            this.radioButtonSeqInnerMasks.Name = "radioButtonSeqInnerMasks";
            this.radioButtonSeqInnerMasks.Size = new System.Drawing.Size(180, 17);
            this.radioButtonSeqInnerMasks.TabIndex = 12;
            this.radioButtonSeqInnerMasks.Text = "Do registration of inner structures";
            this.radioButtonSeqInnerMasks.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeqWholeMasks
            // 
            this.radioButtonSeqWholeMasks.AutoSize = true;
            this.radioButtonSeqWholeMasks.Checked = true;
            this.radioButtonSeqWholeMasks.Location = new System.Drawing.Point(7, 44);
            this.radioButtonSeqWholeMasks.Name = "radioButtonSeqWholeMasks";
            this.radioButtonSeqWholeMasks.Size = new System.Drawing.Size(169, 17);
            this.radioButtonSeqWholeMasks.TabIndex = 11;
            this.radioButtonSeqWholeMasks.TabStop = true;
            this.radioButtonSeqWholeMasks.Text = "Do registration of whole masks";
            this.radioButtonSeqWholeMasks.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(790, 501);
            this.Controls.Add(this.splitContainer3);
            this.Name = "RegistrationForm";
            this.Text = "Registration Overview";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBoxMaskingGeneral.ResumeLayout(false);
            this.groupBoxMaskingGeneral.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRegOrder.ResumeLayout(false);
            this.groupBoxRegOrder.PerformLayout();
            this.tabPageSequentialReg.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.tabPageTransform.ResumeLayout(false);
            this.tabPageTransform.PerformLayout();
            this.groupBoxHowToCompose.ResumeLayout(false);
            this.groupBoxHowToCompose.PerformLayout();
            this.groupBoxInterpolation.ResumeLayout(false);
            this.groupBoxInterpolation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefaultPixelValue)).EndInit();
            this.tabPageNonRigid.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBoxTransformationNonRigid.ResumeLayout(false);
            this.groupBoxTransformationNonRigid.PerformLayout();
            this.groupBoxPenalty.ResumeLayout(false);
            this.groupBoxPenalty.PerformLayout();
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.tabPageRigid.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxTransformationRigid.ResumeLayout(false);
            this.groupBoxTransformationRigid.PerformLayout();
            this.groupBoxMaskRigid.ResumeLayout(false);
            this.groupBoxMaskRigid.PerformLayout();
            this.tabControlRegistration.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSegmentationParams;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRigid;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRegOrder;
        private System.Windows.Forms.RadioButton radioButtonUsePrevInStack;
        private System.Windows.Forms.RadioButton radioButtonMiddleStack;
        private System.Windows.Forms.RadioButton radioButtonLastInStack;
        private System.Windows.Forms.RadioButton radioButtonFirstFromStack;
        private System.Windows.Forms.Button buttonSegmentationInnerstructures;
        private System.Windows.Forms.GroupBox groupBoxMaskingGeneral;
        private System.Windows.Forms.RadioButton radioButtonFixedAndMovingMask;
        private System.Windows.Forms.RadioButton radioButtonOnlyMovingMask;
        private System.Windows.Forms.RadioButton radioButtonOnlyFixedMask;
        private System.Windows.Forms.RadioButton radioButtonNoMask;
        private System.ComponentModel.BackgroundWorker backgroundWorkerNonRigid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonInnerStructures;
        private System.Windows.Forms.RadioButton radioButtonWholeTissue;
        private System.Windows.Forms.RadioButton radioButtonPreDefMasks;
        private System.Windows.Forms.Button buttonLoadMasks;
        private System.Windows.Forms.OpenFileDialog openFileDialogTransformParam;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSequential;
        private System.Windows.Forms.OpenFileDialog openFileDialogParamFile;
        private System.Windows.Forms.TabControl tabControlRegistration;
        private System.Windows.Forms.TabPage tabPageRigid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonEditParameters;
        private System.Windows.Forms.GroupBox groupBoxMaskRigid;
        private System.Windows.Forms.RadioButton radioButtonRigidNoMasking;
        private System.Windows.Forms.RadioButton radioButtonComponent;
        private System.Windows.Forms.RadioButton radioButtonMaskInner;
        private System.Windows.Forms.RadioButton radioButtonMaskWhole;
        private System.Windows.Forms.GroupBox groupBoxTransformationRigid;
        private System.Windows.Forms.RadioButton radioButtonAffine;
        private System.Windows.Forms.RadioButton radioButtonRigid;
        private System.Windows.Forms.RadioButton radioButtonSimilarity;
        private System.Windows.Forms.RadioButton radioButtonTranslation;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonEvaluation;
        private System.Windows.Forms.Button buttonStartRegistration;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxConsoleRigid;
        private System.Windows.Forms.ProgressBar progressBarRigid;
        private System.Windows.Forms.TabPage tabPageNonRigid;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.CheckBox checkBoxUseCoefficientmap;
        private System.Windows.Forms.CheckBox checkBoxJaccobian;
        private System.Windows.Forms.Button buttonEditParamsNonRigid;
        private System.Windows.Forms.GroupBox groupBoxPenalty;
        private System.Windows.Forms.RadioButton radioButtonDistancePreserving;
        private System.Windows.Forms.RadioButton radioButtonBendEnergy;
        private System.Windows.Forms.RadioButton radioButtonTransformRigidity;
        private System.Windows.Forms.RadioButton radioButtonNoPenalties;
        private System.Windows.Forms.GroupBox groupBoxTransformationNonRigid;
        private System.Windows.Forms.RadioButton radioButtonSplineRecursive;
        private System.Windows.Forms.RadioButton radioButtonKernelSpline;
        private System.Windows.Forms.RadioButton radioButtonBsplineDiffusion;
        private System.Windows.Forms.RadioButton radioButtonAdvancedBspline;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button buttonEvaluateNonRigidReg;
        private System.Windows.Forms.Button buttonStartNonRigidRegistration;
        private System.Windows.Forms.Button buttonCancelNonRigidReg;
        private System.Windows.Forms.TextBox textBoxConsoleNonRigid;
        private System.Windows.Forms.ProgressBar progressBarNonRigid;
        private System.Windows.Forms.TabPage tabPageTransform;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownDefaultPixelValue;
        private System.Windows.Forms.GroupBox groupBoxInterpolation;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ComboBox comboBoxInterpolationOrder;
        private System.Windows.Forms.RadioButton radioButtonBSpline;
        private System.Windows.Forms.RadioButton radioButtonNN;
        private System.Windows.Forms.RadioButton radioButtonLinear;
        private System.Windows.Forms.GroupBox groupBoxHowToCompose;
        private System.Windows.Forms.RadioButton radioButtonCompose;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button buttonChooseParamFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTransformParams;
        private System.Windows.Forms.TabPage tabPageSequentialReg;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TreeView treeViewParamFiles;
        private System.Windows.Forms.Button buttonRemoveParamFile;
        private System.Windows.Forms.Button buttonShowFile;
        private System.Windows.Forms.Button buttonAddParamFile;
        private System.Windows.Forms.Label labelParamFiles;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Button buttonEvaluateRegSequential;
        private System.Windows.Forms.Button buttonStartRegSequential;
        private System.Windows.Forms.Button buttonCancelRegSequential;
        private System.Windows.Forms.TextBox textBoxRegSequential;
        private System.Windows.Forms.ProgressBar progressBarRegSequential;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonSeqNoMasking;
        private System.Windows.Forms.RadioButton radioButtonSeqInnerMasks;
        private System.Windows.Forms.RadioButton radioButtonSeqWholeMasks;
    }
}