using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DojoTimer.Helpers;
using System.Threading;

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

            SetupAutoComplete(Person1Input, autocomplete);
            SetupAutoComplete(Person2Input, autocomplete);
            formTitleBar1.BindHandleTo(this);
        }

        public static void SetupAutoComplete(TextBox textbox, AutoCompleteStringCollection autocomplete)
        {
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textbox.AutoCompleteCustomSource = autocomplete;
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

        private bool ValidatePerson()
        {
            bool result = !string.IsNullOrEmpty(Person1) && !string.IsNullOrEmpty(Person2);
            if (!result)
                MessageBox.Show(this, "Please, if you want to save, make sure you fill both boxes.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }

        private void OnlySaveButton_Click(object sender, EventArgs e)
        {
            MarkFinish(false);
        }

        private void MarkFinish(bool commit)
        {
            if (ValidatePerson())
            {
                var person1 = Person1;
                var person2 = Person2;
                new Thread(() =>
                {
                    options.MarkFinish(commit, person1, person2);
                    options.Save();
                }).Start();
                this.Close();
            }
        }

        private void SaveCommitButton_Click(object sender, EventArgs e)
        {
            MarkFinish(true);
        }

        private void WhoWasHereForm_Activated(object sender, EventArgs e)
        {
            HandleActivate(true);
        }

        private void HandleActivate(bool value)
        {
            Person1Input.Visible = Person2Input.Visible = value;
            ClickHereLabel.Visible = !value;
            if (value) Person1Input.Focus();
        }

        private void WhoWasHereForm_Deactivate(object sender, EventArgs e)
        {
            HandleActivate(false);
        }
       
    }
}
