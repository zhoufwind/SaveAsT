using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsSaveObjectsAsXMLAndJSON
{
    public partial class FromSaveAsXML_JSON : Form
    {
        private List<BilingualBook> classicsBilingual;

        public FromSaveAsXML_JSON()
        {
            InitializeComponent();
        }

        private void buttonHydr8_Click(object sender, EventArgs e)
        {
            Popul8Classics();
        }

        private void Popul8Classics()
        {
            classicsBilingual = new List<BilingualBook>();

            var AtWi80Daze = new BilingualBook
            {
                Author = "Jules Verne",
                SourceLang = "French",
                TargetLang = "English",
                EnglishTitle = "Around the World in 80 Days",
                PaperbackURI = GetProductURI("1495308081"),
                KindleURI = GetProductURI("B00I0DOYRE"),
                ImageURI = GetImageURI("51BCZUX2-dL")
            };
            classicsBilingual.Add(AtWi80Daze);

            var gulliver = new BilingualBook
            {
                Author = "Jonathan Swift",
                SourceLang = "English",
                TargetLang = "French",
                EnglishTitle = "Gulliver's Travels",
                PaperbackURI = GetProductURI("1495374688"),
                KindleURI = GetProductURI("B00I5319ZO"),
                ImageURI = GetImageURI("517O76OyaWL")
            };
            classicsBilingual.Add(gulliver);

            var JttCotE = new BilingualBook
            {
                Author = "Jules Verne",
                SourceLang = "French",
                TargetLang = "English",
                EnglishTitle = "Journey to the Center of the Earth",
                PaperbackURI = GetProductURI("1495409031"),
                KindleURI = GetProductURI("B00I6LG25M"),
                ImageURI = GetImageURI("41hosXOIw8L")
            };
            classicsBilingual.Add(JttCotE);

            var treasureIsland = new BilingualBook
            {
                Author = "Robert Louis Stevenson",
                SourceLang = "English",
                TargetLang = "Finnish",
                EnglishTitle = "Treasure Island",
                PaperbackURI = GetProductURI("1495418936"),
                KindleURI = GetProductURI("B00IA5V4KC"),
                ImageURI = GetImageURI("51XNUWbA07L")
            };
            classicsBilingual.Add(treasureIsland);

            var robinsonC = new BilingualBook
            {
                Author = "Daniel Defoe",
                SourceLang = "English",
                TargetLang = "French",
                EnglishTitle = "The Adventures of Robinson Crusoe",
                PaperbackURI = GetProductURI("1495448053"),
                KindleURI = GetProductURI("B00I9IE8OY"),
                ImageURI = GetImageURI("5128hqiw3DL")
            };
            classicsBilingual.Add(robinsonC);

            var Quijote1 = new BilingualBook
            {
                Author = "Miguel de Cervantes",
                SourceLang = "Spanish",
                TargetLang = "English",
                EnglishTitle = "Don Quixote Bilingual Edition Vol. I",
                PaperbackURI = GetProductURI("149474967X"),
                KindleURI = GetProductURI("B00HQMWPQ2"),
                ImageURI = GetImageURI("51HqjOPXLVL")
            };
            classicsBilingual.Add(Quijote1);

            var Quijote2 = new BilingualBook
            {
                Author = "Miguel de Cervantes",
                SourceLang = "Spanish",
                TargetLang = "English",
                EnglishTitle = "Don Quixote Bilingual Edition Vol. II",
                PaperbackURI = GetProductURI("1494803445"),
                KindleURI = GetProductURI("B00HYN2QGM"),
                ImageURI = GetImageURI("51NONygEMYL")
            };
            classicsBilingual.Add(Quijote2);


            var Quijote3 = new BilingualBook
            {
                Author = "Miguel de Cervantes",
                SourceLang = "Spanish",
                TargetLang = "English",
                EnglishTitle = "Don Quixote Bilingual Edition Vol. III",
                PaperbackURI = GetProductURI("1494841983"),
                KindleURI = GetProductURI("B00HLX519E"),
                ImageURI = GetImageURI("51G%2BW3ICHkL")
            };
            classicsBilingual.Add(Quijote3);
        }

        private string GetImageURI(string imgID)
        {
            return string.Format("http://ecx.images-amazon.com/images/I/{0}._SL160_.jpg", imgID);
        }

        private string GetProductURI(string ASIN)
        {
            return string.Format("http://www.amazon.com/exec/obidos/ASIN/{0}/garrphotgall-20", ASIN);
        }

        private void buttonSaveAsXML_Click(object sender, EventArgs e)
        {
            if (null == classicsBilingual)
            {
                Popul8Classics();
            }
            SaveAsXML(classicsBilingual);
        }

        private void SaveAsXML(List<BilingualBook> classicsBilingual)
        {
            const string xmlFileName = "FitTClassics.xml";
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<BilingualBook>));

            var file = new StreamWriter(xmlFileName);
            writer.Serialize(file, classicsBilingual);
            file.Close();
        }

        private void buttonSaveAsJSON_Click(object sender, EventArgs e)
        {
            if (null == classicsBilingual)
            {
                Popul8Classics();
            }
            SaveAsJSON(classicsBilingual);
        }

        private void SaveAsJSON(List<BilingualBook> classicsBilingual)
        {
            const string jsonFileName = "FitTClassics.json";
            string jsonRepresentation = JsonConvert.SerializeObject(classicsBilingual);
            File.WriteAllText(jsonFileName, jsonRepresentation);
        }

        private void buttonSaveAsCSV_Click(object sender, EventArgs e)
        {
            if (null == classicsBilingual)
            {
                Popul8Classics();
            }
            SaveAsCSV(classicsBilingual);
        }

        private void SaveAsCSV(List<BilingualBook> classicsBilingual)
        {
            const string csvFileName = "FitTClassics.csv";
            List<string> csvFile = new List<string>();
            foreach (BilingualBook classic in classicsBilingual)
            {
                csvFile.Add(string.Format("{0},{1},{2},{3},{4},{5},{6}", classic.Author, classic.SourceLang, classic.TargetLang, classic.EnglishTitle, classic.PaperbackURI, classic.KindleURI, classic.ImageURI));
            }
            File.WriteAllLines(csvFileName, csvFile);
        }
    }
}
