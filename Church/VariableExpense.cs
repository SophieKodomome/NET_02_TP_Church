namespace Expenses
{
    public class VariableExpense
    {
        private int id;
        private string motif;
        private int montantUnitaire;

        private string nomVariable;
        private int variable;   
        public int Id{get;set;}
        public string Motif{get;set;}
        public int MontantUnitaire{get;set;}
        public string MotifVariable{get;set;}
        public int Variable{get;set;}


        public VariableExpense(){}

        public VariableExpense addId(int id)
        {
            Id=id;
            return this;
        }
        public VariableExpense addMotif(string motif)
        {
            Motif=motif;
            return this;
        }
        public VariableExpense addMontantUnitaire(int montantUnitaire)
        {
            MontantUnitaire=montantUnitaire;
            return this;
        }
        public VariableExpense addMotifVariable(string motifVariable)
        {
            MotifVariable=motifVariable;
            return this;
        }
        public VariableExpense addVariable(int variable)
        {
            Variable=variable;
            return this;
        }
    }
}