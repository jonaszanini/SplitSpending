using SplitSpending.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SplitSpending
{
    public partial class About : Page
    {
        public int CodExpenseSaved { get; set; }
        public int CodUserWithPaymentMade { get; set; }
        public int AmountUserParticipating { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateItens();
            }
        }

        private void PopulateItens()
        {
            var userList = new List<User_TB>();

            using (DBSpitSpendingEntities context = new DBSpitSpendingEntities())
            {
                userList = context.User_TB.Where(s => s.Cod_User != 0).ToList();
            }

            chb_HoUsedIt.Items.Clear();

            foreach (var user in userList)
            {
                ddl_WhoSpent.Items.Add(new ListItem(user.Name, user.Cod_User.ToString()));
                chb_HoUsedIt.Items.Add(new ListItem(" - " + user.Name, user.Cod_User.ToString()));
            }

            ddl_WhoSpent.Items.Insert(0, new ListItem("...", ""));
        }

        protected void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveExpense();

            SaveExpenditure();
        }

        private void SaveExpense()
        {
            var user = int.Parse(ddl_WhoSpent.SelectedItem.Value);
            var amount = decimal.Parse(txt_Amount.Text);

            // Save Expense context
            Expenses_TB expense = new Expenses_TB
            {
                Cod_User = user,
                Amount = amount
            };

            CodUserWithPaymentMade = user;

            using (DBSpitSpendingEntities context = new DBSpitSpendingEntities())
            {
                context.Expenses_TB.Add(expense);
                context.SaveChanges();

                // Get Expense ID just saved
                Expenses_TB expenseSaves = context.Expenses_TB.FirstOrDefault(ex => ex.Cod_User == user && ex.Amount == amount);
                CodExpenseSaved = expenseSaves.Cod_Expense;
            }
        }

        private void SaveExpenditure()
        {
            //Get amount of users participate on this Expense

            foreach (ListItem item in chb_HoUsedIt.Items)
            {
                if (item.Selected) { AmountUserParticipating++; }
            }

            //Calculate how much each one will pay
            decimal perUser = decimal.Parse(txt_Amount.Text) / AmountUserParticipating;

            //Save Expenditure contexts
            using (DBSpitSpendingEntities context = new DBSpitSpendingEntities())
            {
                foreach (ListItem item in chb_HoUsedIt.Items)
                {
                    if (item.Selected)
                    {
                        Expenditure_TB expenditure = new Expenditure_TB
                        {
                            Cod_User_Pay = CodUserWithPaymentMade,
                            Cod_User_Used = int.Parse(item.Value),
                            Amount = perUser
                        };

                        context.Expenditure_TB.Add(expenditure);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}