$("#find_address").click(function (e) {
    e.preventDefault();
    $("#address_select").remove()
    var house_number = $("#housenumber_search").val();
    var postcode = $("#postcode_search").val();
    $(this).text("Fetching Addresses...")
    $.get(`https://api.getAddress.io/find/${postcode}/${house_number}?api-key=VHJJhIzhEEWfMTaom3QLyg29794&expand=true`, function (response) {
        if (response.addresses.length == 1) {
            var address = response.addresses[0]
            $("#Address1").val(address.line_1)
            $("#Address2").val(address.line_2)
            $("#Address3").val(address.line_3)
            $("#Town").val(address.town_or_city)
            $("#Postcode").val(postcode)
            $("#County").val(address.county)
            $("#manual_address").show()
            $("#postcode_lookup").hide()
        } else {
            var newElement = "<select id='address_select' class='form-control mb-4'><option selected>Please choose an address...</option>"
            for (var i = 0; i < response.addresses.length; i++) {
                newElement += `<option value=${i}>${response.addresses[i].formatted_address}</option>`
            }
            newElement += "</select>"
            $("#postcode_lookup").append(newElement)
            $("#address_select").change(function (e) {
                var address = response.addresses[this.value]
                var address = response.addresses[0]
                $("#Address1").val(address.line_1)
                $("#Address2").val(address.line_2)
                $("#Address3").val(address.line_3)
                $("#Town").val(address.town_or_city)
                $("#Postcode").val(postcode)
                $("#County").val(address.county)
                $("#address_select").remove()
                $("#manual_address").show()
                $("#postcode_lookup").hide()
            })
        }

        $("#find_address").text("Find Address")

    }, "json")
})