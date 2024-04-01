namespace Expenses
{
    public class StaticExpense
    {
        private int id;
        private string motif;
        private int montantUnitaire;    
        public int Id{get;set;}
        public string Motif{get;set;}
        public int MontantUnitaire{get;set;}


        public StaticExpense(){}

        public StaticExpense addId(int id)
        {
            Id=id;
            return this;
        }
        public StaticExpense addMotif(string motif)
        {
            Motif=motif;
            return this;
        }
        public StaticExpense addMontantUnitaire(int montantUnitaire)
        {
            MontantUnitaire=montantUnitaire;
            return this;
        }
    }
}