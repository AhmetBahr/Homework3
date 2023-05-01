using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayinEvi_Homework
{
    public enum EditorInceleEnum { REDDEDILDI, DUZENLENECEK, ONAYLANDI }

    public class EditorKitapGorus

    {

        private Editor editor;

        private string aciklama;

        private EditorInceleEnum karar;

        public EditorKitapGorus(Editor editor, string aciklama, EditorInceleEnum karar)

        {

            this.editor = editor;

            this.aciklama = aciklama;

            this.karar = karar;

        }

        public Editor Editor

        {

            get { return editor; }

        }

        public string Aciklama { get { return aciklama; } }

        public EditorInceleEnum Karar { get { return karar; } }

    }
}
