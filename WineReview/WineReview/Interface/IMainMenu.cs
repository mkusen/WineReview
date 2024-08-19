using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineReview.Controller;

namespace WineReview.Interface
{
    public interface IMainMenu 
    {
        public static abstract void ChooseLoginOrSingin();

        public static abstract void Start();

        public abstract void Menu();

    }
}
