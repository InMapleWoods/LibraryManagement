using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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

        /// <summary>
        /// 去除控件点击事件
        /// </summary>
        /// <param name="function">函数名</param>
        /// <param name="controlName">控件名</param>
        public void RemoveContorlClickMethod(functionDelegate function, ControlNames controlName)
        {
            Control control = null;
            switch (controlName)
            {
                case ControlNames.addButton:
                    {
                        control = addButton;
                        break;
                    }
                case ControlNames.changeButton:
                    {
                        control = changeButton;
                        break;
                    }
                case ControlNames.createButton:
                    {
                        control = createButton;
                        break;
                    }
                case ControlNames.emptyButton:
                    {
                        control = emptyButton;
                        break;
                    }
                case ControlNames.exitButton:
                    {
                        control = exitButton;
                        break;
                    }
                case ControlNames.helpButton:
                    {
                        control = helpButton;
                        break;
                    }
                case ControlNames.nextButton:
                    {
                        control = nextButton;
                        break;
                    }
                case ControlNames.previousButton:
                    {
                        control = previousButton;
                        break;
                    }
                case ControlNames.saveButton:
                    {
                        control = saveButton;
                        break;
                    }
            }
            if (control == null)
            {
                return;
            }
            //下面是复制代码，不知原理
            BindingFlags mPropertyFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic;
            BindingFlags mFieldFlags = BindingFlags.Static | BindingFlags.NonPublic;
            Type controlType = typeof(System.Windows.Forms.Control);
            PropertyInfo propertyInfo = controlType.GetProperty("Events", mPropertyFlags);
            EventHandlerList eventHandlerList = (EventHandlerList)propertyInfo.GetValue(control, null);
            FieldInfo fieldInfo = (typeof(Control)).GetField("EventClick", mFieldFlags);
            Delegate d = eventHandlerList[fieldInfo.GetValue(control)];
            if (d == null) return;
            EventInfo eventInfo = controlType.GetEvent("Click");
            foreach (Delegate dx in d.GetInvocationList())
            {
                eventInfo.RemoveEventHandler(control, dx);
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
