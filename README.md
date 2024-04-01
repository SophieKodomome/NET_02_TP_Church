# NET_02_TP_Church
Following of Python_01_TP_Church

Le fengonana ihany fa atao C# ndray.. miampy dépense ilay vola mivoaka an'ny fengonana..
-Depense fixe: karama, hofatrano sns... ampidirina maina anaty base fa afaka reglena hoe par mois io no aloha na par semestre na par trimestre de @iny no mivoka ny caisse le vola
-depense Variable: jirama, sns.. calculena ohatran'ny le nicalculenan'le prevision ihany le izy.. de mivoaka isaky ny fin(dernier) dimanche du mois io dépense io de la caisse.

Form page(index):
  front:
    -Form
      -Regler les static expenses
        -Options(Pas payer du tout,Mensuel, Semestriel, Trimestriel)
      -Regler les variable expenses
        -Options(Pris en compte, non Pris en compte)
      -Button "Prevoir"
  fonctions & classes:
    -StaticExpense(id,nom,montant_unitaire)
    -VariableExpense(id,nom,montant_unitaire,variable)
    -dbConnect
      -getListDepensesFixes()
      -getListDepensesVariable()
  data:
    -use the same as church
    -table depenses_fixes(id,nom,montant_unitaire)
    -table depenses_variables(id,nom,montant_unitaire,variable)
  
  integration:
    -send info to result page
    
Result Page:
  front:
    -table of check outs
      -fixed expense(nom,montant unitaire,frequences,montant total)
      -variable expense(nom,montant unitaire, moyenne variable,montant total, check out date (dernier dimanche))
      -total
  fonctions & classes:
    -calculateFixedExpense()
    -calculateVariableExpense()
    -getCheckoutDate()
  data:
  integration:
    -get info from Form Page
    
  
