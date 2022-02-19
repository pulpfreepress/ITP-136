using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComputerSimGUI
{
    public partial class MainForm : Form
    {

        private Computer _computer;

        public MainForm()
        {
            InitializeComponent();
            _computer = new Computer(this);
        }

      
        public string AccumulatorTextBox
        {
            get { return _accumulatorTextBox.Text;  }
            set { _accumulatorTextBox.Text = value; }
        }

        public string EntryTextBox
        {
            get { return _entryTextBox.Text; }
            set { _entryTextBox.Text = value; }
        }

        public string OpCodeTextBox
        {
            get { return _opcodeTextBox.Text; }
            set { _opcodeTextBox.Text = value; }
        }

        public string OperandTextBox
        {
            get { return _operandTextBox.Text;  }
            set { _operandTextBox.Text = value;  }
        }

        public string ProgramCounterTextBox
        {
            get { return _programCounterTextBox.Text;  }
            set { _programCounterTextBox.Text = value;  }
        }




        /**************** Event Handlers ******************/
        private void LoadFromTextBoxButtonClick(object sender, EventArgs e)
        {
            string input = _mainTextBox.Text;

            int[] instructions = this.ConvertInstructionStingToIntArray(input);
           
            if(instructions != null)
            {
                _computer.LoadProgram(instructions);
            }
            else
            {
                MessageBox.Show("Invalid instructions. Please review the program.");
            }

            ClearTextBoxes();
        }





        private void LoadFromFileButtonClick(object sender, EventArgs e)
        {
            // Create two local variables to store useful strings
            string file_name = string.Empty;
            string file_contents = string.Empty;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    file_name = fileDialog.FileName;

                    FileStream fs = new FileStream(file_name, FileMode.Open);
                    using(StreamReader reader = new StreamReader(fs))
                    {
                        file_contents = reader.ReadToEnd();
                        
                    }

                }
                _mainTextBox.Text = string.Empty;
                _mainTextBox.Text = file_contents;
                int[] instructions = this.ConvertInstructionStingToIntArray(file_contents);

                if(instructions != null)
                {
                    _computer.LoadProgram(instructions);
                }
                else
                {
                    MessageBox.Show("Invalid instructions. Please review Program.");
                }
            }
            ClearTextBoxes();
        } // end LoadFromFileButtonClick()




        /// <summary>
        ///  Converts a string of instructions to an array of integers
        /// </summary>
        /// <param name="instructionString"></param>
        /// <returns>Array of integers or null if the conversion fails</returns>
        private int[] ConvertInstructionStingToIntArray(string instructionString)
        {
            string[] instruction_strings = instructionString.Split('\n');
            int[] instructions = new int[instruction_strings.Length];
            bool instructions_are_valid = true;

            for (int i = 0; i < instructions.Length; i++)
            {
                try
                {
                    instructions[i] = Int32.Parse(instruction_strings[i]);
                }
                catch (Exception)
                { 
                    instructions_are_valid = false;
                    break;
                }

            }

            if (instructions_are_valid)
            {
                return instructions;
            }else
            {
                return null;
            }


        }

        private void ClearTextBoxes()
        {
          
            _accumulatorTextBox.Text = String.Empty;
            _opcodeTextBox.Text = String.Empty;
            _operandTextBox.Text = String.Empty;
            _programCounterTextBox.Text = String.Empty;
        }


        public void RunButtonClick(object sender, EventArgs e)
        {
            _computer.Execute();
        }

       
    }
}
