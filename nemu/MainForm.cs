// Created by etar125 in SharpDevelop 5.1
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Timers;
using System.ComponentModel;

namespace nemu
{
	public partial class MainForm : Form
	{
		public List<Adress> GlobalData = new List<Adress>
		{
			new Adress(0, "NotEmulator"),
			new Adress(1, "Etar125"),
			new Adress(2, "InDevelop"),
			new Adress(3, "9923145"),
			new Adress(4, ""),
			new Adress(5, ""),
			new Adress(6, ""),
			new Adress(7, ""),
			new Adress(8, ""),
			new Adress(9, ""),
			new Adress(10, ""),
			new Adress(11, ""),
			new Adress(12, ""),
			new Adress(13, ""),
			new Adress(14, ""),
			new Adress(15, ""),
			new Adress(16, ""),
			new Adress(17, ""),
			new Adress(18, ""),
			new Adress(19, ""),
			new Adress(20, ""),
			new Adress(21, ""),
			new Adress(22, ""),
			new Adress(23, ""),
			new Adress(24, ""),
			new Adress(25, ""),
			new Adress(26, ""),
			new Adress(27, ""),
			new Adress(28, ""),
			new Adress(29, ""),
			new Adress(30, ""),
			new Adress(31, ""),
			new Adress(32, ""),
			new Adress(33, ""),
			new Adress(34, ""),
			new Adress(35, ""),
			new Adress(36, ""),
			new Adress(37, ""),
			new Adress(38, ""),
			new Adress(39, ""),
			new Adress(40, ""),
			new Adress(41, ""),
			new Adress(42, ""),
			new Adress(43, ""),
			new Adress(44, ""),
			new Adress(45, ""),
			new Adress(46, ""),
			new Adress(47, ""),
			new Adress(48, ""),
			new Adress(49, ""),
			new Adress(50, ""),
			new Adress(51, ""),
			new Adress(52, ""),
			new Adress(53, ""),
			new Adress(54, ""),
			new Adress(55, ""),
			new Adress(56, ""),
			new Adress(57, ""),
			new Adress(58, ""),
			new Adress(59, ""),
			new Adress(60, ""),
			new Adress(61, ""),
			new Adress(62, ""),
			new Adress(63, ""),
			new Adress(64, ""),
			new Adress(65, ""),
			new Adress(66, ""),
			new Adress(67, ""),
			new Adress(68, ""),
			new Adress(69, ""),
			new Adress(70, ""),
			new Adress(71, ""),
			new Adress(72, ""),
			new Adress(73, ""),
			new Adress(74, ""),
			new Adress(75, ""),
			new Adress(76, ""),
			new Adress(77, ""),
			new Adress(78, ""),
			new Adress(79, ""),
			new Adress(80, ""),
			new Adress(81, ""),
			new Adress(82, ""),
			new Adress(83, ""),
			new Adress(84, ""),
			new Adress(85, ""),
			new Adress(86, ""),
			new Adress(87, ""),
			new Adress(88, ""),
			new Adress(89, ""),
			new Adress(90, ""),
			new Adress(91, ""),
			new Adress(92, ""),
			new Adress(93, ""),
			new Adress(94, ""),
			new Adress(95, ""),
			new Adress(96, ""),
			new Adress(97, ""),
			new Adress(98, ""),
			new Adress(99, ""),
			new Adress(100, ""),
			new Adress(101, ""),
			new Adress(102, ""),
			new Adress(103, ""),
			new Adress(104, ""),
			new Adress(105, ""),
			new Adress(106, ""),
			new Adress(107, ""),
			new Adress(108, ""),
			new Adress(109, ""),
			new Adress(110, ""),
			new Adress(111, ""),
			new Adress(112, ""),
			new Adress(113, ""),
			new Adress(114, ""),
			new Adress(115, ""),
			new Adress(116, ""),
			new Adress(117, ""),
			new Adress(118, ""),
			new Adress(119, ""),
			new Adress(120, ""),
			new Adress(121, ""),
			new Adress(122, ""),
			new Adress(123, ""),
			new Adress(124, ""),
			new Adress(125, ""),
			new Adress(126, ""),
			new Adress(127, ""),
			new Adress(128, ""),
			new Adress(129, ""),
			new Adress(130, ""),
			new Adress(131, ""),
			new Adress(132, ""),
			new Adress(133, ""),
			new Adress(134, ""),
			new Adress(135, ""),
			new Adress(136, ""),
			new Adress(137, ""),
			new Adress(138, ""),
			new Adress(139, ""),
			new Adress(140, ""),
			new Adress(141, ""),
			new Adress(142, ""),
			new Adress(143, ""),
			new Adress(144, ""),
			new Adress(145, ""),
			new Adress(146, ""),
			new Adress(147, ""),
			new Adress(148, ""),
			new Adress(149, ""),
			new Adress(150, ""),
			new Adress(151, ""),
			new Adress(152, ""),
			new Adress(153, ""),
			new Adress(154, ""),
			new Adress(155, ""),
			new Adress(156, ""),
			new Adress(157, ""),
			new Adress(158, ""),
			new Adress(159, ""),
			new Adress(160, ""),
			new Adress(161, ""),
			new Adress(162, ""),
			new Adress(163, ""),
			new Adress(164, ""),
			new Adress(165, ""),
			new Adress(166, ""),
			new Adress(167, ""),
			new Adress(168, ""),
			new Adress(169, ""),
			new Adress(170, ""),
			new Adress(171, ""),
			new Adress(172, ""),
			new Adress(173, ""),
			new Adress(174, ""),
			new Adress(175, ""),
			new Adress(176, ""),
			new Adress(177, ""),
			new Adress(178, ""),
			new Adress(179, ""),
			new Adress(180, ""),
			new Adress(181, ""),
			new Adress(182, ""),
			new Adress(183, ""),
			new Adress(184, ""),
			new Adress(185, ""),
			new Adress(186, ""),
			new Adress(187, ""),
			new Adress(188, ""),
			new Adress(189, ""),
			new Adress(190, ""),
			new Adress(191, ""),
			new Adress(192, ""),
			new Adress(193, ""),
			new Adress(194, ""),
			new Adress(195, ""),
			new Adress(196, ""),
			new Adress(197, ""),
			new Adress(198, ""),
			new Adress(199, ""),
			new Adress(200, ""),
			new Adress(201, ""),
			new Adress(202, ""),
			new Adress(203, ""),
			new Adress(204, ""),
			new Adress(205, ""),
			new Adress(206, ""),
			new Adress(207, ""),
			new Adress(208, ""),
			new Adress(209, ""),
			new Adress(210, ""),
			new Adress(211, ""),
			new Adress(212, ""),
			new Adress(213, ""),
			new Adress(214, ""),
			new Adress(215, ""),
			new Adress(216, ""),
			new Adress(217, ""),
			new Adress(218, ""),
			new Adress(219, ""),
			new Adress(220, ""),
			new Adress(221, ""),
			new Adress(222, ""),
			new Adress(223, ""),
			new Adress(224, ""),
			new Adress(225, ""),
			new Adress(226, ""),
			new Adress(227, ""),
			new Adress(228, ""),
			new Adress(229, ""),
			new Adress(230, ""),
			new Adress(231, ""),
			new Adress(232, ""),
			new Adress(233, ""),
			new Adress(234, ""),
			new Adress(235, ""),
			new Adress(236, ""),
			new Adress(237, ""),
			new Adress(238, ""),
			new Adress(239, ""),
			new Adress(240, ""),
			new Adress(241, ""),
			new Adress(242, ""),
			new Adress(243, ""),
			new Adress(244, ""),
			new Adress(245, ""),
			new Adress(246, ""),
			new Adress(247, ""),
			new Adress(248, ""),
			new Adress(249, ""),
			new Adress(250, ""),
			new Adress(251, ""),
			new Adress(252, ""),
			new Adress(253, ""),
			new Adress(254, ""),
			new Adress(255, ""),
		};
		
