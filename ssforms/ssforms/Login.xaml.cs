using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Xamarin.Forms;

namespace ssforms
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var client = new JsonServiceClient("http://10.136.46.60:8088");  
            var authResponse = client.Send<AuthenticateResponse>(new Authenticate
            {
                UserName = "Admin",
                Password = "Admin"
            });
            lblMessage.Text = "Logged in";
        }
    }
}
