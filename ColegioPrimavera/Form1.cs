using ColegioPrimavera.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioPrimavera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();

            comboCurso.DataSource = bd.Cursos.ToList();
            comboCurso.DisplayMember = "nombre_Curso";
            
            
        }

        private void comboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();

            Curso CursoSeleccionado = (Curso) comboCurso.SelectedItem;

            List<Alumno> AlumnosDelCurso =
                bd.Alumnos.
                Where(Curso => Curso.Id_Curso == CursoSeleccionado.Id_Curso).
                ToList();

            gridAlumnos.DataSource = AlumnosDelCurso;

            gridAlumnos.Columns[0].Visible = false;
            gridAlumnos.Columns[3].Visible = false;
            gridAlumnos.Columns[4].Visible = false;

            txtProfesor.Text = CursoSeleccionado.Profesore.nombre_Profesor;

        }

        private void gridAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProfesor_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
