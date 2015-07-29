using System.Windows.Forms;
using MyApplication.Core;
using MyApplication.Model;

namespace MyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CallMethod();
        }

        private void CallMethod()
        {
            var manager = new EntityManager();
            manager.Elements.Add(new ConcreteEntityA());		
        }
    }
}
