using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEIS209_DENTON_CourseProject
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private bool ValidInput()
        {
            //Check if empty form values
            bool isValid = true;
            if (string.IsNullOrEmpty(titleText.Text))
            {
                MessageBox.Show("The song title cannot be blank.");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                MessageBox.Show("The title cannot be blank.");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("The year cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("The year cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(genreComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("The genre cannot be blank");
            }

            return (isValid);
        }

        private bool SongInList(string songTitle)
        {
            bool isFound = false;

            foreach (var item in songList.Items)
            {
                string currentSong = item as string;
                if(songTitle == currentSong)
                {
                    isFound = true;
                }
            }

            return (isFound);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            if(ValidInput())
            {
                //Add Title to the Song List
                songList.Items.Add(titleText.Text);
                
                //Build Output Text
                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreComboBox.SelectedItem.ToString());
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);

                //Place Text into Output Text Box
                outputText.Text = sb.ToString();
                MessageBox.Show("Song added successfully!");
            }
        }

        private void showAllSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            //Build Output Text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }
            outputText.Text = sb.ToString();
        }

        private void findSongButton_Click(object sender, EventArgs e)
        {
            if (SongInList(titleText.Text))
            {
                MessageBox.Show("Song Found");
            }
            else
            {
                MessageBox.Show("Song Not Found");
            }
        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            titleText.Text = "";
            artistText.Text = "";
            genreComboBox.SelectedIndex = -1;
            yearText.Text = "";
            urlText.Text = "";
        }
    }
}
