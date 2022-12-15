using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuatToanDijkstra
{
    public partial class fDijkstra : Form
    {
        public fDijkstra()
        {
            InitializeComponent();
        }
        public List<Location> Locations = new List<Location>();
        SetUpGraph g = new SetUpGraph();
        private void fDijkstra_Load(object creator, EventArgs e)
        {
            //Tạo các Location
            Location DHQG = new Location("Đại học Quốc gia", "A", 268, 87);
            Location NgaBaGiong = new Location("Ngã Ba Giồng", "B", 122, 55);
            Location SanBayTSN = new Location("Sân bay Tân Sơn Nhất", "C", 200, 98);
            Location DamSen = new Location("Đầm sen", "D", 180, 123);
            Location ChoBenThanh = new Location("Chợ Bến Thành", "E", 225, 120);
            Location CauAnhSao = new Location("Cầu Ánh Sao", "F", 255, 140);
            Location RMIT = new Location("RMIT", "G", 230, 145);
            Location UEHN = new Location("UEH csN", "H", 185, 165);
            Location PhuXuan = new Location("Phú Xuân", "I", 280, 185);

            //Thêm các Location vào List Locations
            Locations.Add(DHQG);
            Locations.Add(NgaBaGiong);
            Locations.Add(SanBayTSN);
            Locations.Add(DamSen);
            Locations.Add(ChoBenThanh);
            Locations.Add(CauAnhSao);
            Locations.Add(RMIT);
            Locations.Add(UEHN);
            Locations.Add(PhuXuan);

            //Thêm Label địa điểm vào cbbDiemDau
            cbbDiemDau.Items.Add("Đại học Quốc gia");
            cbbDiemDau.Items.Add("Ngã Ba Giồng");
            cbbDiemDau.Items.Add("Sân bay Tân Sơn Nhất");
            cbbDiemDau.Items.Add("Đầm sen");
            cbbDiemDau.Items.Add("Chợ Bến Thành");
            cbbDiemDau.Items.Add("Cầu Ánh Sao");
            cbbDiemDau.Items.Add("RMIT");
            cbbDiemDau.Items.Add("UEH csN");
            cbbDiemDau.Items.Add("Phú Xuân");

            //Thêm Label địa điểm vào cbbDiemCuoi
            cbbDiemCuoi.Items.Add("Đại học Quốc gia");
            cbbDiemCuoi.Items.Add("Ngã Ba Giồng");
            cbbDiemCuoi.Items.Add("Sân bay Tân Sơn Nhất");
            cbbDiemCuoi.Items.Add("Đầm sen");
            cbbDiemCuoi.Items.Add("Chợ Bến Thành");
            cbbDiemCuoi.Items.Add("Cầu Ánh Sao");
            cbbDiemCuoi.Items.Add("RMIT");
            cbbDiemCuoi.Items.Add("UEH csN");
            cbbDiemCuoi.Items.Add("Phú Xuân");

            //
            for (int i = 0; i < Locations.Count; i++)
            {
                lvDanhSachDiem.Items.Add(Locations[i].getPointLabel());
                lvDanhSachDiem.Items[i].SubItems.Add(Locations[i].getName());
                g.listPoint.Add(Locations[i].getPoint());
                g.InsertVertex(Locations[i].getName());
            }

            //Insert cạnh, khoảng cách tính bằng phương thức Euclid
            g.InsertEdge("Ngã Ba Giồng", "Đại học Quốc gia", g.CalPath(NgaBaGiong,DHQG));
            g.InsertEdge("Ngã Ba Giồng", "Sân bay Tân Sơn Nhất", g.CalPath(NgaBaGiong,SanBayTSN));
            g.InsertEdge("Ngã Ba Giồng", "Đầm sen", g.CalPath(NgaBaGiong,DamSen));
            g.InsertEdge("Ngã Ba Giồng", "UEH csN", g.CalPath(NgaBaGiong,UEHN));
            g.InsertEdge("Đại học Quốc gia", "Sân bay Tân Sơn Nhất", g.CalPath(DHQG,SanBayTSN));
            g.InsertEdge("Đại học Quốc gia", "Chợ Bến Thành", g.CalPath(DHQG,ChoBenThanh));
            g.InsertEdge("Đại học Quốc gia", "Cầu Ánh Sao", g.CalPath(DHQG,CauAnhSao));
            g.InsertEdge("Đại học Quốc gia", "Phú Xuân", g.CalPath(DHQG,PhuXuan));
            g.InsertEdge("Sân bay Tân Sơn Nhất", "Đầm sen", g.CalPath(DHQG,DamSen));
            g.InsertEdge("Đầm sen", "Chợ Bến Thành", g.CalPath(DamSen,ChoBenThanh));
            g.InsertEdge("Đầm sen", "UEH csN", g.CalPath(DamSen,UEHN));
            g.InsertEdge("Chợ Bến Thành", "Cầu Ánh Sao", g.CalPath(ChoBenThanh,CauAnhSao));
            g.InsertEdge("Chợ Bến Thành", "RMIT", g.CalPath(ChoBenThanh,RMIT));
            g.InsertEdge("Cầu Ánh Sao", "Phú Xuân", g.CalPath(CauAnhSao,PhuXuan));
            g.InsertEdge("RMIT", "UEH csN", g.CalPath(RMIT,UEHN));
            g.InsertEdge("UEH csN", "Phú Xuân", g.CalPath(UEHN,PhuXuan));
        }

        //Vẽ đồ thị vào bản đồ
        private void SGMap_Point(object creator, PaintEventArgs e)
        {
            Graphics graph = SGMap.CreateGraphics();
            for (int i = 0; i < Locations.Count; i++)
            {
                SolidBrush brush = new SolidBrush(Color.SeaGreen);
                Brush pointName = new SolidBrush(Color.White);
                graph.FillEllipse(brush, Locations[i].getPoint().X - 3, Locations[i].getPoint().Y - 2, 18, 18);
                graph.DrawString(Locations[i].getPointLabel(), new Font("Arial", 8), pointName, Locations[i].getPoint().X, Locations[i].getPoint().Y);
            }
            DrawLine();
        }

        //Vẽ đường nối các địa điểm có thể
        private void DrawLine()
        {
            DrawLine("Ngã Ba Giồng", "Đại học Quốc gia");
            DrawLine("Ngã Ba Giồng", "Sân bay Tân Sơn Nhất");
            DrawLine("Ngã Ba Giồng", "Đầm sen");
            DrawLine("Ngã Ba Giồng", "UEH csN");
            DrawLine("Đại học Quốc gia", "Sân bay Tân Sơn Nhất");
            DrawLine("Đại học Quốc gia", "Chợ Bến Thành");
            DrawLine("Đại học Quốc gia", "Cầu Ánh Sao");
            DrawLine("Đại học Quốc gia", "Phú Xuân");
            DrawLine("Sân bay Tân Sơn Nhất", "Đầm sen");
            DrawLine("Đầm sen", "Chợ Bến Thành");
            DrawLine("Đầm sen", "UEH csN");
            DrawLine("Chợ Bến Thành", "Cầu Ánh Sao");
            DrawLine("Chợ Bến Thành", "RMIT");
            DrawLine("Cầu Ánh Sao", "Phú Xuân");
            DrawLine("RMIT", "UEH csN");
            DrawLine("UEH csN", "Phú Xuân");
        }

        //Phương thức vẽ đường nối
        private void DrawLine(string a, string b)
        {
            Graphics graph = SGMap.CreateGraphics();
            int x = g.GetIndex(a);
            int y = g.GetIndex(b);
            Pen p = new Pen(Color.Yellow, 2);
            Point point1 = new Point(g.listPoint[x].X, g.listPoint[x].Y);
            Point point2 = new Point(g.listPoint[y].X, g.listPoint[y].Y);
            graph.DrawLine(p, point1, point2);
            graph.DrawString($"{g.adj[x, y]}", new Font("Fira Code", 10), Brushes.Red, new Point((point1.X + point2.X) / 2 - 8, (point1.Y + point2.Y) / 2 + 8));
        }

        //Vẽ đường đi ngắn nhất
        private void DrawPathLine(int i)
        {
            Graphics graph = SGMap.CreateGraphics();
            Pen p = new Pen(Color.DarkBlue, 2);
            Point point1 = new Point(g.pathIndex[i].X, g.pathIndex[i].Y);
            Point point2 = new Point(g.pathIndex[i + 1].X, g.pathIndex[i + 1].Y);
            graph.DrawLine(p, point1, point2);
        }

        //Button tính toán đường đi ngắn nhất
        //Cảnh báo khi chưa nhập điểm đầu/cuối
        //Cảnh báo khi điểm đầu và cuối trùng nhau
        private void btTinhDuongDi_Click(object sender, EventArgs e)
        {
            if (cbbDiemCuoi.SelectedIndex == -1 || cbbDiemDau.SelectedIndex == -1)
            {
                MessageBox.Show("Mời chọn điểm đầu và điểm cuối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbbDiemDau.SelectedIndex != -1 && cbbDiemCuoi.SelectedIndex != -1)
            {
                SGMap.Controls.Clear();
                SGMap.Refresh();
                DrawLine();
                g.pathIndex.Clear();
                rtbLog.Clear();
                g.FindPaths(cbbDiemDau.SelectedItem.ToString(), cbbDiemCuoi.SelectedIndex.ToString(), rtbLog);
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
            if (cbbDiemDau.SelectedIndex == cbbDiemCuoi.SelectedIndex && cbbDiemDau.SelectedIndex!=-1)
            {
                MessageBox.Show("Không phản hồi\n Địa điểm đầu và cuối không được trùng nhau!", "Thông Báo");
            }
        }

        //Thông tin thành viên trong nhóm
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTin f = new fThongTin();
            f.Show();
        }

        //Thoát khỏi ứng dụng
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
