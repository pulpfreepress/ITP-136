using System;
using System.Windows.Forms;


public class ControlPanel : Form {

    
   private TableLayoutPanel _tablePanel;
   private Button _button1;
   private Button _button2;
   private Button _button3;
   private Button _button4;
   
   
   public ControlPanel(MainApp ma){
      InitializeComponent(ma);
   }
   
   private void InitializeComponent(MainApp ma){
     
	 _tablePanel = new TableLayoutPanel();
	 _tablePanel.RowCount = 3;
	 _tablePanel.ColumnCount = 3;
	 //_tablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	 _tablePanel.Anchor = AnchorStyles.Top;
	 _tablePanel.AutoSize = true;
	 _tablePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
	 
	 _button1 = new Button();
	 _button1.Text = "North";
	 _button1.Click += ma.ButtonOneHandler;
	 
	 _button2 = new Button();
	 _button2.Text = "South";
	 _button2.Click += ma.ButtonTwoHandler;
	 
	 _button3 = new Button();
	 _button3.Text = "East";
	 _button3.Click += ma.ButtonThreeHandler;
	 
	 _button4 = new Button();
	 _button4.Text = "West";
	 _button4.Click += ma.ButtonFourHandler;
	 
	 _tablePanel.SuspendLayout();
	 
	_tablePanel.Controls.Add(_button1);
	_tablePanel.SetCellPosition(_button1, new TableLayoutPanelCellPosition(1,0 ));
	_tablePanel.Controls.Add(_button2);
	_tablePanel.SetCellPosition(_button2, new TableLayoutPanelCellPosition(1,2));
	_tablePanel.Controls.Add(_button3);
	_tablePanel.SetCellPosition(_button3, new TableLayoutPanelCellPosition(2,1));
	_tablePanel.Controls.Add(_button4);
	_tablePanel.SetCellPosition(_button4, new TableLayoutPanelCellPosition(0,1));
	_tablePanel.ResumeLayout();
	
	
	
	 
	 this.Controls.Add(_tablePanel);
	 
	 this.Height =175;
	 this.Width = 300;
	
	 
   }
   






}