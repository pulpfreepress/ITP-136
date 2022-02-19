using System;
using System.Windows.Forms;
using System.Drawing;


public class View : Form {


   private TableLayoutPanel _bookPanel;
   private TableLayoutPanel _buttonPanel;
   private TableLayoutPanel _CDPanel;
   private TableLayoutPanel _mainPanel;
  
   private Label _titleLabel;
   private Label _ISBNLabel;
   private Label _publisherLabel;
   private Label _authorLabel;
   
   private Label _cdTitleLabel;
   private Label _genreLabel;
   private Label _labelLabel;
   private Label _artistLabel;
   
   private TextBox _titleTextbox;
   private TextBox _ISBNTextbox;
   private TextBox _publisherTextbox;
   private TextBox _authorTextbox;
   
   private TextBox _cdTitleTextbox;
   private TextBox _labelTextbox;
   private TextBox _genreTextbox;
   private TextBox _artistTextbox;
   
   private GroupBox _groupBox;
   private RadioButton _bookRadioButton;
   private RadioButton _CDRadioButton;
   
   private Button _addButton;
   private Button _nextButton;
   


   public View(Controller ma){
      InitializeComponent(ma);
   }
   
   private void InitializeComponent(Controller ma){
      
	_bookPanel = new TableLayoutPanel();
	_bookPanel.RowCount = 4;
	_bookPanel.ColumnCount = 2;
	_bookPanel.Height = 200;
	_bookPanel.Width = 300;
	_bookPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	
    _buttonPanel = new TableLayoutPanel();
	_buttonPanel.RowCount = 2;
	_buttonPanel.ColumnCount = 2;
	_buttonPanel.Height = 250;
	_buttonPanel.Width = 300;
	_buttonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	
	
	_CDPanel = new TableLayoutPanel();
	_CDPanel.RowCount = 4;
	_CDPanel.ColumnCount = 2;
	_CDPanel.Height = 200;
	_CDPanel.Width = 300;
	_CDPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	_CDPanel.Visible = false;
  
    _titleLabel = new Label();
	_titleLabel.Text = "Title";
	
    _ISBNLabel = new Label();
	_ISBNLabel.Text = "ISBN";
	
    _publisherLabel = new Label();
	_publisherLabel.Text = "Publisher";
	
    _authorLabel = new Label();
	_authorLabel.Text = "Author";
    
    _titleTextbox = new TextBox();
	_titleTextbox.Width = 100;
	
    _ISBNTextbox = new TextBox();
	_ISBNTextbox.Width = 100;
	
    _publisherTextbox = new TextBox();
	_publisherTextbox.Width = 100;
	
    _authorTextbox = new TextBox();
	_authorTextbox.Width = 100;
	
	_bookPanel.Controls.Add(_titleLabel);
	_bookPanel.Controls.Add(_titleTextbox);
	_bookPanel.Controls.Add(_ISBNLabel);
	_bookPanel.Controls.Add(_ISBNTextbox);
	_bookPanel.Controls.Add(_publisherLabel);
	_bookPanel.Controls.Add(_publisherTextbox);
	_bookPanel.Controls.Add(_authorLabel);
	_bookPanel.Controls.Add(_authorTextbox);
	
	
	_cdTitleLabel = new Label();
	_cdTitleLabel.Text = "Title";

	
	_labelLabel = new Label();
	_labelLabel.Text = "Label";
	
	_genreLabel = new Label();
	_genreLabel.Text = "Genre";
	
	_artistLabel = new Label();
	_artistLabel.Text = "Artist";
	
	_cdTitleTextbox = new TextBox();
	_cdTitleTextbox.Width = 100;
	
	_labelTextbox = new TextBox();
	_labelTextbox.Width = 100;
	
	_genreTextbox = new TextBox();
	_genreTextbox.Width = 100;
	
	_artistTextbox = new TextBox();
	_artistTextbox.Width = 100;
	
	_CDPanel.Controls.Add(_cdTitleLabel);
	_CDPanel.Controls.Add(_cdTitleTextbox);
	_CDPanel.Controls.Add(_labelLabel);
	_CDPanel.Controls.Add(_labelTextbox);
	_CDPanel.Controls.Add(_genreLabel);
	_CDPanel.Controls.Add(_genreTextbox);
	_CDPanel.Controls.Add(_artistLabel);
	_CDPanel.Controls.Add(_artistTextbox);
	
	
   
    _groupBox = new GroupBox();
	_groupBox.Text = "Select Media Type";
	
    _bookRadioButton = new RadioButton();
	_bookRadioButton.Text = "Book";
	_bookRadioButton.Location = new Point(20, 20);
	_bookRadioButton.Checked = true;
	_bookRadioButton.CheckedChanged += this.RadioButtonCheckedChangedHandler;
	
    _CDRadioButton = new RadioButton();
	_CDRadioButton.Text = "CD";
	_CDRadioButton.Location = new Point(125, 20);
	
	_groupBox.Controls.Add(_bookRadioButton);
	_groupBox.Controls.Add(_CDRadioButton);
   
    _addButton = new Button();
	_addButton.Text = "Add";
	_addButton.Click += ma.AddButtonHandler;
	
    _nextButton = new Button();
	_nextButton.Text = "Next";
	_nextButton.Click += ma.NextButtonHandler;
	
	
	_buttonPanel.Controls.Add(_addButton);
	_buttonPanel.Controls.Add(_nextButton);
	_buttonPanel.Controls.Add(_groupBox);
	
	_mainPanel = new TableLayoutPanel();
	_mainPanel.RowCount = 2;
	_mainPanel.ColumnCount = 1;
	_mainPanel.Height = 400;
	_mainPanel.Width = 600;
	_mainPanel.Controls.Add(_bookPanel);
	_mainPanel.Controls.Add(_buttonPanel);
	_mainPanel.Controls.Add(_CDPanel, 0, 0);
	_mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
	
	this.Controls.Add(_mainPanel);
	
	
	  
	  
	  
	  
	  this.Location = new Point(100, 100);
      this.Text = "Media Manager";
   }
   
   
   public void RadioButtonCheckedChangedHandler(object sender, EventArgs args){
     if(_bookRadioButton.Checked){
	   _bookPanel.Visible = true;
	   _CDPanel.Visible = false;
	 }else {
	   _bookPanel.Visible = false;
	   _CDPanel.Visible = true;
	 }
   }
   
   public Media GetMedia(){
      Media m = null;
	  
	  if(_bookRadioButton.Checked){
	    Book b = new Book();
	    b.Title = _titleTextbox.Text;
	    b.ISBN = _ISBNTextbox.Text;
	    b.Publisher = _publisherTextbox.Text;
	    b.Author = _authorTextbox.Text;
		m = b;
	  
	  }else if(_CDRadioButton.Checked) {
	    CD cd = new CD();
		cd.Title = _cdTitleTextbox.Text;
		cd.Label = _labelTextbox.Text;
		cd.Genre = _genreTextbox.Text;
		cd.Artist = _artistTextbox.Text;
	    m = cd;
	  }
	  
	  
	  return m;
   
   }
   
   

}