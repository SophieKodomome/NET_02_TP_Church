namespace Expenses
{
    public class VariableExpense
    {
        private int id;
        private string name;
        private int montantUnitaire; 
        private int variable;   
        public int Id{get;set;}
        public string Name{get;set;}
        public int MontantUnitaire{get;set;}
        public int Variable{get;set;}


        public VariableExpense(){}

        public VariableExpense addId(int id)
        {
            Id=id;
            return this;
        }
        public VariableExpense addName(string name)
        {
            Name=name;
            return this;
        }
        public VariableExpense addMontantUnitaire(int montantUnitaire)
        {
            MontantUnitaire=montantUnitaire;
            return this;
        }
        public VariableExpense addVariable(int variable)
        {
            Variable=variable;
            return this;
        }
    }
}