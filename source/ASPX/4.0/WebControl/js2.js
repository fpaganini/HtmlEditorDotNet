if ("undefined" == typeof jQuery) throw new Error("pgn_html requires jQuery");
! function (a) {
}(jQuery),
function (a) {
    "use strict";
    a.pgn_htmlEditor.MODULES.tooltip = function (b) {
        function c() {
            b.$tooltip.removeClass("pgn-visible").css("left", "-3000px")
        }

        function d(c, d) {
            if (c.data("title") || c.data("title", c.attr("title")), !c.data("title")) return !1;
            c.removeAttr("title"), b.$tooltip.text(c.data("title")), b.$tooltip.addClass("pgn-visible");
            var e = c.offset().left + (c.outerWidth() - b.$tooltip.outerWidth()) / 2;
            0 > e && (e = 0), e + b.$tooltip.outerWidth() > a(b.original_window).width() && (e = a(b.original_window).width() - b.$tooltip.outerWidth()), b.$tooltip.css("left", e), "undefined" == typeof d && (d = b.opts.toolbarBottom), b.$tooltip.css("top", d ? c.offset().top - b.$tooltip.height() : c.offset().top + c.outerHeight())
        }

        function e(e, f, g) {
            b.helpers.isMobile() || (e.on("mouseenter", f, function (b) {
                a(b.currentTarget).hasClass("pgn-disabled") || d(a(b.currentTarget), g)
            }), e.on("mouseleave " + b._mousedown + " " + b._mouseup, f, function (a) {
                c()
            })), b.events.on("destroy", function () {
                e.off("mouseleave " + b._mousedown + " " + b._mouseup, f), e.off("mouseenter", f)
            }, !0)
        }

        function f() {
            b.helpers.isMobile() || (b.$tooltip = a('<div class="pgn-tooltip"></div>'), b.opts.theme && b.$tooltip.addClass(b.opts.theme + "-theme"), a("body").append(b.$tooltip), b.events.on("destroy", function () {
                b.$tooltip.html("").removeData().remove()
            }, !0))
        }
        return {
            require: ["events", "language"],
            _init: f,
            hide: c,
            to: d,
            bind: e
        }
    }
}(jQuery),
function (a) {
    "use strict";
    a.pgn_htmlEditor.MODULES.undo = function (a) {
        function b(b) {
            var c = b.which,
                d = a.keys.ctrlKey(b);
            d && (90 == c && b.shiftKey && b.preventDefault(), 90 == c && b.preventDefault())
        }

        function c() {
            return 0 === a.undo_stack.length || a.undo_index <= 1 ? !1 : !0
        }

        function d() {
            return a.undo_index == a.undo_stack.length ? !1 : !0
        }

        function e(b) {
            if (!a.undo_stack || a.undoing) return !1;
            for (; a.undo_stack.length > a.undo_index;) a.undo_stack.pop();
            "undefined" == typeof b ? (b = a.snapshot.get(), a.undo_stack[a.undo_index - 1] && a.snapshot.equal(a.undo_stack[a.undo_index - 1], b) || (a.undo_stack.push(b), a.undo_index++, b.html != j && (a.events.trigger("contentChanged"), j = b.html))) : a.undo_index > 0 ? a.undo_stack[a.undo_index - 1] = b : (a.undo_stack.push(b), a.undo_index++)
        }

        function f() {
            if (a.undo_index > 1) {
                a.undoing = !0;
                var b = a.undo_stack[--a.undo_index - 1];
                clearTimeout(a._content_changed_timer), a.snapshot.restore(b), a.popups.hideAll(), a.toolbar.enable(), a.events.trigger("contentChanged"), a.events.trigger("commands.undo"), a.undoing = !1
            }
        }

        function g() {
            if (a.undo_index < a.undo_stack.length) {
                a.undoing = !0;
                var b = a.undo_stack[a.undo_index++];
                clearTimeout(a._content_changed_timer), a.snapshot.restore(b), a.popups.hideAll(), a.toolbar.enable(), a.events.trigger("contentChanged"), a.events.trigger("commands.redo"), a.undoing = !1
            }
        }

        function h() {
            a.undo_index = 0, a.undo_stack = []
        }

        function i() {
            h(), a.events.on("initialized", function () {
                j = a.html.get(!1, !0)
            }), a.events.on("keydown", b)
        }
        var j = null;
        return {
            require: ["snapshot", "events", "core"],
            _init: i,
            run: f,
            redo: g,
            canDo: c,
            canRedo: d,
            reset: h,
            saveStep: e
        }
    }
}(jQuery);



