using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace LibraryManagement.Tools.MyUserControl
{
    public partial class ScriptUserControl : UserControl
    {
        public delegate void functionDelegate(object sender, EventArgs e);
        public ScriptUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加控件点击事件
        /// </summary>
        /// <param name="function">函数名</param>
        /// <param name="controlName">控件名</param>
        public void AddContorlClickMethod(functionDelegate function, ControlNames controlName)
        {
            switch (controlName)
            {
                case ControlNames.addButton:
                    {
                        addButton.Click += new EventHandler(function);
                        break;
                    }
                case ControlNames.changeButton:
                    {
                        changeButton.Click += new EventHandler(function);
                        break;
                    }
                case ControlNames.createButton:
                    {
                        createButton.Click += new EventHandler(function);
                        break;
                    }
                case ControlNames.emptyButton:
                    {
                        emptyButton.Click += new EventHandler(function);
                        break;
                    }
                case ControlNames.exitButton:
                    {
                        exitButton.Click += new EventHandler(function);
                        break;
                    }
                case ControlNames.helpButton:
                    {
                        helpButton.Click += new EventHandler(function);
                        break;
                    }
                case ControlNames.nextButton:
                    {
                        nextButton.Click += new EventHandler(function);
                        break;
                    }
                case ControlNames.previousButton:
                    {
                        previousButton.Click += new EventHandler(function);
                        break;
                    }
                case ControlNames.saveButton:
                    {
                        saveButton.Click += new EventHandler(function);
                        break;
                    }
            }

        }

        public enum ControlNames
        {
            createButton,
            changeButton,
            addButton,
            emptyButton,
            saveButton,
            previousButton,
            nextButton,
            helpButton,
            exitButton,
        }
    }
}
