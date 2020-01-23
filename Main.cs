using System;
using System.Windows.Forms;

namespace VirusBuilder_Pro_CSharp {
    public partial class Main : Form {
        string batchFile = "@echo off\ncls\n";
        string shellFile = "";

        public Main() {
            InitializeComponent();
        }

        // On select load the rest of the menu for the selected option
        private void componentList_SelectedIndexChanged(object sender, EventArgs e) {
            // Make sure there's an actual selection
            if(componentList.SelectedIndex == -1) {
                return;
            }
            // Hide all fields
            field1Label.Visible = false;
            field1TextBox.Visible = false;
            field2Label.Visible = false;
            field2TextBox.Visible = false;
            extraInfoLabel.Visible = false;
            // Reset field values
            field1TextBox.Text = "";
            field2TextBox.Text = "";
            // Log the selected component
            System.Console.WriteLine("Selected: " + componentList.SelectedItem.ToString());
            switch(componentList.SelectedIndex) {
                // Title
                case 0:
                    // Set field labels for title
                    field1Label.Text = "Title:";
                    // Set extra info for title
                    extraInfoLabel.Text = "Warning: Won't always work for shell file.";
                    // Show fields
                    field1Label.Visible = true;
                    field1TextBox.Visible = true;
                    extraInfoLabel.Visible = true;
                    break;
                // Colour (Windows Only)
                case 1:
                    // Set field labels for colour
                    field1Label.Text = "Background colour:";
                    field2Label.Text = "Text colour:";
                    // Set extra info
                    extraInfoLabel.Text = "Colours should be written as either a number from 0-9 or a letter from A-F.";
                    // Show fields
                    field1Label.Visible = true;
                    field1TextBox.Visible = true;
                    field2Label.Visible = true;
                    field2TextBox.Visible = true;
                    extraInfoLabel.Visible = true;
                    break;
                // Echo Text to Screen
                case 2:
                    // Set field labels for echo
                    field1Label.Text = "Text:";
                    // Show fields
                    field1Label.Visible = true;
                    field1TextBox.Visible = true;
                    break;
                // Shutdown/Restart/Hibernate
                case 3:
                case 4:
                    // Set field labels for shutdown/restart
                    field1Label.Text = "Text (Windows Only):";
                    field2Label.Text = "Timer in seconds (Windows Only):";
                    // Show fields
                    field1Label.Visible = true;
                    field1TextBox.Visible = true;
                    field2Label.Visible = true;
                    field2TextBox.Visible = true;
                    break;
                case 5:
                    // Set extra info for hibernate
                    extraInfoLabel.Text = "There are no arguments for this virus component.";
                    break;
                // Wait
                case 6:
                    // Set field labels for wait
                    field1Label.Text = "Wait duration in seconds:";
                    // Show fields
                    field1Label.Visible = true;
                    field1TextBox.Visible = true;
                    break;
                // Open CMD (Windows Only)
                case 7:
                    // Set extra info for cmd
                    extraInfoLabel.Text = "There are no arguments for this virus component.";
                    // Show fields
                    extraInfoLabel.Visible = true;
                    break;
                // Open Notepad (Windows Only)
                case 8:
                    // Set field labels for notepad
                    field1Label.Text = "File to open (Optional):";
                    // Set extra info for notepad
                    extraInfoLabel.Text = "Note: File will be opened relative to virus run location, not VirusBuilder Pro C#.";
                    // Show fields
                    field1Label.Visible = true;
                    field1TextBox.Visible = true;
                    extraInfoLabel.Visible = true;
                    break;
            }
            // Show add component button
            addComponentButton.Visible = true;
        }

        private void addComponentButton_Click(object sender, EventArgs e) {
            // Check what component to add
            switch(componentList.SelectedIndex) {
                // Title
                case 0:
                    batchFile += "title " + field1TextBox.Text + "\n";
                    shellFile += "export PS1='\\[\\e]0;" + field1TextBox.Text + ":\\w\\a\\]\\n\\[\\e[32m\\]\\u@\\h \\[\\e[33m\\]~\\w\\[\\e[0m\\]\\n\\$'\n";
                    break;
                // Colour (Windows Only)
                case 1:
                    batchFile += "color " + field1TextBox.Text + field2TextBox.Text + "\n";
                    break;
                // Echo Text to Screen
                case 2:
                    batchFile += "echo " + field1TextBox.Text + "\n";
                    shellFile += "echo \"" + field1TextBox.Text + "\n";
                    break;
                // Shutdown
                case 3:
                    batchFile += "shutdown /s /f /t " + field2TextBox.Text + " /c \"" + field1TextBox.Text + "\"\n";
                    shellFile += "shutdown || poweroff || halt -p\n";
                    break;
                // Restart
                case 4:
                    batchFile += "shutdown /r /f /t " + field2TextBox.Text + " /c \"" + field1TextBox.Text + "\"\n";
                    shellFile += "reboot ||halt --reboot || restart\n";
                    break;
                // Hibernate
                case 5:
                    batchFile += "shutdown /h\n";
                    shellFile += "halt || pm-suspend\n";
                    break;
                // Wait
                case 6:
                    batchFile += "sleep " + field1TextBox.Text + "\n";
                    shellFile += "sleep " + field1TextBox.Text + "\n";
                    break;
                // Open CMD (Windows Only)
                case 7:
                    batchFile += "start cmd\n";
                    break;
                // Open Notepad (Windows Only)
                case 8:
                    batchFile += "notepad " + field1TextBox.Text + "\n";
                    break;
            }
            // Hide fields & buttons
            addComponentButton.Visible = false;
            field1Label.Visible = false;
            field1TextBox.Visible = false;
            field2Label.Visible = false;
            field2TextBox.Visible = false;
            extraInfoLabel.Visible = false;
            System.Console.WriteLine("Added: " + componentList.SelectedItem.ToString());
            // Reset list choice
            componentList.ClearSelected();
        }

        private void buildVirusButton_Click(object sender, EventArgs e) {
            try
            {
                System.IO.File.WriteAllText(batchPathTextBox.Text + ".bat", batchFile);
                System.IO.File.WriteAllText(shellPathTextBox.Text + ".sh", shellFile);

                extraInfoLabel.Text = "Wrote files!";
                extraInfoLabel.Visible = true;
            } catch(Exception) {
                System.Console.WriteLine("Something went wrong when writing the files.");
                extraInfoLabel.Text = "Something went wrong when writing the files.";
                extraInfoLabel.Visible = true;
            }
        }
    }
}
