using System;
using System.Windows.Forms;
using System.Drawing;


public class ControlPanel : Form {


   // fields
   private TableLayoutPanel _table_panel;
   private FlowLayoutPanel  _upper_flow_panel;
   private FlowLayoutPanel  _lower_flow_panel;
   
   
   private Label   _spaces_label;
   private TextBox _spaces_textbox;
   private Button  _turn_right_button;
   private Button  _turn_left_button;
   private Button  _pen_up_button;
   private Button  _pen_down_button;
   private Button  _print_floor;
   private Button  _move_button;
   
   
   
   // properties
   
   public int SpacesToMove {
     get { 
	       int spaces_to_move = 0;
		   
           try{
	         spaces_to_move = Int32.Parse(_spaces_textbox.Text);
		   }catch(Exception) {
		      _spaces_textbox.Text = "Bad value!";
		   }
		   
		   return spaces_to_move;
	      }
   
   }
   
   
   // constructor
   public ControlPanel(MainApp ma){
      InitializeComponent(ma);
   }
   
   
   
   private void InitializeComponent(MainApp ma){
     _table_panel = new TableLayoutPanel();
	 _table_panel.ColumnCount = 1;
	 _table_panel.RowCount = 2;
	 _table_panel.BackColor = Color.Black;
	 //_table_panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
	 _table_panel.Dock = DockStyle.Fill;
	 
	 _upper_flow_panel = new FlowLayoutPanel();
	 _upper_flow_panel.BackColor = Color.Brown;
	 _upper_flow_panel.Dock = DockStyle.Fill;
	 
	 _lower_flow_panel = new FlowLayoutPanel();
	 _lower_flow_panel.BackColor = Color.Blue;
	 _lower_flow_panel.Dock = DockStyle.Fill;
	 
   
     _spaces_label = new Label();
	 _spaces_label.Text = "Enter Spaces To Move:";
	 _spaces_label.AutoSize = true;
	 
	 _spaces_textbox = new TextBox();
	 
   
     _turn_right_button = new Button();
	 _turn_right_button.Text = "Turn Right";
	 _turn_right_button.Click += ma.TurnRightEventHandler;
	 _turn_right_button.BackColor = Color.Beige;
	 
	 _move_button = new Button();
	 _move_button.Text = "Move";
	 _move_button.Click += ma.MoveEventHandler;
	 _move_button.BackColor = Color.Beige;
	 
	 _pen_down_button = new Button();
	 _pen_down_button.Text = "Pen Down";
	 _pen_down_button.Click += ma.PenDownEventHandler;
	 _pen_down_button.BackColor = Color.Beige;
	 
	 
	 _upper_flow_panel.Controls.Add(_spaces_label);
	 _upper_flow_panel.Controls.Add(_spaces_textbox);
	 _lower_flow_panel.Controls.Add(_turn_right_button);
	 _lower_flow_panel.Controls.Add(_move_button);
	 _lower_flow_panel.Controls.Add(_pen_down_button);
	 
	 _table_panel.Controls.Add(_upper_flow_panel);
	 _table_panel.Controls.Add(_lower_flow_panel);
	 
     this.Controls.Add(_table_panel);
   
   }
   


}