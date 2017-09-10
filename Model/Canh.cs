using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.Model
{
    public class Canh : ICloneable, IComparable
    {
        public int ID { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int TrongSo { get; set; }
        public Color mau { get; set; }
        public int IDXP { get; set; }
        public int IDKT { get; set; }

        // 1: canh 1 chieu, 0: canh 2 chieu
        public int LoaiCanh { get; set; }

        private float khoangcach(int x1, int y1, int x2, int y2)
        {
            return (int)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(mau);
            pen.EndCap = LineCap.ArrowAnchor;
            pen.Width = 1;
            e.Graphics.DrawLine(pen, x1, y1, x2, y2);

            int tdx = (x1 + x2) / 2;
            int tdy = (y1 + y2) / 2;

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            if (TrongSo != -1)
                e.Graphics.DrawString(this.TrongSo.ToString(), new Font("Arial", 8), Brushes.Black, new PointF(tdx, tdy + 15), format);

            // ve them xem là cạnh 1 chiều hay là 2 chiều

            /// ve tu (1->2)
            if (LoaiCanh >= 0 && LoaiCanh <= 1)
            {
                float d = khoangcach(x1, y1, x2, y2);
                float ux = (x2 - x1) / d;
                float uy = (y2 - y1) / d;

                float zx = x2 - ux * 10;
                float zy = y2 - uy * 10;

                float z2x = zx - ux * 8;
                float z2y = zy - uy * 8;

                float px = -uy;
                float py = ux;

                float z3x = (z2x - px * 4);
                float z3y = (z2y - py * 4);
                float z4x = (z2x + px * 4);
                float z4y = (z2y + py * 4);

                PointF point1 = new PointF(zx, zy);
                PointF point2 = new PointF(z3x, z3y);
                PointF point3 = new PointF(z4x, z4y);
                PointF[] zPoints = { point1, point2, point3 };


                e.Graphics.FillPolygon(new SolidBrush(mau), zPoints);
            }

            // nếu là 2 chiều mới vẽ chiều ngược lại
            if (LoaiCanh == 0)
            {
                float d = khoangcach(x1, y1, x2, y2);
                float ux = (x1 - x2) / d;
                float uy = (y1 - y2) / d;

                float zx = x1 - ux * 10;
                float zy = y1 - uy * 10;

                float z2x = zx - ux * 8;
                float z2y = zy - uy * 8;

                float px = -uy;
                float py = ux;

                float z3x = z2x - px * 4;
                float z3y = z2y - py * 4;
                float z4x = z2x + px * 4;
                float z4y = z2y + py * 4;

                PointF point1 = new PointF((float)zx,(float) zy);
                PointF point2 = new PointF(z3x, z3y);
                PointF point3 = new PointF(z4x, z4y);
                PointF[] zPoints = { point1, point2, point3 };


                e.Graphics.FillPolygon(new SolidBrush(mau), zPoints);
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #region Compare
        public int CompareTo(object bz)
        {
            if (bz == null) return 1;
            Canh b = bz as Canh;
            if (TrongSo < b.TrongSo) return -1;
            if (TrongSo == b.TrongSo) return 0;
            return 1;
        }
        #endregion
    }
}
