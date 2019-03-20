using SplitSpending.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SplitSpending
{
    public partial class Report : Page
    {
        public List<Expenditure_TB> ExpenditureFromDbList { get; set; }
        public List<Expenditure_TB> ExpenditureList { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadExpenditures();

            gdv_Expenditures.DataSource = ExpenditureList.OrderBy(ex => ex.Cod_User_Pay);
            gdv_Expenditures.DataBind();
        }

        protected void gdv_Expenditures_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {          
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TableCell cellWillReceive = e.Row.Cells[0];
                int nameWillReceive = int.Parse(cellWillReceive.Text);

                using (DBSpitSpendingEntities context = new DBSpitSpendingEntities())
                {
                    var userTB = context.User_TB.FirstOrDefault(ut => ut.Cod_User == nameWillReceive);

                    cellWillReceive.Text = userTB.Name.Trim();
                }

                TableCell cellWillPay = e.Row.Cells[1];
                int nameWillPay = int.Parse(cellWillPay.Text);

                using (DBSpitSpendingEntities context = new DBSpitSpendingEntities())
                {
                    var userTB = context.User_TB.FirstOrDefault(ut => ut.Cod_User == nameWillPay);

                    cellWillPay.Text = userTB.Name.Trim();
                }
            }
        }

        private void LoadExpenditures()
        {
            ExpenditureList = new List<Expenditure_TB>();

            using (DBSpitSpendingEntities context = new DBSpitSpendingEntities())
            {
                ExpenditureFromDbList = context.Expenditure_TB.Where(exp => exp.Cod_Expenditure != 0).ToList();
            }

            foreach (var expenditurefromDb in ExpenditureFromDbList)
            {            
                Expenditure_TB newExpenditure = new Expenditure_TB()
                {
                    Cod_User_Pay = expenditurefromDb.Cod_User_Pay,
                    Cod_User_Used = expenditurefromDb.Cod_User_Used,
                    Amount = expenditurefromDb.Amount
                };

                decimal? finalAmount = expenditurefromDb.Amount;
                int? finalDebtors = expenditurefromDb.Cod_User_Used;
                int? finalReceiver = expenditurefromDb.Cod_User_Pay;



                if (ExpenditureList.Any(exp => exp.Cod_User_Pay == newExpenditure.Cod_User_Used && exp.Cod_User_Used == newExpenditure.Cod_User_Pay))
                {
                    Expenditure_TB expenditureToCompare = new Expenditure_TB();

                    expenditureToCompare = ExpenditureList.FirstOrDefault(exp => exp.Cod_User_Pay == newExpenditure.Cod_User_Used && exp.Cod_User_Used == newExpenditure.Cod_User_Pay);

                    if (expenditureToCompare.Amount < newExpenditure.Amount)
                    {
                        finalAmount = newExpenditure.Amount - expenditureToCompare.Amount;
                        finalDebtors = newExpenditure.Cod_User_Used;
                        finalReceiver = newExpenditure.Cod_User_Pay;
                    }
                    else
                    {
                        finalAmount = expenditureToCompare.Amount - newExpenditure.Amount;
                        finalDebtors = expenditureToCompare.Cod_User_Used;
                        finalReceiver = expenditureToCompare.Cod_User_Pay;
                    }

                    ExpenditureList.Remove(expenditureToCompare);
                }

                if (ExpenditureList.Any(exp => exp.Cod_User_Pay == newExpenditure.Cod_User_Pay && exp.Cod_User_Used == newExpenditure.Cod_User_Used))
                {
                    Expenditure_TB expenditureToCompare = new Expenditure_TB();

                    expenditureToCompare = ExpenditureList.FirstOrDefault(exp => exp.Cod_User_Pay == newExpenditure.Cod_User_Pay && exp.Cod_User_Used == newExpenditure.Cod_User_Used);

                    finalAmount = newExpenditure.Amount + expenditureToCompare.Amount;
                    finalDebtors = newExpenditure.Cod_User_Used;
                    finalReceiver = newExpenditure.Cod_User_Pay;

                    ExpenditureList.Remove(expenditureToCompare);
                }
                
                newExpenditure.Amount = finalAmount;
                newExpenditure.Cod_User_Pay = finalReceiver;
                newExpenditure.Cod_User_Used = finalDebtors;

                if (newExpenditure.Cod_User_Pay != newExpenditure.Cod_User_Used)
                {
                    ExpenditureList.Add(newExpenditure);
                }
                
            }

        }

        private bool CheckifSamePerson(Expenditure_TB expenditure)
        {
            return (expenditure.Cod_User_Pay == expenditure.Cod_User_Used);
        }

    }
}