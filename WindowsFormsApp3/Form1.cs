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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            LoadDrives();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }

        private void LoadDrives()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                drivesListBox.Items.Add(drive);
            }
        }

        private void drivesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drivesListBox.SelectedItem != null)
            {
                string selectedDrive = drivesListBox.SelectedItem.ToString();
                DisplayDriveProperties(selectedDrive);
                LoadDirectories(selectedDrive);
                LoadFiles(selectedDrive);
            }
        }

        private void directoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDirectory = directoriesListBox.SelectedItem.ToString();
            DisplayDirectoryProperties(selectedDirectory);
            LoadFiles(selectedDirectory);
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFile = filesListBox.SelectedItem.ToString();
            DisplayFileProperties(selectedFile);
            if (IsImageFile(selectedFile))
            {
                DisplayImage(selectedFile);
            }
            else if (IsTextFile(selectedFile))
            {
                DisplayTextFileContent(selectedFile);
            }
        }

        private void LoadDirectories(string path)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                directoriesListBox.Items.Clear();
                foreach (string directory in directories)
                {
                    directoriesListBox.Items.Add(directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading directories: " + ex.Message);
            }
        }

        private void LoadFiles(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                filesListBox.Items.Clear();
                foreach (string file in files)
                {
                    filesListBox.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading files: " + ex.Message);
            }
        }

        private void DisplayDriveProperties(string drive)
        {
            DriveInfo driveInfo = new DriveInfo(drive);
            propertiesTextBox.Text = $"Drive Name: {driveInfo.Name}\r\n" +
                $"Drive Type: {driveInfo.DriveType}\r\n" +
                $"Total Size: {driveInfo.TotalSize}\r\n" +
                $"Available Free Space: {driveInfo.AvailableFreeSpace}\r\n";
        }

        private void DisplayDirectoryProperties(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            propertiesTextBox.Text = $"Directory Name: {directoryInfo.Name}\r\n" +
                $"Created: {directoryInfo.CreationTime}\r\n" +
                $"Last Modified: {directoryInfo.LastWriteTime}\r\n" +
                $"Attributes: {directoryInfo.Attributes}\r\n";
        }

        private void DisplayFileProperties(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            propertiesTextBox.Text = $"File Name: {fileInfo.Name}\r\n" +
                $"Size: {fileInfo.Length}\r\n" +
                $"Created: {fileInfo.CreationTime}\r\n" +
                $"Last Modified: {fileInfo.LastWriteTime}\r\n" +
                $"Attributes: {fileInfo.Attributes}\r\n";
        }

        private void DisplayImage(string imagePath)
        {
            try
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private void DisplayTextFileContent(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                contentTextBox.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying text file content: " + ex.Message);
            }
        }

        private bool IsImageFile(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return Array.Exists(imageExtensions, ext => ext.Equals(extension, StringComparison.OrdinalIgnoreCase));
        }

        private bool IsTextFile(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string[] textExtensions = { ".txt", ".csv", ".log" };
            return Array.Exists(textExtensions, ext => ext.Equals(extension, StringComparison.OrdinalIgnoreCase));
        }

       
    }
}