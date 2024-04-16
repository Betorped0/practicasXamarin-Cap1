using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mainshell : Shell
    {
        public Mainshell()
        {
            InitializeComponent();
            Routing.RegisterRoute("articleview", 
                typeof(ArticleView));
        }
    }
}