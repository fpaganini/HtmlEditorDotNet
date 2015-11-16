using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Samples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HtmlEditor1.ToolBar_Bold = chkBold.Checked;
            HtmlEditor1.ToolBar_Italic = chkItalic.Checked;
            HtmlEditor1.ToolBar_Underline = chkUnderline.Checked;
            HtmlEditor1.ToolBar_StrikeThrough = chkStrykethrough.Checked;
            HtmlEditor1.ToolBar_Subscript = chkSubscript.Checked;
            HtmlEditor1.ToolBar_Superscript = chkSuperscript.Checked;
            HtmlEditor1.ToolBar_Undo = chkUndo.Checked;
            HtmlEditor1.ToolBar_Redo = chkRedo.Checked;
            HtmlEditor1.ToolBar_ClearFormatting = chkClear.Checked;
            HtmlEditor1.ToolBar_SelectAll = chkSelectAll.Checked;              

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            ltrResult.Text = HtmlEditor1.HTML;
        }
    }
}