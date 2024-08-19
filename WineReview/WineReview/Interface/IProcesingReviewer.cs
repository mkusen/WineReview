using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineReview.Interface
{
    internal interface IProcesingReviewer
    {
        public abstract static void Select(int num);
        public abstract static void LogIn();
        public abstract static void GetUser(string a, string b);
        public abstract static void SingIn();

    }
}
