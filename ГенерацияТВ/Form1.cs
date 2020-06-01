using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace ГенерацияТВ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class randBuff
        {
            private int[] buff = new int[3];
            private int pointer = 0;

            public randBuff()
            {
                buff[0] = 0; buff[1] = 0; buff[2] = 0;
            }

            public void add(int newEl)
            {
                buff[pointer] = newEl;
                if (pointer == 2) pointer = 0;
                else pointer++;
            }

            public bool Contains(int cur)
            {
                if (buff.Contains<int>(cur)) return true;
                else return false;
            }
        }
        class Gen : Form
        {
            DocX document;
            Paragraph paragraph;
            randBuff buff = new randBuff();
            Random r;

            public Gen(int countVariants)
            {
                r = new Random(System.DateTime.Now.Millisecond);
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".docx";
                saveFile.AddExtension = true;
                saveFile.Title = "Сохранить как...";
                saveFile.OverwritePrompt = true;
                saveFile.Filter = "Text files(*.docx)|*.docx|All files(*.*)|*.*";
                
                if (saveFile.ShowDialog() == DialogResult.Cancel)
                    return;

                // получаем выбранный файл
                string filename = saveFile.FileName;

                // создаём документ
                document = DocX.Create(filename);

                for (int i = 1; i <= countVariants; i++)
                {
                    paragraph = document.InsertParagraph();
                    paragraph.Append(System.Convert.ToString(i) + "  ВАРИАНТ").Font("Century Schoolbook").FontSize(16).Bold().Alignment = Alignment.center;
                    paragraph.AppendLine();

                    gen1();
                    gen2();
                    gen3();
                    gen4();
                    gen5();
                    gen6();
                    gen7();
                    gen8();
                    gen9();
                    gen10();
                    gen11();
                    gen12();
                    gen13();
                    gen14();
                    gen15();
                    gen16();
                    gen17();
                    gen18();

                    if (i != countVariants) paragraph.InsertPageBreakAfterSelf();
                    paragraph = document.InsertParagraph();
                }
                document.Save();
                MessageBox.Show("Файл сохранен");
            }

            int randInt(int from, int to)
            {
                int res;

                do
                {
                    res = r.Next(from, to);
                } while (buff.Contains(res));
                buff.add(res);
                
                return res;
            }

            private void gen1()
            {
                int all, part1, part2;
                int[] mas = new int[5] { 10, 20, 25, 50, 100 };

                all = mas[randInt(0, 4)];
                part1 = randInt(2, all - 2);
                part2 = all - part1;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("1.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В урне " + all.ToString() + " шаров: " + part1.ToString() + " белых и " + part2.ToString() + " черных. Из урны сразу вынимают два шара. Какова вероятность, что оба шара окажутся а) белыми, б) черными, в) по крайней мере один шар будет белым.").Font("Century Schoolbook").FontSize(12);
            }

            private void gen2()
            {
                int all, part1, part2, part3, quest;
                int[] mas = new int[4] { 10, 20, 25, 50};
                
                all = mas[randInt(0, 3)];
                part1 = randInt(3, all - 1);                            
                part2 = all - part1;
                part3 = randInt(4, all/2);
                quest = randInt(2, part3 - 2);

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("2.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В урне " + part1.ToString() +" белых и "+ part2.ToString() +" черных шаров. Наудачу  отобраны "+ part3.ToString() +" шаров.Найти вероятность того, что среди  них окажется ровно "+ quest.ToString() +" белых шаров.").Font("Century Schoolbook").FontSize(12);
                // otvetC( part1,quest)*C(part2,part3 - quest)/C(all,part3)
            }

            private void gen3()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("3.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen4()
            {
                int all, part1, part2, quest;
                int[] mas = new int[4] { 10, 20, 25, 50 };

                all = mas[randInt(0, 3)];
                part2 = randInt(2, all/2);
                part1 = all - part2;
                quest = randInt(2, part2 * 2);
                quest = quest % 2 == 0 ? quest : quest - 1;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("4.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В партии готовой продукции, состоящей из " + all.ToString() + " изделий, " + part2.ToString() + " брако­ванных. Найти вероятность того, что при случайном выборе " + quest.ToString() + "изделий число бракованных и небракованных изделий  окажется поровну.").Font("Century Schoolbook").FontSize(12);
                // otvetC( part1,quest/2)*C(part2, quest/2)/C(all, quest)
            }

            private void gen5()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("5.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen6()
            {





                paragraph = document.InsertParagraph();
                paragraph.AppendLine("6.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen7()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("7.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen8()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("8.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen9()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("9.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen10()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("10.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen11()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("11.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen12()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("12.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen13()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("13.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen14()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("14.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen15()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("15.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen16()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("16.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen17()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("17.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen18()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("18.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }



        }

        private void genButton_Click(object sender, EventArgs e)
        {
            if (variantTextBox.Text == "") { MessageBox.Show("Невнрное кол-во вариантов!"); return; }

            int countVariants = System.Convert.ToInt32(variantTextBox.Text);

            if (countVariants < 1) { MessageBox.Show("Неверное кол-во вариантов!"); return; }

            Gen gen = new Gen(countVariants);

        }
    }
}
