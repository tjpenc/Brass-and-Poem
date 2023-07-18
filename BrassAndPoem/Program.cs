
using System.Xml.Serialization;
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

//put your greeting here
Console.WriteLine("Welcome to Brass and Poem!");
//implement your loop here
DisplayMenu();
void DisplayMenu()
{
    Console.WriteLine(@"Please choose an option:
1: Display Menu
2. Display All Products
3. Delete Product
4. Add Product
5. Exit");
    string choice = null;

    while (choice != "5")
    {
        choice = Console.ReadLine();
        if (choice == "1")
        {

        }
        else if (choice == "2")
        {

        }
        else if (choice == "3")
        {

        }
        else if (choice == "4")
        {

        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye");
        }
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }