using CowsAndBulls;
using CowsAndBulls.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace CAB_Test
{
    [TestClass]
    public class MainMenuTests
    {
        [TestMethod]
        public void ChosenDifficulty_SelectedIndexChanged_Normal_SetNormalDescription()
        {
            // Arrange
            var form = new MainMenuForm();

            // Act
            form.chosenDifficulty.SelectedIndex = 0; // Assuming "Normal" is the first item
            form.chosenDifficulty_SelectedIndexChanged(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(DescriptionBase.NormalDescription != "" ? DescriptionBase.NormalDescription : null, form.descriptionBox.Text != "" ? form.descriptionBox.Text : null);
        }

        [TestMethod]
        public void ChosenDifficulty_SelectedIndexChanged_Hard_SetHardDescription()
        {
            // Arrange
            var form = new MainMenuForm();

            // Act
            form.chosenDifficulty.SelectedIndex = 1; // Assuming "Hard" is the second item
            form.chosenDifficulty_SelectedIndexChanged(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(DescriptionBase.HardDescription != "" ? DescriptionBase.HardDescription : null, form.descriptionBox.Text != "" ? form.descriptionBox.Text : null);
        }

        [TestMethod]
        public void QuitBtn_Click_ClosesForm()
        {
            // Arrange
            var form = new MainMenuForm();

            // Act
            form.quitBtn_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsFalse(form.Visible);
        }
    }
}