		public Drive sys = new Drive();
		public Bitmap display = new Bitmap(320, 240);
		public Bitmap buffer = new Bitmap(320, 240);
		public bool wait = false;
		public int KeyAdress = 1;
		public int ShiftAdress = 2;
		public int ControlAdress = 3;
		public int AltAdress = 4;
		
		#region Functions
		
		public string check(bool check)
		{
			if(check)
				return "1";
			return "0";
		}
		
		public Color prs(string k)
        {
            string[] s = k.Split(";".ToCharArray(), StringSplitOptions.None);
            return Color.FromArgb(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]));
        }
		
		char get(string numa)
        {
            byte num = 0;
            if (numa.StartsWith("0"))
                num = byte.Parse(numa.Remove(0, 1));
            else
                num = byte.Parse(numa);
            if (num == 0)
                return ' ';
            if (num == 1)
                return '\n';
            return "**qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMйцукенгшщзхъфывапролджэячсмитьбюёЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁ1234567890!@#$%^&*()_+-={}[];:'\"\\|/,.<>?`~"[num];
        }
		
		public Adress GetAdress(string adress, List<Adress> LocalData)
		{
			bool isDigit = adress.All(char.IsDigit);
			if(isDigit) {
				if(adress.StartsWith("@"))
					foreach(Adress a in GlobalData)
						if(a.pos == int.Parse(adress))
							return a;
				foreach(Adress a in LocalData)
					if(a.pos == int.Parse(adress))
						return a;
			}
			else {
				if(adress.StartsWith("@"))
					foreach(Adress a in GlobalData)
						if(a.name == adress)
							return a;
				foreach(Adress a in LocalData)
						if(a.name == adress)
							return a;
			}
			return null;
		}
		
		public void SetAdress(string adress, string value, List<Adress> LocalData)
		{
			bool isDigit = adress.All(char.IsDigit);
			if(isDigit) {
				if(adress.StartsWith("@")) {
					foreach(Adress a in GlobalData) {
						if(a.pos == int.Parse(adress)) {
							a.value = value;
							break;
						}
					}
				}
				else {
					foreach(Adress a in LocalData) {
						if(a.pos == int.Parse(adress)) {
							a.value = value;
							break;
						}
					}
				}
			}
			else {
				if(adress.StartsWith("@")) {
					foreach(Adress a in GlobalData) {
						if(a.name == adress) {
							a.value = value;
							break;
						}
					}
				}
				else {
					foreach(Adress a in LocalData) {
						if(a.name == adress) {
							a.value = value;
							break;
						}
					}
				}
			}
		}
		
		public void AssocAdress(string adress, string value, List<Adress> LocalData)
		{
			bool isDigit = adress.All(char.IsDigit);
			if(isDigit) {
				if(adress.StartsWith("@")) {
					foreach(Adress a in GlobalData) {
						if(a.pos == int.Parse(adress)) {
							a.name = value;
							break;
						}
					}
				}
				else {
					foreach(Adress a in LocalData) {
						if(a.pos == int.Parse(adress)) {
							a.name = value;
							break;
						}
					}
				}
			}
			else {
				if(adress.StartsWith("@")) {
					foreach(Adress a in GlobalData) {
						if(a.name == adress) {
							a.name = value;
							break;
						}
					}
				}
				else {
					foreach(Adress a in LocalData) {
						if(a.name == adress) {
							a.name = value;
							break;
						}
					}
				}
			}
		}
		
		#endregion
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		public void DoFunction(string func, string[] args, List<Adress> LocalData)
		{
			if(func == "set")
			{
				if(args[1].StartsWith("$"))
					SetAdress(args[0], args[1].Remove(0, 1), LocalData);
				else
					SetAdress(args[0], GetAdress(args[1], LocalData).value, LocalData);
			}
			else if(func == "add")
			{
				if(args[1].StartsWith("$"))
					SetAdress(args[0], GetAdress(args[0], LocalData).value + args[1].Remove(0, 1), LocalData);
				else
					SetAdress(args[0], GetAdress(args[0], LocalData).value + GetAdress(args[1], LocalData).value, LocalData);
			}
			else if(func == "assoc")
			{
				if(args[1].StartsWith("$"))
					AssocAdress(args[0], args[1].Remove(0, 1), LocalData);
				else
					AssocAdress(args[0], GetAdress(args[0], LocalData).value + GetAdress(args[1], LocalData).value, LocalData);
				
			}
			else if(func == "draw") // draw(x,y)
			{
				int x = 0;
				int y = 0;
				Color clr;
				if(args[0].StartsWith("$"))
					x = int.Parse(args[0].Remove(0, 1));
				else
					x = int.Parse(GetAdress(args[0], LocalData).value);
				if(args[1].StartsWith("$"))
					y = int.Parse(args[1].Remove(0, 1));
				else
					y = int.Parse(GetAdress(args[1], LocalData).value);
				if(args[2].StartsWith("$"))
					clr = prs(args[2].Remove(0, 1));
				else
					clr = prs(GetAdress(args[0], LocalData).value);
				buffer.SetPixel(x, y, clr);
			}
			else if(func == "clear")
				buffer = new Bitmap(320, 240);
			else if(func == "apply")
			{
				display = buffer;
				pictureBox1.Image = display;
			}
		}
		
		public void Do(File file)
		{
			string[] code = file.data.ToArray();
			for(int i = 0; i < code.Length; i++)
			{
				if(code[i].StartsWith(";")) continue;
				if(code[i].StartsWith("goto "))
				{
					string label = code[i].Remove(0, 5);
					for(int a = 0; a < code.Length; a++) {
						if(code[a] == "label " + label) {
							i = a;
							break;
						}
					}
				}
				else if(!code[i].StartsWith("label "))
				{
					string function;
					List<string> args = new List<string>{};
					bool finish = false;
					for(int a = 0; a < code[i].Length; a++)
					{
						if(code[i][a] == '(')
						{
							function = code[i].Substring(0, a);
							bool ina = false;
							int last = a + 1;
							string result = "";
							for(int b = a + 1; b < code[i].Length; b++)
							{
								if(code[i][b] == '\\')
								{
									result += code[i][b + 1];
									b += 2;
								}
								else if(code[i][b] == '"')
								{
									if(ina) ina = false;
									else ina = true;
								}
								else if(code[i][b] == ',' && !ina) { args.Add(result); result = ""; }
								else if(code[i][b] == ')' && !ina)
								{
									args.Add(result); result = "";
									//MessageBox.Show(string.Join("\n", args.ToArray()));
									DoFunction(function, args.ToArray(), file.LocalData);
									args.Clear();
									finish = true;
									break;
								}
								else
									result += code[i][b];
							}
						}
						if(finish)
						{
							finish = false;
							break;
						}
					}
				}
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			sys.Load("disk.txt");
			BackgroundWorker bw = new BackgroundWorker();
			bw.DoWork += (object ss, DoWorkEventArgs d) =>
			{
				try { Do(sys.GetByName("sys").GetByName("main")); }
				catch (Exception ex) {
					MessageBox.Show(ex.Source + "\n-=-=-=-=-=-=-=-=-=-\n" + ex.Message + "\n-=-=-=-=-=-=-=-=-=-\n" + ex.StackTrace + "\n-=-=-=-=-=-=-=-=-=-\n" + ex.TargetSite);
				}
			};
			bw.RunWorkerAsync();
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
	
		}
	}
	public class Drive
	{
		public string name;
		public List<Directory> data = new List<Directory> {};
		
		public Drive() { }
		
		public Drive(string name, List<Directory> data)
		{
			this.name = name;
			this.data = data;
		}
		
		public void RemoveByName(string name)
		{
			foreach(Directory a in data)
			{
				if(a.name == name)
				{
					data.Remove(a);
					break;
				}
			}
		}
		
		public Directory GetByName(string name)
		{
			foreach(Directory a in data)
				if(a.name == name)
					return a;
			return null;
		}
		
		public void Save(string file)
		{
			List<string> result = new List<string>
			{
				name,
				"#"
			};
			foreach(Directory a in data)
			{
				result.Add("&" + a.name);
				foreach(File b in a.data)
				{
					result.Add("?" + b.name);
					foreach(string c in b.data)
						result.Add(c);
					result.Add("end");
				}
				result.Add("end");
			}
			System.IO.File.WriteAllLines(file, result.ToArray());
		}
		
		public void Load(string file)
		{
			try
			{
			List<string> logs = new List<string>{};
			this.name = "";
			this.data = new List<Directory> {};
			string[] cn = System.IO.File.ReadAllLines(file);
			this.name = cn[0];
			logs.Add("Drive name: " + name);
			for(int a = 2; a < cn.Length; a++)
			{
				if(cn[a].StartsWith("&"))
				{
					Directory dir = new Directory();
					dir.name = cn[a].Remove(0, 1);
					logs.Add("Directory create: " + dir.name);
					for(int b = a + 1; b < cn.Length; b++)
					{
						if(cn[b].StartsWith("?"))
						{
							File fil = new File();
							fil.name = cn[b].Remove(0, 1);
							logs.Add("File create: " + fil.name);
							for(int c = b + 1; c < cn.Length; c++)
							{
								if(cn[c] != "end")
									fil.data.Add(cn[c]);
								else
								{
									dir.data.Add(fil);
									logs.Add("File end");
									b = c;
									break;
								}
							}
							logs.Add("File first line: " + fil.data[0]);
						}
						else if(cn[b] == "end")
						{
							this.data.Add(dir);
							logs.Add("Directory end");
							a = b;
							break;
						}
					}
				}
			}
			System.IO.File.WriteAllLines("logs.txt", logs.ToArray());
			}
			catch(Exception e)
			{
				MessageBox.Show("Message: " + e.Message + "\nFull: " + e.StackTrace);
			}
		}
	}
	public class Directory
	{
		public string name;
		public List<File> data = new List<File> {};
		
		public Directory() { }
		
		public void RemoveByName(string name)
		{
			foreach(File a in data)
			{
				if(a.name == name)
				{
					data.Remove(a);
					break;
				}
			}
		}
		
		public File GetByName(string name)
		{
			foreach(File a in data)
				if(a.name == name)
					return a;
			return null;
		}
		
		public Directory(string name, List<File> data)
		{
			this.name = name;
			this.data = data;
		}
	}
	public class File
	{
		public string name;
		public List<string> data = new List<string> {};
		public List<Adress> LocalData = new List<Adress>
		{
			new Adress(0, ""),
			new Adress(1, ""),
			new Adress(2, ""),
			new Adress(3, ""),
			new Adress(4, ""),
			new Adress(5, ""),
			new Adress(6, ""),
			new Adress(7, ""),
			new Adress(8, ""),
			new Adress(9, ""),
			new Adress(10, ""),
			new Adress(11, ""),
			new Adress(12, ""),
			new Adress(13, ""),
			new Adress(14, ""),
			new Adress(15, ""),
			new Adress(16, ""),
			new Adress(17, ""),
			new Adress(18, ""),
			new Adress(19, ""),
			new Adress(20, ""),
			new Adress(21, ""),
			new Adress(22, ""),
			new Adress(23, ""),
			new Adress(24, ""),
			new Adress(25, ""),
			new Adress(26, ""),
			new Adress(27, ""),
			new Adress(28, ""),
			new Adress(29, ""),
			new Adress(30, ""),
			new Adress(31, ""),
			new Adress(32, ""),
			new Adress(33, ""),
			new Adress(34, ""),
			new Adress(35, ""),
			new Adress(36, ""),
			new Adress(37, ""),
			new Adress(38, ""),
			new Adress(39, ""),
			new Adress(40, ""),
			new Adress(41, ""),
			new Adress(42, ""),
			new Adress(43, ""),
			new Adress(44, ""),
			new Adress(45, ""),
			new Adress(46, ""),
			new Adress(47, ""),
			new Adress(48, ""),
			new Adress(49, ""),
			new Adress(50, ""),
			new Adress(51, ""),
			new Adress(52, ""),
			new Adress(53, ""),
			new Adress(54, ""),
			new Adress(55, ""),
			new Adress(56, ""),
			new Adress(57, ""),
			new Adress(58, ""),
			new Adress(59, ""),
			new Adress(60, ""),
			new Adress(61, ""),
			new Adress(62, ""),
			new Adress(63, ""),
			new Adress(64, ""),
			new Adress(65, ""),
			new Adress(66, ""),
			new Adress(67, ""),
			new Adress(68, ""),
			new Adress(69, ""),
			new Adress(70, ""),
			new Adress(71, ""),
			new Adress(72, ""),
			new Adress(73, ""),
			new Adress(74, ""),
			new Adress(75, ""),
			new Adress(76, ""),
			new Adress(77, ""),
			new Adress(78, ""),
			new Adress(79, ""),
			new Adress(80, ""),
			new Adress(81, ""),
			new Adress(82, ""),
			new Adress(83, ""),
			new Adress(84, ""),
			new Adress(85, ""),
			new Adress(86, ""),
			new Adress(87, ""),
			new Adress(88, ""),
			new Adress(89, ""),
			new Adress(90, ""),
			new Adress(91, ""),
			new Adress(92, ""),
			new Adress(93, ""),
			new Adress(94, ""),
			new Adress(95, ""),
			new Adress(96, ""),
			new Adress(97, ""),
			new Adress(98, ""),
			new Adress(99, ""),
			new Adress(100, ""),
			new Adress(101, ""),
			new Adress(102, ""),
			new Adress(103, ""),
			new Adress(104, ""),
			new Adress(105, ""),
			new Adress(106, ""),
			new Adress(107, ""),
			new Adress(108, ""),
			new Adress(109, ""),
			new Adress(110, ""),
			new Adress(111, ""),
			new Adress(112, ""),
			new Adress(113, ""),
			new Adress(114, ""),
			new Adress(115, ""),
			new Adress(116, ""),
			new Adress(117, ""),
			new Adress(118, ""),
			new Adress(119, ""),
			new Adress(120, ""),
			new Adress(121, ""),
			new Adress(122, ""),
			new Adress(123, ""),
			new Adress(124, ""),
			new Adress(125, ""),
			new Adress(126, ""),
			new Adress(127, ""),
			new Adress(128, ""),
			new Adress(129, ""),
			new Adress(130, ""),
			new Adress(131, ""),
			new Adress(132, ""),
			new Adress(133, ""),
			new Adress(134, ""),
			new Adress(135, ""),
			new Adress(136, ""),
			new Adress(137, ""),
			new Adress(138, ""),
			new Adress(139, ""),
			new Adress(140, ""),
			new Adress(141, ""),
			new Adress(142, ""),
			new Adress(143, ""),
			new Adress(144, ""),
			new Adress(145, ""),
			new Adress(146, ""),
			new Adress(147, ""),
			new Adress(148, ""),
			new Adress(149, ""),
			new Adress(150, ""),
			new Adress(151, ""),
			new Adress(152, ""),
			new Adress(153, ""),
			new Adress(154, ""),
			new Adress(155, ""),
			new Adress(156, ""),
			new Adress(157, ""),
			new Adress(158, ""),
			new Adress(159, ""),
			new Adress(160, ""),
			new Adress(161, ""),
			new Adress(162, ""),
			new Adress(163, ""),
			new Adress(164, ""),
			new Adress(165, ""),
			new Adress(166, ""),
			new Adress(167, ""),
			new Adress(168, ""),
			new Adress(169, ""),
			new Adress(170, ""),
			new Adress(171, ""),
			new Adress(172, ""),
			new Adress(173, ""),
			new Adress(174, ""),
			new Adress(175, ""),
			new Adress(176, ""),
			new Adress(177, ""),
			new Adress(178, ""),
			new Adress(179, ""),
			new Adress(180, ""),
			new Adress(181, ""),
			new Adress(182, ""),
			new Adress(183, ""),
			new Adress(184, ""),
			new Adress(185, ""),
			new Adress(186, ""),
			new Adress(187, ""),
			new Adress(188, ""),
			new Adress(189, ""),
			new Adress(190, ""),
			new Adress(191, ""),
			new Adress(192, ""),
			new Adress(193, ""),
			new Adress(194, ""),
			new Adress(195, ""),
			new Adress(196, ""),
			new Adress(197, ""),
			new Adress(198, ""),
			new Adress(199, ""),
			new Adress(200, ""),
			new Adress(201, ""),
			new Adress(202, ""),
			new Adress(203, ""),
			new Adress(204, ""),
			new Adress(205, ""),
			new Adress(206, ""),
			new Adress(207, ""),
			new Adress(208, ""),
			new Adress(209, ""),
			new Adress(210, ""),
			new Adress(211, ""),
			new Adress(212, ""),
			new Adress(213, ""),
			new Adress(214, ""),
			new Adress(215, ""),
			new Adress(216, ""),
			new Adress(217, ""),
			new Adress(218, ""),
			new Adress(219, ""),
			new Adress(220, ""),
			new Adress(221, ""),
			new Adress(222, ""),
			new Adress(223, ""),
			new Adress(224, ""),
			new Adress(225, ""),
			new Adress(226, ""),
			new Adress(227, ""),
			new Adress(228, ""),
			new Adress(229, ""),
			new Adress(230, ""),
			new Adress(231, ""),
			new Adress(232, ""),
			new Adress(233, ""),
			new Adress(234, ""),
			new Adress(235, ""),
			new Adress(236, ""),
			new Adress(237, ""),
			new Adress(238, ""),
			new Adress(239, ""),
			new Adress(240, ""),
			new Adress(241, ""),
			new Adress(242, ""),
			new Adress(243, ""),
			new Adress(244, ""),
			new Adress(245, ""),
			new Adress(246, ""),
			new Adress(247, ""),
			new Adress(248, ""),
			new Adress(249, ""),
			new Adress(250, ""),
			new Adress(251, ""),
			new Adress(252, ""),
			new Adress(253, ""),
			new Adress(254, ""),
			new Adress(255, ""),
		};
		
		public File() { }
		
		public File(string name, List<string> data)
		{
			this.name = name;
			this.data = data;
		}
	}
	public class Adress
	{
		public int pos { get; set; }
		public string name { get; set; }
		public string value { get; set; }
		
		public Adress() {}
		
		public Adress(int pos, string value)
		{
			this.pos = pos;
			this.value = value;
		}
	}
}