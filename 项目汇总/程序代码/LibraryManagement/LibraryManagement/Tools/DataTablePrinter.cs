using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace LibraryManagement.Tools
{
    internal class PrintService
    {
        #region Members //成员
        public string printName = string.Empty;
        public Font prtTextFont = new Font("Verdana", 10);
        public Font prtTitleFont = new Font("宋体", 10);
        private string[] titles = new string[0];
        public string[] Titles
        {
            set
            {
                titles = value;
                if (null == titles)
                {
                    titles = new string[0];
                }
            }
            get
            {
                return titles;
            }
        }
        public int Top { set; get; } = 20;
        public int Left { set; get; } = 20;
        private DataTable printedTable;
        private int pheight;
        private int pWidth;
        private int pindex;
        private int curdgi;
        private int[] width;
        private int rowOfDownDistance = 3;
        private int rowOfUpDistance = 2;

        int startColumnControls = 0;
        int endColumnControls = 0;

        #endregion

        #region Method for PrintDataTable //打印数据集
        /// <summary>
        /// 打印数据集
        /// </summary>
        /// <param name="table">数据集</param>
        /// <returns></returns>
        public bool PrintDataTable(DataTable table)
        {
            PrintDocument prtDocument = new PrintDocument();
            try
            {
                if (printName != string.Empty)
                {
                    prtDocument.PrinterSettings.PrinterName = printName;
                }
                prtDocument.DefaultPageSettings.Landscape = true;
                prtDocument.OriginAtMargins = false;
                PrintDialog prtDialog = new PrintDialog();
                prtDialog.AllowSomePages = true;
                prtDialog.ShowHelp = false;
                prtDialog.Document = prtDocument;
                if (DialogResult.OK != prtDialog.ShowDialog())
                {
                    return false;
                }
                printedTable = table;
                pindex = 0;
                curdgi = 0;
                width = new int[printedTable.Columns.Count];
                pheight = prtDocument.PrinterSettings.DefaultPageSettings.Bounds.Bottom + 400;
                //pheight = prtDocument.PrinterSettings.DefaultPageSettings.Bounds.Bottom;
                pWidth = prtDocument.PrinterSettings.DefaultPageSettings.Bounds.Right;
                prtDocument.PrinterSettings.DefaultPageSettings.Landscape = false;
                prtDocument.PrintPage += new PrintPageEventHandler(docToPrint_PrintPage);
                prtDocument.Print();
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show("没有安装打印机");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            prtDocument.Dispose();
            return true;
        }
        #endregion

        #region Handler for docToPrint_PrintPage //设置打印机开始打印的事件处理函数
        /// <summary>
        /// 设置打印机开始打印的事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        private void docToPrint_PrintPage(object sender,
         PrintPageEventArgs ev)//设置打印机开始打印的事件处理函数
        {
            int x = Left;
            int y = Top;
            int rowOfTop = Top;
            int i;
            Pen pen = new Pen(Brushes.Black, 1);
            if (0 == pindex)
            {
                for (i = 0; i < titles.Length; i++)
                {
                    ev.Graphics.DrawString(titles[i], prtTitleFont, Brushes.Black, Left, y + rowOfUpDistance);
                    y += prtTextFont.Height + rowOfDownDistance;
                }
                rowOfTop = y;
                foreach (DataRow dr in printedTable.Rows)
                {
                    for (i = 0; i < printedTable.Columns.Count; i++)
                    {
                        int colwidth = Convert.ToInt16(ev.Graphics.MeasureString(dr[i].ToString().Trim(), prtTextFont).Width);
                        if (colwidth > width[i])
                        {
                            width[i] = colwidth;
                        }
                    }
                }
            }
            for (i = endColumnControls; i < printedTable.Columns.Count; i++)
            {
                string headtext = printedTable.Columns[i].ColumnName.Trim();
                if (pindex == 0)
                {
                    int colwidth = Convert.ToInt16(ev.Graphics.MeasureString(headtext, prtTextFont).Width);
                    if (colwidth > width[i])
                    {
                        width[i] = colwidth;
                    }
                }
                //判断宽是否越界
                if (x + width[i] > pheight)
                {
                    break;
                }
                ev.Graphics.DrawString(headtext, prtTextFont, Brushes.Black, x, y + rowOfUpDistance);
                x += width[i];
            }
            startColumnControls = endColumnControls;
            if (i < printedTable.Columns.Count)
            {
                endColumnControls = i;
                ev.HasMorePages = true;
            }
            else
            {
                endColumnControls = printedTable.Columns.Count;
            }
            ev.Graphics.DrawLine(pen, Left, rowOfTop, x, rowOfTop);
            y += rowOfUpDistance + prtTextFont.Height + rowOfDownDistance;
            ev.Graphics.DrawLine(pen, Left, y, x, y);
            //打印数据
            for (i = curdgi; i < printedTable.Rows.Count; i++)
            {
                x = Left;
                for (Int32 j = startColumnControls; j < endColumnControls; j++)
                {
                    ev.Graphics.DrawString(printedTable.Rows[i][j].ToString().Trim(), prtTextFont, Brushes.Black, x, y + rowOfUpDistance);
                    x += width[j];
                }
                y += rowOfUpDistance + prtTextFont.Height + rowOfDownDistance;
                ev.Graphics.DrawLine(pen, Left, y, x, y);
                //判断高是否越界
                if (y > pWidth - prtTextFont.Height - 400) //if (y > pWidth - prtTextFont.Height - 30)
                {
                    break;
                }
            }
            ev.Graphics.DrawLine(pen, Left, rowOfTop, Left, y);
            x = Left;
            for (Int32 k = startColumnControls; k < endColumnControls; k++)
            {
                x += width[k];
                ev.Graphics.DrawLine(pen, x, rowOfTop, x, y);
            }
            //判断高是否越界
            if (y > pWidth - prtTextFont.Height - 400) //if (y > pWidth - prtTextFont.Height - 30) 
            {
                pindex++; if (0 == startColumnControls)
                {
                    curdgi = i + 1;
                }
                if (!ev.HasMorePages)
                {
                    endColumnControls = 0;
                }
                ev.HasMorePages = true;
            }
        }
        #endregion
    }
}