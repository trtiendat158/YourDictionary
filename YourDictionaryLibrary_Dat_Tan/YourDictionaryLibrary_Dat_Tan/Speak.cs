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
        public Speak()
        {
            //Webbrowser hoạt động ngầm để thực hiện chức năng nói
            wb = new WebBrowser();
            wb.Width = 0;
            wb.Height = 0;
            wb.Visible = false;
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate("http://responsivevoice.org/text-to-speech-languages/us-english-text-to-speech/");
        }

        /// <summary>
        /// Sau khi có dữ liệu cần nói, đưa data để settext và chọn play để nói
        /// </summary>
        /// <param name="data"></param>
        public void speak(string data)
        {
            SetTextToSpeak(data);
            SpeakText();
        }

        /// <summary>
        /// Soạn từ lên mạng để nói
        /// </summary>
        /// <param name="data"></param>
        private void SetTextToSpeak(string data)
        {
            HtmlElement element = wb.Document.GetElementById("text");
            element.SetAttribute("value", data);
        }

        /// <summary>
        /// Chọn play để nói
        /// </summary>
        private void SpeakText()
        {
            HtmlElement element = wb.Document.GetElementById("playbutton");
            element.InvokeMember("click");
        }
    }
}
