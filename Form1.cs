using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace formularios
{

    public partial class Form1 : Form
    {
        int bnumb=1;

        int x1 = 0;
        int x2 = 0;

        int y1 = 0;
        int y2 = 0;

        public Form1()
        {
            InitializeComponent();
            x1 = txtBuildingName.Location.X;
            y1 = txtBuildingName.Location.Y;

            x2 = txtNumb.Location.X;
            y2 = txtNumb.Location.Y;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("datos/datos.txt", true);
                string line = "";
                int h = 1;
                foreach (var txtBox in grid.Controls.OfType<TextBox>()){
                    if (h % 2 == 0) {
                        line += txtBox.Text;
                        sw.WriteLine(line);
                        line = "";
                        h = 1;
                    }
                    else
                    {
                        line += txtBox.Text+"_";
                        h++;
                    }
                }
                sw.Close();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            finally
            {

            }
        }

        private void ButAddField_Click(object sender, EventArgs e)
        {
            if(bnumb == 14){
                MessageBox.Show("Yastal tope\nLa universidad icesi solo tiene 14 edificios");
            }else{
                bnumb++;
                y1 += 25;
                y2 += 25;

                Size _size = new Size(txtBuildingName.Width, txtBuildingName.Height);
                Size _size2 = new Size(txtNumb.Width, txtNumb.Height);

                var labBuilding = new Label();
                labBuilding.BackColor = Color.Transparent;
                labBuilding.Text = "Edificio";
                labBuilding.Location = new Point(label1.Location.X, y1);

                var labNumber = new Label();
                labNumber.BackColor = Color.Transparent;
                labNumber.Text = "Numero de grifos";
                labNumber.Location = new Point(label2.Location.X, y1);

                var txtNameB = new TextBox();
                txtNameB.Size = _size;
                txtNameB.Location = new Point(x1, y1);

                var txtGrifN = new TextBox();
                txtGrifN.Size = _size2;
                txtGrifN.Location = new Point(x2, y2);

                grid.Controls.Add(txtGrifN);
                grid.Controls.Add(txtNameB);
                grid.Controls.Add(labNumber);
                grid.Controls.Add(labBuilding);
            }
        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("datos/datos.txt");
                string line = null;
                string tot = null;
                int c = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    tot += line + ":";
                    c++;
                }
                while (c>1)
                {
                    ButAddField_Click(sender, e);
                    c--;
                }
                string[] fields = tot.Split(':');
                ArrayList singles = new ArrayList();
                for (int i = 0; i < fields.Length-1; i++)
                {
                    string a = fields[i];
                    string[] wea = a.Split('_');
                    singles.Add(wea[0]);
                    singles.Add(wea[1]);
                }
                foreach (string a in singles)
                {
                    Console.WriteLine(a);
                }
                int h = 0;
                
                foreach (var txtBox in grid.Controls.OfType<TextBox>())
                {
                    if (h < singles.Count)
                    {
                        txtBox.Text = (string)singles[h];
                        h++;
                    }
                }
                    sr.Close();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            finally
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
