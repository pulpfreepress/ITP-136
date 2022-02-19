using System;
using System.Windows.Forms;
using System.Drawing;

public class GUI : Form {

   private Button _add_button;
   private Button _find_image_button;
   private Button _load_button;
   private Button _next_button;
   private TextBox _name_textbox;
   private TextBox _description_textbox;
   private PictureBox _picturebox;
   private Label _name_label;
   private Label _description_label;
   private TableLayoutPanel _main_table_layout_panel;
   private TableLayoutPanel _table_layout_subpanel;
   private OpenFileDialog _open_file_dialog;
   private FlowLayoutPanel _button_panel;
   
   
   public GUI(MainApp ma){
     this.InitializeComponent(ma);
   }
   
   private void InitializeComponent(MainApp ma){
     _main_table_layout_panel = new TableLayoutPanel();
	 _main_table_layout_panel.ColumnCount = 2;
	 _main_table_layout_panel.RowCount = 2;
	 _main_table_layout_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

	 
	 _picturebox = new PictureBox();
	 _picturebox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
   _picturebox.Height = 100;
   _picturebox.Width = 100;
	 
	 _table_layout_subpanel = new TableLayoutPanel();
	 _table_layout_subpanel.ColumnCount = 2;
	 _table_layout_subpanel.RowCount = 2;
	 _table_layout_subpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	 
	 _name_label = new Label();
	 _name_label.Text = "Name";
	 _name_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	 
	 _description_label = new Label();
	 _description_label.Text = "Description";
	 _description_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	 
	 _name_textbox = new TextBox();
	 _name_textbox.Width = 25;
	 _name_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	 
	 _description_textbox = new TextBox();
	 _description_textbox.Width = 25;
	 _description_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	 
	 _table_layout_subpanel.Controls.Add(_name_label);
	 _table_layout_subpanel.Controls.Add(_name_textbox);
	 _table_layout_subpanel.Controls.Add(_description_label);
	 _table_layout_subpanel.Controls.Add(_description_textbox);
	 
	 
	 
	 _add_button = new Button();
	 _add_button.Text = "Add Image";
	 _add_button.Click += ma.AddButtonHandler;
	 //_add_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	 
	 _find_image_button = new Button();
	 _find_image_button.Text = "Find Image";
	 _find_image_button.Click += this.FindImageButtonHandler;
	 //_find_image_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
   
   _load_button = new Button();
   _load_button.Text = "Load";
   _load_button.Click += ma.LoadButtonHandler;
   
   _next_button = new Button();
   _next_button.Text = "Next";
   _next_button.Click += ma.NextButtonHandler;
   
   _button_panel = new FlowLayoutPanel();
	 _button_panel.Controls.Add(_add_button);
   _button_panel.Controls.Add(_find_image_button);
   _button_panel.Controls.Add(_load_button);
   _button_panel.Controls.Add(_next_button);
	 
   
	 _main_table_layout_panel.Controls.Add(_picturebox);
	 _main_table_layout_panel.Controls.Add(_table_layout_subpanel);
	 _main_table_layout_panel.Controls.Add(_button_panel);
   _main_table_layout_panel.Height = 375;
   _main_table_layout_panel.Width = 375;
	 
	 
	 this.SuspendLayout();
	 this.Controls.Add(_main_table_layout_panel);
	 this.Text = "Picture Database";
	 this.Width = 400;
	 this.Height = 200;
	 this.ResumeLayout();
	 
	 
   }
   
   
   public void FindImageButtonHandler(object sender, EventArgs e){
      _open_file_dialog = new OpenFileDialog();
	    if(_open_file_dialog.ShowDialog() == DialogResult.OK){
        try{
          string filename = _open_file_dialog.FileName;
          _picturebox.Image = new Bitmap(filename);
          _picturebox.Width = _picturebox.Image.Width;
          _picturebox.Height = _picturebox.Image.Height;
          
        }catch(Exception){
           
        }
    
      } // end if
   }
   
   
   /****** Properties *****************/
   public string ImageName {
     get { return _name_textbox.Text; }
     set { _name_textbox.Text = value; }
   
   }
   
   public string ImageDescription {
     get { return _description_textbox.Text; }
     set { _description_textbox.Text = value; }
   }
   
   public Image Image {
     get { return _picturebox.Image; }
     set { _picturebox.Image = value; }
   }
  
   

} // end class