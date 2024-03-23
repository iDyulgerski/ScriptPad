using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptPad
{
    public partial class Info : Form
    {
        private Boolean IsEdit;
        private Movie OriginalMovie;
        public Movie EditedMovie;
        public Movie NewMovie;
        public Boolean DataSaved;
        public int indexLocX;
        public int indexLocY;

        public Info(int x, int y)
        {
            indexLocX = x;
            indexLocY = y;
            InitializeComponent();
            IsEdit = false;
        }

        public Info(Movie movie, int x, int y)
        {
            indexLocX = x;
            indexLocY = y;
            InitializeComponent();
            IsEdit = true;
            OriginalMovie = movie;
        }

        private void AddEditMovie_Load(object sender, EventArgs e)
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
            this.Location = new Point(indexLocX + 430, indexLocY);
            DataSaved = false;

            if (IsEdit)
            {
                PopulateOriginalMovie();
                this.Text = "Edit";
            }

            else
            {
                ClearInput();
                this.Text = "Add";
            }
        }

        private void PopulateOriginalMovie()
        {
            TxtTitle.Text = OriginalMovie.Title;
            TxtImagePath.Text = OriginalMovie.ImageUrl;
            NoteBox.Text = OriginalMovie.Note;
            ratingNumeric.Value = OriginalMovie.Rating;
            DtpReleaseDate.Text = OriginalMovie.ReleaseDate.ToString();
        }

        private void ClearInput()
        {
            TxtTitle.Clear();
            TxtImagePath.Clear();
            NoteBox.Clear();
            ratingNumeric.Value = 0;
            DtpReleaseDate.Text = DateTime.Now.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<String> errors;

            errors = ValidateInput();

            if (errors.Count > 0)
            {
                ShowErrors(errors, 5);
                return;
            }

            StoreInput();
            DataSaved = true;
            this.Close();
        }

        private List<string> ValidateInput()
        {
            List<String> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
                errors.Add("Title required");

            if (string.IsNullOrWhiteSpace(TxtImagePath.Text))
                errors.Add("Image Path required");

            return errors;
        }

        private void StoreInput()
        {
            string title;
            string imgUrl;
            string note;
            int rating;
            DateTime releaseDate;
            int id;

            title = TxtTitle.Text;
            imgUrl = TxtImagePath.Text;
            note = NoteBox.Text;
            rating = (int)ratingNumeric.Value;
            releaseDate = DateTime.Parse(DtpReleaseDate.Text.ToString());


            if (IsEdit)
                EditedMovie = new Movie(title, imgUrl, note, rating, releaseDate);
            else
            {
                NewMovie = new Movie(title, imgUrl, note, rating, releaseDate);
            }

        }


        private void ShowErrors(List<string> errors, int max)
        {
            MessageBoxIcon icon;
            MessageBoxButtons buttons;
            string text = null;

            icon = MessageBoxIcon.Error;
            buttons = MessageBoxButtons.OK;

            if (max > errors.Count)
                max = errors.Count;

            for (int i = 0; i < max; i++)
            {
                text += errors[i] + "\n";
            }

            MessageBox.Show(text, "", buttons, icon);
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ratingNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NoteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                TxtImagePath.Text = open.FileName;
            }
        }

        private void TxtImagePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
