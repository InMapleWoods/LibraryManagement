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
            Control control = GetControlByName(controlName);
            if (control == null)
            {
                return;
            }
            control.Click += new EventHandler(function);
        }

        /// <summary>
        /// 去除控件点击事件
        /// </summary>
        /// <param name="controlName">控件名</param>
        public void RemoveContorlClickMethod(ControlNames controlName)
        {
            Control control = GetControlByName(controlName);
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

        private Control GetControlByName(ControlNames controlName)
        {
            switch (controlName)
            {
                case ControlNames.addButton:
                    {
                        return addButton;
                    }
                case ControlNames.changeButton:
                    {
                        return changeButton;
                    }
                case ControlNames.createButton:
                    {
                        return createButton;
                    }
                case ControlNames.emptyButton:
                    {
                        return emptyButton;
                    }
                case ControlNames.exitButton:
                    {
                        return exitButton;
                    }
                case ControlNames.helpButton:
                    {
                        return helpButton;
                    }
                case ControlNames.nextButton:
                    {
                        return nextButton;
                    }
                case ControlNames.previousButton:
                    {
                        return previousButton;
                    }
                case ControlNames.saveButton:
                    {
                        return saveButton;
                    }
                default:
                    {
                        return null;
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
