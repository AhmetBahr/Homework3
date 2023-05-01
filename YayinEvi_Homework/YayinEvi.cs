using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayinEvi_Homework
{
    public class Yayinevi

    {

        string isim;


        private List<Kitap> kitaplar;

        public List<Editor> editorler;

        public Yayinevi(string isim)

        {

            this.isim = isim;

            kitaplar = new List<Kitap>();

            editorler = new List<Editor>();

        }

        public void addKitap(Kitap k)

        {

            kitaplar.Add(k);

        }

        public void removeKitap(Kitap k)

        {

            kitaplar.Remove(k);

        }

        public void addEditor(Editor e)

        {

            editorler.Add(e);

        }

        public void removeEditor(Editor e)

        {

            editorler.Remove(e);

        }

        public Editor[] getEditorler()

        {

            Editor[] dizi = new Editor[editorler.Count];

            int i = 0;

            foreach (Editor e in editorler)

            {

                dizi[i] = e;

                i++;

            }

            return dizi;

        }

    }
}
