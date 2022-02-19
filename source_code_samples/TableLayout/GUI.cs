using System;
using System.Windows.Forms;
using System.Drawing;

public class GUI : Form {
  private TextBox _textbox = null;
  private Button _button = null;
  private Button _button2 = null;
  private Panel _panel1 = null;
  private FlowLayoutPanel _panel2 = null;
  private TableLayoutPanel _table_panel = null;
  
  
  public GUI(){
    InitializeComponent();
  }
  
  private void InitializeComponent(){
	this.SuspendLayout();
	_panel1 = new Panel();
	_panel2 = new FlowLayoutPanel();
	
	_textbox = new TextBox();
	_textbox.Multiline = true;
	_textbox.Dock = DockStyle.Fill;
	_textbox.Width = 400;
	
	_button = new Button();
	_button.BackColor = Color.Coral;
	_button2 = new Button();
	_button2.BackColor = Color.Coral;
	
	
	_table_panel = new TableLayoutPanel();
	_table_panel.SuspendLayout();
	_table_panel.RowCount = 1;
	_table_panel.ColumnCount = 3;
	
	_table_panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
	_table_panel.BorderStyle = BorderStyle.FixedSingle;
	_table_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	
	_panel1.Width = _textbox.Width + 10;
	_panel1.Controls.Add(_textbox);
	_table_panel.Controls.Add(_panel1);
	_table_panel.SetColumnSpan(_panel1, 2);
	_panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	
	_panel2.Controls.Add(_button);
	_panel2.Controls.Add(_button2);
	_panel2.Dock = DockStyle.Fill;
	_panel2.FlowDirection = FlowDirection.TopDown;
	_panel2.BackColor = Color.Blue;
	_panel2.Width = 150;
	_table_panel.Controls.Add(_panel2);
	_table_panel.Dock = DockStyle.Fill;
	
	
	
	this.Controls.Add(_table_panel);
	this.Width = _panel1.Width + _panel2.Width + 40;
	_table_panel.ResumeLayout();
	this.ResumeLayout();
  }
  
  public static void Main(){
    Application.Run(new GUI());
  }
  
}