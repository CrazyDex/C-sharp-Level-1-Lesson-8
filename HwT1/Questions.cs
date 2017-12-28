using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace HwT1
{
    class Questions
    {
        string fileName = "questionsDB.xml";
        public List<Question> obj = new List<Question>();

        public void NullBase()
        {
            Question question1 = new Question("Вы не редактировали базу вопросов, или она была пуста", "t");
            obj.Add(question1);
            SaveQB();
        }

        public List<string> LoadQB()
        {
            XmlSerializer xsr = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            List<string> list = new List<string>();
            try
            {
                obj = (List<Question>)xsr.Deserialize(fStream);
                fStream.Close();
            }
            catch (Exception e)
            {
                fStream.Close();
                NullBase();
            }
            finally
            {
                foreach (var item in obj)
                {
                    list.Add($"{item.quest}({item.answer})");
                }
            }
            return list;
        }

        public void SaveQB()
        {
            XmlSerializer xsr = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xsr.Serialize(fStream, obj);
            fStream.Close();
        }
    }
}
