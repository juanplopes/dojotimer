using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DojoTimer
{
    public partial class WhoWasHereForm : Form
    {
        Options options;
        public string Person1 { get { return Person1Input.Text; } }
        public string Person2 { get { return Person2Input.Text; } }

        public WhoWasHereForm(Options options)
        {
            InitializeComponent();
            this.options = options;
            SetLastParticipant(options);
            var autocomplete = GetAutoCompleteSource(options);

            Person1Input.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Person1Input.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Person1Input.AutoCompleteCustomSource = autocomplete;

            Person2Input.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Person2Input.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Person2Input.AutoCompleteCustomSource = autocomplete;
        }

        private static AutoCompleteStringCollection GetAutoCompleteSource(Options options)
        {
            var autocomplete = new AutoCompleteStringCollection();
            autocomplete.AddRange(options.Participants);
            return autocomplete;
        }

        private void SetLastParticipant(Options options)
        {
            if (options.Participants.Length > 0)
                Person2Input.Text = options.Participants[options.Participants.Length - 1];
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnlySaveButton_Click(object sender, EventArgs e)
        {
            options.MarkFinish(false, Person1, Person2);
            options.Save();
            this.Close();
        }

        private void SaveCommitButton_Click(object sender, EventArgs e)
        {
            options.MarkFinish(true, Person1, Person2);
            options.Save();
            this.Close();
        }
    }
}
