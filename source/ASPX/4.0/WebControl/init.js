function pgnSofthtmlEditorSetValue(value) {
    $(".pgn-wrapper div").html(value);
    $(".pgn-placeholder").html("");
    pgnSofthtmlEditorFillValue();
}

function pgnSofthtmlEditorFillValue() {
    var html = $(".pgn-wrapper div").html();
    html = html.replace(/&/g, "&amp;");
    html = html.replace(/</g, "&lt;");
    html = html.replace(/>/g, "&gt;")
    html = html.replace(/\"/g, "&quot;");
    $(".htmlEditor_value").val(html);
}

$(document).ready(function () {

    $(".pgn-wrapper").keyup(function () {
        pgnSofthtmlEditorFillValue();
    });


    $(".pgn-box *").click(function () {
        pgnSofthtmlEditorFillValue();
    });



});