using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HwT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Questions questC = new Questions();
        
        List<string> listTQ = new List<string>();
        int scT, scL;
        int gaT;
        string answer;
        int lQAC;
        bool gameWasStart = false;
        //--------------------
        void GameStart()
        {
            scT = scL = gaT = 0;
            lblGoodAll.Text = $"{gaT}/{lQAC}";
            lblScore.Text = $"{scT}";

            PanMenu.Visible = false;
            PanMenu.Enabled = false;
            PanGame.Visible = true;
            PanGame.Enabled = true;
            PanEditor.Visible = false;
            PanEditor.Enabled = false;
            Random random = new Random();
            gameWasStart = true;

            List<string> listQA = questC.LoadQB();
            lQAC = listQA.Count;
            
            for (int i = 0; i < lQAC; i++)
            {
                int t = random.Next(0, listQA.Count - 1);
                listTQ.Add(listQA[t]);
                listQA.RemoveAt(t);
            }
            lblGoodAll.Text = $"0/{lQAC}";
            NextTurn();
        }

        void NextTurn()
        {
            if (listTQ.Count > 0)
            {
                LblQ.Text = listTQ[0].Remove(listTQ[0].Length - 3);
                answer = listTQ[0].Substring(listTQ[0].Length - 3);
                listTQ.RemoveAt(0);
            }
            else
            {
                PanGame.Enabled = false;
                MessageBox.Show("Конец игры, посмотрите результат");
                gameWasStart = false;
            }
        }

        void TestTF(string res)
        {
            if (res == answer)
            {
                Console.WriteLine("good");
                scL++;
                scT += scL;
                lblGoodAll.Text = $"{++gaT}/{lQAC}";
                lblScore.Text = $"{scT}";
                NextTurn();
            }
            else
            {
                Console.WriteLine("bad");
                scL = 0;
                lblGoodAll.Text = $"{gaT}/{lQAC}";
                NextTurn();
            }
        }
        //--------------------

        private void MBStart_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            TestTF("(t)");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            TestTF("(f)");
        }

        private void MBContinue_Click(object sender, EventArgs e)
        {
            PanMenu.Visible = false;
            PanMenu.Enabled = false;
            PanGame.Visible = true;
            PanGame.Enabled = true;
            PanEditor.Visible = false;
            PanEditor.Enabled = false;
        }

        private void hmEditBase_Click(object sender, EventArgs e)
        {
            PanMenu.Visible = false;
            PanMenu.Enabled = false;
            PanGame.Visible = false;
            PanGame.Enabled = false;
            PanEditor.Visible = true;
            PanEditor.Enabled = true;
            EditorRefresh();
        }

        private void hmMenu_Click(object sender, EventArgs e)
        {
            PanMenu.Visible = true;
            PanMenu.Enabled = true;
            PanGame.Visible = false;
            PanGame.Enabled = false;
            PanEditor.Visible = false;
            PanEditor.Enabled = false;
            if (gameWasStart) MBContinue.Enabled = true;
            else MBContinue.Enabled = false;
        }

        private void hmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------editor------
        #region Editor panel
        void EditorRefresh()
        {
            List<string> list = questC.LoadQB();
            string txt = "";
            int tempI = 0;
            string ans;
            foreach (var item in list)
            {
                ans = item.Substring(item.Length - 3) == "(t)" ? "Правда" : "Ложь";
                txt += $"{tempI++}. Утверждение: {item.Remove(item.Length - 3)}. Ответ: {ans}\n---\n";
            }
            editorTxt.Text = txt;
        }

        private void editorAdd_Click(object sender, EventArgs e)
        {
            string addq = Microsoft.VisualBasic.Interaction.InputBox("Введите вопрос и ответ в следующем виде (ответ пишется в самом конце вопроса, t - правда, или f - ложь): 1+1=3f");
            if (addq != "")
            {
                Question q = new Question(addq.Remove(addq.Length - 1), addq.Substring(addq.Length - 1));
                questC.obj.Add(q);
                questC.SaveQB();
            }
            EditorRefresh();
        }

        private void editorEdit_Click(object sender, EventArgs e)
        {
            string temp = Microsoft.VisualBasic.Interaction.InputBox("Введите номер вопроса");
            int indx;
            if (temp != "")
            {
                indx = Convert.ToInt32(temp);
                string editq = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите вопрос и ответ в следующем виде (ответ пишется в самом конце вопроса, t - правда, или f - ложь): 1+1=3f",
                $"Измените вопрос",
                $"{questC.obj[indx].quest}{questC.obj[indx].answer}");
                if (editq != "")
                {
                    questC.obj[indx].quest = editq.Remove(editq.Length - 1);
                    questC.obj[indx].answer = editq.Substring(editq.Length - 1);
                    questC.SaveQB();
                }
            }
            EditorRefresh();
        }

        private void editorDel_Click(object sender, EventArgs e)
        {
            string temp = Microsoft.VisualBasic.Interaction.InputBox("Введите номер вопроса");
            int indx;
            if (temp != "")
            {
                indx = Convert.ToInt32(temp);
                questC.obj.RemoveAt(indx);
                questC.SaveQB();
            }
            EditorRefresh();
        }

        private void editorClear_Click(object sender, EventArgs e)
        {
            questC.obj.Clear();
            questC.SaveQB();
            EditorRefresh();
        }
        #endregion
        //-----/editor------
    }
}
