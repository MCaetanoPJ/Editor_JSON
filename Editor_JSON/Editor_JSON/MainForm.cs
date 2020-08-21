/*
 * Created by SharpDevelop.
 * User: Omnia
 * Date: 21/08/2020
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing; //Responsável por verificar as impressoras
using System.Web.Script.Serialization; //Responsavel por ler o JSON
using System.Windows.Forms;

namespace Editor_JSON
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		JavaScriptSerializer serializer = new JavaScriptSerializer();
		string adressFileJSON;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			adressFileJSON = txt_AdressFileJSON.Text;
			SelectFileJSON();
			ListNamePrintersThisComputer();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void ListNamePrintersThisComputer(){
			try{
				String printerName;
				for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++){
					printerName = PrinterSettings.InstalledPrinters[i];
					
					comboBox_PrinterDefault.Items.Add(printerName);
			        comboBox_PrinterProtocol.Items.Add(printerName);
					comboBox_PrinterTagPaste.Items.Add(printerName);
					comboBox_PrinterPoster.Items.Add(printerName);
					comboBox_PrinterZebra.Items.Add(printerName);
				}
			}
			catch(Exception Error){
					
			}
		}
		private void SelectFileJSON(){
			try{
				StreamReader readerTxt = new StreamReader(txt_AdressFileJSON.Text);
				string fileJSON = readerTxt.ReadToEnd();
				readerTxt.Close();
				readerTxt.Dispose();
				txt_viewDataJSON.Text = fileJSON;
				ReadDataFileJSON(fileJSON);
			}
			catch(Exception Error){
				
			}
		}
		private void ReadDataFileJSON(string fileNameJSON){
			try{
				dynamic DataFileJSON = serializer.DeserializeObject(fileNameJSON);
				foreach(KeyValuePair<string, object> entry in DataFileJSON){
					var NomeInJSON = entry.Key;
					var ValueInJSON = entry.Value.ToString();
					WriteDataJSONInComboBox(NomeInJSON,ValueInJSON );
				}
			}
			catch(Exception Error){
				
			}
		}
		private void WriteDataJSONInComboBox(string NameFieldInJSON,string PrinterNameInJSON){
			try{
				switch(NameFieldInJSON){
					case "Impressora_Padrao":
						comboBox_PrinterDefault.Text = PrinterNameInJSON;
					break;
					case "Impressora_Protocolo":
						comboBox_PrinterProtocol.Text = PrinterNameInJSON;
					break;
					case "Impressora_FichaPasta":
						comboBox_PrinterTagPaste.Text = PrinterNameInJSON;
					break;
					case "Impressora_Poster":
						comboBox_PrinterPoster.Text = PrinterNameInJSON;
					break;
					case "Impressora_Zebra":
						comboBox_PrinterZebra.Text = PrinterNameInJSON;
					break;
				}
			}
			catch(Exception Error){
				
			}
		}
		private void CreateUpdateDataFileJSON(){
			try{
				StreamWriter writerTxt = new StreamWriter(adressFileJSON);
				string newJSON = "{ \n	\"Impressora_Padrao\":" + "\""+comboBox_PrinterDefault.Text+"\""
					+ ",\n	\"Impressora_Protocolo\":" + "\""+comboBox_PrinterProtocol.Text+"\""
					+ ",\n	\"Impressora_FichaPasta\":" + "\""+comboBox_PrinterTagPaste.Text+"\""
					+ ",\n	\"Impressora_Poster\":" + "\""+comboBox_PrinterPoster.Text+"\""
					+ ",\n	\"Impressora_Zebra\":" + "\""+comboBox_PrinterZebra.Text+"\"" + "\n}";
				writerTxt.Write(newJSON);
				writerTxt.Close();
				writerTxt.Dispose();
				MessageBox.Show("As impressoras que serão usadas pelo sistema foram salvas/atualizadas");
			}
			catch(Exception Error){
				
			}
		}
		void Btn_SaveChangeComboBoxClick(object sender, EventArgs e)
		{
			CreateUpdateDataFileJSON();
			SelectFileJSON();
		}
		void Btn_StartReadFileJSONClick(object sender, EventArgs e)
		{
			adressFileJSON = txt_AdressFileJSON.Text;
			SelectFileJSON();
		}
	}
}
