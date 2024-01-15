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
    }
}
