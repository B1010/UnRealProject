using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnRealProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PropertyGrid subjectEdit = new PropertyGrid();
            propertyGrid1.SelectedObject = subjectEdit;
            subjectEdit.subjectList_result[0]=5;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    class PropertyGrid
    {
        public int[] subjectList_result = new int[4];
        [Category("Предметы")]
        [DisplayName("Математика")]
        public int sub_math
        {
            get
            {
                return subjectList_result[0];
            }
            set
            {
                subjectList_result[0] = value;
            }
        }
        [Category("Предметы")]
        [DisplayName("Физика")]
        public int sub_phys
        {
            get
            {
                return subjectList_result[1];
            }
            set
            {
                subjectList_result[1] = value;
            }
        }
        [Category("Предметы")]
        [DisplayName("Программирование")]
        public int sub_prog
        {
            get
            {
                return subjectList_result[2];
            }
            set
            {
                subjectList_result[2] = value;
            }
        }
        [Category("Предметы")]
        [DisplayName("Физкультура")]
        public int sub_fiz
        {
            get
            {
                return subjectList_result[3];
            }
            set
            {
                subjectList_result[3] = value;
            }
        }
    }
}
