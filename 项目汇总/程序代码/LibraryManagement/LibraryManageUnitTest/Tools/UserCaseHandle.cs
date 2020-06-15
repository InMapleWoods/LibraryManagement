using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace LibraryManageUnitTest.Tools
{
    public class UserCaseHandle
    {
        public string Src = "";

        public UserCaseHandle(string src)
        {
            Src = src;
        }

        public IEnumerable GetUserCases()
        {
            if (File.Exists(Src) == true)
            {
                string name = Path.GetFileNameWithoutExtension(Src).Split('_')[1];
                Assembly assembly = Assembly.Load("LibraryManagement");
                Type type = assembly.GetType("LibraryManagement.Model." + name, true, true);
                var modelList = Activator.CreateInstance(typeof(List<>).MakeGenericType(new Type[] { type })) as IList;
                var addMethod = modelList.GetType().GetMethod("Add");
                string userCaseText = File.ReadAllText(Src, Encoding.GetEncoding("Unicode"));
                string[] userCases = Regex.Split(userCaseText, "\r\n");
                string[] title = Regex.Split(userCases[0], "\t");
                for (int i = 1; i < userCases.Length - 1; i++)
                {
                    var temp = Activator.CreateInstance(type);
                    string[] cases = Regex.Split(userCases[i], "\t");
                    for (int j = 0; j < title.Length; j++)
                    {
                        FieldInfo fieldInfo = type.GetField(title[j]);
                        if (fieldInfo != null)
                        {
                            if (fieldInfo.FieldType == typeof(int))
                            {
                                fieldInfo.SetValue(temp, int.Parse(cases[j]));//给对应属性赋值
                            }
                            else if (fieldInfo.FieldType == typeof(string))
                            {
                                fieldInfo.SetValue(temp, cases[j]);//给对应属性赋值
                            }
                            else if (fieldInfo.FieldType == typeof(double))
                            {
                                fieldInfo.SetValue(temp, double.Parse(cases[j]));//给对应属性赋值
                            }
                        }
                    }
                    addMethod.Invoke(modelList, new object[] { temp });
                }
                return modelList;
            }
            return null;
        }
    }
}
