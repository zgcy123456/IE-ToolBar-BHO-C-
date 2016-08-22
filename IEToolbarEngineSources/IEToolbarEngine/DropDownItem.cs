using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace IEToolbarEngine
{
    internal class DropDownItem:BaseToolbarItem
    {

        private System.Windows.Forms.ToolStripComboBox comboBox;

        public System.Windows.Forms.ToolStripComboBox ComboBox
        {
            get { return comboBox; }
            set { comboBox = value; }
        }

        private System.Windows.Forms.ToolStripLabel titleLabel;

        bool ignoreIndexChange = false;
        bool firstClick = true;
        Color originalColor;



        //string clearHistoryText;
        //string greetingText;
        //string searchURL;

        internal DropDownItem(IEToolbarEngine engine, string labelText, string labelToolTipText, string comboBoxText, string comboBoxToolTipText, Size comboBoxSize,List<ToolStripMenuItem> initItem, FlatStyle inputBoxFlatStyle, Image img)
            : base(engine, img)
        {
            Create(labelText, labelToolTipText, comboBoxText, comboBoxToolTipText, comboBoxSize,initItem, inputBoxFlatStyle);
        }

        public override ToolbarItemType TypeID
        {
            get { return ToolbarItemType.ListDropDown; }
        }

        internal void Create(string labelText, string labelToolTipText, string comboBoxText, string comboBoxToolTipText, Size comboBoxSize, List<ToolStripMenuItem> initItem, FlatStyle inputBoxFlatStyle)
        {

            //this.clearHistoryText = clearHistoryText;
            //this.greetingText = greetingText;
            //this.searchURL = searchURL;

            Reset();

            this.titleLabel = new System.Windows.Forms.ToolStripLabel();
            this.comboBox = new System.Windows.Forms.ToolStripComboBox();

            //
            //label
            //
            this.titleLabel.Text = labelText;
            this.titleLabel.ToolTipText = comboBoxToolTipText;
            this.titleLabel.Image = this.Image;
            this.titleLabel.ImageAlign = ContentAlignment.MiddleRight;
            this.titleLabel.TextImageRelation = TextImageRelation.TextBeforeImage;
            this.titleLabel.ImageScaling = ToolStripItemImageScaling.None;

            //
            //comboBox
            //
            this.comboBox.Size = comboBoxSize;
            this.comboBox.FlatStyle = inputBoxFlatStyle;
            this.comboBox.ToolTipText = labelToolTipText;
            this.comboBox.ForeColor = Color.Gray;
            this.comboBox.Text = comboBoxText;
            if (null != initItem)
            {
                this.comboBox.Items.AddRange(initItem.ToArray());
            }
            this.comboBox.GotFocus += new EventHandler(comboBox_GotFocus);
            this.comboBox.LostFocus += new EventHandler(comboBox_LostFocus);
            //this.searchInputBox.SelectedIndexChanged += new System.EventHandler();
            //this.searchInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler();
            //this.searchInputBox.Click += new System.EventHandler();

            //originalColor = this.comboBox.ForeColor;
            
            //searchInputBox.GotFocus += new EventHandler(searchInputBox);
            //searchInputBox.LostFocus += new EventHandler();

            items.Add(titleLabel);
            items.Add(comboBox);
            
            engine.Toolbar.Items.AddRange(this.items.ToArray());
        }

        private void comboBox_LostFocus(object sender, EventArgs e)
        {
            this.engine.InternalLostFocus(e);
        }

        private void comboBox_GotFocus(object sender, EventArgs e)
        {
            this.engine.InternalGotFocus(e);
        }

    }
}
