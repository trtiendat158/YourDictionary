using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourDictionaryLibrary_Dat_Tan
{
    class Speak
    {
        private WebBrowser wb;
        public Speak(WebBrowser wb)
        {
            this.Wb = wb;
        }

        public void Spreak(string data)
        {

        }

        public void SetText(string data)
        {

        }
        public WebBrowser Wb { get => wb; set => wb = value; }
    }
}
