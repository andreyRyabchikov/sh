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
namespace sh4
{
    public partial class main : Form
    {
        Assembly Models;
        IEnumerable<Type> types;

        Type type;
        object Object;

        MethodInfo method;
        object[] methodParameters;


        public main()
        {
            InitializeComponent();
        }

        private void mainLoad(object sender, EventArgs e)
        {
            Models = Assembly.Load("sh4");
            types = Models.GetTypes().Where(type => type.GetInterface("transportVehicle") != null && !type.IsAbstract);
            ObjComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }
        void fillMethodsComboBox()
        {
            MethodsComboBox.Items.Clear();
            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            MethodsComboBox.Items.AddRange(type.GetMethods().Where(method => !objectMethods.Contains(method.Name) &&method.Name.Substring(0, 4) != "get_" &&method.Name.Substring(0, 4) != "set_").Select(method => method.Name).ToArray());
        }
        object inputIntNumber(string message)
        {
            read nf = new read(message);
            nf.ShowDialog();
            this.Enabled = true;

            return Int32.Parse(nf.number);
        }

        object inputObject(Type type)
        {
            MessageBox.Show($"input {type.Name} object");

            object newObject = Activator.CreateInstance(type);

            foreach (var item in type.GetProperties())
            {
                    item.SetValue(newObject, inputIntNumber("input " + item.Name));
            }

            return newObject;
        }

        void showObjectFields()
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
            fillMethodsComboBox();
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
            Object = inputObject(type);
            if (method?.GetParameters().Length == 0)
                RunMethodButton.Enabled = true;
            showObjectFields();
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
            showObjectFields();
        }

        private void InputFieldsButton_Click(object sender, EventArgs e)
        {
            if (method.GetParameters()[0].ParameterType.Name == "IFurniture")
                methodParameters = new object[1] { inputObject(type) };
            else if (method.GetParameters().Length != 0)
                methodParameters = method.GetParameters().Select(param => inputIntNumber("input" + param.Name)).ToArray();
            if (Object != null)
                RunMethodButton.Enabled = true;
        }
    }
}
