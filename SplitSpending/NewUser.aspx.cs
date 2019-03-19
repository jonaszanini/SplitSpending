using SplitSpending.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SplitSpending
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        protected void LoadUsers()
        {
            using (DBSpitSpendingEntities1 context = new DBSpitSpendingEntities1())
            {
                var users = context.User_TB.Where(s => s.Cod_User != 0).ToList();
            }

             
        }

        protected void Btn_Save_Click(object sender, EventArgs e)
        {
            using (DBSpitSpendingEntities1 context = new DBSpitSpendingEntities1())
            {
                User_TB user = new User_TB
                {
                    Name = name.Text,
                    Bank_Account = bankAccount.Text
                };

                context.User_TB.Add(user);
                context.SaveChanges();

                name.Text = "";
                bankAccount.Text = "";
            }
        }
    }
}