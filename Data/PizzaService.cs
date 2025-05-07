namespace BlazingPizza.Data
{
    public class PizzaService
    {
        public Task<Pizzza[]> GetPizzasAsync()
            {
                var pizzas = new Pizzza[]
                {
                    new Pizzza { PizzaId = 1, Name = "Mozzarella", Price = 10.00m },
                    new Pizzza { PizzaId = 2, Name = "Pepperoni", Price = 12.00m },
                    new Pizzza { PizzaId = 3, Name = "Frango com Catupiry", Price = 13.50m }
                };

                return Task.FromResult(pizzas);
            }
    }
}