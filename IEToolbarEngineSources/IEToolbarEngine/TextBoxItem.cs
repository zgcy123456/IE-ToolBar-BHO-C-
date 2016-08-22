using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IEToolbarEngine
{
    internal class TextBoxItem:BaseToolbarItem
    {
        #region "Data Members"

        private ToolStripLabel label;
        private ToolStripTextBox inputTextBox;
        
        public ToolStripTextBox InputTextBox
        {
            get { return inputTextBox; }
            set { inputTextBox = value; }
        }
        

        bool ignoreIndexChange = false;
        bool firstClick = true;
        Color originalColor;

        #endregion;

        #region "Item Options"

        string clearHistoryText;
        string greetingText;
        string searchURL;

        #endregion;


        internal TextBoxItem(IEToolbarEngine engine, string labelText, string labelToolTipText, string inputBoxToolTipText, Size inputBoxSize, Image img)
            : base(engine, img)
        {
            Create(labelText, labelToolTipText, inputBoxToolTipText, inputBoxSize);
        }

        public override ToolbarItemType TypeID
        {
            get { return ToolbarItemType.TextBoxItem; }
        }

        internal void Create(string labelText, string labelToolTipText, string inputBoxToolTipText, Size inputBoxSize)
        {

            //this.clearHistoryText = clearHistoryText;
            //this.greetingText = greetingText;
            //this.searchURL = searchURL;

            Reset();

            this.label = new ToolStripLabel();
            this.inputTextBox = new ToolStripTextBox();

            //
            //label
            //
            this.label.Text = labelText;
            this.label.ToolTipText = inputBoxToolTipText;
            this.label.Image = this.Image;
            this.label.ImageAlign = ContentAlignment.MiddleRight;
            this.label.TextImageRelation = TextImageRelation.TextBeforeImage;
            this.label.ImageScaling = ToolStripItemImageScaling.None;

            //
            //comboBox
            //
            this.inputTextBox.Size = inputBoxSize;            
            this.inputTextBox.ToolTipText = labelToolTipText;
            this.inputTextBox.ForeColor = Color.Gray;
            //this.searchInputBox.SelectedIndexChanged += new System.EventHandler();
            //this.searchInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler();
            //this.searchInputBox.Click += new System.EventHandler();

            //originalColor = this.comboBox.ForeColor;
            
            //searchInputBox.GotFocus += new EventHandler(searchInputBox);
            //searchInputBox.LostFocus += new EventHandler();

            items.Add(label);
            items.Add(inputTextBox);

            //待查 这句是什么作用
            //engine.LoadSearchHistory(this);
            engine.Toolbar.Items.AddRange(this.items.ToArray());
        }

    }
}
