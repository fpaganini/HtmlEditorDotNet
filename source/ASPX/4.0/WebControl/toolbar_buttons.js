

if ("undefined" == typeof jQuery) throw new Error("pgn_html requires jQuery");
! function (a) {
}(jQuery),
function (a) {
    "use strict";
    
    a.extend(a.pgn_htmlEditor.DEFAULTS, {
        toolbarInline: !1,
        toolbarVisibleWithoutSelection: !1,
        toolbarSticky: !0,
        toolbarButtons: [fullscreen, bold, italic, underline, strikeThrough, subscript, superscript, fontFamily, fontSize, "|", color, emoticons, inlineStyle, paragraphStyle, "|", paragraphFormat, align, formatOL, formatUL, outdent, indent, quote, insertHR, insertLine, insertLink, insertImage, insertVideo, insertFile, insertTable, undo, redo, clearFormatting, selectAll, html],
        toolbarButtonsXS: [fullscreen, bold, italic, underline, strikeThrough, subscript, superscript, fontFamily, fontSize, "|", color, emoticons, inlineStyle, paragraphStyle, "|", paragraphFormat, align, formatOL, formatUL, outdent, indent, quote, insertHR, insertLine, insertLink, insertImage, insertVideo, insertFile, insertTable, undo, redo, clearFormatting, selectAll, html],
        toolbarButtonsSM: [fullscreen, bold, italic, underline, strikeThrough, subscript, superscript, fontFamily, fontSize, "|", color, emoticons, inlineStyle, paragraphStyle, "|", paragraphFormat, align, formatOL, formatUL, outdent, indent, quote, insertHR, insertLine, insertLink, insertImage, insertVideo, insertFile, insertTable, undo, redo, clearFormatting, selectAll, html],
        toolbarButtonsMD: [fullscreen, bold, italic, underline, strikeThrough, subscript, superscript, fontFamily, fontSize, "|", color, emoticons, inlineStyle, paragraphStyle, "|", paragraphFormat, align, formatOL, formatUL, outdent, indent, quote, insertHR, insertLine, insertLink, insertImage, insertVideo, insertFile, insertTable, undo, redo, clearFormatting, selectAll, html],
        toolbarStickyOffset: 0
    }),


  
        a.pgn_htmlEditor.MODULES.toolbar = function (b) {
            function c() {
                var a = b.button.buildList(b.opts.toolbarButtons);
                b.$tb.append(a), b.button.bindCommands(b.$tb)
            }

            function d() {
                null == b.opts.toolbarButtonsXS && (b.opts.toolbarButtonsXS = b.opts.toolbarButtons), null == b.opts.toolbarButtonsSM && (b.opts.toolbarButtonsSM = b.opts.toolbarButtons), null == b.opts.toolbarButtonsMD && (b.opts.toolbarButtonsMD = b.opts.toolbarButtons), b.$tb.find("> .pgn-command").each(function (c, d) {
                    b.opts.toolbarButtonsXS.indexOf(a(d).data("cmd")) >= 0 && a(d).addClass("pgn-visible-xs"), b.opts.toolbarButtonsSM.indexOf(a(d).data("cmd")) >= 0 && a(d).addClass("pgn-visible-sm"), b.opts.toolbarButtonsMD.indexOf(a(d).data("cmd")) >= 0 && a(d).addClass("pgn-visible-md")
                }), b.opts.toolbarButtonsXS.indexOf("-") >= 0 && b.$tb.find(".pgn-separator.pgn-hs").addClass("pgn-visible-xs"), b.opts.toolbarButtonsSM.indexOf("-") >= 0 && b.$tb.find(".pgn-separator.pgn-hs").addClass("pgn-visible-sm"), b.opts.toolbarButtonsMD.indexOf("-") >= 0 && b.$tb.find(".pgn-separator.pgn-hs").addClass("pgn-visible-md"), b.opts.toolbarButtonsXS.indexOf("|") >= 0 && b.$tb.find(".pgn-separator.pgn-vs").addClass("pgn-visible-xs"), b.opts.toolbarButtonsSM.indexOf("|") >= 0 && b.$tb.find(".pgn-separator.pgn-vs").addClass("pgn-visible-sm"), b.opts.toolbarButtonsMD.indexOf("|") >= 0 && b.$tb.find(".pgn-separator.pgn-vs").addClass("pgn-visible-md")
            }

            function e(c, d) {
                b.helpers.isMobile() ? b.toolbar.show() : setTimeout(function () {
                    if (c && c.which == a.pgn_htmlEditor.KEYCODE.ESC);
                    else if (b.selection.inEditor() && b.core.hasFocus() && !b.popups.areVisible() && (b.opts.toolbarVisibleWithoutSelection || "" !== b.selection.text() || d)) {
                        if (0 == b.events.trigger("toolbar.show")) return !1;
                        b.helpers.isMobile() || b.position.forSelection(b.$tb), b.$tb.show()
                    }
                }, 0)
            }

            function f() {
                return 0 == b.events.trigger("toolbar.hide") ? !1 : void b.$tb.hide()
            }

            function g() {
                return 0 == b.events.trigger("toolbar.show") ? !1 : void b.$tb.show()
            }

            function h() {
                b.events.on("window.mousedown", f), b.events.on("keydown", f), b.events.on("blur", f), b.events.on("window.mouseup", e), b.events.on("window.keyup", e), b.events.on("keydown", function (b) {
                    b && b.which == a.pgn_htmlEditor.KEYCODE.ESC && f()
                }), b.$wp.on("scroll.toolbar", e), b.events.on("commands.after", e)
            }

            function i() {
                b.events.on("focus", e, !0), b.events.on("blur", f, !0)
            }

            function j() {
                b.opts.toolbarInline ? (b.$box.addClass("pgn-inline"), b.helpers.isMobile() ? (b.helpers.isIOS() ? (a("body").append(b.$tb), b.position.addSticky(b.$tb)) : (b.$tb.addClass("pgn-bottom"), b.$box.append(b.$tb), b.position.addSticky(b.$tb), b.opts.toolbarBottom = !0), b.$tb.addClass("pgn-inline"), i(), b.opts.toolbarInline = !1) : (a(b.opts.scrollableContainer).append(b.$tb), b.$tb.data("container", a(b.opts.scrollableContainer)), b.$tb.addClass("pgn-inline"), h(), b.opts.toolbarBottom = !1)) : (b.opts.toolbarBottom && !b.helpers.isIOS() ? (b.$box.append(b.$tb), b.$tb.addClass("pgn-bottom"), b.$box.addClass("pgn-bottom")) : (b.opts.toolbarBottom = !1, b.$box.prepend(b.$tb), b.$tb.addClass("pgn-top"), b.$box.addClass("pgn-top")), b.$box.addClass("pgn-basic"), b.$tb.addClass("pgn-basic"), b.opts.toolbarSticky && (b.opts.toolbarStickyOffset && (b.opts.toolbarBottom ? b.$tb.css("bottom", b.opts.toolbarStickyOffset) : b.$tb.css("top", b.opts.toolbarStickyOffset)), b.position.addSticky(b.$tb)))
            }

            function k() {
                b.$box.removeClass("pgn-top pgn-bottom pgn-inline pgn-basic"), b.$box.find(".pgn-sticky-dummy").remove(), b.$tb.off(b._mousedown + " " + b._mouseup), b.$tb.html("").removeData().remove()
            }

            function l() {
                return b.$wp ? (b.$tb = a('<div class="pgn-toolbar"></div>'), b.opts.theme && b.$tb.addClass(b.opts.theme + "-theme"), b.opts.zIndex > 1 && b.$tb.css("z-index", b.opts.zIndex + 1), "auto" != b.opts.direction && b.$tb.removeClass("pgn-ltr pgn-rtl").addClass("pgn-" + b.opts.direction), b.helpers.isMobile() ? b.$tb.addClass("pgn-mobile") : b.$tb.addClass("pgn-desktop"), j(), o = b.$tb.get(0).ownerDocument, p = "defaultView" in o ? o.defaultView : o.parentWindow, c(), d(), b.$tb.on(b._mousedown + " " + b._mouseup, function (a) {
                    var b = a.originalEvent ? a.originalEvent.target || a.originalEvent.originalTarget : null;
                    return b && "INPUT" != b.tagName ? (a.stopPropagation(), a.preventDefault(), !1) : void 0
                }), void b.events.on("destroy", k, !0)) : !1
            }

            function m() {
                !q && b.$tb && (b.$tb.find("> .pgn-command").addClass("pgn-disabled"), q = !0)
            }

            function n() {
                q && b.$tb && (b.$tb.find("> .pgn-command").removeClass("pgn-disabled"), q = !1), b.button.bulkRefresh()
            }
            var o, p, q = !1;
            return {
                require: ["events", "tooltip", "button", "icon", "core", "language"],
                _init: l,
                hide: f,
                show: g,
                showInline: e,
                disable: m,
                enable: n
            }
        }
}(jQuery)


