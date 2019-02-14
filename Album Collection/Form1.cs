using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Album_Collection
{
    public partial class Form1 : Form
    {
        List<string> albumOriginal = new List<string>();
        List<string> albumSorted = new List<string>();
        string albumName;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            albumName = albumBox.Text;

            if (albumName != "")
            {
                albumOriginal.Add(albumName);
                albumSorted.Add(albumName);
                albumSorted.Sort();


                resetLabels();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            albumName = albumBox.Text;

            if (albumOriginal.Contains(albumName) == true)
            {
                albumOriginal.Remove(albumName);
                albumSorted.Remove(albumName);

                resetLabels();
            }
            else if (albumOriginal.Contains(albumName) == false)
            {
                failLabel.Text = "Album " + albumName + " cannot be found.";
            }
        }

        private void resetLabels()
        {
            originalLabel.Text = "Original Order\n****************";
            for (int i = 0; i < albumOriginal.Count(); i++)
            {
                originalLabel.Text += "\n" + albumOriginal[i];
            }

            sortedLabel.Text = "Sorted Order\n****************"; 
            for (int i = 0; i < albumSorted.Count(); i++)
            {
                sortedLabel.Text += "\n" + albumSorted[i];
            }
        }
    }
}
