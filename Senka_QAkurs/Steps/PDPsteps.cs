using Senka_QAkurs.Helpers;
using Senka_QAkurs.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    public class PDPsteps : Base
    {
        [Given(@"user opens '(.*)' section")]
        public void GivenUserOpensSection(string p0)
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.Dresses);

        }


    }
}
