$.ready(function() {
    goToSelectedPage();
});

function goToSelectedPage() {
    $("#confirmBtn").click(function () {
        var x = $("#radGroupId").val();
        alert(x);
    });
}