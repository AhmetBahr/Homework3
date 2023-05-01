using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YayinEvi_Homework
{
    public partial class Form1 : Form
    {
        Yayinevi yayevi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxYayinEvi.Items.Add(txtYayin.Text);


            yayevi = new Yayinevi(txtYayin.Text);
            Editor e1 = new Editor(editor_isim1.Text, editor_soyisim1.Text);
            Editor e2 = new Editor(editor_isim2.Text, editor_soyisim2.Text);
            yayevi.addEditor(e1);
            yayevi.addEditor(e2);


        }

        private void button4_Click(object sender, EventArgs e) // BtmKitap
        {

        }

        private void btmYazar_Click(object sender, EventArgs e)
        {

        }

        private void btmEditor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Show
        {
            /*   int id;

               id = (int)comboBoxYayinEvi.Items[0];

               switch (id)
               {
                   case 0: for (int i = 0; i < yayevi.editorler.Count; i++)
                           listBoxEditor.Items.Add(yayevi.editorler);

                   break;

               }
               */
            for (int i = 0; i < yayevi.editorler.Count; i++)
                listBoxEditor.Items.Add(yayevi.editorler.ToList<Editor>());
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
