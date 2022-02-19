using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text;

public class Gui : Form {
  
  private TableLayoutPanel _main_panel = null;
  private TableLayoutPanel _entry_panel = null;
  private FlowLayoutPanel _button_panel = null;
  private TextBox _main_text_box = null;
  private TextBox _name_text_box = null;
  private Label _name_label = null;
  private Label _birthday_label = null;
  private DateTimePicker _birthday_picker = null;
  private Button _new_button = null;
  private Button _load_button = null;
  private Button _save_button = null;
  private Button _update_button = null;
  private Button _next_button = null;
  
  public Gui(MainApp ma){
    InitializeComponent(ma);
  }
  
  public void InitializeComponent(MainApp ma){
    _main_panel = new TableLayoutPanel();
	_main_panel.RowCount = 2;
	_main_panel.ColumnCount = 2;
	_main_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    //_main_panel.Dock = DockStyle.Top;
	
   
   _entry_panel = new TableLayoutPanel();
   _entry_panel.RowCount = 2;
   _entry_panel.ColumnCount = 2;
   _entry_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
   _entry_panel.Dock = DockStyle.Top;
   
   
   _button_panel = new FlowLayoutPanel();
   _button_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
   _button_panel.Dock = DockStyle.Bottom;
   
   _main_text_box = new TextBox();
   _main_text_box.Multiline = true;
   _main_text_box.Height = 200;
   _main_text_box.Width = 200;
   _main_text_box.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
   _main_text_box.ScrollBars = ScrollBars.Vertical;
   
   _name_text_box = new TextBox();
   _name_text_box.Width = 200;
   
   _name_label = new Label();
   _name_label.Text = "Name:";
   
   _birthday_label = new Label();
   _birthday_label.Text = "Birthday:";
   
   _birthday_picker = new DateTimePicker();

   
   _new_button = new Button();
   _new_button.Text = "New";
   _new_button.Click += ma.NewButtonClickHandler;
   
   _load_button = new Button();
   _load_button.Text = "Load";
   _load_button.Click += ma.LoadButtonClickHandler;
   
   _save_button = new Button();
   _save_button.Text = "Save";
   _save_button.Click += ma.SaveButtonClickHandler;
   
   _update_button = new Button();
   _update_button.Text = "Update";
   _update_button.Click += ma.UpdateButtonClickHandler;
   
   _next_button = new Button(); 
   _next_button.Text = "Next";
   _next_button.Click += ma.NextButtonClickHandler;
   
   _button_panel.Controls.Add(_new_button);
   _button_panel.Controls.Add(_load_button);
   _button_panel.Controls.Add(_save_button);
   _button_panel.Controls.Add(_update_button);
   _button_panel.Controls.Add(_next_button);
   
   _entry_panel.Controls.Add(_name_label);
   _entry_panel.Controls.Add(_name_text_box);
   _entry_panel.Controls.Add(_birthday_label);
   _entry_panel.Controls.Add(_birthday_picker);
   
   _main_panel.Controls.Add(_main_text_box);
   _main_panel.Controls.Add(_entry_panel);
   _main_panel.Controls.Add(_button_panel);
   _main_panel.SetColumnSpan(_button_panel, 2);
   
   this.SuspendLayout();
   this.Controls.Add(_main_panel);
   this.Width = 550;
   this.Height = 350;
   _main_panel.Size = this.Size;
   this.Text = "Gui";
   this.ResumeLayout();
   
  
  }// end InitializeComponent
  
  public String NameText {
    get{ return _name_text_box.Text; }
	set{ _name_text_box.Text = value; }
  }
  
  public DateTime Birthday {
    get{ return _birthday_picker.Value; }
	set{ _birthday_picker.Value = value; }
  }
  
  public string MainText {
    get{ return _main_text_box.Text; }
	set{ _main_text_box.Text = value; }
  }
  

  
  
  
  
  
  
  
  
  
  

} // end class definition