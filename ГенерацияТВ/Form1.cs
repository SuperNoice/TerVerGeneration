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
using System.Diagnostics;


namespace ГенерацияТВ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateCountVariants();
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
        class Gen
        {
            DocX document;
            Paragraph paragraph;
            randBuff buff = new randBuff();
            Random r;
            string font;
            string[] allresult;
            int variantIterator;
            IExcel.Application excel;
            Form1 form1;

            public Gen(int countVariants, Form1 mainform)
            {
                form1 = mainform;
                r = new Random(System.DateTime.Now.Millisecond);
                allresult = new string[countVariants];
                excel = new IExcel.Application();
                font = "Times New Roman";
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".docx";
                saveFile.AddExtension = true;
                saveFile.Title = "Сохранить как...";
                saveFile.OverwritePrompt = true;
                saveFile.Filter = "Word files(*.docx)|*.docx|All files(*.*)|*.*";

                if (saveFile.ShowDialog() == DialogResult.Cancel)
                    return;

                // получаем выбранный файл
                string filename = saveFile.FileName;

                // создаём документ
                document = DocX.Create(filename);

                form1.progressBar.Maximum = countVariants;

                for (variantIterator = 0; variantIterator < countVariants; variantIterator++)
                {
                    form1.progressBar.Value = variantIterator;

                    paragraph = document.InsertParagraph();

                    if (variantIterator < (form1.studentsDataGrid.Rows.Count) - 1) paragraph.Append(form1.studentsDataGrid["studentName", variantIterator].Value.ToString()).Font(font).FontSize(10).Alignment = Alignment.right;

                    paragraph = document.InsertParagraph();
                    paragraph.Append(System.Convert.ToString(variantIterator + 1) + "  ВАРИАНТ").Font(font).FontSize(14).Bold().Alignment = Alignment.center;
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
                    gen11_12();
                    gen13_14();
                    gen15();
                    gen16();
                    gen17();
                    gen18();

                    if (variantIterator != countVariants) paragraph.InsertPageBreakAfterSelf();
                    paragraph = document.InsertParagraph();
                }

                // Вывод ответов
                paragraph = document.InsertParagraph();

                paragraph.Append("Ответы").Font(font).FontSize(16).Bold().Alignment = Alignment.center;

                for (variantIterator = 0; variantIterator < countVariants; variantIterator++)
                {
                    paragraph.Append("\nВариант " + (variantIterator + 1).ToString()).Font(font).FontSize(14).Bold().Alignment = Alignment.left;
                    paragraph.Append(allresult[variantIterator]).Font(font).FontSize(12).Alignment = Alignment.left;
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

            string doubleNormalize(string strIn)
            {
                int ptr = strIn.Length - 1, count = 0; ;

                while (strIn[ptr] != ',')
                {
                    ++count;
                    --ptr;
                    if (ptr == -1) return strIn;
                }

                if (count > 4)
                {
                    string strOut = "";
                    ptr = -1;
                    do
                    {
                        ++ptr;
                        strOut += strIn[ptr];
                    } while (strIn[ptr] != ',');

                    ++ptr;

                    for (int i = 0; i < 4; ++i, ++ptr)
                        strOut += strIn[ptr];

                    return strOut;
                }
                else return strIn;
            }

            private void gen1()
            {
                int all, part1, part2;
                int[] mas = new int[5] { 10, 20, 25, 50, 100 };

                all = mas[randInt(0, 4)];
                part1 = randInt(2, all - 2);
                part2 = all - part1;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("1.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В урне " + all.ToString() + " шаров: " + part1.ToString() + " белых и " + part2.ToString() + " черных. Из урны сразу вынимают два шара. Какова вероятность, что оба шара окажутся а) белыми, б) черными, в) по крайней мере один шар будет белым.").Font(font).FontSize(12);
                double resulta, resultb, resultd;
                resulta = (double)excel.WorksheetFunction.Combin(part1, 2) / (double)excel.WorksheetFunction.Combin(all, 2);
                resultb = (double)excel.WorksheetFunction.Combin(part2, 2) / (double)excel.WorksheetFunction.Combin(all, 2);
                resultd = 1 - (double)excel.WorksheetFunction.Combin(part2, 2) / (double)excel.WorksheetFunction.Combin(all, 2);
                allresult[variantIterator] += "\n1. a) " + doubleNormalize(resulta.ToString()) + ";\n    б) " + doubleNormalize(resultb.ToString()) + ";\n    в) " + doubleNormalize(resultd.ToString());
            }

            private void gen2()
            {
                int all, part1, part2, part3, quest;
                int[] mas = new int[4] { 10, 20, 25, 50 };

                all = mas[r.Next(0, 3)];
                part1 = r.Next(3, all - 3);
                part2 = all - part1;
                part3 = r.Next(4, all / 2);
                quest = r.Next(part2 < part3 ? part3 - part2 : 2, part1 > part3 ? part3 - 2 : part1 - 1);

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("2.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В урне " + part1.ToString() + " белых и " + part2.ToString() + " черных шаров. Наудачу отобраны " + part3.ToString() + " шаров. Найти вероятность того, что среди них окажется ровно " + quest.ToString() + " белых шаров.").Font(font).FontSize(12);
                double result = (double)excel.WorksheetFunction.Combin(part1, quest) * (double)excel.WorksheetFunction.Combin(part2, part3 - quest) / (double)excel.WorksheetFunction.Combin(all, part3);
                if (result > 1) MessageBox.Show("Говно");
                allresult[variantIterator] += "\n2. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen3()
            {
                double part;
                part = r.Next(3, 10);
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("3.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В колоде 32 карты. Наугад вынимают " + part + " карт. Найти вероятность того, что среди них окажутся хотя бы одна дама.").Font(font).FontSize(12);
                double result = 1d - (double)excel.WorksheetFunction.Combin(28, part) / (double)excel.WorksheetFunction.Combin(32, part);
                allresult[variantIterator] += "\n3. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen4()
            {
                int all, part1, part2, quest;
                int[] mas = new int[4] { 10, 20, 25, 50 };
                all = mas[r.Next(0, 3)];
                part2 = r.Next(2, all / 2);

                part1 = all - part2;
                quest = r.Next(2, part2 * 2);
                quest = quest % 2 == 0 ? quest : quest - 1;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("4.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("В партии готовой продукции, состоящей из " + all.ToString() + " изделий, " + part2.ToString() + " бракованных. Найти вероятность того, что при случайном выборе " + quest.ToString() + " изделий число бракованных и не бракованных изделий окажется поровну.").Font(font).FontSize(12);
                double result = (double)excel.WorksheetFunction.Combin(part1, quest / 2) * (double)excel.WorksheetFunction.Combin(part2, quest / 2) / (double)excel.WorksheetFunction.Combin(all, quest);
                if (result > 1) MessageBox.Show("Говно");
                allresult[variantIterator] += "\n4. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen5()
            {
                double part1, part2, part3, part4;
                part1 = r.Next(5, 20);
                part2 = r.Next(3, (int)(part1 - 2));
                part3 = part1 - part2;
                part4 = r.Next(2, (int)part2);

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("5.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Устройство состоит из " + part1.ToString() + " элементов, из которых " + part3.ToString() + " изношены. При включении устройства включаются случайным образом " + part4.ToString() + " элемента. Найти вероятность того, что включенными окажутся неизношенные элементы.").Font(font).FontSize(12);
                double result = (double)excel.WorksheetFunction.Combin(part2, part4) / (double)excel.WorksheetFunction.Combin(part1, part4);
                allresult[variantIterator] += "\n5. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen6()
            {
                double part1, part2;
                part1 = (double)randInt(1, 9) / 10d;
                part2 = (double)randInt(1, 9) / 10d;



                paragraph = document.InsertParagraph();
                paragraph.AppendLine("6.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Произведен залп из двух орудий. Вероятность попадания из первого орудия равна " + part1.ToString() + ", из второго " + part2.ToString() + ". Найти вероятность поражения цели.").Font(font).FontSize(12);
                double result = 1 - (1 - part1) * (1 - part2);
                if (result > 1) MessageBox.Show("Говно");
                allresult[variantIterator] += "\n6. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen7()
            {
                double part1, part2, part3;
                part1 = r.Next(1, 8) / 10d;
                part2 = r.Next(1, 8) / 10d;
                part3 = r.Next(1, 8) / 10d;


                paragraph = document.InsertParagraph();
                paragraph.AppendLine("7.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Для разрушения моста достаточно попадания одной авиационной бомбы. Найти вероятность того, что мост будет разрушен, если на него сбросить три бомбы, вероятности попадания которых соответственно равны: p1 = " + part1.ToString() + ", р2 = " + part2.ToString() + " р3 = " + part3.ToString() + ".").Font(font).FontSize(12);
                double result = 1 - (1 - part1) * (1 - part2) * (1 - part3);
                allresult[variantIterator] += "\n7. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen8()
            {
                double part1, part2, part3;
                part1 = (double)randInt(1, 9) / 100d;
                part2 = (double)randInt(1, 9) / 100d;
                part3 = (double)randInt(1, 9) / 100d;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("8.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Рабочий обслуживает 3 автомата. Вероятность брака для первого автомата равна " + part1.ToString() + "; для второго " + part2.ToString() + "; для третьего " + part3.ToString() + ". Производительность всех автоматов одинакова. Изготовленные детали попадают на общий конвейер. Определить вероятность того, что взятая наугад деталь будет годной.").Font(font).FontSize(12);
                double result = 1d - (((1d / 3d) * part1) + ((1d / 3d) * part2) + ((1d / 3d) * part3));
                if (result > 1) MessageBox.Show("Говно");
                allresult[variantIterator] += "\n8. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen9()
            {

                double part1, part2, part3, part4;
                part1 = r.Next(1, 9);
                part2 = 10 - part1;
                part3 = r.Next(85, 95);
                part4 = (double)r.Next(75, (int)part3) / 100d;
                part3 /= 100d;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("9.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Из 10 винтовок " + part1.ToString() + " имеют оптический прицел. Вероятность того, что стрелок поразит мишень при выстреле из винтовки с оптическим прицелом равна " + part3.ToString() + "; для винтовки без оптического прицела " + part4.ToString() + ". Стрелок поразил мишень из наугад взятой винтовки. Найти вероятность того, что стрелок стрелял из винтовки без оптического прицела.").Font(font).FontSize(12);
                part1 /= 10d;
                part2 /= 10d;
                double preresult = part1 * part3 + part2 * part4;
                double result = part2 * part4 / preresult;
                allresult[variantIterator] += "\n9. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen10()
            {
                double part1, part2, part3;
                part1 = r.Next(3, 15);
                part2 = r.Next(1, (int)part1 - 1);
                part3 = (double)r.Next(15, 35) / 100d;



                paragraph = document.InsertParagraph();
                paragraph.AppendLine("10.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Вероятность выигрыша по облигации займа равна " + part3.ToString() + ". Какова вероятность того, что из " + part1.ToString() + " взятых облигаций " + part2.ToString() + " выиграют?").Font(font).FontSize(12);
                double result = (double)excel.WorksheetFunction.Combin(part1, part2) * Math.Pow(part3, part2) * Math.Pow(1 - part3, part1 - part2);
                if (result > 1) MessageBox.Show("Говно");
                allresult[variantIterator] += "\n10. " + doubleNormalize(result.ToString()) + ";";
            }

            private void gen11_12()
            {
                double part1, part2, part3, part4, part5;
                part1 = r.Next(1, 8);
                part2 = r.Next(1, 10 - (int)part1);
                part3 = 10 - part1 - part2;
                part4 = r.Next(0, (int)part1) / 10d;
                part1 = Math.Abs(part1 / 10d - part4);
                part5 = r.Next(0, (int)part2) / 10d;
                part2 = Math.Abs(part2 / 10d - part5);
                part3 /= 10d;
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("11.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Случайная величина ξ имеет распределения вероятностей, представленное таблицей:").Font(font).FontSize(12);
                Table table = document.AddTable(2, 6);
                table.Alignment = Alignment.center;
                table.SetColumnWidth(0, 40);
                table.SetColumnWidth(1, 40);
                table.SetColumnWidth(2, 40);
                table.SetColumnWidth(3, 40);
                table.SetColumnWidth(4, 40);
                table.SetColumnWidth(5, 40);
                table.Rows[0].Cells[0].Paragraphs[0].Append("ξ").Alignment = Alignment.center;
                table.Rows[1].Cells[0].Paragraphs[0].Append("P(x)").Alignment = Alignment.center;
                table.Rows[0].Cells[1].Paragraphs[0].Append("-1").Alignment = Alignment.center;
                table.Rows[0].Cells[2].Paragraphs[0].Append("0").Alignment = Alignment.center;
                table.Rows[0].Cells[3].Paragraphs[0].Append("1").Alignment = Alignment.center;
                table.Rows[0].Cells[4].Paragraphs[0].Append("2").Alignment = Alignment.center;
                table.Rows[0].Cells[5].Paragraphs[0].Append("3").Alignment = Alignment.center;
                table.Rows[1].Cells[1].Paragraphs[0].Append(part1.ToString()).Alignment = Alignment.center;
                table.Rows[1].Cells[2].Paragraphs[0].Append(part2.ToString()).Alignment = Alignment.center;
                table.Rows[1].Cells[3].Paragraphs[0].Append(part3.ToString()).Alignment = Alignment.center;
                table.Rows[1].Cells[4].Paragraphs[0].Append(part4.ToString()).Alignment = Alignment.center;
                table.Rows[1].Cells[5].Paragraphs[0].Append(part5.ToString()).Alignment = Alignment.center;

                paragraph = document.InsertParagraph();
                paragraph.InsertTableBeforeSelf(table);
                paragraph.Append("Построить многоугольник распределения и найти функцию распределения F(x).").Font(font).FontSize(12);




                string resultf = "φ(х)=0, при x≤-1\n      φ(х)=" + part1.ToString() + ", при -1<x≤0\n" +
                    "      φ(х)=" + (part1 + part2).ToString() + ", при 0<x≤1\n" +
                    "      φ(х)=" + (part1 + part2 + part3).ToString() + ", при 1<x≤2\n" +
                    "      φ(х)=" + (part1 + part2 + part3 + part4).ToString() + ", при 2<x≤3\n" +
                    "      φ(х)=" + (part1 + part2 + part3 + part4 + part5).ToString() + ", при x>3";

                allresult[variantIterator] += "\n11. " + resultf + ";";


                paragraph = document.InsertParagraph();
                paragraph.AppendLine("12.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Найти М(ξ), D(ξ), σ(ξ) случайной величины ξ примера 11.").Font(font).FontSize(12);
                double ME, DE, q;
                ME = -1 * part1 + 0 * part2 + 1 * part3 + 2 * part4 + 3 * part5;
                DE = 1 * part1 + 0 * part2 + 1 * part3 + 4 * part4 + 9 * part5 - ME * ME;
                q = Math.Sqrt(DE);

                allresult[variantIterator] += "\n12. М(ξ)=" + doubleNormalize(ME.ToString()) + "\n      D(ξ)=" + doubleNormalize(DE.ToString()) + "\n      σ(ξ)= " + doubleNormalize(q.ToString()) + "; ";
            }

            private void gen13_14()
            {
                string[] f1 = new string[] { "-π/2", "-π/3", "-π/4", "-π/6", "0" };
                string[] f2 = new string[] { "π/2", "π/3", "π/4", "π/6" };
                int part1 = r.Next(0, 4);
                int part2 = r.Next(0, 3);
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("13.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Задана плотность распределения непрерывной случайной величины ξ:"
                + "\n φ(х)=K*cos(x), ∀x ∈ (" + f1[part1] + " ; " + f2[part2] + "]\n φ(х)=0, ∀x ∉ (" + f1[part1] + " ; " + f2[part2] + "]\nНайти K и функцию распределения F(x).").Font(font).FontSize(12);

                string[,] kresultm = new string[,] { { "1/2", "(-2√3 + 4)", "(√2 +2)","2/3"},
                                                     {"(4-2√3)","√3/3","(-2√2 + 2√3)","(-1+√3)"},
                                                     {"(2-√2)","(2√3-2√2)","√2/2","(-2+2√2)" },
                                                     {"2/3","(√3 -1)","(2√2-2)","1" },
                                                     {"1","2√3/3","√2","2" } };
                string kresult = kresultm[part1, part2];

                string fresult = "\n      φ(х)=0,при x≤" + f1[part1] +
                                 "\n      φ(х)=" + kresult + "*sin(x),при " + f1[part1] + " < x ≤ " + f2[part2] +
                                 "\n      φ(х)=1,при x > " + f2[part2];

                allresult[variantIterator] += "\n13. K= " + kresult.ToString() + fresult + "; ";

                double ME, DE, q;
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("14.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("ξ - непрерывная случайная величина примера 13. Найти М(ξ), D(ξ), σ(ξ).").Font(font).FontSize(12);

                double[] f1num = new double[] { -Math.PI / 2d, -Math.PI / 3d, -Math.PI / 4d, -Math.PI / 6d, 0d };
                double[] f2num = new double[] { Math.PI / 2d, Math.PI / 3d, Math.PI / 4d, Math.PI / 6d };
                double[,] knum = new double[,] { { 1d/2d, -2d*(double)Math.Sqrt(3d) + 4d, (double)Math.Sqrt(2d) +2d,2d/3d},
                                                 {4d-2d*(double)Math.Sqrt(3d),(double)Math.Sqrt(3d)/3d,-2d*(double)Math.Sqrt(2d) + 2d*(double)Math.Sqrt(3d),-1d*(double)Math.Sqrt(3d)},
                                                 {2d-(double)Math.Sqrt(2d),2d*(double)Math.Sqrt(3d)-2d*(double)Math.Sqrt(2d),(double)Math.Sqrt(2d)/2d,-2d+2d*(double)Math.Sqrt(2d) },
                                                 {2d/3d,(double)Math.Sqrt(3d) -1d,2d*(double)Math.Sqrt(2d)-2d,1d },
                                                 {1d,2d*(double)Math.Sqrt(3d)/3d,(double)Math.Sqrt(2d),2d } };

                ME = knum[part1, part2] * (f2num[part2] * Math.Sin(f2num[part2]) + Math.Cos(f2num[part2]) - (f1num[part1] * Math.Sin(f1num[part1]) + Math.Cos(f1num[part1])));
                DE = knum[part1, part2] * (f2num[part2] * f2num[part2] * Math.Sin(f2num[part2]) + 2d * f2num[part2] * Math.Cos(f2num[part2]) + 2d * Math.Sin(f2num[part2]) - (f1num[part1] * f2num[part1] * Math.Sin(f1num[part1]) + 2d * f1num[part1] * Math.Cos(f1num[part1]) + 2d * Math.Sin(f1num[part1]))) - ME * ME;
                q = Math.Sqrt(DE);

                allresult[variantIterator] +=
                    "\n14. М(ξ)= " + doubleNormalize(ME.ToString()) +
                    "\n      D(ξ)= " + doubleNormalize(DE.ToString()) +
                    "\n      σ(ξ)= " + doubleNormalize(q.ToString()) + ";";
            }

            private void gen15()
            {
                double all, part1, part2;
                all = r.Next(20, 50);

                part2 = (double)r.Next(5, 9) / 10d;
 
                all *= 100;
                double x = (double)r.Next(-200, 200) / 100d;
                part1 = (int)(x * Math.Sqrt(all * part2 * (1d - part2)) + all * part2);   
                double result = (double)excel.WorksheetFunction.Norm_S_Dist(x,false) / (double)Math.Sqrt(all * part2 * (1d - part2));
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("15.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Вероятность наступления события А в одном опыте равна " + part2.ToString() + ". Найти вероятность того, что событие А наступит " + part1.ToString() + " раз в " + all.ToString() + " опытах.").Font(font).FontSize(12);
                allresult[variantIterator] += "\n15. " + doubleNormalize(result.ToString()) + "; ";
            }

            private void gen16()
            {

                double a, q;

                a = (double)randInt(5, 20);
                q = (double)randInt(1, (int)a) / 10d;
                a /= 10d;
                double result = (excel.WorksheetFunction.NormSDist((1d - a) / q) - 0.5) - (excel.WorksheetFunction.NormSDist((0.3 - a) / q) - 0.5);
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("16.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;

                paragraph.Append("ξ - нормально распределенная случайная величина с парамет­рами а=" + a.ToString() + " σ=" + q.ToString() + ". Найти Р(0,3<ξ<1).").Font(font).FontSize(12);

                if (result > 1) MessageBox.Show("Говно");
                allresult[variantIterator] += "\n16. " + doubleNormalize(result.ToString()) + "; ";
            }

            private void gen17()
            {
                double all, part1, part2, result;
                all = r.Next(50, 100);
                part1 = (double)r.Next(5, 9) / 10d;

                all *= 100d;

                double x1, x2;
                x1 = (double)r.Next(-250, 250)/100d;
                part2 = (int)(x1 * Math.Sqrt(all * part1 * (1d - part1)) + all * part1);           
                x2 = (0d - all * part1) / Math.Sqrt(all * part1 * (1d - part1));
                double F1 = (double)excel.WorksheetFunction.Norm_S_Dist(x1, true) - 0.5;
                    double F2= (double)excel.WorksheetFunction.Norm_S_Dist(x2, true)-0.5;
                result = F1 - F2;

                paragraph = document.InsertParagraph();
                paragraph.AppendLine("17.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Вероятность появления события в каждом из " + all.ToString() + " независимых испытании постоянна и равна " + part1.ToString() + ". Найти вероятность того, что событие появится не более чем " + part2.ToString() + " раз.").Font(font).FontSize(12);
                if (result > 1) MessageBox.Show("Говно");
                allresult[variantIterator] += "\n17. " + doubleNormalize(result.ToString()) + "; ";
            }

            private void gen18()
            {
                double part1, part2, part3, part4, part5, part6, Mn, ME, Dn, DE, MEn, DEn;

                part1 = r.Next(1, 8);
                part2 = r.Next(1, 10 - (int)part1);
                part3 = 10 - part1 - part2;
                part4 = r.Next(0, (int)part1) / 10d;
                part1 = Math.Abs(part1 / 10d - part4);
                part5 = r.Next(0, (int)part2) / 10d;
                part2 = Math.Abs(part2 / 10d - part5);
                part6 = r.Next(0, (int)part3) / 10d;
                part3 = Math.Abs(part3 / 10d - part6);
                paragraph = document.InsertParagraph();
                paragraph.AppendLine("18.  ").Font(font).FontSize(12).Bold().Alignment = Alignment.left;
                paragraph.Append("Дана таблица распределения вероятностей двумерной случайной величины (ξ,η)").Font(font).FontSize(12);
                Table table = document.AddTable(3, 4);
                table.Alignment = Alignment.center;
                table.SetColumnWidth(0, 40);
                table.SetColumnWidth(1, 40);
                table.SetColumnWidth(2, 40);
                table.SetColumnWidth(3, 40);
                table.Rows[0].Cells[0].Paragraphs[0].Append("ξ/η").Alignment = Alignment.center;
                table.Rows[0].Cells[1].Paragraphs[0].Append("-1").Alignment = Alignment.center;
                table.Rows[0].Cells[2].Paragraphs[0].Append("0").Alignment = Alignment.center;
                table.Rows[0].Cells[3].Paragraphs[0].Append("1").Alignment = Alignment.center;
                table.Rows[1].Cells[0].Paragraphs[0].Append("0").Alignment = Alignment.center;
                table.Rows[2].Cells[0].Paragraphs[0].Append("1").Alignment = Alignment.center;
                table.Rows[1].Cells[1].Paragraphs[0].Append(part1.ToString()).Alignment = Alignment.center;
                table.Rows[1].Cells[2].Paragraphs[0].Append(part2.ToString()).Alignment = Alignment.center;
                table.Rows[1].Cells[3].Paragraphs[0].Append(part3.ToString()).Alignment = Alignment.center;
                table.Rows[2].Cells[1].Paragraphs[0].Append(part4.ToString()).Alignment = Alignment.center;
                table.Rows[2].Cells[2].Paragraphs[0].Append(part5.ToString()).Alignment = Alignment.center;
                table.Rows[2].Cells[3].Paragraphs[0].Append(part6.ToString()).Alignment = Alignment.center;

                paragraph = document.InsertParagraph();
                paragraph.InsertTableBeforeSelf(table);
                paragraph.Append("Найти М(ξ), М(η), М(ξη), D(ξ), D(η), D(ξη).").Font(font).FontSize(12);
                ME = part4 + part5 + part6;
                DE = part4 + part5 + part6 - ME * ME;
                Mn = (part1 + part4) * (-1) + part3 + part6;
                Dn = (part1 + part4) - Mn * Mn;

                MEn = 1d * (-1d) * part4 + 1d * 1d * part6;
                DEn = 1d * 1d * part4 + 1d * 1d + part6 - MEn * MEn;
                allresult[variantIterator] += "\n18. М(ξ)= " + ME.ToString() +
                    "\n      D(ξ)= " + doubleNormalize(DE.ToString()) +
                    "\n      М(η)= " + doubleNormalize(Mn.ToString()) +
                    "\n      D(η)= " + doubleNormalize(Dn.ToString()) +
                    "\n      М(ξη)= " + doubleNormalize(MEn.ToString()) +
                    "\n      D(ξη)= " + doubleNormalize(DEn.ToString()) + ". ";

            }

        }

        private void genButton_Click(object sender, EventArgs e)
        {
            if (variantTextBox.Text == "") { MessageBox.Show("Невнрное кол-во вариантов!"); return; }

            try
            {
                int countVariantstest = System.Convert.ToInt32(variantTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное кол-во вариантов!"); return;
            }

            int countVariants = System.Convert.ToInt32(variantTextBox.Text);

            if (countVariants < 1) { MessageBox.Show("Неверное кол-во вариантов!"); return; }

            UseWaitCursor = true;

            Gen gen = new Gen(countVariants, this);

            progressBar.Value = 0;

            UseWaitCursor = false;
        }

        private void addStudentsButton_Click(object sender, EventArgs e)
        {
            Form addStudents = new addStudentsForm(this);
            addStudents.Show();

        }

        public void updateCountVariants()
        {
            variantTextBox.Text = (studentsDataGrid.Rows.Count - 1).ToString();
        }

        private void studentsDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateCountVariants();
        }

        private void studentsDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateCountVariants();
        }
    }
}
