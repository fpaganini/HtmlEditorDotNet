using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InHTML
{
    public partial class htmleditor : System.Web.UI.UserControl
    {
        public bool ToolBar_Bold { get; set; } = true;
        public bool ToolBer_Italic { get; set; } = true;
        public bool ToolBar_Underscore { get; set; } = true;
        public bool ToolBar_Stryke { get; set; } = true;
        public bool ToolBar_SubScript { get; set; } = true;
        public bool ToolBar_SuperScript { get; set; } = true;
        public bool ToolBar_DecreaseIndent { get; set; } = true;
        public bool ToolBar_IncreaseIndent { get; set; } = true;
        public bool ToolBar_InsertHorizontalLine { get; set; } = true;
        public bool ToolBar_Undo { get; set; } = true;
        public bool ToolBar_Redo { get; set; } = true;
        public bool ToolBar_Clear { get; set; } = true;
        public bool ToolBar_Select { get; set; } = true;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}