namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Reporting reporting = new Reporting();
            Grivnya saltPrice = new Grivnya(10,20);
            Dolar plasticPrice = new Dolar(5,10);
            Product salt = new Product("сiль", saltPrice);
            Product plastic = new Product("пластмаса", plasticPrice);

            Grivnya decreaseMoney = new Grivnya(2,30);

           
            salt.ProductPrice.GetMoneyAltogether();
            salt.decreasePrice(decreaseMoney, salt);
            salt.ProductPrice.GetMoneyAltogether();

            WareHouse saltWarehouse = new WareHouse("Сольвий", "кг", "06.05.2023", 0, salt);
            WareHouse plastWarehouse = new WareHouse("Пластиковий", "м", "05.04.2023", 4, plastic);

            saltWarehouse.removeProduct(salt);
            saltWarehouse.addProduct(salt);
            saltWarehouse.removeProduct(salt);
            plastWarehouse.addProduct(plastic);

            reporting.GetWarehouseBalances(saltWarehouse);
            reporting.GetWarehouseBalances(plastWarehouse);
            




        }
    }
}