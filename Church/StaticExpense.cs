namespace Expenses
{
    public class StaticExpense
    {
        private int id;
        private string name;
        private int montantUnitaire;    
        public int Id{get;set;}
        public string Name{get;set;}
        public int MontantUnitaire{get;set;}


        public StaticExpense(){}

        public StaticExpense addId(int id)
        {
            Id=id;
            return this;
        }
        public StaticExpense addName(string name)
        {
            Name=name;
            return this;
        }
        public StaticExpense addMontantUnitaire(int montantUnitaire)
        {
            MontantUnitaire=montantUnitaire;
            return this;
        }
    }
}