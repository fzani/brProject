function categoryClick(categoryId) {

    $('#productsId').html('Loading...');


    /////////////////

    //var itens = [
    //     { title: "ASP.NET 4 Unleashed", price: 37.79, picture: "AspNet4Unleashed.jpg", description: "The most comprehensive book on Microsoft’s new ASP.NET 4.. " },
    //     { title: "ASP.NET MVC Unleashed", price: 44.99, picture: "AspNetMvcUnleashed.jpg", description: "Writing for professional programmers, Walther explains the crucial concepts that make the Model-View-Controller (MVC) development paradigm work…" },
    //     { title: "ASP.NET Kick Start", price: 4.00, picture: "AspNetKickStart.jpg", description: "Visual Studio .NET is the premier development environment for creating .NET applications…." },
    //     { title: "ASP.NET MVC Unleashed iPhone", price: 44.99, picture: "AspNetMvcUnleashedIPhone.jpg", description: "ASP.NET MVC Unleashed for the iPhone…" },
    //];

    $.get('Store/GetProduct', { id: categoryId }, function (data) {
        console.log(data)

        if (data.length > 0) {
            $('#productsId').empty();
            render(data);
        }
        else {
            $('#productsId').html('Sory. No have itens in this category');
        }
    }, 'json');

       


}
// Render using the template

function render(itens) {
    $("#itemTemplate").tmpl(itens).appendTo("#productsId");

}

function formatPrice(price) {
    return "$" + price.toFixed(2);
}