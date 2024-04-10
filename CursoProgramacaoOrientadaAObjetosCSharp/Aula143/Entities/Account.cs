namespace Aula143.Entities
{
    abstract class Account //abstract pode ser usado em uma class e indica que ela não pode ser instaciada 
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount) //virtual é usado nos metodos da superclass incando que eles podem ser sobrescritos em uma subclass
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        abstract public void Test(); //abstract pode ser usado em um metodo também e indica que ele não pode ser instaciado na propria class
    }
}
