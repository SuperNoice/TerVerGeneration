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
using Microsoft.Office.Interop.Excel;
using IExcel = Microsoft.Office.Interop.Excel;

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
            IExcel.Application excel;
            public Gen(int countVariants)
            {
                r = new Random(System.DateTime.Now.Millisecond);
                excel = new IExcel.Application();
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

                if (to - from + 1 < 4)
                {
                    do
                    {
                        res = r.Next(from, to);
                    } while (buff.Contains(res));
                    buff.add(res);
                }
                else res = r.Next(from, to);

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
               
                all = mas[r.Next(0, 3)];
                part1 = r.Next(3, all - 3);                            
                part2 = all - part1;
                part3 = r.Next(4, all/2);
                quest = r.Next(part2 < part3 ? part3 - part2:2, part1 > part3 ? part3 - 2 : part1 - 1);

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("2.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В урне " + part1.ToString() +" белых и "+ part2.ToString() +" черных шаров. Наудачу отобраны "+ part3.ToString() +" шаров. Найти вероятность того, что среди них окажется ровно "+ quest.ToString() +" белых шаров.").Font("Century Schoolbook").FontSize(12);
                double result = (double)excel.WorksheetFunction.Combin(part1, quest) * (double)excel.WorksheetFunction.Combin(part2, part3 - quest) / (double)excel.WorksheetFunction.Combin(all, part3);
                if (result > 1) MessageBox.Show("Говно");
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
                all = mas[r.Next(0, 3)];
                part2 = r.Next(2, all/2);

                part1 = all - part2;
                quest = r.Next(2, part2 * 2);
                quest = quest % 2 == 0 ? quest : quest - 1;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("4.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В партии готовой продукции, состоящей из " + all.ToString() + " изделий, " + part2.ToString() + " брако­ванных. Найти вероятность того, что при случайном выборе " + quest.ToString() + " изделий число бракованных и не бракованных изделий окажется поровну.").Font("Century Schoolbook").FontSize(12);
                double result = (double)excel.WorksheetFunction.Combin(part1, quest / 2) * (double)excel.WorksheetFunction.Combin(part2, quest / 2) / (double)excel.WorksheetFunction.Combin(all, quest);
                if (result > 1) MessageBox.Show("Говно");
            }

            private void gen5()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("5.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen6()
            {
                double part1, part2;
                part1 = (double)randInt(1, 9) / 10d;
                part2 = (double)randInt(1, 9) / 10d;



                paragraph = document.InsertParagraph();
                paragraph.AppendLine("6.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Произведен залп из двух орудий. Вероятность попадания из первого орудия равна " + part1.ToString() + ", из второго " + part2.ToString() + ". Найти вероятность поражения цели.").Font("Century Schoolbook").FontSize(12);
                double result = 1 - (1 - part1) * (1 - part2);
                if (result > 1) MessageBox.Show("Говно");
            }

            private void gen7()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("7.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen8()
            {
                double part1, part2, part3;
                part1 = (double)randInt(1, 9) / 100d;
                part2 = (double)randInt(1, 9) / 100d;
                part3 = (double)randInt(1, 9) / 100d;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("8.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Рабочий обслуживает 3 автомата. Вероятность брака для пер­вого автомата равна " + part1.ToString() + "; для второго " + part2.ToString() + "; для третьего "+part3.ToString()+ ". Производи­тельность всех автоматов одинакова. Изготовленные детали попадают на общий конвейер. Определить вероятность того, что взятая наугад деталь будет годной.").Font("Century Schoolbook").FontSize(12);
                double result = 1 - (1 / 3 * part1 + 1 / 3 * part2 + 1 / 3 * part3);
                if (result > 1) MessageBox.Show("Говно");
            }

            private void gen9()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("9.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;


            }

            private void gen10()
            {
                double part1, part2, part3;
                part1 = r.Next(3, 15);
                part2 = r.Next(1, (int)part1 - 1);
                part3 = (double)r.Next(15, 35)/100d;



                paragraph = document.InsertParagraph();
                paragraph.AppendLine("10.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Вероятность выигрыша по облигации займа равна " + part3.ToString() + ". Какова вероятность того, что из " + part1.ToString() + " взятых облигаций " + part2.ToString() + " выиграют?").Font("Century Schoolbook").FontSize(12);
                double result = (double)excel.WorksheetFunction.Combin(part1, part2) * Math.Pow(part3, part2) * Math.Pow(1 - part3, part1 - part2);
                if (result > 1) MessageBox.Show("Говно");
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
                double a, q;

                a = (double)randInt(5, 20);
                q = (double)randInt(1, (int)a) / 10d;
                a /= 10d;
                double result = (excel.WorksheetFunction.NormSDist((1 - a) / q) - 0.5) - (excel.WorksheetFunction.NormSDist((0.3 - a) / q) - 0.5);
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("16.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("E - нормально распределенная случайная величина с парамет­рами а=" + a.ToString() + "  q=" + q.ToString() + ".  Найти Р(0,3<E<1).").Font("Century Schoolbook").FontSize(12);
                if (result > 1) MessageBox.Show("Говно");

            }

            private void gen17()
            {
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("17.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                
            }

            private void gen18()
            {
                double part1, part2, part3, part4, part5, part6,Mn,ME,Dn,DE,ME0n;

                part1 = r.Next(1, 8);
                part2 = r.Next(1, 10 - (int)part1);
                part3 = 10 - part1 - part2;
                part4 = r.Next(0, (int)part1)/10d;
                part1 = Math.Abs(part1/10d - part4);
                part5 = r.Next(0, (int)part2) / 10d;
                part2 = Math.Abs(part2/10d - part5);
                part6 = r.Next(0, (int)part3) / 10d;
                part3 = Math.Abs(part3 / 10d - part6);
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("18.  ").Font("Century Schoolbook").FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Дана таблица распределения вероятностей двумерной случай­ной величины (E,n?)").Font("Century Schoolbook").FontSize(12);
                Table table = document.AddTable(3, 4);
                table.Alignment = Alignment.left;
                table.Rows[0].Cells[0].Paragraphs[0].Append("E,n");
                table.Rows[0].Cells[1].Paragraphs[0].Append("-1");
                table.Rows[0].Cells[2].Paragraphs[0].Append("0");
                table.Rows[0].Cells[3].Paragraphs[0].Append("1");
                table.Rows[1].Cells[0].Paragraphs[0].Append("0");
                table.Rows[2].Cells[0].Paragraphs[0].Append("1");
                table.Rows[1].Cells[1].Paragraphs[0].Append(part1.ToString());
                table.Rows[1].Cells[2].Paragraphs[0].Append(part2.ToString());
                table.Rows[1].Cells[3].Paragraphs[0].Append(part3.ToString());
                table.Rows[2].Cells[1].Paragraphs[0].Append(part4.ToString());
                table.Rows[2].Cells[2].Paragraphs[0].Append(part5.ToString());
                table.Rows[2].Cells[3].Paragraphs[0].Append(part6.ToString());

                paragraph = document.InsertParagraph();
                paragraph.InsertTableBeforeSelf(table);
                
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
