using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryManagementFunctionTest.Tools
{
    public class UserCaseHandle
    {
        public string Src = "";

        public UserCaseHandle(string src)
        {
            Src = src;
        }

        private string GetModelText(IEnumerable models)
        {
            StringBuilder result = new StringBuilder();
            foreach (var i in models)
            {
                var newType = i.GetType();
                foreach (var item in newType.GetFields())
                {
                    result.Append(item.Name).Append("\t");
                }
                result.Append("\r\n");
                foreach (var item in newType.GetFields())
                {
                    result.Append(item.GetValue(i)).Append("\t");
                }
                result.Append("\r\n");
            }
            return result.ToString();
        }

        public bool AddUserCases(IEnumerable models)
        {
            string content = GetModelText(models);
            if (File.Exists(Src) == true)
            {
                content = File.ReadAllText(Src, Encoding.GetEncoding("Unicode")) + content;
            }
            if (string.IsNullOrEmpty(content))
            {
                return false;
            }
            try
            {
                File.WriteAllText(Src, content, Encoding.GetEncoding("Unicode"));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public DataTable GetUserCasesDataTable()
        {
            DataTable dataTable = new DataTable();
            if (File.Exists(Src) == true)
            {
                string userCaseText = File.ReadAllText(Src, Encoding.GetEncoding("Unicode"));
                string[] userCases = Regex.Split(userCaseText, "\r\n");
                string[] title = Regex.Split(userCases[0], "\t");
                for (int i = 0; i < title.Length - 1; i++)
                {
                    dataTable.Columns.Add(title[i]);
                }
                for (int i = 1; i < userCases.Length - 1; i += 2)
                {
                    string[] cases = Regex.Split(userCases[i], "\t");
                    dataTable.Rows.Add(cases.Take(cases.Length - 1).ToArray());
                }
            }
            return dataTable;
        }

        public IEnumerable GetUserCases()
        {
            if (File.Exists(Src) == true)
            {
                string name = Path.GetFileNameWithoutExtension(Src);
                Type type = Type.GetType("LibraryManagementFunctionTest.Model." + name, true, true);
                var modelList = Activator.CreateInstance(typeof(List<>).MakeGenericType(new Type[] { type })) as IList;
                var addMethod = modelList.GetType().GetMethod("Add");
                string userCaseText = File.ReadAllText(Src, Encoding.GetEncoding("Unicode"));
                string[] userCases = Regex.Split(userCaseText, "\r\n");
                string[] title = Regex.Split(userCases[0], "\t");
                for (int i = 1; i < userCases.Length - 1; i += 2)
                {
                    var temp = Activator.CreateInstance(type);
                    string[] cases = Regex.Split(userCases[i], "\t");
                    for (int j = 0; j < title.Length - 1; j++)
                    {
                        FieldInfo fieldInfo = type.GetField(title[j]);
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
                    addMethod.Invoke(modelList, new object[] { temp });
                }
                return modelList;
            }
            return null;
        }

        public bool DeleteUserCase(int modelid)
        {
            IEnumerable models = GetUserCases();
            List<object> list = new List<object>();
            foreach(var m in models)
            {
                if((int)m.GetType().GetField("Id").GetValue(m) != modelid)
                {
                    list.Add(m);
                }
            }

            //foreach (var i in models)
            //{
            //    var type = i.GetType();
            //    FieldInfo fieldInfo = type.GetField("Id");
            //    int id = (int)fieldInfo.GetValue(i);
            //    if (id == modelid)
            //    {
            //        list = ((List<object>)models).Except(new object[] { model });
            //    }
            //}
            string content = GetModelText(list);
            try
            {
                File.WriteAllText(Src, content, Encoding.GetEncoding("Unicode"));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
