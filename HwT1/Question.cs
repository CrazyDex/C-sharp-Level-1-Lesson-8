using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace HwT1
{
    [Serializable]
    public class Question
    {
        public string quest;
        public string answer;
        public Question(string q, string a)
        {
            quest = q;
            answer = a;
        }
        public Question()
        {
        }
    }
}
