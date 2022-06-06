using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace sh4Forms
{
    public partial class main : Form
    {
        Assembly models;
        IEnumerable<Type> types;

        Type type;
        object Object;

        MethodInfo method;
        object[] methodParameters;


        public main()
        {
            InitializeComponent();
        }

        private void MainLoad(object sender, EventArgs e)
        {   
            models = Assembly.Load("transport2");
            types = models.GetTypes().Where(type => type.GetInterface("ITransportVehicle") != null && !type.IsAbstract);
            ObjComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }
        void FillMethodsComboBox()
        {
            MethodsComboBox.Items.Clear();
            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            MethodsComboBox.Items.AddRange(type.GetMethods().Where(method => !objectMethods.Contains(method.Name) &&method.Name.Substring(0, 4) != "get_" &&method.Name.Substring(0, 4) != "set_").Select(method => method.Name).ToArray());
        }
        object InputIntNumber(string message)
        {
            Read nf = new Read(message);
            nf.ShowDialog();
            this.Enabled = true;

            return Int32.Parse(nf.number);
        }

        object InputObject(Type type)
        {
            MessageBox.Show($"input {type.Name} object");

            object newObject = Activator.CreateInstance(type);

            foreach (var item in type.GetProperties())
            {
                    item.SetValue(newObject, InputIntNumber("input " + item.Name));
            }

            return newObject;
        }

        void ShowObjectFields()
        {
            objectFieldsListBox.Items.Clear();

            foreach (var item in type.GetProperties())
            {
                objectFieldsListBox.Items.Add(item.Name + ": " + item.GetValue(Object));
            }
        }


        private void ObjComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = types.First(type => type.Name == ObjComboBox.SelectedItem.ToString());
            Object = null;
            FillMethodsComboBox();
            CreateObjButton.Enabled = true;
            ObjComboBox.Enabled = true;
            InputFieldsButton.Enabled = false;
            RunMethodButton.Enabled = false;
            objectFieldsListBox.Items.Clear();
        }

        private void MethodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            method = type.GetMethods().First(Method => Method.Name == MethodsComboBox.SelectedItem.ToString());
            RunMethodButton.Enabled = false;
            if (method.GetParameters().Length == 0)
            {
                InputFieldsButton.Enabled = false;
                RunMethodButton.Enabled = Object != null;
            }
            else
                InputFieldsButton.Enabled = true;
            methodParameters = null;
            methodsFieldsListBox.Items.Clear();
            foreach (var item in method.GetParameters())
            {
                methodsFieldsListBox.Items.Add(item.Name);
            }
        }

        private void CreateObjButton_Click(object sender, EventArgs e)
        {
            Object = InputObject(type);
            if (method?.GetParameters().Length == 0)
                RunMethodButton.Enabled = true;
            ShowObjectFields();
        }

        private void RunMethodButton_Click(object sender, EventArgs e)
        {
            if (method.ReturnType == typeof(void))
            {
                method.Invoke(Object, methodParameters);
                MessageBox.Show("Метод выполнен");
            }
            else
                MessageBox.Show(method.Invoke(Object, methodParameters).ToString());
            ShowObjectFields();
        }

        private void InputFieldsButton_Click(object sender, EventArgs e)
        {
            if (method.GetParameters()[0].ParameterType.Name == "IFurniture")
                methodParameters = new object[1] { InputObject(type) };
            else if (method.GetParameters().Length != 0)
                methodParameters = method.GetParameters().Select(param => InputIntNumber("input" + param.Name)).ToArray();
            if (Object != null)
                RunMethodButton.Enabled = true;
        }
    }
}
