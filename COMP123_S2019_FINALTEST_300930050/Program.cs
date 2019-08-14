using COMP123_S2019_FINALTEST_300930050.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *STUDENT NAME:Liya cao
 *STUDENT ID:300930050
 *DESCRIPTION: this is the Character class used in character creation
 *             This is also the Data container for the application
     */
namespace COMP123_S2019_FINALTEST_300930050
{
    public static class Program
    {
        public static CharacterGeneratorForm characterForm;
        internal static object aboutForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGeneratorForm();

            Application.Run(characterForm);
        }
    }
}
