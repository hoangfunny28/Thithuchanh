// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


{
    "name"; "Product",
        "properties";
    {
        "id";
        {
            "type"; "number",
                "description"; "Product identifier",
                    "required"; true
        },
        "name";
        {
            "description"; "Name of the product",
                "type"; "string",
                    "required"; true
        },
        "price";
        {
            "type"; "number",
                "minimum"; 0,
                    "required"; true
        },
    }
}