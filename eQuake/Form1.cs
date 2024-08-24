using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace eQuake
{
	public partial class eQuakeMonitor : Form
	{
		public eQuakeMonitor()
		{
			InitializeComponent();
		}

		private void CheckData_Tick(object sender, EventArgs e)
		{
			//リンク作成用のコード
			DateTime datetime = DateTime.Now.AddSeconds(-1);
			string d1 = datetime.ToString("yyyyMMdd");
			string d2 = datetime.ToString("yyyyMMddHHmmss");
			//リンクの作成
			string PointImage = $"http://www.kmoni.bosai.go.jp/data/map_img/RealTimeImg/jma_s/{d1}/{d2}.jma_s.gif";
			string EEW = $"http://www.kmoni.bosai.go.jp/data/map_img/PSWaveImg/eew/{d1}/{d2}.eew.gif";
			string Shindo = $"http://www.kmoni.bosai.go.jp/data/map_img/EstShindoImg/eew/{d1}/{d2}.eew.gif";
			string jsonpath = $"http://www.kmoni.bosai.go.jp/webservice/hypo/eew/{d2}.json";
			var data = ReadData(PointImage, EEW, Shindo,jsonpath);
			if (data.nowJP != null)
			{
				Monitor.Image = data.nowJP;
			}
			if (data.parsedJson != null)
			{
				richTextBox1.Text = data.parsedJson;
			}
		}

		private (Image nowJP, string parsedJson) ReadData(string PointImage, string EEW, string quakelink,string jsonpath)
		{
			try
			{
				//draw realtime image
				Image eQuakeMap = new Bitmap(352, 400);
				WebClient webClient = new WebClient();
				Image RealTimePoint = Image.FromStream(new MemoryStream(webClient.DownloadData(PointImage)));
				Image EEWImage = Image.FromStream(new MemoryStream(webClient.DownloadData(EEW)));
				Image Quake = Image.FromStream(new MemoryStream(webClient.DownloadData(quakelink)));
				Graphics g = Graphics.FromImage(eQuakeMap);
				g.DrawImage(Setting.Background, new Point(0, 0));
				g.DrawImage(RealTimePoint, new Point(0, 0));
				g.DrawImage(EEWImage, new Point(0, 0));
				g.DrawImage(Quake, new Point(0, 0));
				g.Dispose();

				//json test (debug)
				string rawjson = Encoding.UTF8.GetString(webClient.DownloadData(jsonpath));
				string parsedjson = JToken.Parse(rawjson).ToString(Formatting.Indented);

				webClient.Dispose();
				return (eQuakeMap, parsedjson);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return (null, null);
			}
		}

		private void CheckEvent()
		{

		}

		private void OnEvent()
		{

		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			if (!Setting.isAlwaysVisible)
			{
				Visible = false;
				Hide();
			}
			CheckData.Start();
		}

		private void TaskbarAlert_Click(object sender, EventArgs e)
		{
			if (Visible)
			{
				Visible = false;
				Hide();
			}
			else
			{
				Visible = true;
				Show();
				Focus();
			}
		}

		private void debugB_Click(object sender, EventArgs e)
		{

		}
	}
}
