$("#manual_address").hide()

        
        </script >
    <script>

        $("#manually").click(function (e) {
            e.preventDefault();
            $("#manual_address").show()
            $("#postcode_lookup").hide()
        })
        $("#automatic").click(function (e) {
            e.preventDefault();
            $("#manual_address").hide()
            $("#postcode_lookup").show()
        })