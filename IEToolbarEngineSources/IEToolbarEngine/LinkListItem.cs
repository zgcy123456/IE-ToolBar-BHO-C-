using mshtml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace IEToolbarEngine
{
    internal class LinkListItem: BaseToolbarItem
    {

        //public HTMLDocument document = ShowToolboorBHO.document;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="engine">Toolbar engine</param>
        internal LinkListItem(IEToolbarEngine engine, 
            string caption,  
            string hint, 
            KeyValuePair<string, string>[] links, System.Drawing.Image img)
            : base(engine, img)
        {
            this.Create(caption, hint, links);   
        }

        public override ToolbarItemType TypeID
        {
            get { return ToolbarItemType.LinkList; }
        }

        public void Create (string buttonText,
            string buttonTooltip,            
            KeyValuePair<string,string> [] links)
        {

            this.linkListButton = new System.Windows.Forms.ToolStripSplitButton ();

            this.linkListButton.Image = this.Image;            
            this.linkListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkListButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.linkListButton.Text = buttonText;
            this.linkListButton.ToolTipText = buttonTooltip;

            this.linkListButton.ButtonClick += new EventHandler (linkListButton_Click);

            foreach (KeyValuePair <string,string> link in links)
            {
                if (string.IsNullOrEmpty (link.Key))
                {
                    this.linkListButton.DropDownItems.Add (new System.Windows.Forms.ToolStripSeparator ());
                }
                else
                {
                    System.Windows.Forms.ToolStripItem menuItem = this.linkListButton.DropDownItems.Add (link.Key);
                    menuItem.Tag = link.Value;                    
                    menuItem.Click += new EventHandler (menuItem_Click);
                }
            }


            items.Add (this.linkListButton);
            engine.Toolbar.Items.AddRange (this.items.ToArray ());
        }

        void linkListButton_Click (object sender, EventArgs e)
        {
            this.linkListButton.DropDown.Visible = true;
        }

        void menuItem_Click (object sender, EventArgs e)
        {
            
            System.Windows.Forms.ToolStripMenuItem menuItem = sender as System.Windows.Forms.ToolStripMenuItem;
            this.engine.SmartNavigate (menuItem.Tag.ToString ());
        }


        private System.Windows.Forms.ToolStripSplitButton linkListButton; 
    }
}
