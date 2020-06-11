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

        private string GetModelText(IEnumerable models, bool isFirst = true)
        {
            StringBuilder result = new StringBuilder();
            if (isFirst)
            {
                foreach (var i in models)
                {
                    var newType = i.GetType();
                    foreach (var item in newType.GetFields())
                    {
                        result.Append(item.Name).Append("\t");
                    }
                    result.Append("\r\n");
                    break;
                }
            }
            foreach (var i in models)
            {
                var newType = i.GetType();
                int count = 0;
                foreach (var item in newType.GetFields())
                {
                    count++;
                    if (count <= newType.GetFields().Length)
                    {
                        result.Append(item.GetValue(i)).Append("\t");
                    }
                    else
                    {
                        result.Append(item.GetValue(i));
                    }
                }
                result.Append("\r\n");
            }
            return result.ToString();
        }

        public IEnumerable GetUserCases()
        {
            if (File.Exists(Src) == true)
            {
                string name = Path.GetFileNameWithoutExtension(Src);
                Assembly assembly=Assembly.Load("LibraryManagement");
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
                    for (int j = 0; j < title.Length - 1; j++)
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
