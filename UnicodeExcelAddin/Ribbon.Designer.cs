namespace UnicodeExcelAddin
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            this.tabMain = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.btnSelectedText = this.Factory.CreateRibbonButton();
            this.box2 = this.Factory.CreateRibbonBox();
            this.btnWholeText = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnSearchWord = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btnSorting = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.box7 = this.Factory.CreateRibbonBox();
            this.button7 = this.Factory.CreateRibbonButton();
            this.box8 = this.Factory.CreateRibbonBox();
            this.button8 = this.Factory.CreateRibbonButton();
            this.tabMain.SuspendLayout();
            this.group1.SuspendLayout();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.group4.SuspendLayout();
            this.box7.SuspendLayout();
            this.box8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Groups.Add(this.group1);
            this.tabMain.Groups.Add(this.group2);
            this.tabMain.Groups.Add(this.group3);
            this.tabMain.Groups.Add(this.group4);
            this.tabMain.Label = "MMNLP Unicode";
            this.tabMain.Name = "tabMain";
            // 
            // group1
            // 
            this.group1.Items.Add(this.box1);
            this.group1.Items.Add(this.box2);
            this.group1.Label = "Unicode Conversion";
            this.group1.Name = "group1";
            // 
            // box1
            // 
            this.box1.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical;
            this.box1.Items.Add(this.btnSelectedText);
            this.box1.Name = "box1";
            // 
            // btnSelectedText
            // 
            this.btnSelectedText.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSelectedText.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectedText.Image")));
            this.btnSelectedText.Label = "Convert SelectedText";
            this.btnSelectedText.Name = "btnSelectedText";
            this.btnSelectedText.ShowImage = true;
            this.btnSelectedText.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSelectedText_Click);
            // 
            // box2
            // 
            this.box2.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical;
            this.box2.Items.Add(this.btnWholeText);
            this.box2.Name = "box2";
            // 
            // btnWholeText
            // 
            this.btnWholeText.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnWholeText.Image = ((System.Drawing.Image)(resources.GetObject("btnWholeText.Image")));
            this.btnWholeText.Label = "Convert Whole Text";
            this.btnWholeText.Name = "btnWholeText";
            this.btnWholeText.ShowImage = true;
            this.btnWholeText.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnWholeText_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnSearchWord);
            this.group2.Label = "Exact Searching";
            this.group2.Name = "group2";
            // 
            // btnSearchWord
            // 
            this.btnSearchWord.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSearchWord.Image = global::UnicodeExcelAddin.Properties.Resources.icon_3;
            this.btnSearchWord.Label = "Search Word";
            this.btnSearchWord.Name = "btnSearchWord";
            this.btnSearchWord.ShowImage = true;
            this.btnSearchWord.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSearchWord_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.btnSorting);
            this.group3.Label = "Exact Searching";
            this.group3.Name = "group3";
            // 
            // btnSorting
            // 
            this.btnSorting.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSorting.Image = global::UnicodeExcelAddin.Properties.Resources.icon_4;
            this.btnSorting.Label = "Myanmar Unicode Sorting";
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.ShowImage = true;
            this.btnSorting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSorting_Click);
            // 
            // group4
            // 
            this.group4.Items.Add(this.box7);
            this.group4.Items.Add(this.box8);
            this.group4.Label = "Segmentation";
            this.group4.Name = "group4";
            // 
            // box7
            // 
            this.box7.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical;
            this.box7.Items.Add(this.button7);
            this.box7.Name = "box7";
            // 
            // button7
            // 
            this.button7.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button7.ImageName = "p";
            this.button7.Label = "Word Break";
            this.button7.Name = "button7";
            this.button7.ShowImage = true;
            // 
            // box8
            // 
            this.box8.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical;
            this.box8.Items.Add(this.button8);
            this.box8.Name = "box8";
            // 
            // button8
            // 
            this.button8.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button8.ImageName = "p";
            this.button8.Label = "Phrase Break";
            this.button8.Name = "button8";
            this.button8.ShowImage = true;
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabMain);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.box7.ResumeLayout(false);
            this.box7.PerformLayout();
            this.box8.ResumeLayout(false);
            this.box8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabMain;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSelectedText;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnWholeText;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSearchWord;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSorting;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
