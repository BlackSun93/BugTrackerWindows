using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bugtracker
{
    public partial class Window : Form
    {

        Form1 f1;
        ProjectsForm projForm;
        NewProjectForm newProjForm;

        string currentForm;
        public Window()
        {
            
            InitializeComponent();
            DisplayForm1();
        }
        public void DisplayForm1()
        {
            currentForm = "Form1";
            Controls.Clear();
            f1 = new Form1(this);
            f1.TopLevel = false;
            Controls.Add(f1);
            f1.Show();
        }

        public  void DisplayProjectsForm()
        {
            currentForm = "DisplayProjectsForm";
            Controls.Clear();
            projForm = new ProjectsForm(this);
            projForm.TopLevel = false;
            Controls.Add(projForm);
            projForm.Show();
        }
        public void DisplayNewProjectForm()
        {
            currentForm = "DisplayNewProjectForm";
            Controls.Clear();
            newProjForm = new NewProjectForm(this);
            newProjForm.TopLevel = false;
            Controls.Add(newProjForm);
            newProjForm.Show();
        }

        private void Window_Resize(object sender, EventArgs e)
        {
            // CONSIDER VIABILITY OF THESE FUNCTIONS, MAYBE ON-RESIZE SHOULD ONLY DEAL WITH ELEMENTS REQUIREING
            // RESIZE RATHER THAN RELOAD WHOLE FORM
            switch (currentForm)
            {
                case "Form1":
                    
                    DisplayForm1();
                    
                    break;

                case "DisplayProjectsForm":
                    //On resize, should change the width of the project form to the size of the window, however on resize, form
                    //contents remain as if it was fullscreened. WE can get this working by calling the form's Display(formname)()
                    //however this clears the form and redisplays it on resize which clears out all fields (textboxes, richtext etc)
                    //and is also pretty slow.
                    //projForm.Resize += new System.EventHandler(projForm.ProjectsForm_Resize);
                    projForm.Width = Width;
                    projForm.Height = Height;
                    //DisplayProjectsForm();

                    projForm.testResize();
                    break;

                case "DisplayNewProjectForm":
                    DisplayNewProjectForm();
                    break;
            }

        }
    }
}
