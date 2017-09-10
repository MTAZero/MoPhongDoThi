using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.Model
{
    public class DoThi
    {
        public List<Dinh> dsDinh = new List<Dinh>();
        public List<Canh> dsCanh = new List<Canh>();

        public void Clear(){
            dsDinh.Clear();
            dsCanh.Clear();
        }
        public void AddDinh(Dinh tg)
        {
            dsDinh.Add(tg);
        }

        public void AddCanh(Canh tg)
        {
            dsCanh.Add(tg);
        }

        public void Draw(PaintEventArgs e)
        {
            //foreach (Dinh dinh in dsDinh) dinh.Draw(e);
            foreach (Canh canh in dsCanh) canh.Draw(e);
            foreach (Dinh dinh in dsDinh) dinh.Draw(e);
        }

        public DoThi Clone()
        {
            DoThi ans = new DoThi();
            foreach (Dinh dinh in this.dsDinh)
            {
                Dinh zdinh;
                zdinh = (Dinh) dinh.Clone();
                ans.AddDinh(zdinh);
            }

            foreach (Canh canh in this.dsCanh)
            {
                Canh zcanh;
                zcanh = (Canh)canh.Clone();
                ans.AddCanh(zcanh);
            }
            return ans;
        }

        #region Thao tac File
        public void ReadFile(string FileName)
        {
            try
            {
                DoThi temp = new DoThi();
                using (StreamReader readtext = new StreamReader(FileName))
                {
                    // Load list
                    int cntDinh;
                    cntDinh = Int32.Parse(readtext.ReadLine());
                    for (int index = 0; index < cntDinh; index++)
                    {
                        Dinh dinh = new Dinh();

                        string line = readtext.ReadLine();
                        string[] k = line.Split(' ');

                        dinh.ID = Int32.Parse(k[0]);
                        dinh.x = Int32.Parse(k[1]);
                        dinh.y = Int32.Parse(k[2]);
                        dinh.Ten = k[3];
                        dinh.mau = Color.Green;

                        temp.dsDinh.Add(dinh);
                    }

                    // Load list canh
                    int cntCanh;
                    cntCanh = Int32.Parse(readtext.ReadLine());
                    for (int index = 0; index < cntCanh; index++)
                    {
                        Canh canh = new Canh();

                        string line = readtext.ReadLine();
                        string[] k = line.Split(' ');

                        canh.ID = Int32.Parse(k[0]);
                        canh.IDXP = Int32.Parse(k[1]);
                        canh.IDKT = Int32.Parse(k[2]);
                        canh.x1 = Int32.Parse(k[3]);
                        canh.y1 = Int32.Parse(k[4]);
                        canh.x2 = Int32.Parse(k[5]);
                        canh.y2 = Int32.Parse(k[6]);
                        canh.TrongSo = Int32.Parse(k[7]);
                        canh.LoaiCanh = Int32.Parse(k[8]);
                        canh.mau = Color.Black;

                        temp.dsCanh.Add(canh);
                    }
                }

                MessageBox.Show("Load đồ thị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // lưu đồ thị theo đồ thị vừa đọc
                this.dsDinh = temp.dsDinh;
                this.dsCanh = temp.dsCanh;
            }
            catch
            {
                MessageBox.Show("Đọc đồ thị thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void WriteFile(string FileName)
        {
            try
            {
                using (StreamWriter writetext = new StreamWriter(FileName))
                {
                    // ghi danh sach dinh
                    writetext.WriteLine(dsDinh.Count);
                    for (int index = 0; index < dsDinh.Count; index++)
                    {
                        Dinh dinh = dsDinh[index];
                        writetext.WriteLine(dinh.ID + " " + dinh.x + " " + dinh.y + " " + dinh.Ten);
                    }

                    // ghi danh sach dinh
                    writetext.WriteLine(dsCanh.Count);
                    for (int index = 0; index < dsCanh.Count; index++)
                    {
                        Canh canh = dsCanh[index];
                        writetext.WriteLine(canh.ID + " " + canh.IDXP + " " + canh.IDKT + " " + canh.x1 + " " + canh.y1 + " " + canh.x2 + " " + canh.y2 + " " + canh.TrongSo + " " + canh.LoaiCanh);
                    }

                    // thong bao
                    MessageBox.Show("Lưu đồ thị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lưu đồ thị thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
