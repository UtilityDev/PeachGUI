using PeachGUI.Classes;

namespace PeachGUI
{
    public partial class ProjectSetup : Form
    {
        string projectName;
        string projectLanguage;

        string defaultProjectDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string projectDirectory;

        public ProjectSetup()
        {
            InitializeComponent();

            ProjectDirectoryTbx.Text = defaultProjectDirectory;
        }

        // Create project
        private void CreateProjectBtn_Click(object sender, EventArgs e)
        {
            projectName = ProjectNameTbx.Text.Trim();
            projectLanguage = ProjectTemplateDd.Text.Trim().ToLower();
            projectDirectory = ProjectDirectoryTbx.Text.Trim();

            try
            {
                ProjectManager.CreateProject(projectName, projectDirectory, projectLanguage);
            } catch { return; }
        }
    }
}
