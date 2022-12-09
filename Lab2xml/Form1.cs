using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Lab2xml
{
    public partial class Lab2 : Form
    {
        private string myAuthorName = null, myFaculty = null, myDate = null, myDepartment = null, myVolume = null, myType = null;
        private string path = "base1.xml";
        public Lab2()
        {
            InitializeComponent();
            buildBox(authorNameBox, facultyBox, dateBox, departmentBox, volumeBox, typeBox);
        }

        private void buildBox(ComboBox authorNameBox, ComboBox facultyBox, ComboBox dateBox, ComboBox departmentBox, ComboBox volumeBox, ComboBox typeBox)
        {
            IParse parse = new LINQtoXML();
            List<Search> res = parse.AnalyzeFile(new Search(), path);
            List<string> authorName = new();
            List<string> faculty = new();
            List<string> date = new();
            List<string> department = new();
            List<string> volume = new();
            List<string> type = new();
            foreach (Search el in res)
            {
                if (!authorName.Contains(el.authorName))
                {
                    authorName.Add(el.authorName);
                }
                if (!faculty.Contains(el.faculty))
                {
                    faculty.Add(el.faculty);
                }
                if (!date.Contains(el.date))
                {
                    date.Add(el.date);
                }
                if (!department.Contains(el.department))
                {
                    department.Add(el.department);
                }
                if (!volume.Contains(el.volume))
                {
                    volume.Add(el.volume);
                }
                if (!type.Contains(el.type))
                {
                    type.Add(el.type);
                }
            }
            authorName = authorName.OrderBy(x => x).ToList();
            faculty = faculty.OrderBy(x => x).ToList();
            date = date.OrderBy(x => x).ToList();
            department = department.OrderBy(x => x).ToList();
            type = type.OrderBy(x => x).ToList();
            authorNameBox.Items.AddRange(authorName.ToArray());
            facultyBox.Items.AddRange(faculty.ToArray());
            dateBox.Items.AddRange(date.ToArray());
            departmentBox.Items.AddRange(department.ToArray());
            volumeBox.Items.Add("1-20");
            volumeBox.Items.Add("21-50");
            volumeBox.Items.Add("51-100");
            volumeBox.Items.Add("101-200");
            volumeBox.Items.Add("201-999");
            typeBox.Items.AddRange(type.ToArray());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParsingForXML();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            ParsingNames(sender);
        }

        private void ParsingComboBoxes(object sender)
        {

            string temp = (sender as ComboBox).Name;
            switch (temp) { 
                    case "authorNameBox":
                        myAuthorName = authorNameBox.SelectedItem.ToString();
                        break;
                    case "facultyBox":
                        myFaculty = facultyBox.SelectedItem.ToString();
                        break;
                    case "dateBox":
                        myDate = dateBox.SelectedItem.ToString();
                        break;
                    case "departmentBox":
                        myDepartment = departmentBox.SelectedItem.ToString();
                        break;
                    case "volumeBox":
                        myVolume = volumeBox.SelectedItem.ToString();
                        break;
                    case "typeBox":
                        myType = typeBox.SelectedItem.ToString();
                        break;
                }
        }

        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ParsingComboBoxes(sender);
        }

        private void btnToHTML_Click(object sender, EventArgs e)
        {
            ToHtml();
        }

        private void Lab2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
            MessageBox.Show(
                "Бажаєте вийти з програми?", "Вихід",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        void OpenFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string prevpath = path;
            path = openFileDialog.FileName;
            XDocument doc = new();
            try
            {
                doc = XDocument.Load(@path);
            }
            catch
            {
                MessageBox.Show("Обрано файл неправильного формату", "Помилка типу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                path = prevpath;
            }
        }

        void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void Lab2_Load(object sender, EventArgs e)
        {

        }

        private string helpInfo()
        {
            String helptext = "";
            try
            {
                String line;
                StreamReader streamReader = new("help.txt");
                line = streamReader.ReadLine();
                while (line != null)
                {
                    helptext += line + "\n";
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return helptext;
        }

        private void допомогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpInfo());
        }

        private void ToHtml()
        {
            XslCompiledTransform xsl = new();
            xsl.Load("transform.xsl");
            string input = path;
            string htmlres = "TextMaterials.html";
            xsl.Transform(input, htmlres);
            MessageBox.Show("Трансформація виконана!");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

        private void ParsingNames(object sender)
        {

                var temp = sender as CheckBox;
                if (temp != null) switch (temp.Text)
                {
                    case "Ім'я автора":
                        authorNameBox.SelectedItem = null;
                        if (temp.CheckState == CheckState.Checked) authorNameBox.Enabled = true;
                        else { authorNameBox.Enabled = false; myAuthorName = null; }
                        break;
                    case "Факультет":
                        facultyBox.SelectedItem = null;
                        if (temp.CheckState == CheckState.Checked) facultyBox.Enabled = true;
                        else { facultyBox.Enabled = false; myFaculty = null; }
                        break;
                    case "Дата":
                        dateBox.SelectedItem = null;
                        if (temp.CheckState == CheckState.Checked) dateBox.Enabled = true;
                        else { dateBox.Enabled = false; myDate = null; }
                        break;
                    case "Кафедра":
                        departmentBox.SelectedItem = null;
                        if (temp.CheckState == CheckState.Checked) departmentBox.Enabled = true;
                        else { departmentBox.Enabled = false; myDepartment = null; }
                        break;
                    case "Обсяг":
                        volumeBox.SelectedItem = null;
                        if (temp.CheckState == CheckState.Checked) volumeBox.Enabled = true;
                        else { volumeBox.Enabled = false; myVolume = null; }
                        break;
                    case "Вид роботи":
                        typeBox.SelectedItem = null;
                        if (temp.CheckState == CheckState.Checked) typeBox.Enabled = true;
                        else { typeBox.Enabled = false; myType = null; }
                        break;
            }
        }

        private void ParsingForXML()
        {
            Search myTemplate = new();
            myTemplate.authorName = myAuthorName;
            myTemplate.faculty = myFaculty;
            myTemplate.date = myDate;
            myTemplate.department = myDepartment;
            myTemplate.volume = myVolume;
            myTemplate.type = myType;
            if (radioButtonSAX.Checked)
            {
                List<Search> res;
                IParse parser = new SAX();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }
            if (radioButtonDOM.Checked)
            {
                List<Search> res;
                IParse parser = new DOM();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }
            if (radioButtonLINQ.Checked)
            {
                List<Search> res;
                IParse parser = new LINQtoXML();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }
        }
        private void Output(List<Search> res)
        {
            richTextBox1.Clear();
            foreach (Search n in res)
            {
                richTextBox1.AppendText("Назва: " + n.title + "\n");
                richTextBox1.AppendText("Ім'я автора: " + n.authorName + "\n");
                richTextBox1.AppendText("Факультет: " + n.faculty + "\n");
                richTextBox1.AppendText("Кафедра: " + n.department + "\n");
                richTextBox1.AppendText("Вид роботи: " + n.type + "\n");
                richTextBox1.AppendText("Обсяг: " + n.volume + "\n");
                richTextBox1.AppendText("Дата: " + n.date + "\n");
                richTextBox1.AppendText("\n");
            }
        }
    }
}
