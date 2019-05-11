using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; 
namespace file
{
    public partial class Form1 : Form
    {
        DataSet DS = new DataSet();
        List<int>removes=new List<int>();
        string fileContent = "";
        string filePath = "";
        string filename = "";
        public Form1()
        {
            InitializeComponent();
           

        }

        public class student
        {
            public string id;
            public string name;
            public string gender;
            public string department;
            public List<string> projects;
            public student(string i, string n, string g, string d, List<string> p)
            {
                id = i; name = n; gender = g; department = d; projects = p;
            }

        }
        
        
        // Aggregate functions
        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                if (table.FirstDisplayedCell != null)
                {
                    int colindex = table.CurrentCell.ColumnIndex;
                    int row = (table.RowCount) - 1;
                    int sum = 0;

                    for (int i = 0; i < row; i++)
                    {
                        sum += Convert.ToInt32(table.Rows[i].Cells[colindex].Value);
                    }

                    MessageBox.Show("The Summation of The Selected Column is : " + sum, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Table is Empty Please Upload Any Table", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void avg_Click(object sender, EventArgs e)
        {
            try
            {
                if (table.FirstDisplayedCell != null)
                {
                    int colindex = table.CurrentCell.ColumnIndex;
                    int row = (table.RowCount) - 1;
                    int sum = 0;

                    int avg = 0;
                    for (int i = 0; i < row; i++)
                    {
                        sum += Convert.ToInt32(table.Rows[i].Cells[colindex].Value);
                        avg = sum / row;
                    }
                    MessageBox.Show("The Average of The Selected Column is : " + avg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Table is Empty Please Upload Any Table", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            try
            {
                if (table.FirstDisplayedCell != null)
                {
                    int colindex = table.CurrentCell.ColumnIndex;
                    int row = (table.RowCount) - 1;
                    int min = 0;
                    List<int> values = new List<int>();
                    for (int i = 0; i < row; i++)
                    {
                        values.Add(Convert.ToInt32(table.Rows[i].Cells[colindex].Value));
                    }
                    values.Sort();
                    min = values[0];
                    MessageBox.Show("The Minimum Value In The Selected Column is : " + min, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Table is Empty Please Upload Any Table", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void max_Click(object sender, EventArgs e)
        {
            try
            {
                if (table.FirstDisplayedCell != null)
                {
                    int colindex = table.CurrentCell.ColumnIndex;
                    int row = (table.RowCount) - 1;
                    int max = 0;
                    List<int> values = new List<int>();
                    for (int i = 0; i < row; i++)
                    {
                        values.Add(Convert.ToInt32(table.Rows[i].Cells[colindex].Value));
                    }
                    values.Sort();
                    values.Reverse();
                    max = values[0];
                    MessageBox.Show("The Maximum Value In The Selected Column is : " + max, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("The Table is Empty Please Upload Any Table", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        //function of noded xml
        private void edit()
        {
            int rows = (table.RowCount)-1;
            File.Delete(filePath);
            for (int row = 0; row < rows; row++)
            {
                List<string> projects = new List<string>();
                string id = "", name = "", gender = "", department = "";
                int No_of_col = table.ColumnCount;

                //int row = table.CurrentCell.RowIndex;
                id = table.Rows[row].Cells[0].Value.ToString();
                name = table.Rows[row].Cells[1].Value.ToString();
                gender = table.Rows[row].Cells[2].Value.ToString();
                department = table.Rows[row].Cells[3].Value.ToString();
                for (int colindex = 4; colindex < No_of_col; colindex++)
                {
                    if (table.Rows[row].Cells[colindex].Value!= null)
                    {
                        string pro = table.Rows[row].Cells[colindex].Value.ToString();
                        projects.Add(pro);
                    }
                }
                student st = new student(id, name, gender, department, projects);
                
                //write in xml
                if (!File.Exists(filePath))
                {
                    XmlWriter xw = XmlWriter.Create(filePath);
                    xw.WriteStartDocument();

                    xw.WriteStartElement("student");

                    xw.WriteStartElement("id");
                    xw.WriteString(st.id);
                    xw.WriteEndElement();

                    xw.WriteStartElement("name");
                    xw.WriteString(st.name);
                    xw.WriteEndElement();

                    xw.WriteStartElement("gender");
                    xw.WriteString(st.gender);
                    xw.WriteEndElement();

                    xw.WriteStartElement("department");
                    xw.WriteString(st.department);
                    xw.WriteEndElement();

                    xw.WriteStartElement("projects");
                    int i = 1;
                    foreach (string pro in st.projects)
                    {
                        xw.WriteStartElement("project" + i);
                        xw.WriteString(pro);
                        xw.WriteEndElement();
                        i++;
                    }
                    xw.WriteEndElement();

                    xw.WriteEndElement();
                    xw.WriteEndDocument();
                    xw.Close();
                    
                }
                else
                {

                    XmlDocument Doc = new XmlDocument();
                    XmlElement student = Doc.CreateElement("student");
                    XmlElement node;
                    XmlElement nodein;

                    node = Doc.CreateElement("id");
                    node.InnerText = st.id;
                    student.AppendChild(node);

                    node = Doc.CreateElement("name");
                    node.InnerText = st.name;
                    student.AppendChild(node);

                    node = Doc.CreateElement("gender");
                    node.InnerText = st.gender;
                    student.AppendChild(node);

                    node = Doc.CreateElement("department");
                    node.InnerText = st.department;
                    student.AppendChild(node);

                    int i = 1;
                    node = Doc.CreateElement("project");
                    foreach (string pro in st.projects)
                    {
                        nodein = Doc.CreateElement("project" + i);
                        nodein.InnerText = pro;
                        node.AppendChild(nodein);
                        i++;
                    }
                    student.AppendChild(node);

                    Doc.Load(filePath);
                    XmlElement Root = Doc.DocumentElement;
                    Root.AppendChild(student);
                    Doc.Save(filePath);
                }

            }

                MessageBox.Show("Edit is Done");
            
        }
        private void load_noded_xml()
        {

            XmlDocument DOC = new XmlDocument();
            DOC.Load(filePath);
            XmlNodeList list = DOC.GetElementsByTagName("student");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childs = list[i].ChildNodes;

                string id = childs[0].InnerText;
                string name = childs[1].InnerText;
                string gender = childs[2].InnerText;
                string dep = childs[3].InnerText;

                XmlNodeList projects = childs[4].ChildNodes;
                string[] pro = new string[5];

                for (int j = 0; j < projects.Count; j++)
                {
                    string p1 = projects[j].InnerText;
                    pro[j] = p1;
                }
                if (table.ColumnCount == 0)
                {
                    string h_id = childs[0].Name;
                    string h_name = childs[1].Name;
                    string h_gender = childs[2].Name;
                    string h_dep = childs[3].Name;
                    table.Columns.Add("ID", h_id);
                    table.Columns.Add("NAME", h_name);
                    table.Columns.Add("GENDER", h_gender);
                    table.Columns.Add("DEPARTMENT", h_dep);
                    table.Columns.Add("PRO1", "project 1");
                    table.Columns.Add("PRO2", "project 2");
                    table.Columns.Add("PRO3", "project 3");
                    table.Columns.Add("PRO4", "project 4");
                    table.Columns.Add("PRO5", "project 5");
                }

                string[] row = { id, name, gender, dep, pro[0], pro[1], pro[2], pro[3], pro[4] };
                table.Rows.Add(row);
            }
        }
        public void Search(string searchKEY)
        {
            string op = "not showed";
            XmlDocument DOC = new XmlDocument();
            DOC.Load(filePath);
            XmlNodeList list = DOC.GetElementsByTagName("student");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childs = list[i].ChildNodes;

                string id = childs[0].InnerText;
                string name = childs[1].InnerText;
                string gender = childs[2].InnerText;
                string dep = childs[3].InnerText;

                XmlNodeList projects = childs[4].ChildNodes;
                string[] pro = new string[5];

                for (int j = 0; j < projects.Count; j++)
                {
                    string p1 = projects[j].InnerText;

                    pro[j] = p1;

                }



                if (kindOfSearch_CB.Text == "name")
                {
                    if (searchKEY == name)
                    {
                        string[] row = { id, name, gender, dep, pro[0], pro[1], pro[2], pro[3], pro[4] };
                        table.Rows.Add(row);
                        op = "done";
                    }
                }

                else if (kindOfSearch_CB.Text == "id")
                {
                    if (searchKEY == id)
                    {
                        string[] row = { id, name, gender, dep, pro[0], pro[1], pro[2], pro[3], pro[4] };
                        table.Rows.Add(row);
                        op = "done";
                    }
                }

                else if (kindOfSearch_CB.Text == "gender")
                {
                    if (searchKEY == gender)
                    {
                        string[] row = { id, name, gender, dep, pro[0], pro[1], pro[2], pro[3], pro[4] };
                        table.Rows.Add(row);
                        op = "done";
                    }
                }

                else if (kindOfSearch_CB.Text == "department")
                {
                    if (searchKEY == dep)
                    {
                        string[] row = { id, name, gender, dep, pro[0], pro[1], pro[2], pro[3], pro[4] };
                        table.Rows.Add(row);
                        op = "done";
                    }
                }

            }
            if (op != "done") MessageBox.Show("this field is not exist");

        }
        private void search_B_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            if (search_TX.Text != "")
                Search(search_TX.Text);
            else
                MessageBox.Show("please enter search key");

        }


        private void choice_file_Click(object sender, EventArgs e)
        {
            //choice_fileB.Text = "RELOUD NEW FILE";
            table.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.InitialDirectory = "C:\\Users\\mahmo\\OneDrive\\Desktop\\rrr\\Querying-Module\\file\\xml files";
                openFileDialog.Filter = "xml files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    filename = openFileDialog.SafeFileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                
            }


            var result = MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                filepathTX.Text = filename;
                if (filename == "students.xml")
                {
                    load_noded_xml();
                   // Update.Text = "ADD NEW STUDENT";
                    comboBox3.Items.Add("Aggregate functions");
                    comboBox3.Items.Add("Comparison queries");
                    comboBox3.Items.Add("Boolean opperators");
                    comboBox3.Items.Add("Search");
                }
                else
                {

                    DS.ReadXml(filePath);
                    table.DataSource = DS.Tables[0];

                    comboBox3.Items.Add("Aggregate functions");
                    comboBox3.Items.Add("Comparison queries");
                    comboBox3.Items.Add("Boolean opperators");
                    

                }
            }
            bunifuTransition1.ShowSync(panel3);
        }


        //shafik
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int column = table.CurrentCell.ColumnIndex; 
            int num_of_row = table.RowCount;
            num_of_row-- ;
            removes.Clear();
            if (comboBox1.Text != "")
            {
                
              
               
                if (comboBox1.Text == "=")
                {
                    for (int i = 0; i < num_of_row; i++)
                    {

                        if (Convert.ToInt32(cfield_tx.Text) != Convert.ToInt32(table.Rows[i].Cells[column].Value))
                        {

                            removes.Add(i);

                        }
                        
                       
                    }
                    for (int i = 0; i < removes.Count; i++)
                    {
                        table.Rows.RemoveAt(removes[i]);
                        for(int j=0;j<removes.Count;j++)
                        {
                            if (i == j) continue;
                            else { removes[j]--; }
                        }
                    }
                   

                }
                else if (comboBox1.Text == "<")
                {

                    for (int i = 0; i < num_of_row; i++)
                    {

                        if (Convert.ToInt32(cfield_tx.Text) <= Convert.ToInt32(table.Rows[i].Cells[column].Value))
                        {

                            removes.Add(i);

                        }

                    }
                    for (int i = 0; i < removes.Count; i++)
                    {
                        table.Rows.RemoveAt(removes[i]);
                        for (int j = 0; j < removes.Count; j++)
                        {
                            if (i == j) continue;
                            else { removes[j]--; }
                        }
                    }


                }
                else if (comboBox1.Text == ">")
                {
                    for (int i = 0; i < num_of_row; i++)
                    {

                        if (Convert.ToInt32(cfield_tx.Text) >= Convert.ToInt32(table.Rows[i].Cells[column].Value))
                        {

                            removes.Add(i);

                        }

                    }
                    for (int i = 0; i < removes.Count; i++)
                    {
                        table.Rows.RemoveAt(removes[i]);
                        for (int j = 0; j < removes.Count; j++)
                        {
                            if (i == j) continue;
                            else { removes[j]--; }
                        }
                    }

                }

                else if (comboBox1.Text == "!=")
                {
                    for (int i = 0; i < num_of_row; i++)
                    {

                        if (Convert.ToInt32(cfield_tx.Text) == Convert.ToInt32(table.Rows[i].Cells[column].Value))
                        {

                            removes.Add(i);

                        }

                    }
                    for (int i = 0; i < removes.Count; i++)
                    {
                        table.Rows.RemoveAt(removes[i]);
                        for (int j = 0; j < removes.Count; j++)
                        {
                            if (i == j) continue;
                            else { removes[j]--; }
                        }
                    }

                }
                else if(comboBox1.Text == "in")
                {
                    

                    string[] s = cfield_tx.Text.Split(' ');
                  
                  int min,max;
                    min=Convert.ToInt32(s[0]);
                    max=Convert.ToInt32(s[1]);
                    for (int i = 0; i < num_of_row; i++)
                    {
                        
                        if (!(min <= Convert.ToInt32(table.Rows[i].Cells[column].Value) && max >= Convert.ToInt32(table.Rows[i].Cells[column].Value)))
                        {

                            removes.Add(i);

                        }

                    }
                    for (int i = 0; i < removes.Count; i++)
                    {
                        table.Rows.RemoveAt(removes[i]);
                        for (int j = 0; j < removes.Count; j++)
                        {
                            if (i == j) continue;
                            else { removes[j]--; }
                        }
                    }

                    

                }




            }
        }



        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (filename == "students.xml")
            {
                DialogResult res = MessageBox.Show("if you did not edit yet, Do you wanna Add new row? ", "add new student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    add_student_form st = new add_student_form();
                    st.Show();
                }
                else
                    edit();

            }
            else
            {
                try
                {
                    DS.Tables[0].WriteXml(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (table.FirstDisplayedCell != null)
            {
                bunifuTransition1.ShowSync(panel4);
            }
            else
                MessageBox.Show("No Table Was Found!!! Please Upload Any Table First", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        // GUI CODE
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (comboBox3.Text == "Aggregate functions")
                {
                    bunifuTransition1.HideSync(studentpanal);
                    bunifuTransition1.HideSync(Comparison);
                    bunifuTransition2.HideSync(Boolean);

                    bunifuTransition2.ShowSync(Aggregate);
                    bunifuTransition2.ShowSync(sum);
                    bunifuTransition2.ShowSync(avg);
                    bunifuTransition2.ShowSync(min);
                    bunifuTransition2.ShowSync(max);
                }
                else if (comboBox3.Text == "Comparison queries")
                {
                    bunifuTransition1.HideSync(studentpanal);
                    bunifuTransition1.HideSync(Aggregate);
                    bunifuTransition2.HideSync(Boolean);

                    bunifuTransition2.ShowSync(Comparison);
                    bunifuTransition2.ShowSync(cfield_tx);
                    bunifuTransition2.ShowSync(equal);
                    bunifuTransition2.ShowSync(not_equal);
                    bunifuTransition2.ShowSync(great);
                    bunifuTransition2.ShowSync(small);
                    bunifuTransition2.ShowSync(in_range);
                }
                else if (comboBox3.Text == "Boolean opperators")
                {
                    bunifuTransition1.HideSync(Comparison);
                    bunifuTransition1.HideSync(Aggregate);
                    bunifuTransition1.HideSync(studentpanal);

                    bunifuTransition2.ShowSync(Boolean);
                    bunifuTransition2.ShowSync(and);
                    bunifuTransition2.ShowSync(or);
                }
            else
                {
                    bunifuTransition1.HideSync(Comparison);
                    bunifuTransition1.HideSync(Aggregate);
                    bunifuTransition1.HideSync(Boolean);

                    bunifuTransition2.ShowSync(studentpanal);
                }

        }

      
        private void cfield_tx_Click(object sender, EventArgs e)
        {
            cfield_tx.Text = "";
            cfield_tx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

        }

        private void kindOfSearch_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_TX.Text = "";
            table.Rows.Clear();
            load_noded_xml();
        }

        private void search_TX_Click(object sender, EventArgs e)
        {
            search_TX.Text = "";
            search_TX.ForeColor = System.Drawing.SystemColors.ControlLight;
        }

        // Shafik&Youssef
        private void equal_Click(object sender, EventArgs e)
        {

        }

        private void not_equal_Click(object sender, EventArgs e)
        {

        }

        private void great_Click(object sender, EventArgs e)
        {

        }

        private void small_Click(object sender, EventArgs e)
        {

        }
    }
}
