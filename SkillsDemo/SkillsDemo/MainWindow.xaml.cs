using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkillsDemo
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Beispiel für alle Skills eines Mitarbeiters
        public Employee employee = new Employee();
        public MainWindow()
        {
            InitializeComponent();

            
            for(int i = 0;i <10;i++)
            {
                Skill skill = new Skill(5,"C#", SkillLevel.Amateur, 1);
                employee.Skills.Add(skill);
            }

            dg_Skills.DataContext = employee.Skills;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //Selected item nehmen

            //aus db löschen
            //aus liste lokal löschen

            //Wenn die Ansicht nicht updated dann:
            //dg_Skills.DataContext = null;
            //dg_Skills.DataContext = employee.skills;
        }

        //Alternative zum Datagrid alleine
        //Datagrid auf nicht editierbar stellen und einzelne Textboxen nehmen und mit Daten vom asugewählten Objekt füllen
        //ICollectionView ist gut für die Liste (kein muss)
    }
}
