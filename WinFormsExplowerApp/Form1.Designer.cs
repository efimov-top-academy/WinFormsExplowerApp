namespace WinFormsExplowerApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstViewPath = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            imgListFileTypes = new ImageList(components);
            imgListSmall = new ImageList(components);
            imgListList = new ImageList(components);
            radioViewLarge = new RadioButton();
            radioSmall = new RadioButton();
            radioTile = new RadioButton();
            radioList = new RadioButton();
            treePath = new TreeView();
            SuspendLayout();
            // 
            // lstViewPath
            // 
            lstViewPath.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstViewPath.LargeImageList = imgListFileTypes;
            lstViewPath.Location = new Point(384, 54);
            lstViewPath.Name = "lstViewPath";
            lstViewPath.Size = new Size(423, 383);
            lstViewPath.SmallImageList = imgListSmall;
            lstViewPath.StateImageList = imgListList;
            lstViewPath.TabIndex = 2;
            lstViewPath.UseCompatibleStateImageBehavior = false;
            lstViewPath.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Type";
            // 
            // imgListFileTypes
            // 
            imgListFileTypes.ColorDepth = ColorDepth.Depth8Bit;
            imgListFileTypes.ImageStream = (ImageListStreamer)resources.GetObject("imgListFileTypes.ImageStream");
            imgListFileTypes.TransparentColor = Color.Transparent;
            imgListFileTypes.Images.SetKeyName(0, "docx.png");
            imgListFileTypes.Images.SetKeyName(1, "file.png");
            imgListFileTypes.Images.SetKeyName(2, "folder.png");
            imgListFileTypes.Images.SetKeyName(3, "jpg.png");
            imgListFileTypes.Images.SetKeyName(4, "pdf.png");
            imgListFileTypes.Images.SetKeyName(5, "png.png");
            imgListFileTypes.Images.SetKeyName(6, "txt.png");
            // 
            // imgListSmall
            // 
            imgListSmall.ColorDepth = ColorDepth.Depth8Bit;
            imgListSmall.ImageStream = (ImageListStreamer)resources.GetObject("imgListSmall.ImageStream");
            imgListSmall.TransparentColor = Color.Transparent;
            imgListSmall.Images.SetKeyName(0, "docx.png");
            imgListSmall.Images.SetKeyName(1, "file.png");
            imgListSmall.Images.SetKeyName(2, "folder.png");
            imgListSmall.Images.SetKeyName(3, "jpg.png");
            imgListSmall.Images.SetKeyName(4, "pdf.png");
            imgListSmall.Images.SetKeyName(5, "png.png");
            imgListSmall.Images.SetKeyName(6, "txt.png");
            // 
            // imgListList
            // 
            imgListList.ColorDepth = ColorDepth.Depth8Bit;
            imgListList.ImageStream = (ImageListStreamer)resources.GetObject("imgListList.ImageStream");
            imgListList.TransparentColor = Color.Transparent;
            imgListList.Images.SetKeyName(0, "docx.png");
            imgListList.Images.SetKeyName(1, "file.png");
            imgListList.Images.SetKeyName(2, "folder.png");
            imgListList.Images.SetKeyName(3, "jpg.png");
            imgListList.Images.SetKeyName(4, "pdf.png");
            imgListList.Images.SetKeyName(5, "png.png");
            imgListList.Images.SetKeyName(6, "txt.png");
            // 
            // radioViewLarge
            // 
            radioViewLarge.AutoSize = true;
            radioViewLarge.Location = new Point(384, 12);
            radioViewLarge.Name = "radioViewLarge";
            radioViewLarge.Size = new Size(113, 19);
            radioViewLarge.TabIndex = 4;
            radioViewLarge.TabStop = true;
            radioViewLarge.Text = "View Large Icons";
            radioViewLarge.UseVisualStyleBackColor = true;
            radioViewLarge.CheckedChanged += RadioView_CheckedChanged;
            // 
            // radioSmall
            // 
            radioSmall.AutoSize = true;
            radioSmall.Location = new Point(512, 12);
            radioSmall.Name = "radioSmall";
            radioSmall.Size = new Size(113, 19);
            radioSmall.TabIndex = 4;
            radioSmall.TabStop = true;
            radioSmall.Text = "View Small Icons";
            radioSmall.UseVisualStyleBackColor = true;
            radioSmall.CheckedChanged += RadioView_CheckedChanged;
            // 
            // radioTile
            // 
            radioTile.AutoSize = true;
            radioTile.Location = new Point(644, 12);
            radioTile.Name = "radioTile";
            radioTile.Size = new Size(71, 19);
            radioTile.TabIndex = 4;
            radioTile.TabStop = true;
            radioTile.Text = "View Tile";
            radioTile.UseVisualStyleBackColor = true;
            radioTile.CheckedChanged += RadioView_CheckedChanged;
            // 
            // radioList
            // 
            radioList.AutoSize = true;
            radioList.Location = new Point(736, 12);
            radioList.Name = "radioList";
            radioList.Size = new Size(71, 19);
            radioList.TabIndex = 4;
            radioList.TabStop = true;
            radioList.Text = "View List";
            radioList.UseVisualStyleBackColor = true;
            radioList.CheckedChanged += RadioView_CheckedChanged;
            // 
            // treePath
            // 
            treePath.Location = new Point(27, 54);
            treePath.Name = "treePath";
            treePath.Size = new Size(321, 383);
            treePath.TabIndex = 5;
            treePath.BeforeExpand += treePath_BeforeExpand;
            treePath.AfterSelect += treePath_AfterSelect;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 500);
            Controls.Add(treePath);
            Controls.Add(radioList);
            Controls.Add(radioTile);
            Controls.Add(radioSmall);
            Controls.Add(radioViewLarge);
            Controls.Add(lstViewPath);
            Name = "Form1";
            Text = "Explower";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lstViewPath;
        private ImageList imgListFileTypes;
        private RadioButton radioViewLarge;
        private RadioButton radioSmall;
        private RadioButton radioTile;
        private RadioButton radioList;
        private ImageList imgListSmall;
        private ImageList imgListList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TreeView treePath;
    }
}