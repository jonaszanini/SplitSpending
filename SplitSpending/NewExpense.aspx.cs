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
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateItens();
        }

        private void PopulateItens()
        {
            var userList = new List<User_TB>();

            using (DBSpitSpendingEntities1 context = new DBSpitSpendingEntities1())
            {
                userList = context.User_TB.Where(s => s.Cod_User != 0).ToList();
            }

            chb_whoUsedIt.Items.Clear();

            foreach (var user in userList)
            {
                ddl_WhoSpent.Items.Add(new ListItem(user.Name, user.Cod_User.ToString()));
                chb_whoUsedIt.Items.Add(new ListItem(" - " + user.Name, user.Cod_User.ToString()));
            }

            ddl_WhoSpent.Items.Insert(0, new ListItem("...", ""));
        }

        protected void Btn_Save_Click(object sender, EventArgs e)
        {

            foreach (var item in chb_whoUsedIt.Items)
            {
                if (item.Selected)
            }

            using (DBSpitSpendingEntities1 context = new DBSpitSpendingEntities1())
            {
                Expenses_TB user = new Expenses_TB
                {
                    Cod_User = name.Text,
                    Amount = decimal.Parse(amount.Text)

                };

                //    context.User_TB.Add(user);
                //    context.SaveChanges();

                //    name.Text = "";
                //    bankAccount.Text = "";
                }
            }
    }
}