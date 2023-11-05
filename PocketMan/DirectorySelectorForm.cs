using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

public class DirectorySelectorForm : Form
{
    private ListBox listBox;
    private Button selectButton;
    private string currentDirectory;

    public DirectorySelectorForm()
    {
        listBox = new ListBox();
        listBox.Dock = DockStyle.Fill;
        this.Controls.Add(listBox);

        selectButton = new Button();
        selectButton.Text = "Select";
        selectButton.Dock = DockStyle.Bottom;
        this.Controls.Add(selectButton);

        selectButton.Click += new EventHandler(selectButton_Click);
        listBox.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
    }

    void selectButton_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedItem != null)
        {
            currentDirectory = Path.Combine(currentDirectory, listBox.SelectedItem.ToString());
            UpdateDirectory();
        }
    }

    void listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBox.SelectedItem.ToString() == "..")
        {
            currentDirectory = Path.GetDirectoryName(currentDirectory);
            UpdateDirectory();
        }
    }

    public string SelectDirectory()
    {
        currentDirectory = "\\";
        UpdateDirectory();
        this.ShowDialog();
        return currentDirectory;
    }

    private void UpdateDirectory()
    {
        listBox.Items.Clear();

        if (currentDirectory != "\\")
        {
            listBox.Items.Add("..");
        }

        string[] directories = Directory.GetDirectories(currentDirectory);
        foreach (string directory in directories)
        {
            listBox.Items.Add(Path.GetFileName(directory));
        }
    }
}