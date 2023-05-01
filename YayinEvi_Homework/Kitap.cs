using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayinEvi_Homework
{

    public class KitapInceleme

    {

        private List<EditorKitapGorus> gorusler;

        private Kitap kitap;

        public KitapInceleme(Kitap kitap)

        {

            gorusler = new List<EditorKitapGorus>();

            this.kitap = kitap;

        }

        public void addKitapGorus(Editor editor, string aciklama, EditorInceleEnum karar)

        {

            gorusler.Add(new EditorKitapGorus(editor, aciklama, karar));

        }

        public EditorInceleEnum getKarar()

        {

            EditorInceleEnum sonuc = 0;

            int red = 0, duzenlenecek = 0, onay = 0;

            for (int i = 0; i < gorusler.Count; i++)

            {

                EditorInceleEnum karar = gorusler[i].Karar;

                if (karar == EditorInceleEnum.REDDEDILDI) red++;

                else if (karar == EditorInceleEnum.ONAYLANDI) onay++;

                else duzenlenecek++;

            }

            if (red > 0) sonuc = EditorInceleEnum.REDDEDILDI;

            else if (duzenlenecek > 0) sonuc = EditorInceleEnum.DUZENLENECEK;

            else if (onay > 0 && onay == gorusler.Count) sonuc = EditorInceleEnum.ONAYLANDI;

            return sonuc;

        }

    }

    public enum KitapDurumEnum { REDDEDILDI , INCELEMEDE, YAYINLANDI }


    public class Kitap

    {

        private Yazar yazar;

        private List<KitapInceleme> incelemeler;

        private KitapDurumEnum durum;

        private String adi;

        public Kitap(Yazar yazar, string adi)

        {

            this.yazar = yazar;

            this.adi = adi;

            incelemeler = new List<KitapInceleme>();

        }

        public Yazar Yazar { get { return yazar; } }

        public string Adi { get { return adi; } }

        public KitapDurumEnum Durum { get { return durum; } }

        public void addInceleme(KitapInceleme inceleme)

        {

            incelemeler.Add(inceleme);

            kitapDurumGuncelle();

        }

        public void removeInceleme(KitapInceleme inceleme)

        {

            incelemeler.Remove(inceleme);

            kitapDurumGuncelle();

        }

        public void kitapDurumGuncelle()

        {

            KitapInceleme sonInceleme = incelemeler[incelemeler.Count - 1];

            if (sonInceleme.getKarar() == EditorInceleEnum.REDDEDILDI)

                durum = KitapDurumEnum.REDDEDILDI;

            else if (sonInceleme.getKarar() == EditorInceleEnum.DUZENLENECEK)

                durum = KitapDurumEnum.INCELEMEDE;

            else if (sonInceleme.getKarar() == EditorInceleEnum.ONAYLANDI)

                durum = KitapDurumEnum.YAYINLANDI;

        }

    } 

    
}
