using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public static Point newpoint = new Point();
    public static int x;
    public static int y;

	public Form1()
	{
		this.InitializeComponent();
	}

    #region "System Move Title Panel"

    private void xMouseDown(object sender, MouseEventArgs e)
    {
        x = Control.MousePosition.X - base.Location.X;
        y = Control.MousePosition.Y - base.Location.Y;
    }
    private void xMouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            newpoint = Control.MousePosition;
            newpoint.X -= x;
            newpoint.Y -= y;
            base.Location = newpoint;
        }
    }

    #endregion 

	private void Form1_Load(object sender, EventArgs e)
	{


		string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\CSM";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\Settings";
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text);
			Directory.CreateDirectory(text2);
			StreamWriter streamWriter = File.CreateText(text2 + "\\FolderPath.ini");
			streamWriter.Write(text);
			streamWriter.Close();
			this.folderBox.Text = text;
			StreamWriter streamWriter2 = File.CreateText(text2 + "\\Parent.ini");
			streamWriter2.Write("true");
			streamWriter2.Close();
			StreamWriter streamWriter3 = File.CreateText(text2 + "\\Theme.ini");
			streamWriter3.Write("Dark");
			streamWriter3.Close();
			this.themeComboBox.SelectedIndex = 0;
			StreamWriter streamWriter4 = File.CreateText(text2 + "\\TopMost.ini");
			streamWriter4.Write("false");
			streamWriter4.Close();
			StreamWriter streamWriter5 = File.CreateText(text2 + "\\OpenFolder.ini");
			streamWriter5.Write("true");
			streamWriter5.Close();
		}
		else
		{
			string text3 = File.ReadAllText(text2 + "\\FolderPath.ini");
			if (!Directory.Exists(text3))
			{
				StreamWriter streamWriter6 = File.CreateText(text2 + "\\FolderPath.ini");
				streamWriter6.Write(text);
				streamWriter6.Close();
				this.folderBox.Text = text;
			}
			else
			{
				this.folderBox.Text = text3;
			}
			string a = File.ReadAllText(text2 + "\\Parent.ini");
			if (a == "true")
			{
				this.parentCheckBox.Checked = true;
			}
			else if (!(a == "false"))
			{
				StreamWriter streamWriter7 = File.CreateText(text2 + "\\Parent.ini");
				streamWriter7.Write("true");
				streamWriter7.Close();
			}
			else
			{
				this.parentCheckBox.Checked = false;
			}
			string a2 = File.ReadAllText(text2 + "\\Theme.ini");
			if (!(a2 == "Dark"))
			{
				if (a2 == "Light")
				{
					this.themeComboBox.SelectedIndex = 1;
				}
				else
				{
					StreamWriter streamWriter8 = File.CreateText(text2 + "\\Theme.ini");
					streamWriter8.Write("Dark");
					streamWriter8.Close();
				}
			}
			else
			{
				this.themeComboBox.SelectedIndex = 0;
			}
			string a3 = File.ReadAllText(text2 + "\\TopMost.ini");
			if (!(a3 == "true"))
			{
				if (!(a3 == "false"))
				{
					StreamWriter streamWriter9 = File.CreateText(text2 + "\\TopMost.ini");
					streamWriter9.Write("false");
					streamWriter9.Close();
				}
				else
				{
					this.settingCheckBox1.Checked = false;
				}
			}
			else
			{
				this.settingCheckBox1.Checked = true;
			}
			string a4 = File.ReadAllText(text2 + "\\OpenFolder.ini");
			if (!(a4 == "true"))
			{
				if (!(a4 == "false"))
				{
					StreamWriter streamWriter10 = File.CreateText(text2 + "\\OpenFolder.ini");
					streamWriter10.Write("true");
					streamWriter10.Close();
				}
				else
				{
					this.settingCheckBox2.Checked = false;
				}
			}
			else
			{
				this.settingCheckBox2.Checked = true;
			}
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.youtube.com/channel/UCHeIf0Dmn5Bc9ZCyDFYNrnQ?sub_confirmation=1");
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.youtube.com/channel/UCg8xhln_9ZjI5mtsNpm0MZw?sub_confirmation=1");
	}

	private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.themeComboBox.Text == "ダーク")
		{
			this.BackColor = Color.FromArgb(45, 45, 48);
			this.tabPage1.BackColor = Color.FromArgb(45, 45, 48);
			this.tabPage2.BackColor = Color.FromArgb(45, 45, 48);
			this.label1.ForeColor = Color.FromArgb(241, 241, 241);
			this.label2.ForeColor = Color.FromArgb(241, 241, 241);
			this.label3.ForeColor = Color.FromArgb(241, 241, 241);
			this.label4.ForeColor = Color.FromArgb(241, 241, 241);
			this.label5.ForeColor = Color.FromArgb(241, 241, 241);
			this.label6.ForeColor = Color.FromArgb(241, 241, 241);
			this.label7.ForeColor = Color.FromArgb(241, 241, 241);
			this.label8.ForeColor = Color.FromArgb(241, 241, 241);
			this.parentCheckBox.ForeColor = Color.FromArgb(222, 221, 220);
			this.settingCheckBox1.ForeColor = Color.FromArgb(222, 221, 220);
			this.settingCheckBox2.ForeColor = Color.FromArgb(222, 221, 220);
			this.fileBox.BackColor = Color.FromArgb(30, 30, 30);
			this.fileBox.ForeColor = Color.FromArgb(222, 221, 220);
			this.folderBox.BackColor = Color.FromArgb(30, 30, 30);
			this.folderBox.ForeColor = Color.FromArgb(241, 241, 241);
			this.parentComboBox.BackColor = Color.FromArgb(30, 30, 30);
			this.parentComboBox.ForeColor = Color.FromArgb(241, 241, 241);
			this.themeComboBox.BackColor = Color.FromArgb(30, 30, 30);
			this.themeComboBox.ForeColor = Color.FromArgb(241, 241, 241);
			this.browseButton1.BackColor = Color.FromArgb(37, 37, 38);
			this.browseButton1.ForeColor = Color.FromArgb(241, 241, 241);
			this.browseButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 52, 52);
			this.browseButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 64);
			this.browseButton2.BackColor = Color.FromArgb(37, 37, 38);
			this.browseButton2.ForeColor = Color.FromArgb(241, 241, 241);
			this.browseButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 52, 52);
			this.browseButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 64);
			this.doneButton.BackColor = Color.FromArgb(37, 37, 38);
			this.doneButton.ForeColor = Color.FromArgb(241, 241, 241);
			this.doneButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 64);
		}
		else if (this.themeComboBox.Text == "ライト")
		{
			this.BackColor = Color.FromArgb(238, 238, 242);
			this.tabPage1.BackColor = Color.FromArgb(238, 238, 242);
			this.tabPage2.BackColor = Color.FromArgb(238, 238, 242);
			this.label1.ForeColor = Color.FromArgb(30, 30, 30);
			this.label2.ForeColor = Color.FromArgb(30, 30, 30);
			this.label3.ForeColor = Color.FromArgb(30, 30, 30);
			this.label4.ForeColor = Color.FromArgb(30, 30, 30);
			this.label5.ForeColor = Color.FromArgb(30, 30, 30);
			this.label6.ForeColor = Color.FromArgb(30, 30, 30);
			this.label7.ForeColor = Color.FromArgb(30, 30, 30);
			this.label8.ForeColor = Color.FromArgb(30, 30, 30);
			this.parentCheckBox.ForeColor = Color.FromArgb(30, 30, 30);
			this.settingCheckBox1.ForeColor = Color.FromArgb(30, 30, 30);
			this.settingCheckBox2.ForeColor = Color.FromArgb(30, 30, 30);
			this.fileBox.BackColor = Color.FromArgb(241, 241, 241);
			this.fileBox.ForeColor = Color.FromArgb(30, 30, 30);
			this.folderBox.BackColor = Color.FromArgb(241, 241, 241);
			this.folderBox.ForeColor = Color.FromArgb(30, 30, 30);
			this.parentComboBox.BackColor = Color.FromArgb(241, 241, 241);
			this.parentComboBox.ForeColor = Color.FromArgb(30, 30, 30);
			this.themeComboBox.BackColor = Color.FromArgb(241, 241, 241);
			this.themeComboBox.ForeColor = Color.FromArgb(30, 30, 30);
			this.browseButton1.BackColor = Color.FromArgb(245, 245, 245);
			this.browseButton1.ForeColor = Color.FromArgb(30, 30, 30);
			this.browseButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 200, 200);
			this.browseButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 220, 220);
			this.browseButton2.BackColor = Color.FromArgb(245, 245, 245);
			this.browseButton2.ForeColor = Color.FromArgb(30, 30, 30);
			this.browseButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 200, 200);
			this.browseButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 220, 220);
			this.doneButton.BackColor = Color.FromArgb(245, 245, 245);
			this.doneButton.ForeColor = Color.FromArgb(30, 30, 30);
			this.doneButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 222, 245);
		}
		StreamWriter streamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\Settings\\Theme.ini");
		if (!(this.themeComboBox.Text == "ダーク"))
		{
			if (this.themeComboBox.Text == "ライト")
			{
				streamWriter.Write("Light");
			}
		}
		else
		{
			streamWriter.Write("Dark");
		}
		streamWriter.Close();
	}

	private void settingCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		StreamWriter streamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\Settings\\TopMost.ini");
		if (this.settingCheckBox1.Checked)
		{
			base.TopMost = true;
			streamWriter.Write("true");
		}
		else
		{
			base.TopMost = false;
			streamWriter.Write("false");
		}
		streamWriter.Close();
	}

	private void settingCheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		StreamWriter streamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\Settings\\OpenFolder.ini");
		if (!this.settingCheckBox2.Checked)
		{
			streamWriter.Write("false");
		}
		else
		{
			streamWriter.Write("true");
		}
		streamWriter.Close();
	}

	private void browseButton1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = "C:\\";
		openFileDialog.Filter = "BlockBench(*.json)|*.json";
		openFileDialog.RestoreDirectory = true;
		openFileDialog.Title = "ファイルを選択";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			this.fileBox.Text = openFileDialog.FileName;
		}
	}

	private void fileBox_TextChanged(object sender, EventArgs e)
	{
		this.label7.Text = "";
		this.fileBox.Text = this.fileBox.Text.Replace("\"", "");
	}

	private void tabPage1_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop))
			{
				string extension = Path.GetExtension(path);
				if (extension != ".json")
				{
					return;
				}
			}
			e.Effect = DragDropEffects.Copy;
		}
	}

	private void tabPage1_DragDrop(object sender, DragEventArgs e)
	{
		foreach (string text in (string[])e.Data.GetData(DataFormats.FileDrop))
		{
			string extension = Path.GetExtension(text);
			if (!e.Data.GetDataPresent(DataFormats.FileDrop) || !(extension == ".json"))
			{
				break;
			}
			this.fileBox.Text = text;
		}
	}

	private void browseButton2_Click(object sender, EventArgs e)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		folderBrowserDialog.Description = "保存先を指定";
		folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
		folderBrowserDialog.SelectedPath = "C:\\Windows";
		if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
		{
			this.folderBox.Text = folderBrowserDialog.SelectedPath;
		}
	}

	private void folderBox_TextChanged(object sender, EventArgs e)
	{
		this.label7.Text = "";
		this.folderBox.Text = this.folderBox.Text.Replace("\"", "");
		if (Directory.Exists(this.folderBox.Text))
		{
			StreamWriter streamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\Settings\\FolderPath.ini");
			streamWriter.Write(this.folderBox.Text);
			streamWriter.Close();
		}
	}

	private void parentComboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.parentComboBox.Text == "頭")
		{
			this.parentBox.Text = "HEAD";
		}
		else if (!(this.parentComboBox.Text == "胴体"))
		{
			if (this.parentComboBox.Text == "右腕")
			{
				this.parentBox.Text = "ARM0";
			}
			else if (!(this.parentComboBox.Text == "左腕"))
			{
				if (!(this.parentComboBox.Text == "右脚"))
				{
					if (this.parentComboBox.Text == "左脚")
					{
						this.parentBox.Text = "LEG1";
					}
				}
				else
				{
					this.parentBox.Text = "LEG0";
				}
			}
			else
			{
				this.parentBox.Text = "ARM1";
			}
		}
		else
		{
			this.parentBox.Text = "BODY";
		}
	}

	private void doneButton_Click(object sender, EventArgs e)
	{
		string text = this.fileBox.Text;
		string text2 = this.folderBox.Text;
		if (!(this.fileBox.Text == ""))
		{
			if (!(this.folderBox.Text == ""))
			{
				if (!File.Exists(text))
				{
					this.label7.Text = "ファイルパスが有効ではありません";
				}
				else if (!Directory.Exists(text2))
				{
					this.label7.Text = "保存先が有効ではありません";
				}
				else if (Path.GetExtension(text) != ".json")
				{
					this.label7.Text = "ファイルの拡張子が違います";
				}
				else
				{
					string extension = Path.GetExtension(text);
					string text3 = File.ReadAllText(text);
					if (!(extension == ".json"))
					{
						if (extension == "CSM")
						{
						}
					}
					else if (text3.Contains("\"cubes\": ["))
					{
						if (!(this.parentComboBox.Text == ""))
						{
							if (this.parentCheckBox.Checked)
							{
								this.writeDownBox.Text = "LEG1\rLEG1\rLEG1\r-2\r0\r-2\r4\r12\r4\r0\r16\rLEG0\rLEG0\rLEG0\r-2\r0\r-2\r4\r12\r4\r0\r16\rARM1\rARM1\rARM1\r-1\r-2\r-2\r4\r12\r4\r40\r16\rARM0\rARM0\rARM0\r-3\r-2\r-2\r4\r12\r4\r40\r16\rBODY\rBODY\rBODY\r-4\r0\r-2\r8\r12\r4\r16\r16\rHEAD\rHEAD\rHEAD\r-4\r-8\r-4\r8\r8\r8\r0\r0\r";
							}
							else
							{
								this.writeDownBox.ResetText();
							}
							string text4 = this.parentBox.Text;
							string text5 = text3.Replace(" ", "").Replace("\t", "").Replace("\"", "").Replace("mirror:false", "").Replace("mirror:false", "").Replace("]},", "").Replace("],},", "").Replace("],}", "");
							string text6 = text5.Replace("{origin:[", "BOX\r" + text4 + "\rBOX\r").Replace("],size:[", "\r").Replace("],uv:[", "\r").Replace(",", "\r");
							string text7 = text6.Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "");
							int num = text7.IndexOf("cubes:");
							string text8 = text7.Substring(num + 6);
							string text9 = text8.Replace("\r\r", "\r").Replace("\n\n", "\r");
							if (text9.Contains("name:"))
							{
								int length = text9.IndexOf("name:");
								string str = text9.Substring(0, length);
								TextBox textBox = this.writeDownBox;
								textBox.Text += str;
								int num2 = text9.IndexOf("cubes:");
								string text10 = text9.Substring(num2 + 6);
								if (text10.Contains("name:"))
								{
									int length2 = text10.IndexOf("name:");
									string str2 = text10.Substring(0, length2);
									TextBox textBox2 = this.writeDownBox;
									textBox2.Text += str2;
									int num3 = text10.IndexOf("cubes:");
									string text11 = text10.Substring(num3 + 6);
									if (!text11.Contains("name:"))
									{
										TextBox textBox3 = this.writeDownBox;
										textBox3.Text += text11;
									}
									else
									{
										int length3 = text11.IndexOf("name:");
										string str3 = text11.Substring(0, length3);
										TextBox textBox4 = this.writeDownBox;
										textBox4.Text += str3;
										int num4 = text11.IndexOf("cubes:");
										string text12 = text11.Substring(num4 + 6);
										if (!text12.Contains("name:"))
										{
											TextBox textBox5 = this.writeDownBox;
											textBox5.Text += text12;
										}
										else
										{
											int length4 = text12.IndexOf("name:");
											string str4 = text12.Substring(0, length4);
											TextBox textBox6 = this.writeDownBox;
											textBox6.Text += str4;
											int num5 = text12.IndexOf("cubes:");
											string text13 = text12.Substring(num5 + 6);
											if (!text13.Contains("name:"))
											{
												TextBox textBox7 = this.writeDownBox;
												textBox7.Text += text13;
											}
											else
											{
												int length5 = text13.IndexOf("name:");
												string str5 = text13.Substring(0, length5);
												TextBox textBox8 = this.writeDownBox;
												textBox8.Text += str5;
												int num6 = text13.IndexOf("cubes:");
												string text14 = text13.Substring(num6 + 6);
												if (text14.Contains("name:"))
												{
													int length6 = text14.IndexOf("name:");
													string str6 = text14.Substring(0, length6);
													TextBox textBox9 = this.writeDownBox;
													textBox9.Text += str6;
													int num7 = text14.IndexOf("cubes:");
													string text15 = text14.Substring(num7 + 6);
													if (!text15.Contains("name:"))
													{
														TextBox textBox10 = this.writeDownBox;
														textBox10.Text += text15;
													}
													else
													{
														int length7 = text15.IndexOf("name:");
														string str7 = text15.Substring(0, length7);
														TextBox textBox11 = this.writeDownBox;
														textBox11.Text += str7;
														int num8 = text15.IndexOf("cubes:");
														string text16 = text15.Substring(num8 + 6);
														if (text16.Contains("name:"))
														{
															int length8 = text16.IndexOf("name:");
															string str8 = text16.Substring(0, length8);
															TextBox textBox12 = this.writeDownBox;
															textBox12.Text += str8;
															int num9 = text16.IndexOf("cubes:");
															string text17 = text16.Substring(num9 + 6);
															if (text17.Contains("name:"))
															{
																int length9 = text17.IndexOf("name:");
																string str9 = text17.Substring(0, length9);
																TextBox textBox13 = this.writeDownBox;
																textBox13.Text += str9;
																int num10 = text17.IndexOf("cubes:");
																string text18 = text17.Substring(num10 + 6);
																if (!text18.Contains("name:"))
																{
																	TextBox textBox14 = this.writeDownBox;
																	textBox14.Text += text18;
																}
																else
																{
																	int length10 = text18.IndexOf("name:");
																	string str10 = text18.Substring(0, length10);
																	TextBox textBox15 = this.writeDownBox;
																	textBox15.Text += str10;
																	int num11 = text18.IndexOf("cubes:");
																	string text19 = text18.Substring(num11 + 6);
																	if (!text19.Contains("name:"))
																	{
																		TextBox textBox16 = this.writeDownBox;
																		textBox16.Text += text19;
																	}
																	else
																	{
																		int length11 = text19.IndexOf("name:");
																		string str11 = text19.Substring(0, length11);
																		TextBox textBox17 = this.writeDownBox;
																		textBox17.Text += str11;
																		int num12 = text19.IndexOf("cubes:");
																		string text20 = text19.Substring(num12 + 6);
																		if (text20.Contains("name:"))
																		{
																			int length12 = text20.IndexOf("name:");
																			string str12 = text20.Substring(0, length12);
																			TextBox textBox18 = this.writeDownBox;
																			textBox18.Text += str12;
																			int num13 = text20.IndexOf("cubes:");
																			string text21 = text20.Substring(num13 + 6);
																			if (text21.Contains("name:"))
																			{
																				int length13 = text21.IndexOf("name:");
																				string str13 = text21.Substring(0, length13);
																				TextBox textBox19 = this.writeDownBox;
																				textBox19.Text += str13;
																				int num14 = text21.IndexOf("cubes:");
																				string text22 = text21.Substring(num14 + 6);
																				if (text22.Contains("name:"))
																				{
																					int length14 = text22.IndexOf("name:");
																					string str14 = text22.Substring(0, length14);
																					TextBox textBox20 = this.writeDownBox;
																					textBox20.Text += str14;
																					int num15 = text22.IndexOf("cubes:");
																					string text23 = text22.Substring(num15 + 6);
																					if (!text23.Contains("name:"))
																					{
																						TextBox textBox21 = this.writeDownBox;
																						textBox21.Text += text23;
																					}
																					else
																					{
																						int length15 = text23.IndexOf("name:");
																						string str15 = text23.Substring(0, length15);
																						TextBox textBox22 = this.writeDownBox;
																						textBox22.Text += str15;
																						int num16 = text23.IndexOf("cubes:");
																						string text24 = text23.Substring(num16 + 6);
																						if (!text24.Contains("name:"))
																						{
																							TextBox textBox23 = this.writeDownBox;
																							textBox23.Text += text24;
																						}
																						else
																						{
																							int length16 = text24.IndexOf("name:");
																							string str16 = text24.Substring(0, length16);
																							TextBox textBox24 = this.writeDownBox;
																							textBox24.Text += str16;
																							int num17 = text24.IndexOf("cubes:");
																							string text25 = text24.Substring(num17 + 6);
																							if (!text25.Contains("name:"))
																							{
																								TextBox textBox25 = this.writeDownBox;
																								textBox25.Text += text25;
																							}
																							else
																							{
																								int length17 = text25.IndexOf("name:");
																								string str17 = text25.Substring(0, length17);
																								TextBox textBox26 = this.writeDownBox;
																								textBox26.Text += str17;
																								int num18 = text25.IndexOf("cubes:");
																								string text26 = text25.Substring(num18 + 6);
																								if (!text26.Contains("name:"))
																								{
																									TextBox textBox27 = this.writeDownBox;
																									textBox27.Text += text26;
																								}
																								else
																								{
																									int length18 = text26.IndexOf("name:");
																									string str18 = text26.Substring(0, length18);
																									TextBox textBox28 = this.writeDownBox;
																									textBox28.Text += str18;
																									int num19 = text26.IndexOf("cubes:");
																									string text27 = text26.Substring(num19 + 6);
																									if (!text27.Contains("name:"))
																									{
																										TextBox textBox29 = this.writeDownBox;
																										textBox29.Text += text27;
																									}
																									else
																									{
																										int length19 = text27.IndexOf("name:");
																										string str19 = text27.Substring(0, length19);
																										TextBox textBox30 = this.writeDownBox;
																										textBox30.Text += str19;
																										int num20 = text27.IndexOf("cubes:");
																										string text28 = text27.Substring(num20 + 6);
																										TextBox textBox31 = this.writeDownBox;
																										textBox31.Text += text28;
																										if (text28.Contains("name:"))
																										{
																											this.label7.Text = "グループが多すぎます";
																											return;
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																				else
																				{
																					TextBox textBox32 = this.writeDownBox;
																					textBox32.Text += text22;
																				}
																			}
																			else
																			{
																				TextBox textBox33 = this.writeDownBox;
																				textBox33.Text += text21;
																			}
																		}
																		else
																		{
																			TextBox textBox34 = this.writeDownBox;
																			textBox34.Text += text20;
																		}
																	}
																}
															}
															else
															{
																TextBox textBox35 = this.writeDownBox;
																textBox35.Text += text17;
															}
														}
														else
														{
															TextBox textBox36 = this.writeDownBox;
															textBox36.Text += text16;
														}
													}
												}
												else
												{
													TextBox textBox37 = this.writeDownBox;
													textBox37.Text += text14;
												}
											}
										}
									}
								}
								else
								{
									TextBox textBox38 = this.writeDownBox;
									textBox38.Text += text10;
								}
							}
							else
							{
								TextBox textBox39 = this.writeDownBox;
								textBox39.Text += text9;
							}
							string text29 = Path.GetFileNameWithoutExtension(text) + ".CSM";
							StreamWriter streamWriter = File.CreateText(text2 + "\\" + text29);
							streamWriter.Write(this.writeDownBox.Text);
							streamWriter.Close();
							if (File.Exists(text2 + "\\" + text29))
							{
								SystemSounds.Asterisk.Play();
								this.label7.Text = "完了！";
								if (this.settingCheckBox2.Checked)
								{
									Process.Start("EXPLORER.EXE", string.Concat(new string[]
									{
										"/select,\"",
										text2,
										"\\",
										text29,
										"\""
									}));
								}
								if (this.parentCheckBox.Checked)
								{
									StreamWriter streamWriter2 = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\Settings\\Parent.ini");
									streamWriter2.Write("true");
									streamWriter2.Close();
								}
								else
								{
									StreamWriter streamWriter3 = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\Settings\\Parent.ini");
									streamWriter3.Write("false");
									streamWriter3.Close();
								}
							}
						}
						else
						{
							this.label7.Text = "ペアレントが選択されていません";
						}
					}
					else
					{
						this.label7.Text = "ファイルが破損しています";
					}
				}
			}
			else
			{
				this.label7.Text = "保存先が選択されていません";
			}
		}
		else
		{
			this.label7.Text = "ファイルが選択されていません";
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		this.folderBox.Cut();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(this.fileBox.Text);
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		if (Clipboard.ContainsText())
		{
			TextBox textBox = this.folderBox;
			textBox.Text += Clipboard.GetText();
		}
	}

	private void toolStripMenuItem_7_Click(object sender, EventArgs e)
	{
		this.folderBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CSM Converter\\CSM";
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		this.folderBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		this.fileBox.Cut();
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(this.fileBox.Text);
	}

	private void toolStripMenuItem_6_Click(object sender, EventArgs e)
	{
		if (Clipboard.ContainsText())
		{
			TextBox textBox = this.fileBox;
			textBox.Text += Clipboard.GetText();
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}
}
