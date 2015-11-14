using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace br.com.pgnsoft.web
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:htmlEditor runat=server></{0}:htmlEditor>")]
    public class htmlEditor : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string HTML
        {
            get
            {
                String s = (String)ViewState["HTML"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["HTML"] = value;
            }
        }

        private bool ToolBar_FullScreen { get; set; } = true;
        public bool ToolBar_Bold { get; set; } = true;
        public bool ToolBar_Italic { get; set; } = true;
        public bool ToolBar_Underline { get; set; } = true;
        public bool ToolBar_StrikeThrough { get; set; } = true;
        public bool ToolBar_Subscript { get; set; } = true;
        public bool ToolBar_Superscript { get; set; } = true;
        private bool ToolBar_FontFamily { get; set; } = true;
        private bool ToolBar_FontSize { get; set; } = true;
        private bool ToolBar_Color { get; set; } = true;
        private bool ToolBar_Emoticons { get; set; } = true;
        private bool ToolBar_Align { get; set; } = true;
        private bool ToolBar_ParagraphStyle { get; set; } = true;
        private bool ToolBar_ParagraphFormat { get; set; } = true;
        private bool ToolBar_InlineStyle { get; set; } = true;
        private bool ToolBar_FormatOL { get; set; } = true;
        private bool ToolBar_FormatUL { get; set; } = true;
        private bool ToolBar_Quote { get; set; } = true;
        private bool ToolBar_Indent { get; set; } = true;
        private bool ToolBar_InsertHR { get; set; } = true;
        private bool ToolBar_Outdent { get; set; } = true;
        private bool ToolBar_InsertLink { get; set; } = true;
        private bool ToolBar_InsertImage { get; set; } = true;
        private bool ToolBar_InsertVideo { get; set; } = true;
        private bool ToolBar_InsertTable { get; set; } = true;
        private bool ToolBar_InsertFile { get; set; } = true;
        private bool ToolBar_HTML { get; set; } = true;
        public  bool ToolBar_ClearFormatting { get; set; } = true;
        public bool ToolBar_DecreaseIndent { get; set; } = true;
        public bool ToolBar_IncreaseIndent { get; set; } = true;
        public bool ToolBar_InsertLine { get; set; } = true;
        public bool ToolBar_Undo { get; set; } = true;
        public bool ToolBar_Redo { get; set; } = true;
        public bool ToolBar_SelectAll { get; set; } = true;

        [UrlProperty()]
        public string TranslateFile { get; set; } = "";


        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
        }

        protected override void OnInit(EventArgs e)
        {
            if (this.Context.Request["htmlEditor1_value"] != null)
            {
                HTML = GetHTML(this.Context.Request[this.UniqueID + "_value"]);
            }

            base.OnInit(e);
             
            this.Page.Header.Controls.Add(new LiteralControl("<link rel='stylesheet' type='text/css' href='" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.fonts.font-awesome.css") + "' ></link>"));
            this.Page.Header.Controls.Add(new LiteralControl("<link rel='stylesheet' type='text/css' href='" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.css.css") + "' ></link>"));
            this.Page.Header.Controls.Add(new LiteralControl("<script type='text/javascript' src='" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.js1.js") + "' ></script>"));
            this.Page.Header.Controls.Add(new LiteralControl("<script type='text/javascript' src='" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.js2.js") + "' ></script>"));

        }

        private string GetHTML(string v)
        {
            v = v.Replace("&quot;","\"");
            v = v.Replace("&gt;", ">");
            v = v.Replace("&lt;", "<");
            v = v.Replace("&amp;", "&");

            return v;
        }

        protected override void RenderContents(HtmlTextWriter output)
        {

            output.Write("<style>");
            output.Write("@font-face { font-family: 'FontAwesome'; ");
            output.Write("src: url('" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.fonts.fontawesome-webfont.eot") + "');");
            output.Write("src: url('" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.fonts.fontawesome-webfont.eot") + "') format('embedded-opentype') ,");
            output.Write(" url('" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.fonts.fontawesome-webfont.woff2") + "') format('woff2') ,");
            output.Write(" url('" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.fonts.fontawesome-webfont.woff") + "') format('woff') ,");
            output.Write(" url('" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.fonts.fontawesome-webfont.ttf") + "') format('truetype') ,");
            output.Write(" url('" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.fonts.fontawesome-webfont.svg") + "') format('svg') ;");
            output.Write("font-weight: normal;font-style: normal; }");

            

            output.Write("</style>");

            

            output.Write("<script>");
            
            output.Write("var bold='" + ( ToolBar_Bold ? "bold":"" )
                + "' , fullscreen = '" + (ToolBar_FullScreen ? "fullscreen" : "")
                + "' , italic = '" + ( ToolBar_Italic ? "italic":"" ) 
                + "', underline = '" + ( ToolBar_Underline ? "underline":"" ) 
                + "', strikeThrough = '" + ( ToolBar_StrikeThrough ? "strikeThrough":"" ) 
                + "', subscript = '" + ( ToolBar_Subscript ? "subscript":"" ) 
                + "', superscript = '" + ( ToolBar_Superscript ? "superscript":"" ) 
                + "', fontFamily = '" + ( ToolBar_FontFamily ? "fontFamily":"" ) 
                + "', fontSize = '" + ( ToolBar_FontSize ? "fontSize":"" ) 
                + "', color = '" + ( ToolBar_Color ? "color":"" ) 
                + "', emoticons = '" + ( ToolBar_Emoticons ? "emoticons":"" ) 
                + "', inlineStyle ='" + ( ToolBar_InlineStyle ? "inlineStyle":"" ) 
                + "', paragraphStyle = '" + ( ToolBar_ParagraphStyle ? "paragraphStyle":"" ) 
                + "', paragraphFormat = '" + ( ToolBar_ParagraphFormat ? "paragraphFormat":"" ) 
                + "', align = '" + ( ToolBar_Align ? "align":"" ) 
                + "', formatOL = '" + ( ToolBar_FormatOL ? "formatOL":"" ) 
                + "', formatUL = '" + ( ToolBar_FormatUL ? "formatUL":"" ) 
                + "', outdent = '" + ( ToolBar_Outdent ? "outdent":"" ) 
                + "', indent = '" + ( ToolBar_Indent ? "indent":"" ) 
                + "', quote = '" + ( ToolBar_Quote ? "quote":"" ) 
                + "', insertHR = '" + ( ToolBar_InsertHR ? "insertHR":"" ) 
                + "', insertLine = '" + ( ToolBar_InsertLine ? "-":"" ) 
                + "', insertLink = '" + ( ToolBar_InsertLink ? "insertLink":"" ) 
                + "', insertImage = '" + ( ToolBar_InsertImage ? "insertImage":"" ) 
                + "', insertVideo = '" + ( ToolBar_InsertVideo ? "insertVideo":"" ) 
                + "', insertFile = '" + ( ToolBar_InsertFile ? "insertFile":"" ) 
                + "', insertTable = '" + ( ToolBar_InsertTable ? "insertTable":"" ) 
                + "', undo = '" + ( ToolBar_Undo ? "undo":"" ) 
                + "', redo = '" + ( ToolBar_Redo ? "redo":"" ) 
                + "', clearFormatting = '" + ( ToolBar_ClearFormatting ? "clearFormatting":"" )
                + "', selectAll = '" + ( ToolBar_SelectAll ? "selectAll":"" ) 
                + "', html =  '" + ( ToolBar_HTML ? "html":"" ) + "';");
            //output.Write("toolbarButtonsXS: ['fullscreen', 'bold', 'italic', 'underline', 'strikeThrough', 'subscript', 'superscript', 'fontFamily', 'fontSize', '|', 'color', 'emoticons', 'inlineStyle', 'paragraphStyle', '|', 'paragraphFormat', 'align', 'formatOL', 'formatUL', 'outdent', 'indent', 'quote', 'insertHR', '-', 'insertLink', 'insertImage', 'insertVideo', 'insertFile', 'insertTable', 'undo', 'redo', 'clearFormatting', 'selectAll', 'html'],              toolbarButtonsSM: ['fullscreen', 'bold', 'italic', 'underline', 'strikeThrough', 'subscript', 'superscript', 'fontFamily', 'fontSize', '|', 'color', 'emoticons', 'inlineStyle', 'paragraphStyle', '|', 'paragraphFormat', 'align', 'formatOL', 'formatUL', 'outdent', 'indent', 'quote', 'insertHR', '-', 'insertLink', 'insertImage', 'insertVideo', 'insertFile', 'insertTable', 'undo', 'redo', 'clearFormatting', 'selectAll', 'html'],              toolbarButtonsMD: ['fullscreen', 'bold', 'italic', 'underline', 'strikeThrough', 'subscript', 'superscript', 'fontFamily', 'fontSize', '|', 'color', 'emoticons', 'inlineStyle', 'paragraphStyle', '|', 'paragraphFormat', 'align', 'formatOL', 'formatUL', 'outdent', 'indent', 'quote', 'insertHR', '-', 'insertLink', 'insertImage', 'insertVideo', 'insertFile', 'insertTable', 'undo', 'redo', 'clearFormatting', 'selectAll', 'html'],              toolbarStickyOffset: 0          });"); 
            //output.Write("a.pgn_htmlEditor.MODULES.toolbar = function (b) {              function c() {                  var a = b.button.buildList(b.opts.toolbarButtons);                  b.$tb.append(a), b.button.bindCommands(b.$tb)              }                function d() {                  null == b.opts.toolbarButtonsXS && (b.opts.toolbarButtonsXS = b.opts.toolbarButtons), null == b.opts.toolbarButtonsSM && (b.opts.toolbarButtonsSM = b.opts.toolbarButtons), null == b.opts.toolbarButtonsMD && (b.opts.toolbarButtonsMD = b.opts.toolbarButtons), b.$tb.find('> .pgn-command').each(function (c, d) {                      b.opts.toolbarButtonsXS.indexOf(a(d).data('cmd')) >= 0 && a(d).addClass('pgn-visible-xs'), b.opts.toolbarButtonsSM.indexOf(a(d).data('cmd')) >= 0 && a(d).addClass('pgn-visible-sm'), b.opts.toolbarButtonsMD.indexOf(a(d).data('cmd')) >= 0 && a(d).addClass('pgn-visible-md')                  }), b.opts.toolbarButtonsXS.indexOf('-') >= 0 && b.$tb.find('.pgn-separator.pgn-hs').addClass('pgn-visible-xs'), b.opts.toolbarButtonsSM.indexOf('-') >= 0 && b.$tb.find('.pgn-separator.pgn-hs').addClass('pgn-visible-sm'), b.opts.toolbarButtonsMD.indexOf('-') >= 0 && b.$tb.find('.pgn-separator.pgn-hs').addClass('pgn-visible-md'), b.opts.toolbarButtonsXS.indexOf('|') >= 0 && b.$tb.find('.pgn-separator.pgn-vs').addClass('pgn-visible-xs'), b.opts.toolbarButtonsSM.indexOf('|') >= 0 && b.$tb.find('.pgn-separator.pgn-vs').addClass('pgn-visible-sm'), b.opts.toolbarButtonsMD.indexOf('|') >= 0 && b.$tb.find('.pgn-separator.pgn-vs').addClass('pgn-visible-md')              }                function e(c, d) {                  b.helpers.isMobile() ? b.toolbar.show() : setTimeout(function () {                      if (c && c.which == a.pgn_htmlEditor.KEYCODE.ESC);                      else if (b.selection.inEditor() && b.core.hasFocus() && !b.popups.areVisible() && (b.opts.toolbarVisibleWithoutSelection || '' !== b.selection.text() || d)) {                          if (0 == b.events.trigger('toolbar.show')) return !1;                          b.helpers.isMobile() || b.position.forSelection(b.$tb), b.$tb.show()                      }                  }, 0)              }                function f() {                  return 0 == b.events.trigger('toolbar.hide') ? !1 : void b.$tb.hide()              }                function g() {                  return 0 == b.events.trigger('toolbar.show') ? !1 : void b.$tb.show()              }                function h() {                  b.events.on('window.mousedown', f), b.events.on('keydown', f), b.events.on('blur', f), b.events.on('window.mouseup', e), b.events.on('window.keyup', e), b.events.on('keydown', function (b) {                      b && b.which == a.pgn_htmlEditor.KEYCODE.ESC && f()                  }), b.$wp.on('scroll.toolbar', e), b.events.on('commands.after', e)              }                function i() {                  b.events.on('focus', e, !0), b.events.on('blur', f, !0)              }                function j() {                  b.opts.toolbarInline ? (b.$box.addClass('pgn-inline'), b.helpers.isMobile() ? (b.helpers.isIOS() ? (a('body').append(b.$tb), b.position.addSticky(b.$tb)) : (b.$tb.addClass('pgn-bottom'), b.$box.append(b.$tb), b.position.addSticky(b.$tb), b.opts.toolbarBottom = !0), b.$tb.addClass('pgn-inline'), i(), b.opts.toolbarInline = !1) : (a(b.opts.scrollableContainer).append(b.$tb), b.$tb.data('container', a(b.opts.scrollableContainer)), b.$tb.addClass('pgn-inline'), h(), b.opts.toolbarBottom = !1)) : (b.opts.toolbarBottom && !b.helpers.isIOS() ? (b.$box.append(b.$tb), b.$tb.addClass('pgn-bottom'), b.$box.addClass('pgn-bottom')) : (b.opts.toolbarBottom = !1, b.$box.prepend(b.$tb), b.$tb.addClass('pgn-top'), b.$box.addClass('pgn-top')), b.$box.addClass('pgn-basic'), b.$tb.addClass('pgn-basic'), b.opts.toolbarSticky && (b.opts.toolbarStickyOffset && (b.opts.toolbarBottom ? b.$tb.css('bottom', b.opts.toolbarStickyOffset) : b.$tb.css('top', b.opts.toolbarStickyOffset)), b.position.addSticky(b.$tb)))              }                function k() {                  b.$box.removeClass('pgn-top pgn-bottom pgn-inline pgn-basic'), b.$box.find('.pgn-sticky-dummy').remove(), b.$tb.off(b._mousedown + ' ' + b._mouseup), b.$tb.html('').removeData().remove()              }                function l() {                  return b.$wp ? (b.$tb = a('<div class='pgn-toolbar'></div>'), b.opts.theme && b.$tb.addClass(b.opts.theme + '-theme'), b.opts.zIndex > 1 && b.$tb.css('z-index', b.opts.zIndex + 1), 'auto' != b.opts.direction && b.$tb.removeClass('pgn-ltr pgn-rtl').addClass('pgn-' + b.opts.direction), b.helpers.isMobile() ? b.$tb.addClass('pgn-mobile') : b.$tb.addClass('pgn-desktop'), j(), o = b.$tb.get(0).ownerDocument, p = 'defaultView' in o ? o.defaultView : o.parentWindow, c(), d(), b.$tb.on(b._mousedown + ' ' + b._mouseup, function (a) {                      var b = a.originalEvent ? a.originalEvent.target || a.originalEvent.originalTarget : null;                      return b && 'INPUT' != b.tagName ? (a.stopPropagation(), a.preventDefault(), !1) : void 0                  }), void b.events.on('destroy', k, !0)) : !1              }                function m() {                  !q && b.$tb && (b.$tb.find('> .pgn-command').addClass('pgn-disabled'), q = !0)              }                function n() {                  q && b.$tb && (b.$tb.find('> .pgn-command').removeClass('pgn-disabled'), q = !1), b.button.bulkRefresh()              }              var o, p, q = !1;              return {                  require: ['events', 'tooltip', 'button', 'icon', 'core', 'language'],                  _init: l,                  hide: f,                  show: g,                  showInline: e,                  disable: m,                  enable: n              }          }      }(jQuery),      function (a) {          'use strict';          a.pgn_htmlEditor.MODULES.tooltip = function (b) {              function c() {                  b.$tooltip.removeClass('pgn-visible').css('left', '-3000px')              }                function d(c, d) {                  if (c.data('title') || c.data('title', c.attr('title')), !c.data('title')) return !1;                  c.removeAttr('title'), b.$tooltip.text(c.data('title')), b.$tooltip.addClass('pgn-visible');                  var e = c.offset().left + (c.outerWidth() - b.$tooltip.outerWidth()) / 2;                  0 > e && (e = 0), e + b.$tooltip.outerWidth() > a(b.original_window).width() && (e = a(b.original_window).width() - b.$tooltip.outerWidth()), b.$tooltip.css('left', e), 'undefined' == typeof d && (d = b.opts.toolbarBottom), b.$tooltip.css('top', d ? c.offset().top - b.$tooltip.height() : c.offset().top + c.outerHeight())              }                function e(e, f, g) {                  b.helpers.isMobile() || (e.on('mouseenter', f, function (b) {                      a(b.currentTarget).hasClass('pgn-disabled') || d(a(b.currentTarget), g)                  }), e.on('mouseleave ' + b._mousedown + ' ' + b._mouseup, f, function (a) {                      c()                  })), b.events.on('destroy', function () {                      e.off('mouseleave ' + b._mousedown + ' ' + b._mouseup, f), e.off('mouseenter', f)                  }, !0)              }                function f() {                  b.helpers.isMobile() || (b.$tooltip = a('<div class='pgn-tooltip'></div>'), b.opts.theme && b.$tooltip.addClass(b.opts.theme + '-theme'), a('body').append(b.$tooltip), b.events.on('destroy', function () {                      b.$tooltip.html('').removeData().remove()                  }, !0))              }              return {                  require: ['events', 'language'],                  _init: f,                  hide: c,                  to: d,                  bind: e              }          }      }(jQuery),      function (a) {          'use strict';          a.pgn_htmlEditor.MODULES.undo = function (a) {              function b(b) {                  var c = b.which,                      d = a.keys.ctrlKey(b);                  d && (90 == c && b.shiftKey && b.preventDefault(), 90 == c && b.preventDefault())              }                function c() {                  return 0 === a.undo_stack.length || a.undo_index <= 1 ? !1 : !0              }                function d() {                  return a.undo_index == a.undo_stack.length ? !1 : !0              }                function e(b) {                  if (!a.undo_stack || a.undoing) return !1;                  for (; a.undo_stack.length > a.undo_index;) a.undo_stack.pop();                  'undefined' == typeof b ? (b = a.snapshot.get(), a.undo_stack[a.undo_index - 1] && a.snapshot.equal(a.undo_stack[a.undo_index - 1], b) || (a.undo_stack.push(b), a.undo_index++, b.html != j && (a.events.trigger('contentChanged'), j = b.html))) : a.undo_index > 0 ? a.undo_stack[a.undo_index - 1] = b : (a.undo_stack.push(b), a.undo_index++)              }                function f() {                  if (a.undo_index > 1) {                      a.undoing = !0;                      var b = a.undo_stack[--a.undo_index - 1];                      clearTimeout(a._content_changed_timer), a.snapshot.restore(b), a.popups.hideAll(), a.toolbar.enable(), a.events.trigger('contentChanged'), a.events.trigger('commands.undo'), a.undoing = !1                  }              }                function g() {                  if (a.undo_index < a.undo_stack.length) {                      a.undoing = !0;                      var b = a.undo_stack[a.undo_index++];                      clearTimeout(a._content_changed_timer), a.snapshot.restore(b), a.popups.hideAll(), a.toolbar.enable(), a.events.trigger('contentChanged'), a.events.trigger('commands.redo'), a.undoing = !1                  }              }                function h() {                  a.undo_index = 0, a.undo_stack = []              }                function i() {                  h(), a.events.on('initialized', function () {                      j = a.html.get(!1, !0)                  }), a.events.on('keydown', b)              }              var j = null;              return {                  require: ['snapshot', 'events', 'core'],                  _init: i,                  run: f,                  redo: g,                  canDo: c,                  canRedo: d,                  reset: h,                  saveStep: e              }          }      }(jQuery);");
            output.Write("</script>");

            output.Write("<script type='text/javascript' src='" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.toolbar_buttons.js") + "' ></script>");


            //Verificando se tradução está setada para assim, carregar o conteudo
            output.Write (string.IsNullOrEmpty(TranslateFile) ? "" : GetTranslate());

            string name = this.UniqueID ;

            //Iniciando div container e script
            output.Write("<div id='" + name + "'><input class='htmlEditor_value' type='hidden' class='pgn-view' name='" + name   + "_value' value='valor teste'><div id='" + name +"_edit' style='margin-top: 30px;'></div><script>");
            output.Write("$(function () {$('#" + name + "_edit').pgn_htmlEditor({");
            //Verificando se tradução está setada
            output.Write(string.IsNullOrEmpty(TranslateFile) ? "" : "language: 'translate'");
            output.Write("}); });");
            //Encerrando div container es cript


            




            output.Write("</script></div>");


            output.Write("<script type='text/javascript' src='" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "br.com.pgnsoft.web.init.js") + "' ></script>");
            
            if (!string.IsNullOrEmpty(HTML))
            {
                output.Write("<script>$(document).ready(function () {  pgnSofthtmlEditorSetValue('" + HTML + "'); });</script>");
            }




        }

        public string GetTranslate()
        {
            string html = "";
            if (TranslateFile.ToLower().Contains("http://") || TranslateFile.ToLower().Contains("https://"))
            {
                //Download File
                //TODO: Implement load from external url
            }
            else
            {
                if (System.IO.File.Exists(this.MapPathSecure(TranslateFile)))
                {
                    html += "<script>";
                    html += "$.pgn_htmlEditor.LANGUAGE['translate'] = {";
                    html += "translation: {";
                    html += System.IO.File.ReadAllText(this.MapPathSecure(TranslateFile));
                    html += "},direction: 'ltr'};</script>";
                }
            }
            return html;
        }
    }
}
