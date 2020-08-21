/*
 * Created by SharpDevelop.
 * User: Omnia
 * Date: 21/08/2020
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Editor_JSON
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ComboBox comboBox_PrinterZebra;
		private System.Windows.Forms.ComboBox comboBox_PrinterPoster;
		private System.Windows.Forms.ComboBox comboBox_PrinterTagPaste;
		private System.Windows.Forms.ComboBox comboBox_PrinterProtocol;
		private System.Windows.Forms.ComboBox comboBox_PrinterDefault;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_SaveChangeComboBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txt_viewDataJSON;
		//private System.Windows.Forms.Button Btn_StartReadFileJSONClick;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_AdressFileJSON;
		private System.Windows.Forms.Button Btn_StartReadFileJSON;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.Btn_StartReadFileJSON = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_viewDataJSON = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_AdressFileJSON = new System.Windows.Forms.TextBox();
			this.btn_SaveChangeComboBox = new System.Windows.Forms.Button();
			this.comboBox_PrinterZebra = new System.Windows.Forms.ComboBox();
			this.comboBox_PrinterPoster = new System.Windows.Forms.ComboBox();
			this.comboBox_PrinterTagPaste = new System.Windows.Forms.ComboBox();
			this.comboBox_PrinterProtocol = new System.Windows.Forms.ComboBox();
			this.comboBox_PrinterDefault = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(539, 396);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.Btn_StartReadFileJSON);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.txt_viewDataJSON);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.txt_AdressFileJSON);
			this.tabPage2.Controls.Add(this.btn_SaveChangeComboBox);
			this.tabPage2.Controls.Add(this.comboBox_PrinterZebra);
			this.tabPage2.Controls.Add(this.comboBox_PrinterPoster);
			this.tabPage2.Controls.Add(this.comboBox_PrinterTagPaste);
			this.tabPage2.Controls.Add(this.comboBox_PrinterProtocol);
			this.tabPage2.Controls.Add(this.comboBox_PrinterDefault);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(531, 370);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Configurando Serviço";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Btn_StartReadFileJSON
			// 
			this.Btn_StartReadFileJSON.Location = new System.Drawing.Point(131, 32);
			this.Btn_StartReadFileJSON.Name = "Btn_StartReadFileJSON";
			this.Btn_StartReadFileJSON.Size = new System.Drawing.Size(390, 23);
			this.Btn_StartReadFileJSON.TabIndex = 17;
			this.Btn_StartReadFileJSON.Text = "Ler Arquivo JSON selecionado";
			this.Btn_StartReadFileJSON.UseVisualStyleBackColor = true;
			this.Btn_StartReadFileJSON.Click += new System.EventHandler(this.Btn_StartReadFileJSONClick);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(7, 73);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(256, 23);
			this.label11.TabIndex = 16;
			this.label11.Text = "Visualização do conteúdo do arquivo no endereço";
			// 
			// txt_viewDataJSON
			// 
			this.txt_viewDataJSON.Enabled = false;
			this.txt_viewDataJSON.Location = new System.Drawing.Point(7, 99);
			this.txt_viewDataJSON.Multiline = true;
			this.txt_viewDataJSON.Name = "txt_viewDataJSON";
			this.txt_viewDataJSON.Size = new System.Drawing.Size(514, 90);
			this.txt_viewDataJSON.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(3, 37);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(122, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Carregar Arquivo";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(3, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(122, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "End Arquivo JSON";
			// 
			// txt_AdressFileJSON
			// 
			this.txt_AdressFileJSON.Location = new System.Drawing.Point(131, 6);
			this.txt_AdressFileJSON.Name = "txt_AdressFileJSON";
			this.txt_AdressFileJSON.Size = new System.Drawing.Size(390, 20);
			this.txt_AdressFileJSON.TabIndex = 11;
			this.txt_AdressFileJSON.Text = "C:\\\\iLaborNet\\\\impressora_config.json";
			// 
			// btn_SaveChangeComboBox
			// 
			this.btn_SaveChangeComboBox.Location = new System.Drawing.Point(151, 336);
			this.btn_SaveChangeComboBox.Name = "btn_SaveChangeComboBox";
			this.btn_SaveChangeComboBox.Size = new System.Drawing.Size(370, 23);
			this.btn_SaveChangeComboBox.TabIndex = 10;
			this.btn_SaveChangeComboBox.Text = "Salvar";
			this.btn_SaveChangeComboBox.UseVisualStyleBackColor = true;
			this.btn_SaveChangeComboBox.Click += new System.EventHandler(this.Btn_SaveChangeComboBoxClick);
			// 
			// comboBox_PrinterZebra
			// 
			this.comboBox_PrinterZebra.FormattingEnabled = true;
			this.comboBox_PrinterZebra.Location = new System.Drawing.Point(151, 309);
			this.comboBox_PrinterZebra.Name = "comboBox_PrinterZebra";
			this.comboBox_PrinterZebra.Size = new System.Drawing.Size(370, 21);
			this.comboBox_PrinterZebra.TabIndex = 9;
			// 
			// comboBox_PrinterPoster
			// 
			this.comboBox_PrinterPoster.FormattingEnabled = true;
			this.comboBox_PrinterPoster.Location = new System.Drawing.Point(151, 286);
			this.comboBox_PrinterPoster.Name = "comboBox_PrinterPoster";
			this.comboBox_PrinterPoster.Size = new System.Drawing.Size(370, 21);
			this.comboBox_PrinterPoster.TabIndex = 8;
			// 
			// comboBox_PrinterTagPaste
			// 
			this.comboBox_PrinterTagPaste.FormattingEnabled = true;
			this.comboBox_PrinterTagPaste.Location = new System.Drawing.Point(151, 263);
			this.comboBox_PrinterTagPaste.Name = "comboBox_PrinterTagPaste";
			this.comboBox_PrinterTagPaste.Size = new System.Drawing.Size(370, 21);
			this.comboBox_PrinterTagPaste.TabIndex = 7;
			// 
			// comboBox_PrinterProtocol
			// 
			this.comboBox_PrinterProtocol.FormattingEnabled = true;
			this.comboBox_PrinterProtocol.Location = new System.Drawing.Point(151, 240);
			this.comboBox_PrinterProtocol.Name = "comboBox_PrinterProtocol";
			this.comboBox_PrinterProtocol.Size = new System.Drawing.Size(370, 21);
			this.comboBox_PrinterProtocol.TabIndex = 6;
			// 
			// comboBox_PrinterDefault
			// 
			this.comboBox_PrinterDefault.FormattingEnabled = true;
			this.comboBox_PrinterDefault.Location = new System.Drawing.Point(151, 217);
			this.comboBox_PrinterDefault.Name = "comboBox_PrinterDefault";
			this.comboBox_PrinterDefault.Size = new System.Drawing.Size(370, 21);
			this.comboBox_PrinterDefault.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 312);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 4;
			this.label7.Text = "Impressora Zebra";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 289);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "Impressora Poster";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 266);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Impressora Ficha de Pasta";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 243);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Impressora Protocolos";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Impressora Padrão";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 416);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Editor_JSON";
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
