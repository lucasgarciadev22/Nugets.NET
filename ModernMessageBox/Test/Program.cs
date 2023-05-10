using ModernMessageBox;
using ModernMessageBox.Enums;
using System;
using System.Media;

namespace Test
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            TestMessageBox();
        }

        static void TestMessageBox()
        {
            //README SAMPLE_CHECKED.PNG TEST
            ModernBox.Show("Success", "Test Content", ImageStyles.Success);
            ModernBox.Show("Custom Color", "Test Content", "#FF0000");
            //README SAMPLE_ERROR.PNG TEST
            try
            {
                //...SOMETHING THAT THROWS AN EXCEPTION...
                int.Parse("");
            }
            catch (Exception ex)
            {
                ModernBox.Show("Error", "An error occurred:", ex);
            }

            //README SAMPLE_INFO.PNG TEST
            MessageResults result1 = ModernBox.Show("Info", "Test Content", ImageStyles.Info, ButtonTypes.CancelOk);

            //README SAMPLE_QUESTION.PNG TEST
            MessageResults result2 = ModernBox.Show("Question", "Test Content", ImageStyles.Question, ButtonTypes.NoYesAux, "Test Aux");

            //OTHER TESTS
            ModernBox.Show("Title", "Test Content");
            ModernBox.Show("Title", "Test Content", ButtonTypes.Ok);
            ModernBox.Show("Title", "Test Content", ButtonTypes.OkAux, "Test Aux");
            ModernBox.Show("Title", "Test Content", ImageStyles.Info, ButtonTypes.OkAux, "Test Aux");

            try
            {
                int.Parse("");
            }
            catch (Exception ex)
            {
                ModernBox.Show("Title", ex);
            }

            //CUSTOM IMAGES AND SOUNDS TESTS

            ModernBox.Show("Title", "Test Content", ImageStyles.Custom, ButtonTypes.NoYesAux, @"Images\leopard.png", "Test Aux");
            ModernBox.Show("Title", "Test Content", ImageStyles.Custom, ButtonTypes.NoYesAux, @"Images\leopard.png", SystemSounds.Beep, "Test Aux");
        }
    }
}
