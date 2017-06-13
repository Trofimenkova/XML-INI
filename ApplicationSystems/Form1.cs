using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace ApplicationSystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:/users/user/documents";
            openFileDialog1.Filter = "XML Files|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XDocument myXML = XDocument.Load(openFileDialog1.FileName);
                IniFile.setPath(openFileDialog1.FileName);
                IniFile.IniWriteValue(Convert.ToString(myXML.Root.Name), "text", myXML.Root.Value);
                write_attributes(myXML.Root);
                write_elements(myXML, myXML.Root);
                IniFile.open();
            }
        }

        private void write_elements(XDocument myXML, XElement e)
        {
            string[] sections = new string[100];
            int kol = 0;
            foreach (XElement el in myXML.Element(e.Name).Descendants())
            {
                sections[kol] = Convert.ToString(el.Name);
                kol++;
                int i = 0;
                foreach (string s in sections)
                {
                    if (s != null && el.Name != null)
                        if (s.Equals(Convert.ToString(el.Name))) i++;
                }

                if (i > 1) el.Name = el.Name + Convert.ToString(i);
                IniFile.IniWriteValue(Convert.ToString(el.Name), "text", el.Value);
                write_attributes(el);
            }
        }

        private void write_attributes(XElement e)
        {
            foreach (XAttribute attr in e.Attributes())
                IniFile.IniWriteValue(Convert.ToString(e.Name), Convert.ToString(attr.Name), Convert.ToString(attr.Value));
        }

        public class IniFile
        {
            private static string path = "c:/users/user/documents/";

            public static void setPath(string file)
            {
                IniFile.path = IniFile.path + Path.GetFileNameWithoutExtension(file) + ".ini";
            }

            public static void open()
            {
                System.Diagnostics.Process.Start(path);
            }

            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section,
                string key, string val, string filePath);

            public static void IniWriteValue(string Section, string Key, string Value)
            {
                WritePrivateProfileString(Section, Key, Value, path);
            }
        }
    }
}
