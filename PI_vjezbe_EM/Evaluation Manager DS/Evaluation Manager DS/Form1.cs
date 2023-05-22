using Evaluation_Manager_DS.Models;
using Evaluation_Manager_DS.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager_DS {
    private List<StudentReportView> GenerateStudentReport() 
        { var allStudents = StudentRepository.GetStudents();
        var examReports = new List<StudentReportView>();
        foreach (var student in allStudents) { if (student.HasSignature() == true) { var examReport = new StudentReportView(student);
                examReports.Add(examReport); 
            } } return examReports;
    }

    private void FrmFinalReport_Load(object sender, EventArgs e)
        { var results = GenerateStudentReport(); 
        dgvResults.DataSource = results; }
    var form = new FrmFinalReport();
    form.ShowDialog();
    public partial class DbvResults : Form {
        public DbvResults() {
            InitializeComponent();
        }

        private void DbvResults_Load(object sender, EventArgs e) {

        }

        private void BtnClose_Click(object sender, EventArgs e) {

        }
    }
}
