using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decimo_sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Orange Solar Power");
            checkedListBox1.Items.Add("Resun Solar Energy");
            checkedListBox1.Items.Add("Changzhou GS Energy");
            checkedListBox1.Items.Add("CSG PVTech Co");
            checkedListBox1.Items.Add("Tamesol Desa S.L.");
            checkedListBox1.Items.Add("Jiangsu Runda PV Co");
            checkedListBox1.Items.Add("Sky Energy Indonesia");
            checkedListBox1.Items.Add("Anhui Daheng Energy Technology");
            checkedListBox1.Items.Add("Luxen Solar Energy Co");
            checkedListBox1.Items.Add("Sun Electronics International");
            checkedListBox1.Items.Add("Infinity New Energy Co");
            checkedListBox1.Items.Add("Suzhou Suncome Solar Science");
            checkedListBox1.Items.Add("Jiangyin Shine Science and Tech");
            checkedListBox1.Items.Add("Chinaland Solar Energy Co");
            checkedListBox1.Items.Add("Jetion Solar (China) Co");
            checkedListBox1.Items.Add("Econess Energy Co");
            checkedListBox1.Items.Add("YY Solar Co., Ltd.");
            checkedListBox1.Items.Add("TN Solar");
            checkedListBox1.Items.Add("Jinhua Dokio Technology Co.");
            checkedListBox1.Items.Add("Risen Energy Co., Ltd.");
            checkedListBox1.Items.Add("Infinity New Energy Co., Ltd.");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            checkedListBox2.Items.Clear();


            if (checkedListBox1.CheckedItems.Count > 1) //mensaje para mas de uno
            {
                MessageBox.Show("solo se puede seleccionar un checkox");
                checkedListBox2.Items.Clear();
                foreach (int a in checkedListBox1.CheckedIndices) //se quita la seleccion de los listcheckbox
                {
                    checkedListBox1.SetItemCheckState(a, CheckState.Unchecked);
                }
            }

            if (checkedListBox1.CheckedItems.Count == 1) //validacion solo este seleccionada uno
            {
                listBox1.Items.Add("1-> " + checkedListBox1.CheckedItems[0].ToString());

                if (checkedListBox1.CheckedItems[0] == "Orange Solar Power")
                {
                    checkedListBox2.Items.Add("OSP-SG270M");
                    checkedListBox2.Items.Add("OSP-SG280M");
                    checkedListBox2.Items.Add("OSP-OS280M");
                    checkedListBox2.Items.Add("OSP-OS290M");
                    checkedListBox2.Items.Add("OSP-OS300M");
                }

                if (checkedListBox1.CheckedItems[0] == "Resun Solar Energy")
                {
                    checkedListBox2.Items.Add("RS6S 295P");
                    checkedListBox2.Items.Add("RS6S 300P");
                    checkedListBox2.Items.Add("RS6S 305P");
                    checkedListBox2.Items.Add("RS6S 310P");
                    checkedListBox2.Items.Add("RS6S 315P");

                }

                if (checkedListBox1.CheckedItems[0] == "Changzhou GS Energy")
                {
                    checkedListBox2.Items.Add("235");
                    checkedListBox2.Items.Add("240");
                    checkedListBox2.Items.Add("245");
                    checkedListBox2.Items.Add("250");
                    checkedListBox2.Items.Add("255");
                    checkedListBox2.Items.Add("260");
                }

                if (checkedListBox1.CheckedItems[0] == "CSG PVTech Co")
                {
                    checkedListBox2.Items.Add("290");
                    checkedListBox2.Items.Add("295");
                    checkedListBox2.Items.Add("300");
                    checkedListBox2.Items.Add("305");
                    checkedListBox2.Items.Add("310");
                    checkedListBox2.Items.Add("315");
                    checkedListBox2.Items.Add("320");
                }

                if (checkedListBox1.CheckedItems[0] == "Tamesol Desa S.L.")
                {
                    checkedListBox2.Items.Add("TM-P672280");
                    checkedListBox2.Items.Add("TM-P672285");
                    checkedListBox2.Items.Add("TM-P672290");
                    checkedListBox2.Items.Add("TM-P6722952");
                    checkedListBox2.Items.Add("TM-P672300");

                }


                if (checkedListBox1.CheckedItems[0] == "Jiangsu Runda PV Co")
                {
                    checkedListBox2.Items.Add("RS240P-60");
                    checkedListBox2.Items.Add("RS245P-60");
                    checkedListBox2.Items.Add("RS250P-60");
                    checkedListBox2.Items.Add("RS255P-60");
                    checkedListBox2.Items.Add("RS260P-60");
                }

                if (checkedListBox1.CheckedItems[0] == "Sky Energy Indonesia")
                {
                    checkedListBox2.Items.Add("STM255");
                    checkedListBox2.Items.Add("STM260");
                    checkedListBox2.Items.Add("STM265");
                    checkedListBox2.Items.Add("STM270");
                }

                if (checkedListBox1.CheckedItems[0] == "Anhui Daheng Energy Technology")
                {
                    checkedListBox2.Items.Add("30");
                    checkedListBox2.Items.Add("50");
                    checkedListBox2.Items.Add("70");
                    checkedListBox2.Items.Add("80");
                    checkedListBox2.Items.Add("100");

                }

                if (checkedListBox1.CheckedItems[0] == "Luxen Solar Energy Co")
                {
                    checkedListBox2.Items.Add("LNSE-250M");
                    checkedListBox2.Items.Add("LNSE-255M");
                    checkedListBox2.Items.Add("LNSE-260M");
                    checkedListBox2.Items.Add("LNSE-2M65");
                    checkedListBox2.Items.Add("LNSE-270M");
                }

                if (checkedListBox1.CheckedItems[0] == "Sun Electronics International")
                {
                    checkedListBox2.Items.Add("YL280P-35b");
                    checkedListBox2.Items.Add("YL285P-35b");
                    checkedListBox2.Items.Add("YL290P-35b");
                    checkedListBox2.Items.Add("YL295P-35b");
                    checkedListBox2.Items.Add("YL300P-35b");
                    checkedListBox2.Items.Add("YL305P-35b");
                    checkedListBox2.Items.Add("YL310P-35b");
                }

                if (checkedListBox1.CheckedItems[0] == "Infinity New Energy Co")
                {
                    checkedListBox2.Items.Add("INE-260-6MB");
                    checkedListBox2.Items.Add("INE-265-6MB");
                    checkedListBox2.Items.Add("INE-270-6MB");
                    checkedListBox2.Items.Add("INE-275-6MB");
                }

                if (checkedListBox1.CheckedItems[0] == "Suzhou Suncome Solar Science")
                {
                    checkedListBox2.Items.Add("245");
                    checkedListBox2.Items.Add("250");
                    checkedListBox2.Items.Add("255");
                    checkedListBox2.Items.Add("260");
                }

                if (checkedListBox1.CheckedItems[0] == "Jiangyin Shine Science and Tech")
                {
                    checkedListBox2.Items.Add("SS230-60M(Black)");
                    checkedListBox2.Items.Add("SS235-60M(Black)");
                    checkedListBox2.Items.Add("SS240-60M(Black)");
                    checkedListBox2.Items.Add("SS245-60M(Black)");
                    checkedListBox2.Items.Add("SS250-60M(Black)");

                }

                if (checkedListBox1.CheckedItems[0] == "Chinaland Solar Energy Co")
                {
                    checkedListBox2.Items.Add("220");
                    checkedListBox2.Items.Add("230");
                    checkedListBox2.Items.Add("235");
                    checkedListBox2.Items.Add("240");
                    checkedListBox2.Items.Add("245");
                    checkedListBox2.Items.Add("250");
                    checkedListBox2.Items.Add("255");
                    checkedListBox2.Items.Add("260");
                }

                if (checkedListBox1.CheckedItems[0] == "Jetion Solar (China) Co")
                {
                    checkedListBox2.Items.Add("JT135SFc");
                    checkedListBox2.Items.Add("JT140SFc");
                    checkedListBox2.Items.Add("JT145SFc");
                    checkedListBox2.Items.Add("JT150SFc");

                }
              


                if(checkedListBox1.CheckedItems[0] == "Econess Energy Co")
                {
                    checkedListBox2.Items.Add("EN 156P-72-300");
                    checkedListBox2.Items.Add("EN 156P-72-305");
                    checkedListBox2.Items.Add("EN 156P-72-310");
                    checkedListBox2.Items.Add("EN156P-72-315");
                    checkedListBox2.Items.Add("EN156P-72-320");
                }

                if (checkedListBox1.CheckedItems[0] == "YY Solar Co., Ltd.")
                {
                    checkedListBox2.Items.Add("10");
                    checkedListBox2.Items.Add("20");
                    checkedListBox2.Items.Add("30");
                    checkedListBox2.Items.Add("40");
                    checkedListBox2.Items.Add("50");
                    checkedListBox2.Items.Add("60");
                    checkedListBox2.Items.Add("80");
                    checkedListBox2.Items.Add("100");
                }
                if(checkedListBox1.CheckedItems[0]== "TN Solar")
                {
                    checkedListBox2.Items.Add("TN Solar 230P");
                    checkedListBox2.Items.Add("TN Solar 235P");
                    checkedListBox2.Items.Add("TN Solar 240P");
                    checkedListBox2.Items.Add("TN Solar 245P");
                    checkedListBox2.Items.Add("TN Solar 250P");
                }

                if (checkedListBox1.CheckedItems[0] == "Jinhua Dokio Technology Co.")
                {
                    checkedListBox2.Items.Add("DSP80P-1");
                    checkedListBox2.Items.Add("DSP80P-2");
                    checkedListBox2.Items.Add("DSP240P-1");
                    checkedListBox2.Items.Add("DS240P-2");
                    checkedListBox2.Items.Add("DS290P");
                    
                }

                if (checkedListBox1.CheckedItems[0]== "Risen Energy Co., Ltd.")
                {
                    checkedListBox2.Items.Add("RSM72-6-300P");
                    checkedListBox2.Items.Add("RSM72-6-300P");
                    checkedListBox2.Items.Add("RSM72-6-310P");
                    checkedListBox2.Items.Add("SYP310S");
                    checkedListBox2.Items.Add("RSM72-6-315P");
                    checkedListBox2.Items.Add("SYP315S");
                    checkedListBox2.Items.Add("RSM72-6-320P");
                    checkedListBox2.Items.Add("SYP320S");
                }

                if (checkedListBox1.CheckedItems[0]== "Infinity New Energy Co., Ltd.")
                {
                    checkedListBox2.Items.Add("INE-250-6PB");
                    checkedListBox2.Items.Add("INE-255-6PB");
                    checkedListBox2.Items.Add("INE-260-6PB");
                    checkedListBox2.Items.Add("INE-265-6PB");
                }

            } }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox3.Items.Clear();
            checkedListBox4.Items.Clear();
            checkedListBox5.Items.Clear();
            checkedListBox6.Items.Clear();
            checkedListBox7.Items.Clear();
            if (checkedListBox2.CheckedItems.Count > 1) //mensaje para mas de uno
            {
                MessageBox.Show("solo se puede seleccionar un checkox");



            }

            if (checkedListBox2.CheckedItems.Count == 1) //validacion solo este seleccionada uno
            {
                listBox1.Items.Add("2-> " + checkedListBox2.CheckedItems[0].ToString());
                checkedListBox3.Items.Add("HOSOLA Smart 3000TL");
                if (listBox1.Items.Count > 7)
                {
                    listBox1.Items.RemoveAt(6);

                }


                if (listBox1.Items.Count > 6)
                {
                    listBox1.Items.RemoveAt(5);

                }


                if (listBox1.Items.Count > 5)
                {
                    listBox1.Items.RemoveAt(4);

                }

                if (listBox1.Items.Count > 4)
                {
                    listBox1.Items.RemoveAt(3);


                }


                if (listBox1.Items.Count > 3)
                {
                    listBox1.Items.RemoveAt(2);

                }

                if (listBox1.Items.Count > 2)
                {
                    listBox1.Items.RemoveAt(1);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox4.Items.Clear();
            checkedListBox5.Items.Clear();
            checkedListBox6.Items.Clear();
            checkedListBox7.Items.Clear();

            if (checkedListBox3.CheckedItems.Count > 1) //mensaje para mas de uno
            {
                MessageBox.Show("solo se puede seleccionar un checkox");



            }

            if (checkedListBox3.CheckedItems.Count == 1) //validacion solo este seleccionada uno
            {
                listBox1.Items.Add("3-> " + checkedListBox3.CheckedItems[0].ToString());
                checkedListBox4.Items.Add("AERL SRMVW");


                if (listBox1.Items.Count > 7)
                {
                    listBox1.Items.RemoveAt(6);

                }


                if (listBox1.Items.Count > 6)
                {
                    listBox1.Items.RemoveAt(5);

                }


                if (listBox1.Items.Count > 5)
                {
                    listBox1.Items.RemoveAt(4);

                }

                if (listBox1.Items.Count > 4)
                {
                    listBox1.Items.RemoveAt(3);


                }
                if (listBox1.Items.Count > 3)
                {
                    listBox1.Items.RemoveAt(2);

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox5.Items.Clear();
            checkedListBox6.Items.Clear();
            checkedListBox7.Items.Clear();

            if (checkedListBox4.CheckedItems.Count > 1) //mensaje para mas de uno
            {
                MessageBox.Show("solo se puede seleccionar un checkox");



            }

            if (checkedListBox4.CheckedItems.Count == 1) //validacion solo este seleccionada uno
            {
                listBox1.Items.Add("4-> " + checkedListBox4.CheckedItems[0].ToString());
                checkedListBox5.Items.Add("Trojan Battery Company 27-Gel");



                if (listBox1.Items.Count > 7)
                {
                    listBox1.Items.RemoveAt(6);

                }


                if (listBox1.Items.Count > 6)
                {
                    listBox1.Items.RemoveAt(5);

                }


                if (listBox1.Items.Count > 5)
                {
                    listBox1.Items.RemoveAt(4);

                }
                if (listBox1.Items.Count > 4)
                {
                    listBox1.Items.RemoveAt(3);


                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox6.Items.Clear();
            checkedListBox7.Items.Clear();
            if (checkedListBox5.CheckedItems.Count > 1) //mensaje para mas de uno
            {
                MessageBox.Show("solo se puede seleccionar un checkox");



            }

            if (checkedListBox5.CheckedItems.Count == 1) //validacion solo este seleccionada uno
            {
                listBox1.Items.Add("5-> " + checkedListBox5.CheckedItems[0].ToString());
                checkedListBox6.Items.Add("CENTRON C1S");





                if (listBox1.Items.Count > 7)
                {
                    listBox1.Items.RemoveAt(6);

                }


                if (listBox1.Items.Count > 6)
                {
                    listBox1.Items.RemoveAt(5);

                }
                if (listBox1.Items.Count > 5)
                {
                    listBox1.Items.RemoveAt(4);

                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkedListBox7.Items.Clear();
            if (checkedListBox6.CheckedItems.Count > 1) //mensaje para mas de uno
            {
                MessageBox.Show("solo se puede seleccionar un checkox");



            }

            if (checkedListBox6.CheckedItems.Count == 1) //validacion solo este seleccionada uno
            {
                listBox1.Items.Add("6-> " + checkedListBox6.CheckedItems[0].ToString());
                checkedListBox7.Items.Add("MONSOL Quick Domo");

                if (listBox1.Items.Count > 7)
                {
                    listBox1.Items.RemoveAt(6);

                }

                if (listBox1.Items.Count > 6)
                {
                    listBox1.Items.RemoveAt(5);

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkedListBox7.CheckedItems.Count > 1) //mensaje para mas de uno
            {
                MessageBox.Show("solo se puede seleccionar un checkox");



            }

            if (checkedListBox7.CheckedItems.Count == 1) //validacion solo este seleccionada uno
            {
                listBox1.Items.Add("7-> " + checkedListBox7.CheckedItems[0].ToString());
               

                if (listBox1.Items.Count > 7)
                {
                    listBox1.Items.RemoveAt(6);

                }
            }
        }
    }
}
