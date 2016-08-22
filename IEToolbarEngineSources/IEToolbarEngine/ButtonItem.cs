using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using SHDocVw;
using mshtml;


namespace IEToolbarEngine
{
    internal class ButtonItem:BaseToolbarItem
    {

        #region "Data Members"

        //private ShowToolbarBHO test;
        private ToolStripButton toolbarButton;

        public ToolStripButton ToolbarButton
        {
            get { return toolbarButton; }
            set { toolbarButton = value; }
        }
        private HTMLDocument document;

        bool ignoreIndexChange = false;
        bool firstClick = true;
        Color originalColor;
        private InternetExplorer ie;

        #endregion;

        internal ButtonItem(IEToolbarEngine engine, string buttonText, string buttonToolTipText, InternetExplorer internetExplorer, Size inputBoxSize, Image img)
            : base(engine, img)
        {
            Create(buttonText, buttonToolTipText, inputBoxSize, internetExplorer);
        }

        public override ToolbarItemType TypeID
        {
            get { return ToolbarItemType.ButtonItem; }
        }

        internal void Create(string buttonText, string buttonToolTipText, Size inputBoxSize, InternetExplorer internetExplorer)
        {

            Reset();

            this.toolbarButton = new ToolStripButton();
            //this.ie = internetExplorer;
            //
            //label
            //
            this.toolbarButton.Text = buttonText;
            this.toolbarButton.ToolTipText = buttonToolTipText;
            this.toolbarButton.Image = this.Image;
            this.toolbarButton.ImageAlign = ContentAlignment.MiddleRight;
            this.toolbarButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            this.toolbarButton.ImageScaling = ToolStripItemImageScaling.None;
            this.toolbarButton.Size = inputBoxSize;
            this.toolbarButton.ForeColor = Color.Gray;

            items.Add(toolbarButton);            

            engine.Toolbar.Items.AddRange(this.items.ToArray());
        }

        
    }
}
