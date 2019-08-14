using COMP123_S2019_FinalTestC.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: Haeun Jeong
 * STUDENT ID: 301004579
 * DESCRIPTION: This is the form to create character, display information.
 * And this form allows user to save and open file. 
 */

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        CharacterPortfolio character;
        Random random = new Random();
        public CharacterGenerationForm()
        {
            InitializeComponent();
            character = new CharacterPortfolio();
        }
        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count -1)
            {
                MainTabControl.SelectedIndex++;
            }

            if(MainTabControl.SelectedIndex == 3)
            {
                DisplayCharacterInfo();
            }
        }

        private void DisplayCharacterInfo()
        {
            FirstNameDisplayLabel.Text = FirstNameDataLabel.Text;
            LastNameDisplayLabel.Text = LastNameDataLabel.Text;
            StrengthDisplayLabel.Text = StrengthDataLabel.Text;
            DexterityDisplayLabel.Text = DexterityDataLabel.Text;
            EnduranceDisplayLabel.Text = EnduranceDataLabel.Text;
            IntellectDisplayLabel.Text = IntellectDataLabel.Text;
            EducationDisplayLabel.Text = EducationDataLabel.Text;
            SocialStandingDisplayLabel.Text = SocialStandingDataLabel.Text;
            Skill1DisplayLabel.Text = Skill1DataLabel.Text;
            Skill2DisplayLabel.Text = Skill2DataLabel.Text;
            Skill3DisplayLabel.Text = Skill3DataLabel.Text;
            Skill4DisplayLabel.Text = Skill4DataLabel.Text;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();

        }

        private void GenerateNames()
        {
            
            string[] firstNames = File.ReadAllLines("..\\..\\Data\\firstNames.txt");
            string[] lastNames = File.ReadAllLines("..\\..\\Data\\lastNames.txt");

            character.Identity.FirstName = firstNames[random.Next(firstNames.Length)];
            character.Identity.LastName = lastNames[random.Next(lastNames.Length)];

            FirstNameDataLabel.Text = character.Identity.FirstName;
            LastNameDataLabel.Text = character.Identity.LastName;
        }

        private void GenerateSkillsButton_Click(object sender, EventArgs e)
        {
            string[] skillNames = File.ReadAllLines("..\\..\\Data\\skills.txt");
            character.skill.Name = skillNames[random.Next(skillNames.Length)];

            Skill1DataLabel.Text = character.skill.Name;
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();

        }

        private void GenerateAbilities()
        {
            int strength = random.Next(15);
            StrengthDataLabel.Text = strength.ToString();
            int dexterity = random.Next(15);
            DexterityDataLabel.Text = dexterity.ToString();
            int endurance = random.Next(15);
            EnduranceDataLabel.Text = endurance.ToString();
            int intellect = random.Next(15);
            IntellectDataLabel.Text = intellect.ToString();
            int education = random.Next(15);
            EducationDataLabel.Text = education.ToString();
            int socialstanding = random.Next(15);
            SocialStandingDataLabel.Text = socialstanding.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            CharacterSaveFileDialog.FileName = "Chracter.txt";
            CharacterOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSaveFileDialog.Filter = "Text files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = CharacterSaveFileDialog.ShowDialog();
            if(result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamWriter outputString = new StreamWriter(
               File.Open("Character.txt", FileMode.Create)))
                    {
                        outputString.WriteLine(character.Identity.FirstName);
                        outputString.WriteLine(character.Identity.LastName);


                        outputString.Close();
                        outputString.Dispose();
                    }

                    MessageBox.Show("File Saved Successfully!", "Saving file...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);
                }

            }

           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            CharacterOpenFileDialog.FileName = "Chracter.txt";
            CharacterOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterOpenFileDialog.Filter = "Text files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = CharacterOpenFileDialog.ShowDialog();
            if(result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputString = new StreamReader(
                                   File.Open(CharacterOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //inputString.ReadLine(character.Identity.FirstName);
                    }
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);
                }
            }

           
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
