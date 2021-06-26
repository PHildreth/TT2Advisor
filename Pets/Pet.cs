using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.Pets
{
    public class Pet<T> where T : IPet
    {
        public Pet(JToken petToken)
        {
            IPet.Level = (int)petToken.SelectToken("");
        }
    }
}
