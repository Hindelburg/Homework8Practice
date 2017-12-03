
function cat(key) {
    $.ajax({
        url: "Home/Get",
        type: "Get",
        data: {
            keyG: key
        },
        success: function (data) {
            $('#tmp').remove();
            $('#test').append(`<ul id="tmp"></ul>`);

            $.each(data, function (i, item) {
                $('#tmp').append(`<li>` + item + `</li>`);
            })
        }
    });
}