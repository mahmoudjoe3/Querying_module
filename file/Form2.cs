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
    public partial class add_student_form : Form
    {
        
        //path that i store the xml file in it
        string filepath = Form1.filePath;
        public add_student_form()
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
        private void ADD()
        {
            List<string> projects = new List<string>();
            string gender = "undefined";
            if (male_rb.Checked == true) { gender = male_rb.Text; }
            else if (female_rb.Checked == true) { gender = female_rb.Text; }

            foreach (string pro in projects_clb.CheckedItems)
            {
                projects.Add(pro);
            }
            student st = new student(id_tb.Text, name_tb.Text, gender, department_cb.Text, projects);
            clearLayout();
            //write in xml
            if (!File.Exists(filepath))
            {
                XmlWriter xw = XmlWriter.Create(filepath);
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

                Doc.Load(filepath);
                XmlElement Root = Doc.DocumentElement;
                Root.AppendChild(student);
                Doc.Save(filepath);


            }
            MessageBox.Show("ADD is Done");
        }
        

        private void clearLayout()
        {
            id_tb.Text = ""; name_tb.Text = ""; male_rb.Checked = false; female_rb.Checked = false; department_cb.Text = ""; projects_clb.ClearSelected();
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clear_b_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure in that ?", "caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("clearing is cancel");
            }
            else
            {
                File.Delete(filepath);
                MessageBox.Show("clearing is Done");
            }
        }

        private void add_b_Click_1(object sender, EventArgs e)
        {
            ADD();
           
        }
    }
}
